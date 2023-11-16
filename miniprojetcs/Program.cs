using System.Linq.Expressions;

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
    public static int SearchInt(int[] array,int code)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == code)
            {
                return i; // retourne l'indice si le code est trouvé
            }
        }
        return -1; // retourne -1 si la cible n'est pas trouvé
    }

    // Fonction de recherche d'un element dans un tableau
    public static int SearchString(string[] array, string code)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Equals(code))
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
        Console.WriteLine("\n\n********************");
        Console.WriteLine(" MENU PRINCIPAL ");
        Console.WriteLine("********************");
        Console.WriteLine("1. Ajouter un article");
        Console.WriteLine("2. Supprimer un article");
        Console.WriteLine("3. Afficher le panier");
        Console.WriteLine("0. Payer");

    }


   
    static void AfficherArticles()
    {
        Console.WriteLine("\n\n********************");
        Console.WriteLine("  AJOUT ARTICLE  ");
        Console.WriteLine("********************");
        Console.WriteLine("A1: Crayons - 3.99$");
        Console.WriteLine("A2: Cahier Canada - 1.59$");
        Console.WriteLine("B1: Table pliante - 66.99$");
        Console.WriteLine("B2: Fauteuil en cuir - 199.99$");
        Console.WriteLine("B3: Bureau d'étudiant - 118.99$");
        Console.WriteLine("L1: Laptop ASUS - 600.89$");
        Console.WriteLine("L2: Laptop HP - 700.89$");
        Console.WriteLine("L3: Laptop Acer - 250.99$");
    }

    static string AjoutArticle(string[] codeArticle)
    {
        AfficherArticles(); // Appel de la fonction permettant d'afficher les articles

        bool test;
        string article;
        do
        {
            Console.Write("Votre choix: ");
            article = Console.ReadLine();
            // Methode permettant de verifier qu'un code article existe dans le tableau codeArticle
            test = codeArticle.Contains(article);
            if (test == false)
            {
                Console.WriteLine("\nCode invalide... ");
            }
        } while (test == false);
        return article;
    }

    static void AfficherPanier(string[] codeArticle, string[] nomArticle, double[] prixArticle, List<string> panier) 
    {
        foreach (string article in panier)
        {
            int index = SearchString(codeArticle, article); // Verifie que le code article existe dans le tableau codeArticle et retourne l'index
            Console.WriteLine(codeArticle[index] + ": "+  nomArticle[index]+  " - "+ prixArticle[index]+ "$");
        }
    }

    static void RetirerDansPanier(string[] codeArticle, string[] nomArticle, double[] prixArticle, List<string> panier)
    {
        // Appel de la fonction permettant d'afficher les elements du panier
        AfficherPanier(codeArticle, nomArticle, prixArticle, panier);
        bool test;
        string article;
        do
        {
            Console.Write("Votre choix: ");
            article = Console.ReadLine();
            // Methode permettant de verifier qu'un code article existe dans la liste 
            test = panier.Contains(article);
            if (test == false)
            {
                Console.WriteLine("\nCode invalide... ");
            }
        } while (test == false);
        // Methode permettant de supprimer un element dans une liste
        panier.Remove(article);
    }

    // Methode principale
    static void Main(string[] args)
    {

        // Declaration de variables 
        int code, result, choix;
        //Déclaration de tableau d'entier et de string de taille 5 avec des valeurs initiales
        int[] accesCode = new int[5] { 2215, 2216, 2317, 2318, 2319 };
        string[] employee = new string[5] { "Harry", "Ron", "Cassim", "Samir", "Laeticia" };
        string[] codeArticle = new string[8] { "A1", "A2", "B1", "B2", "B3", "L1", "L2", "L3"};
        string[] nomArticle = new string[8] { "Crayons", "Cahier Canada", "Table pliante", "Fauteuil en cuir", "Bureau d'étudiant", "Laptop ASUS", "Laptop HP", "Laptop Acer" };
        double[] prixArticle = new double[8] { 3.99, 1.59, 66.99, 199.99, 118.99, 600.89, 700.89, 250.99 };
        List<string> panier = new List<string>();

        do
        {
            // Appel de la 1ère fonction saisi()
            code = Saisie();
            // Appel de la 2nd fonction Search()
            result = SearchInt(accesCode, code);
            if (result == -1)
            {
                Console.WriteLine("Code invalide ! Veuillez taper un code valide a 4 chiffre.");
            }

        } while (result == -1);
        if (result != -1)
        {
            string name = employee[result];
            Console.WriteLine("\nBonjour " + name + "\n");

            bool close = false;

            while(!close) 
            {
                AfficherMenuPrincipal(); // Appel de la procedure AfficherMenu()
                do
                {
                    choix = Choix();
                    if (choix > 4 || choix < 0)
                    {
                        Console.Write("Choix invalide... ");
                    }

                } while (choix > 4 || choix < 0);

                switch (choix)
                {
                    case 0:
                        Console.WriteLine("Hello World Zero! ");
                        close = true;
                        break;
                    case 1:
                        // Appel de la fonction pour l'ajout de l'article
                        string article = AjoutArticle(codeArticle);
                        panier.Add(article);
                        break;
                    case 2:
                        // Appel de la fonction pour la suppression d'un article
                        RetirerDansPanier(codeArticle, nomArticle, prixArticle, panier);
                        break;
                    case 3:
                        // Appel de la fonction pour l'affichage des elements du panier
                        AfficherPanier(codeArticle, nomArticle, prixArticle, panier);
                        break;
                    default:
                        break;
                }
            }
        }
        Console.ReadKey();
    }
}

