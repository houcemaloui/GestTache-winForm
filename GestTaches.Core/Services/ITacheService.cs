using GestTaches.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestTaches.Core.Services
{
    /// <summary>
    /// Interface qui définit les operation de gestion des taches 
    /// </summary>
    public interface ITacheService
    {
        void AjouterTache(Tache tache);
        void SupprimerTache(Tache tache);
        void MarquerCommeTerminee(Tache tache);
        List<Tache> GetTachesTriees();
        void Sauvegarder();
        void Charger();
    }
}
