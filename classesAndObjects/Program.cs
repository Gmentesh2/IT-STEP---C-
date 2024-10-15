namespace classesAndObjects
    {
    internal class Program
        {
        static void Main( string[] args )
            {
            // 1
            //Person myInfo = new Person("Giorgi", "Menteshashvili", 24, 01005000000, "574020702", "gmenteshashvili@gmail.com");
            //myInfo.DisplayPersonInfo();
            //Console.ReadKey();
            // 2

            Account account = new Account("USD", "GE12345678901234567890");
            Account account2 = new Account("USD", "GE12345678901234567892");

            
            Client client = new Client("Maria", "Sharapova", "12345678901", account);
            Client client2 = new Client("Dimitri", "Kuzanov", "22223489743", account2);

            
            account.Deposit(500); 
            account.Deposit(500);

            // Output balances
            Console.WriteLine($"{client.Name} {client.SurName} balance: {client.Account.Balance} {client.Account.Currency}");
            Console.WriteLine($"{client2.Name} {client2.SurName} balance: {client2.Account.Balance} {client2.Account.Currency}");

           
            Console.ReadKey();


            }
        }
    }
