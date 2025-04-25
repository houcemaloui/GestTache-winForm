using GestTaches.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestTaches.Core.Abstractions
{
    /// <summary>
    /// Interface definir les operation de stockage des taches - 
    /// permet de sauvegarder et recupperer les taches de fichier json de stockage 
    /// </summary>
    public interface ITacheStorage 
    {
        void SauvegarderTaches(List<Tache> taches);
        List<Tache> ChargerTaches();
    }
}
