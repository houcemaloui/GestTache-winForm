using GestTaches.Core.Abstractions;
using GestTaches.Core.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
namespace GestTaches.Data.Repositories
{

    /// <summary>
    /// classe TacheRepository implemente l'interface ITacheStorage assure la separation des responabilités
    /// permet la sauvegarde et le chargement des taches dans et de fichier JSON "taches.json"
    /// </summary>
    public class TacheRepository : ITacheStorage
    {
        // chemin de fichier Json
        private static readonly string CheminFichier = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "taches.json");


        /// <summary>
        /// chargement des taches de fichier taches.json
        /// </summary>
        /// <returns> retoune la liste des taches et une liste vide </returns>
        /// <returns> si le fichier contient des erreurs ou n'existe pas </returns>
        public List<Tache> ChargerTaches()
        {
            try
            {
                //verifier l'existance de fchier 
                if (!File.Exists(CheminFichier))
                    return new List<Tache>();

                var json = File.ReadAllText(CheminFichier);
                var taches = JsonConvert.DeserializeObject<List<Tache>>(json);

                // retour de la liste des taches 
                return taches ?? new List<Tache>();
            }
            catch (JsonException ex)
            {
                //gestion d'erreur : en cas d'erreur au fichier 
                Console.WriteLine($"Erreur lors de la lecture de fichier JSON : {ex.Message}");
                return new List<Tache>();
            }
            catch (Exception ex)
            {
                // gestion de toute autre erreur inattendue
                Console.WriteLine($"Impossible de charger les tâches  : {ex.Message}");
                return new List<Tache>();
            }
        }

        /// <summary>
        /// sauvegarde des taches au fichier 
        /// </summary>
        /// <param name="taches">  liste des taches a sauvegarder </param>

        public void SauvegarderTaches(List<Tache> taches)
        {
            try
            {
                //convertir la liste des taches en format Json
                var json = JsonConvert.SerializeObject(taches, Formatting.Indented);
                File.WriteAllText(CheminFichier, json);
            }
            catch (Exception ex)
            {
                //erreur de sauvegarde 
                Console.WriteLine($"Erreur lors de la sauvegarde des tâches : {ex.Message}");
            }
        }
    }
}
