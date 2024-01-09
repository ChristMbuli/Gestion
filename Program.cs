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
            Console.WriteLine("\nBienvenue Gestion des filières, enseignants et étudiants en C# ");
            Console.WriteLine("-------------------------------------------------------------\n");
            Console.WriteLine("Menu Principale : \n");


            Console.WriteLine("1. Ajouter une filière \t 2. Ajouter un enseignant \t 3. Ajouter un étudiant \n");
            Console.WriteLine("4. Afficher toutes les filières \t 5. Afficher tous les enseignants \t 6. Afficher tous les étudiants \n");
            Console.WriteLine("7. Supprimer un étudiants \t 8. Modifier un étudiants \n");
            Console.WriteLine("0. QUITTER");
            Console.WriteLine("**************************************************************************************************************");


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
                case 7:
                    SupprimerEtudiant();
                    break;
                case 8:
                    ModifierEtudiant();
                    break;
                // case 9:
                //     SupprimerEnseignant();
                //     break;
                // case 10:
                //     ModifierEnseignant();
                //     break;

                case 0:
                    Console.WriteLine("\n Au revoir ! \n");
                    return;
                default:
                    Console.WriteLine("\n Choix invalide \n");
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
        Console.WriteLine("Entrez le nom de l'enseignant :\n");
        string nom = Console.ReadLine();
        enseignants.Add(new Enseignant(nom));
        Console.WriteLine("Enseignant ajouté avec succès !\n");
    }

    // Méthode pour ajouter un étudiant
    static void AjouterEtudiant()
    {
        Console.WriteLine("Entrez le prénom de l'étudiant :\n");
        string prenom = Console.ReadLine();
        Console.WriteLine("Entrez le nom de l'étudiant :\n");
        string nom = Console.ReadLine();
        Console.WriteLine("Entrez l'email de l'étudiant :\n");
        string email = Console.ReadLine();
        Console.WriteLine("Entrez le sexe de l'étudiant (M/F) :\n");
        char sexe = Convert.ToChar(Console.ReadLine());

        etudiants.Add(new Etudiant(prenom, nom, email, sexe));
        Console.WriteLine("Étudiant ajouté avec succès !\n");
    }

    // Méthode pour afficher toutes les filières
    static void AfficherFilieres()
    {
        Console.WriteLine("Liste des filières :\n");
        foreach (var filiere in filieres)
        {
            Console.WriteLine(filiere.Nom);
        }
    }

    // Méthode pour afficher tous les enseignants
    static void AfficherEnseignants()
    {
        Console.WriteLine("Liste des enseignants :\n");
        foreach (var enseignant in enseignants)
        {
            Console.WriteLine(enseignant.Nom);
        }
    }

    // Méthode pour afficher tous les étudiants
    static void AfficherEtudiants()
    {
        Console.WriteLine("Liste des étudiants :\n");
        foreach (var etudiant in etudiants)
        {
            Console.WriteLine($"{etudiant.Prenom} {etudiant.Nom}, Email: {etudiant.Email}, Sexe: {etudiant.Sexe}");
        }
    }
    // Méthode pour supprimer un étudiant
    static void SupprimerEtudiant()
    {
        Console.WriteLine("Entrez l'email de l'étudiant à supprimer :\n");
        string email = Console.ReadLine();

        var etudiantASupprimer = etudiants.Find(e => e.Email == email);
        if (etudiantASupprimer != null)
        {
            etudiants.Remove(etudiantASupprimer);
            Console.WriteLine("Étudiant supprimé avec succès !\n");
        }
        else
        {
            Console.WriteLine("Étudiant non trouvé.\n");
        }
    }

    // Méthode pour modifier un étudiant
    static void ModifierEtudiant()
    {
        Console.WriteLine("Entrez l'email de l'étudiant à modifier : \n");
        string email = Console.ReadLine();

        var etudiantAModifier = etudiants.Find(e => e.Email == email);
        if (etudiantAModifier != null)
        {
            Console.WriteLine("Entrez le nouveau prénom de l'étudiant :\n");
            etudiantAModifier.Prenom = Console.ReadLine();
            Console.WriteLine("Entrez le nouveau nom de l'étudiant :\n");
            etudiantAModifier.Nom = Console.ReadLine();
            Console.WriteLine("Entrez le nouvel email de l'étudiant :\n");
            etudiantAModifier.Email = Console.ReadLine();
            Console.WriteLine("Entrez le nouveau sexe de l'étudiant (M/F) :\n");
            etudiantAModifier.Sexe = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Étudiant modifié avec succès !\n");
        }
        else
        {
            Console.WriteLine("Étudiant non trouvé.");
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
    public string Prenom { get; set; }
    public string Nom { get; set; }
    public string Email { get; set; }
    public char Sexe { get; set; }

    public Etudiant(string prenom, string nom, string email, char sexe)
    {
        Prenom = prenom;
        Nom = nom;
        Email = email;
        Sexe = sexe;
    }
}
