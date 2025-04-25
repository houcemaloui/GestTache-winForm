using GestTaches.Core.Abstractions;
using GestTaches.Core.Enums;
using GestTaches.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GestTaches.Core.Services
{
    /// <summary>
    ///  Service pour la gestion des taches ( ajout - suppression - tri - sauvegarde )
    ///  interagit avec le systeme de stockage (fichier JSON)
    /// </summary>
    public class TacheService : ITacheService
    {
        //Interface de gestion de stockage
        private readonly ITacheStorage _storage;
        //liste des taches en memoire 
        private List<Tache> _taches = new List<Tache>();


        //Constructeur qui initialise le service avec le system de stockage
        public TacheService(ITacheStorage storage)
        {
            _storage = storage;
        }


        /// <summary>
        /// ajout d'une nouvelle tache 
        /// </summary>
        /// <param name="tache"> tache a ajouter </param>
        /// <exception cref="ArgumentNullException"> exception levée  en cas la tache est null </exception>
        /// <exception cref="InvalidOperationException"> exception levée en cas ou une tache identique avec un etat en cours existe deja  </exception>
        public void AjouterTache(Tache tache)
        {
            if (tache == null)
                throw new ArgumentNullException(nameof(tache), "La tâche ne peut pas être null");

            // Verification si une tâche avec le meme titre est deja encours 
            if (_taches.Any(t => t.Titre.Equals(tache.Titre, StringComparison.OrdinalIgnoreCase)
                                 && t.Etat != EtatTache.Terminee))
            {
                throw new InvalidOperationException("Une tâche avec ce titre existe déjà et n'est pas encore terminée.");
            }

            _taches.Add(tache);
            //sauvegarde de la liste mis a jour
            Sauvegarder();
        }




        /// <summary>
        /// Suppression d'une tache existe dans la liste des taches 
        /// </summary>
        /// <param name="tache"> tache a supprimer </param>
        /// <exception cref="ArgumentNullException"> exception levée  en cas la tache est null </exception>
        public void SupprimerTache(Tache tache)
        {
            if (tache == null)
                throw new ArgumentNullException(nameof(tache), "la tache ne peut pas être null");

            if (_taches.Remove(tache))
            {
                //mise a jour de liste apres suppression 
                Sauvegarder();
            }
        }



        /// <summary>
        /// marquer une tache comme terminer 
        /// </summary>
        /// <param name="tache">tache mis a jour </param>
        /// <exception cref="ArgumentNullException"> exception levée  en cas la tache est null </exception>
        public void MarquerCommeTerminee(Tache tache)
        {
            if (tache == null)
                throw new ArgumentNullException(nameof(tache), "la tache ne peut pas être null");


            // Trouver l'index de la tache en comparer les titres 
            var index = _taches.FindIndex(t => t.Titre == tache.Titre);

            //Verification si tache trouvée 
            if (index != -1)
            {
                //mis a jour et sauvegarde d'etat de tache 
                _taches[index].Etat = EtatTache.Terminee;
                Sauvegarder();
            }
        }


        /// <summary>
        /// recupperer la liste des taches tries par priorité (haute - moyenne - basse)
        /// </summary>
        /// <returns> liste des tache trié </returns>
        public List<Tache> GetTachesTriees()
        {
            return _taches.OrderByDescending(t => t.Priorite).ToList();
        }



        /// <summary>
        /// Sauvegarde de liste des taches 
        /// </summary>
        public void Sauvegarder()
        {
            _storage.SauvegarderTaches(_taches);
        }


        /// <summary>
        /// Charger les taches depuis  le ficher JSON et mis a jour en memoire 
        /// </summary>
        public void Charger()
        {
            _taches = _storage.ChargerTaches();
        }
    }
}
