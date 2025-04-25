using GestTaches.Core.Enums;
using GestTaches.Core.Models;
using GestTaches.Core.Services;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GestTaches.Views
{

    /// <summary>
    /// 
    /// Fenetre principale de l'application - gestion des taches - 
    /// Permet : 
    ///  - Ajouter une tache 
    ///  - Consulter liste des taches 
    ///  - Marquer une tache comme terminé 
    ///  - Supprimer une tache 
    ///  
    /// </summary>
    public partial class GestTacheForm : Form
    {
        private readonly ITacheService _tacheService;

        /// <summary>
        /// initialiser le form et charger les taches 
        /// </summary>
        public GestTacheForm(ITacheService tacheService)
        {
            InitializeComponent();
            _tacheService = tacheService;
            _tacheService.Charger();
            ChargerTachesDansListView();
        }


        /// <summary>
        /// chargement des taches de service et les afficher 
        /// </summary>

        private void ChargerTachesDansListView()
        {
            listViewTaches.Items.Clear();
            SupprimerTousLesBoutons(); // Suppression des buttons dupliqués

            foreach (var tache in _tacheService.GetTachesTriees())
            {
                AjouterTacheDansListView(tache);
            }

        }





        /// <summary>
        /// button ajout tache qui ouvre la fenetre d'ajout d'une nouvelle tache 
        /// </summary>

        private void buttonAjoutTache_Click(object sender, EventArgs e)
        {
            try
            {
                using (AjoutTacheForm ajoutTacheForm = new AjoutTacheForm())
                {
                    if (ajoutTacheForm.ShowDialog() == DialogResult.OK)
                    {
                        Tache nouvelleTache = ajoutTacheForm.NouvelleTache;
                        _tacheService.AjouterTache(nouvelleTache);
                        _tacheService.Sauvegarder();

                        //chargement de list apres l'ajout 
                        ChargerTachesDansListView();
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur inattendue est survenue : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        /// <summary>
        /// Ajouter une tache a la liste view 
        /// </summary>

        private void AjouterTacheDansListView(Tache tache)
        {

            ListViewItem item = new ListViewItem(tache.Titre)
            {
                //marquer les tache terminer par un style grisé 
                ForeColor = tache.Etat == EtatTache.Terminee ? Color.Gray : Color.Black,
                Font = tache.Etat == EtatTache.Terminee ? new Font(Font, FontStyle.Italic) : Font
            };


            item.SubItems.Add(tache.Priorite.ToString());
            item.SubItems.Add(tache.Etat.ToString());
            item.SubItems.Add(""); // Colonne des boutons

            listViewTaches.Items.Add(item);
            AjouterBoutonsAction(item, tache);

        }


        private void AjouterBoutonsAction(ListViewItem item, Tache tache)
        {
            if (!listViewTaches.IsHandleCreated)
            {
                listViewTaches.HandleCreated += (sender, e) => AjouterBoutonsAction(item, tache);
                return;
            }

            TableLayoutPanel panel = new TableLayoutPanel
            {
                Size = new Size(35, 20), 
                ColumnCount = 2, 
                RowCount = 1, 
                BackColor = Color.Transparent,
                Tag = tache.Titre,
                AutoSize = true, 
            };

            //Chemin de dossier "Assets" des icons utiliser 

            string assetsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets");
            string SupprIconPath = Path.Combine(assetsPath, "IconSuppr.png");
            string checkIconPath = Path.Combine(assetsPath, "IconCheck.png");

            //Chargement des icons 
            Image imgSupprimer = File.Exists(SupprIconPath) ? Image.FromFile(SupprIconPath) : null;
            Image imgTerminer = File.Exists(checkIconPath) ? Image.FromFile(checkIconPath) : null;

            // button supprimer pour tous les taches meme ceux qui sont marquer comme terminee
            Button btnSupprimer = new Button
            {
                Size = new Size(15, 15), 
                Margin = new Padding(2), 
                FlatStyle = FlatStyle.Flat,
                BackgroundImage = imgSupprimer,
                BackgroundImageLayout = ImageLayout.Stretch,
                BackColor = Color.Transparent, 
                Cursor = Cursors.Hand, 
                FlatAppearance = { BorderSize = 0, MouseOverBackColor = Color.LightCoral } 
            };
            btnSupprimer.Click += (sender, e) => AfficherConfirmationSuppression(tache);

            //  Button terminer s'affiche seulement pour les taches qui ne sont pas encore terminee
            if (tache.Etat != EtatTache.Terminee)
            {
                Button btnTerminer = new Button
                {
                    Size = new Size(15, 15),
                    Margin = new Padding(2),
                    FlatStyle = FlatStyle.Flat,
                    BackgroundImage = imgTerminer,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    BackColor = Color.Transparent,
                    Cursor = Cursors.Hand,
                    FlatAppearance = { BorderSize = 0, MouseOverBackColor = Color.LightGreen } 
                };
                btnTerminer.Click += (sender, e) => AfficherConfirmationTerminer(tache);
                panel.Controls.Add(btnTerminer, 0, 0);
            }

            panel.Controls.Add(btnSupprimer, 1, 0);

            listViewTaches.BeginInvoke((MethodInvoker)delegate
            {
                Rectangle rect = item.SubItems[3].Bounds;
                panel.Location = new Point(rect.X + 10, rect.Y);
                listViewTaches.Controls.Add(panel);
            });
        }




        /// <summary>
        /// Supprimer les buttons qui peut faire des doublons  
        /// </summary>
        private void SupprimerTousLesBoutons()
        {
            // supprission de tous les boutons existants pour eviter des doublons
            var controlsToRemove = listViewTaches.Controls.Cast<Control>().Where(c => c is TableLayoutPanel).ToList();
            foreach (var control in controlsToRemove)
            {
                listViewTaches.Controls.Remove(control);
                control.Dispose();
            }
        }


        /// <summary>
        /// Appel de formulaire "ConfirmerTacheTermineeForm" pour la confirmation avant de marquer une tache comme terminée 
        /// </summary>
        private void AfficherConfirmationTerminer(Tache tache)
        {

            using (ConfirmerTacheTermineeForm confirmerTacheTerminee = new ConfirmerTacheTermineeForm())
            {
                if (confirmerTacheTerminee.ShowDialog() == DialogResult.OK && confirmerTacheTerminee.EstConfirme)
                {
                    _tacheService.MarquerCommeTerminee(tache);
                    _tacheService.Sauvegarder();
                    ChargerTachesDansListView();
                }
            }

        }



        /// <summary>
        /// Appel de formulaire "ConfirmerSuppressionForm" pour la confirmation avant de supprimer une tache  
        /// </summary>
        private void AfficherConfirmationSuppression(Tache tache)
        {

            using (ConfirmerSuppressionForm confirmerSuppression = new ConfirmerSuppressionForm())
            {
                if (confirmerSuppression.ShowDialog() == DialogResult.OK && confirmerSuppression.EstConfirmer)
                {
                    _tacheService.SupprimerTache(tache);
                    _tacheService.Sauvegarder();
                    ChargerTachesDansListView();
                }
            }




        }
    }
}
