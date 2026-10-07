using System.Data.SqlTypes;
using System.Diagnostics;

namespace Echauffement;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */

        // Etape 1 : présentez-vous en écrivant votre prénom et votre jeu préféré
        Console.WriteLine("Nathan, Elden Ring");

        // Etape 2 : demandez à l'utilisateur son prénom et son âge
        Console.WriteLine("Comment t'appelles-tu ?");
        string prenom = Console.ReadLine();

        if (prenom == "Xabab")
        {
            Console.WriteLine("C'est pas un jeu Mario c'est une licence");
        }

        if (prenom == "Gohan")
        {
            Console.WriteLine("Relation discrète, relation parfaite, vivons caché on aura moins de problèmes");
        }

        Console.WriteLine("Quel âge as-tu ?");
        int age = Convert.ToInt32(Console.ReadLine());

        // Etape 3 : affichez soit "Tu es majeur", soit "Tu es mineur" dépendant de l'âge fourni par l'utilisateur
        bool isUnderage = age < 18;
        if (isUnderage)
        {
            Console.WriteLine("Tu es mineur");
        }
        else
        {
            Console.WriteLine("Tu es majeur");
        }

        // Etape 4 : demandez maintenant à l'utilisateur combien d'euro il a (nombre décimal)
        Console.WriteLine("Combien d'euro as-tu ?");
        float money = Convert.ToSingle(Console.ReadLine());

        // Etape 5 : affichez maintenant 4 choix d'armes avec chacune un prix
        Console.WriteLine("Tu veux acheter ma marchandise ?");

        Console.WriteLine("1. pistolet des hendeks, c parfait pour les manifs, 50$");
        Console.WriteLine("2. epee en diams, tah steve, 75$");
        Console.WriteLine("3. master sword, on va buter ganon avec, 5000$ (trai trai cher)");
        Console.WriteLine("4. carapace bleu, pour detruire des amities sur mario kart, 125$");

        // Etape 6 : laissez l'utilisateur choisir l'une de ces 4 armes en indiquant un nombre entre 1 et 4
        Console.WriteLine("Choisis une arme (choisis une arme citées et casse pas les couilles)");
        int armes = Convert.ToInt32(Console.ReadLine());

        int weaponChoice = Convert.ToInt32(Console.ReadLine());
        // Etape 7a : vérifiez si l'utilisateur a assez d'argent par rapport à la somme qu'il avait rentré à l'étape 4
        if (weaponChoice == 1)
        {
            float price = 50.0f;
            if (money < price || isUnderage)
            {
                Console.WriteLine("t pauvre, sale merde boooooooooo");
            }
            else
            {
                money = money - price;
                Console.WriteLine("tiens pour toi bg");
            }
        }
        else if (weaponChoice == 2)
        {
            float price = 75.0f;
            if (money < price || isUnderage)
            {
                Console.WriteLine("t pauvre, sale merde boooooooooo");
            }
            else
            {
                money = money - price;
                Console.WriteLine("tiens pour toi bg");
            }
        }
        else if (weaponChoice == 3)
        {
            float price = 5000.0f;
            if (money < price || isUnderage)
            {
                Console.WriteLine("t pauvre, sale merde boooooooooo");
            }
            else
            {
                money = money - price;
                Console.WriteLine("tiens pour toi bg");
            }
        }
        else if (weaponChoice == 4)
        {
            float price = 125.0f;
            if (money < price || isUnderage)
            {
                Console.WriteLine("t pauvre, sale merde boooooooooo");
            }
            else
            {
                money = money - price;
                Console.WriteLine("tiens pour toi bg");
            }
        }
        else
        {
            Console.WriteLine("gros t'essaye d'acheter quoi la ?");
        }
    }
        // Etape 7b : modifiez l'étape 7a pour ajouter un connecteur logique qui vérifie que l'utilisateur est majeur en plus d'avoir assez d'argent
        // Lorsque l'utilisateur respecte ces demandes, retirez le prix de l'arme de l'argent de l'utilisateur, puis confirmez à l'utilisateur que l'action a été effectuée 
        // Dans tous les autres cas, informez l'utilisateur que l'action n'a pas été possible

        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */

}