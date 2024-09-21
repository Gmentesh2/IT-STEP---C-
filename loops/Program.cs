namespace loops
    {
    internal class Program
        {
        static void Main( string[] args )
            {
            // 1 
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= number; i++)
                {
                sum += i;
                }
            Console.WriteLine($"The sum of the numbers from 1 to {number} is {sum}");
            Console.ReadKey();

            // 2
            Console.Write("Enter number: ");
            int number1 = int.Parse(Console.ReadLine());


            Console.Write("Enter number between 1 to 10: ");
            int square = int.Parse(Console.ReadLine());

            int result;
            try
                {
                if (square <= 10)
                    {
                    result = number1 * square;
                    Console.WriteLine($"The {number1} multiplied by {square} is {result} ");
                    }
                else
                    {
                    throw new ArgumentOutOfRangeException("square", "The number must between 1 to 10");
                    }
                }
            catch (Exception ex)
                {
                Console.WriteLine(ex.Message);
                }

            Console.ReadKey();

            // 3

            Console.Write("Enter desired number: ");
            int number2 = int.Parse(Console.ReadLine());

            char character = '*';

            string result1 = "";

            for (int i = 0; i < number2; i++)
                {
                result1 += character;
                Console.WriteLine(result1);
                }
            Console.ReadKey();

            // 4 

            Console.Write("Enter number: ");
            int number3 = int.Parse(Console.ReadLine());

            int factorial = 1;
            for (int i = 1; i <= number3; i++)
                {
                factorial *= i;
                }
            Console.WriteLine($"{number3} factorial is {factorial}");
            Console.ReadKey();

            // 5 

            Console.Write("Enter number: ");
            int number4 = int.Parse(Console.ReadLine());


            for (int i = 1; i <= number4; i++)
                {
                for (int j = 1; j <= i; j++)
                    {
                    Console.Write(i);
                    }
                Console.WriteLine();
                }

            Console.ReadKey();

            // 6 

            Console.Write("Enter first number: ");
            int firstNumber = int.Parse( Console.ReadLine() );

            Console.Write("Enter second number: ");
            int secondNumber = int.Parse( Console.ReadLine() ); 


            int start = Math.Min(firstNumber, secondNumber );
            int end = Math.Max(firstNumber, secondNumber);

            for(int i = start; i <= end; i++)
                {
                if(i % 2 == 0)
                    {
                    Console.WriteLine(i);
                    }
                }
            Console.ReadKey();


            
        }
        }
    }
