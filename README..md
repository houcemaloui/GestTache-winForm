### GestTaches - Gestionnaire de Tâches

## 1. Description

__ GestTaches__  est une application Windows Forms développée en C# permettant la gestion des tâches avec les fonctionnalités suivantes :

    * Ajout de tâches avec priorité (Haute, Moyenne, Basse).
    * Affichage des tâches triées par priorité.
    * Marquage des tâches comme terminées.
    * Suppression des tâches.
    * Sauvegarde et chargement des tâches dans un fichier JSON.

## 2. Architecture du projet 

# 2.1. Vue d'ensemble 

 **GestTaches** suit une architecture modulaire basée sur la **Clean Architecture**, séparant les préoccupations en plusieurs couches distinctes :
- **GestTaches.Core** : Contient les modèles, les interfaces et les services métier.
- **GestTaches.Data** : Responsable de la gestion des données et de la persistance des tâches.
- **GestTaches.Views** : Interface utilisateur en Windows Forms (WinForms).
- **Assets** : Contient les icônes.



# 2.2. Structure du projet

**GestTaches** (Projet principal)
    => C'est le projet d'exécution qui initialise et lie les différentes couches

- **Program.cs** : Point d'entrée principal de l'application
- **App.config** : Fichier de configuration de l'application
- **Views/** : Contient les formulaires WinForms pour l'affichage et l'interaction utilisateur
- **Assets/** : Contient les icônes et images utilisées dans l'application


**GestTaches.Core** (Couche métier)
    => Cette couche définit la logique métier et les entités principales.

- **Abstractions/** : Définit les interfaces pour l'abstraction des services et du stockage.
- **Enums/ **: Contient les énumérations comme PrioriteTache et EtatTache.
- **Models/** : Définit les classes de modèle (Tache).
- **Services/** : Implémente la gestion des tâches avec TacheService.


**GestTaches.Data** (Accès aux données)
    => Cette couche gère la lecture et l'écriture des données (fichiers JSON)

- **Repositories/** : Contient TacheRepository, qui gère la sauvegarde et le chargement des tâches.


# 2.3. Principe de fonctionnement

    1. L'interface utilisateur (GestTaches.Views) permet à l'utilisateur d'ajouter, modifier et supprimer des tâches.
    2. Les services métier (GestTaches.Core.Services) assurent la logique de gestion des tâches.
    3. Le stockage des données (GestTaches.Data.Repositories) enregistre et récupère les tâches depuis un fichier JSON.
    4. L'injection de dépendances est utilisée pour connecter la couche de persistance et la couche métier.


## 3.Technologies utilisées

* Langage : C#
* Framework : .NET (Windows Forms - WinForms)
* Stockage des tâches : Fichier JSON avec Newtonsoft.Json
* Pattern : Clean Architecture avec séparation des responsabilités



## 4. Fonctionnalités implémentées

* Ajout d'une tâche avec un titre et une priorité (Haute, Moyenne, Basse).
* Affichage des tâches triées par priorité (Haute en premier, puis Moyenne, puis Basse).
* Marquage des tâches comme terminées, avec un style visuel distinct (texte grisé et italique).
* Suppression des tâches avec confirmation.
* Sauvegarde et chargement des tâches depuis un fichier JSON.
* Interface utilisateur ergonomique avec des boutons illustrés et un design amélioré.

## 5. Utilisation de l'application

* Ajouter une tâche : Bouton Ajouter une tâche
* Terminer une tâche : Icône "check" en Vert
* Supprimer une tâche : Icône "Trash" en Rouge
* Fermeture et réouverture : Les tâches sont sauvegardées et restaurées automatiquement


## 6. Limitations

* Pas de base de données : L'application utilise un fichier JSON pour la persistance des tâches, ce qui peut poser des problèmes de performance avec un grand nombre de tâches.
* Pas de gestion multi-utilisateurs : Chaque utilisateur utilise ses propres tâches en local, il n'y a pas de synchronisation entre différents utilisateurs.
* Absence de filtres avancés : Actuellement, l'affichage ne permet pas de filtrer les tâches par état ou par priorité.
* Interface en WinForms : WinForms est une technologie vieillissante, ce qui limite les possibilités d'amélioration graphique avancée.



## 7. Améliorations futures

* Migration vers une base de données pour une gestion plus efficace des tâches.
* Implémentation d’un système d’authentification avec gestion des rôles.
* Ajout de filtres et d’une recherche avancée pour une meilleure gestion des tâches.
* Intégration d’un système de rappels et notifications en temps réel.
* Refonte de l’interface utilisateur avec un design moderne et ergonomique.
* Possibilité d’export et d’import des tâches en différents formats (PDF, Excel, CSV).
* Développement d’une version web et mobile pour une accessibilité multiplateforme.
* Synchronisation des tâches via le cloud pour un accès sur plusieurs appareils.
* Ajout d’un mode sombre et clair pour améliorer le confort visuel.
* Intégration avec des outils externes comme Google Calendar et Outlook.


## 8. Déploiement et utilisation

L'application peut être exécutée en lançant le fichier exécutable généré après la compilation. 
Aucune installation spécifique n'est requise, à part l'exécution sur un environnement Windows avec le .NET Framework installé.

