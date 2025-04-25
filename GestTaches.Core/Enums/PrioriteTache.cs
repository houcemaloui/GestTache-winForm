using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestTaches.Core.Enums
{

    /// <summary>
    /// Definir les niveau de priorité des taches
    /// </summary>
    ///

    public enum PrioriteTache
    {
        Basse, // tache non urgente
        Moyenne,// tache a faire dans un temps raisonnable 
        Haute // tache importante a faire rapidement 
    }
}
