namespace CollectionJeuxVideo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Ajouter un jeu");
            Console.WriteLine("2. Liste des jeux");
            Console.WriteLine("3. Afficher détail d'un jeu");
            Console.WriteLine("4. Ajouter une catégorie");
            Console.WriteLine("5. Lister les catégories");
            Console.WriteLine("6. Modifier une catégorie");
            Console.WriteLine("0. Quitter");

            int choix = int.Parse(Console.ReadLine());

            switch (choix)
            {
                case 1:
                    AjouterJeu();
                    break;
                case 2:
                    ListerJeux();
                    break;
                case 3:
                    AfficherDetailJeu();
                    break;
                case 4:
                    AjouterCategorie();
                    break;
                case 5:
                    ListerCategories();
                    break;
                case 6:
                    ModifierCategorie();
                    break;
                case 0:
                    return;
            }
        }
    }
}