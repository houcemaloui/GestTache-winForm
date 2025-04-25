using GestTaches.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestTaches.Core.Models
{
    /// <summary>
    /// Model Tache : represente une tache avec son titre , sa priorité et son etat 
    /// </summary>
    
    public class Tache
    {
        
        public string Titre { get; } //titre en lecture seule
        public PrioriteTache Priorite { get; } // Priorite de tache (Haute - Moyenne - Basses )
        public EtatTache Etat { get;  set; } //Etat de tache a faire ou terminé 



        /// <summary>
        /// 
        /// </summary>
        /// <param name="titre"></param>
        /// <param name="priorite"></param>
        /// <exception cref="ArgumentException"></exception>
        public Tache(string titre, PrioriteTache priorite)
        {
            
            if (string.IsNullOrWhiteSpace(titre))
                throw new ArgumentException("Le titre ne peut pas être vide");

            Titre = titre.Trim();
            Priorite = priorite;
            Etat = EtatTache.AFaire;
        }

       




    }
}
