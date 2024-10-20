namespace counterStrike
    {
    internal class Program
        {
        static void Main( string[] args )
            {
            //
            Hero hero = new Hero("Spiderman", 200, 500, 250);
            Villain villain = new Villain("Joker", 180, 450, 200);

            hero.Attack(villain);
            villain.Attack(hero);

            Hero hero2 = new Hero("Batman", 150, 400, 190);
            hero2.Heal(hero, 150);

            Console.ReadKey();
            }
        }
    }
