namespace stringsAndFunctions
    {
    internal class Program
        {
        static void Main( string[] args )
            {
            // strings 1 

            string input = Console.ReadLine();

            string[] words = input.Split('.');

            for (int i = 0; i < words.Length; i++)
                {
                words[i] = words[i].Trim();
                words[i] = words[i][0].ToString().ToUpper() + words[i].Substring(1);
                }
            string result = string.Join(".", words);
            Console.WriteLine(result);
            Console.ReadKey();

            //functions 1

            static int SymbolsQuantity( string text )
                {
                return text.Length;
                }

            Console.WriteLine(SymbolsQuantity("Hello"));
            Console.ReadKey();

            // 2 


            int[] intArray = { 2, 5, 232, 767, 213, 900, 2 };

            static int GetSum( int[] intArray )
                {
                int sum = 0;

                for (int i = 0; i < intArray.Length; i++)
                    {
                    sum += intArray[i];
                    }
                return sum;

                }

            Console.WriteLine("The sum of an array is: " + GetSum(intArray));

            Console.ReadKey();

            //  3

            int[] numbers = { 2, 3, 4, 3, 545, 2, 23, 87, 65, 43 };

            static int OddNumbersSum( int[] numbers )
                {
                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                    {
                    if (numbers[i] % 2 != 0)
                        {
                        sum += numbers[i];
                        }
                    }
                return sum;
                }
            Console.WriteLine("Odd numbers sum: " + OddNumbersSum(numbers));

            Console.ReadKey();

            // 4 

            static int GetTwoNumberSum( int x, int y )
                {
                return x + y;
                }
            Console.WriteLine(GetTwoNumberSum(1, 2));
            Console.ReadKey();
            // 5 

            int[] numbersArray = { 2, 55, 2, 213, 1232, 8877, 333, 909 };

            static int GetMaxNumber( int[] numbers )
                {
                int maxNumber = numbers[0];

                for (int i = 0; i < numbers.Length; i++)
                    {
                    if (numbers[i] > maxNumber)
                        {
                        maxNumber = numbers[i];
                        }
                    }
                return maxNumber;
                }
            Console.WriteLine("Max number: " + GetMaxNumber(numbersArray));
            Console.ReadKey();

            // 6 

            int[] intArray2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            static int GetDesiredElement( int[] intArray )
                {
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int result))
                    {
                    Console.WriteLine("Invalid input");
                    return 0;
                    }

                for (int i = 0; i < intArray.Length; i++)
                    {
                    if (result == intArray[i])
                        {
                        return result;
                        }
                    }
                return -1;
                }

            Console.WriteLine(GetDesiredElement(intArray2));
            Console.ReadKey();

            // 7

            int[] intArray3 = { 2, 3, 4, 32, 22, 99, 344, 33, 54, 77 };
            NumbersAscending(intArray3);

            Console.WriteLine("Sorted array: " + string.Join(", ", intArray3));

            static void NumbersAscending( int[] intArray )
                {
                for (int i = 0; i < intArray.Length; i++)
                    {
                    for (int j = i + 1; j < intArray.Length; j++)
                        {
                        if (intArray[i] > intArray[j])
                            {
                            int temp = intArray[i];
                            intArray[i] = intArray[j];
                            intArray[j] = temp;
                            }
                        }
                    }
                }
            Console.ReadKey();

            // 8 


            string text = "Hello how are you?";
            char symbol = 'm';

            bool containsOrNot = Contains(text, symbol);
            Console.WriteLine($"Symbol '{symbol}' {(containsOrNot ? "exists" : "not exists")} in given text");


            static bool Contains( string text, char character )
                {
                foreach (char c in text)
                    {
                    if (c == character)
                        {
                        return true;
                        }
                    }
                return false;
                }

            Console.ReadKey();


            //  9 
            string text1 = "bla";
            char symbol1 = 'b';

            bool allSymbolMatch = All(text1, symbol1);

            Console.WriteLine($"All symbol '{symbol1}' {(allSymbolMatch ? "equals" : "not equals")} to given text's symbols");


            static bool All(string text, char character )
                {
                foreach ( char c in text)
                    {
                    if( c != character)
                        {
                        return false;
                        }
                    }
                return true;
                }
             Console.ReadKey();



            }
        }
    }
