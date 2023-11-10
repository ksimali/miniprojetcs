namespace miniprojetcs;

class Program
{
    static void Main(string[] args)
    {
        // Declaration des variables entier et tableaux.
        int code;
        // Appel de la fonction saisi()
        code = Saisie();
    }

    //Fonction de saisie d'un nombre par l'utilisateur
    public static int Saisie()
    {
        //Declaration d'une variable entier
        int code;
        // Saisie d'un nombre par l'utilisateur
        Console.Write("Veuillez saisir votre code d'employé: ");
        code = int.Parse(Console.ReadLine());

        return code;
    }
}

