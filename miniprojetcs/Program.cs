namespace miniprojetcs;

class Program
{
    static void Main(string[] args)
    {

        // Declaration de variables
        int code;

        // Appel de la 1ère fonction saisi()
        code = Saisie();

        // Appel de la procedure AfficherMenu()
        AfficherMenu();
    }

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

    // Fonction qui affiche le menu principal
    static void AfficherMenu()
    {
        Console.WriteLine("********************");
        Console.WriteLine(" MENU PRINCIPAL ");
        Console.WriteLine("********************");
        Console.WriteLine("1. Ajouter un article");
        Console.WriteLine("2. Supprimer un article");
        Console.WriteLine("3. Afficher le panier");
        Console.WriteLine("0. Payer");

    }

}

