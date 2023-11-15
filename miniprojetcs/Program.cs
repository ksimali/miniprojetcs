﻿using System.Linq.Expressions;

namespace miniprojetcs;

class Program
{
    // Fonction de saisie d'un nombre par l'utilisateur
    public static int Saisie()
    {
        //Declaration d'une variable entier
        int code;
        // Saisie d'un nombre par l'utilisateur
        Console.Write("Veuillez saisir votre code d'employé: ");
        code = int.Parse(Console.ReadLine());

        return code;
    }
    // Fonction de recherche d'un element dans un tableau
    public static int Search(int[] array,int code)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]== code)
            {
                return i; // retourne l'indice si le code est trouvé
            }
        }
        return -1; // retourne -1 si la cible n'est pas trouvé
    }
    // Method qui recupere le choix de l'employé dans le menu principal
    public static int Choix()
    {
        Console.Write("Votre choix: ");
        int choix = int.Parse(Console.ReadLine());

        return choix;
    }

    // Procédure qui affiche le menu principal
    static void AfficherMenuPrincipal()
    {
        Console.WriteLine("********************");
        Console.WriteLine(" MENU PRINCIPAL ");
        Console.WriteLine("********************");
        Console.WriteLine("1. Ajouter un article");
        Console.WriteLine("2. Supprimer un article");
        Console.WriteLine("3. Afficher le panier");
        Console.WriteLine("0. Payer");

    }
   

    // Methode principale
    static void Main(string[] args)
    {

        // Declaration de variables 
        int code, result, choix;
        //Déclaration de tableau d'entier et de string de taille 5 avec des valeurs initiales
        int[] accesCode = new int[5] { 2215, 2216, 2317, 2318, 2319 };
        string[] employee = new string[5] { "Harry", "Ron", "Cassim", "Samir", "Laeticia" };

        // Appel de la 1ère fonction saisi()
        code = Saisie();
        // Appel de la 2nd fonction Search()
        result = Search(accesCode,code);
        do
        {
            Console.WriteLine("Code invalide ! Veuillez taper un code valide a 4 chiffre.");
            // Appel de la 1ère fonction saisi()
            code = Saisie();
            // Appel de la 2nd fonction Search()
            result = Search(accesCode, code);

        } while (result == -1);
        if (result != -1)
        {
            string name = employee[result];
            Console.WriteLine("\nBonjour " + name + "\n");
            AfficherMenuPrincipal(); // Appel de la procedure AfficherMenu()
            choix = Choix();

            // WARNING !!! Partie de feature-listitems à repenser !!!
            do
            {
                Console.Write("Choix invalide..."+" Votre choix: ");
                choix = int.Parse(Console.ReadLine());
             
            } while (choix > 4 || choix < 0);

            switch (choix)
            {
                case 0:
                    Console.WriteLine("Hello World Zero! ");
                    break;
                case 1:
                    Console.WriteLine("Hello World 1 ! ");
                    break;
                case 2:
                    Console.WriteLine("Hello World 2 ! ");
                    break;
                case 3:
                    Console.WriteLine("Hello World 3 ! ");
                    break;
                case 4:
                    Console.WriteLine("Hello World 4 ! ");
                    break;
            }
        }
        

        Console.ReadKey();
    }

    

}

