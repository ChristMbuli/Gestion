using System;
using System.Collections.Generic;

class Program
{
    // Listes pour stocker les données
    static List<Filiere> filieres = new List<Filiere>();
    static List<Enseignant> enseignants = new List<Enseignant>();
    static List<Etudiant> etudiants = new List<Etudiant>();

    static void Main(string[] args)
    {
        // Boucle pour l'interaction avec l'utilisateur
        while (true)
        {
            // Menu des options disponibles
            Console.WriteLine("1. Ajouter une filière");
            Console.WriteLine("2. Ajouter un enseignant");
            Console.WriteLine("3. Ajouter un étudiant");
            Console.WriteLine("4. Afficher toutes les filières");
            Console.WriteLine("5. Afficher tous les enseignants");
            Console.WriteLine("6. Afficher tous les étudiants");
            Console.WriteLine("0. Quitter");

            int choix = Convert.ToInt32(Console.ReadLine());

            switch (choix)
            {
                case 1:
                    AjouterFiliere();
                    break;
                case 2:
                    AjouterEnseignant();
                    break;
                case 3:
                    AjouterEtudiant();
                    break;
                case 4:
                    AfficherFilieres();
                    break;
                case 5:
                    AfficherEnseignants();
                    break;
                case 6:
                    AfficherEtudiants();
                    break;
                case 0:
                    Console.WriteLine("Au revoir !");
                    return;
                default:
                    Console.WriteLine("Choix invalide");
                    break;
            }
        }
    }

    // Méthode pour ajouter une filière
    static void AjouterFiliere()
    {
        Console.WriteLine("Entrez le nom de la filière :");
        string nom = Console.ReadLine();
        filieres.Add(new Filiere(nom));
        Console.WriteLine("Filière ajoutée avec succès !");
    }

    // Méthode pour ajouter un enseignant
    static void AjouterEnseignant()
    {
        Console.WriteLine("Entrez le nom de l'enseignant :");
        string nom = Console.ReadLine();
        enseignants.Add(new Enseignant(nom));
        Console.WriteLine("Enseignant ajouté avec succès !");
    }

    // Méthode pour ajouter un étudiant
    static void AjouterEtudiant()
    {
        Console.WriteLine("Entrez le prénom de l'étudiant :");
        string prenom = Console.ReadLine();
        Console.WriteLine("Entrez le nom de l'étudiant :");
        string nom = Console.ReadLine();
        Console.WriteLine("Entrez l'email de l'étudiant :");
        string email = Console.ReadLine();
        Console.WriteLine("Entrez le sexe de l'étudiant (M/F) :");
        char sexe = Convert.ToChar(Console.ReadLine());

        etudiants.Add(new Etudiant(prenom, nom, email, sexe));
        Console.WriteLine("Étudiant ajouté avec succès !");
    }

    // Méthode pour afficher toutes les filières
    static void AfficherFilieres()
    {
        Console.WriteLine("Liste des filières :");
        foreach (var filiere in filieres)
        {
            Console.WriteLine(filiere.Nom);
        }
    }

    // Méthode pour afficher tous les enseignants
    static void AfficherEnseignants()
    {
        Console.WriteLine("Liste des enseignants :");
        foreach (var enseignant in enseignants)
        {
            Console.WriteLine(enseignant.Nom);
        }
    }

    // Méthode pour afficher tous les étudiants
    static void AfficherEtudiants()
    {
        Console.WriteLine("Liste des étudiants :");
        foreach (var etudiant in etudiants)
        {
            Console.WriteLine($"{etudiant.Prenom} {etudiant.Nom}, Email: {etudiant.Email}, Sexe: {etudiant.Sexe}");
        }
    }
}

// Classe Filiere pour représenter une filière
class Filiere
{
    public string Nom { get; }

    public Filiere(string nom)
    {
        Nom = nom;
    }
}

// Classe Enseignant pour représenter un enseignant
class Enseignant
{
    public string Nom { get; }

    public Enseignant(string nom)
    {
        Nom = nom;
    }
}

// Classe Etudiant pour représenter un étudiant
class Etudiant
{
    public string Prenom { get; }
    public string Nom { get; }
    public string Email { get; }
    public char Sexe { get; }

    public Etudiant(string prenom, string nom, string email, char sexe)
    {
        Prenom = prenom;
        Nom = nom;
        Email = email;
        Sexe = sexe;
    }
}






//hgjfhtdghd