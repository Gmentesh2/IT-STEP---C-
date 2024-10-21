namespace counterStrike
    {
    internal class Program
        {
        static void Main( string[] args )
            {
            //
            Hero hero = new Hero("Spiderman", 200, 500, 250);
            Villain villain = new Villain("Joker", 180, 450, 200);


            Weapon riffle = new Weapon("riffle", 100, 150);
            Weapon shotgun = new Weapon("shotgun", 150, 200);

            hero.BuyWeapon(riffle);
            villain.BuyWeapon(shotgun);
                
            hero.Attack(villain);
            villain.Attack(hero);


            Hero hero2 = new Hero("Batman", 150, 400, 190);
            hero2.Heal(hero, 150);

            Console.ReadKey();
            }
        }
    }
