using GestTaches.Core.Enums;
using GestTaches.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestTaches.Views
{
    public partial class AjoutTacheForm : Form
    {

        public Tache NouvelleTache { get; private set; }
        public AjoutTacheForm()
        {
            InitializeComponent();
            ChargerPriorites();
        }

        private void ChargerPriorites()
        {
            comboPriorite.DataSource = Enum.GetValues(typeof(PrioriteTache))
                .Cast<PrioriteTache>()
                .ToList();
        }



        private void buttonAjoutTache_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textTitre.Text))
            {
                MessageBox.Show(" le champs titre ne peut pas etre vide ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PrioriteTache priorite = (PrioriteTache) comboPriorite.SelectedItem;
            NouvelleTache = new Tache(textTitre.Text, priorite);    
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
