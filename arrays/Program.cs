namespace arrays
    {
    internal class Program
        {
        static void Main( string[] args )
            {
            // 1
            int[] intArray = { 1, 2, 3, 6, 8, 11, 14, 16, 20, 22, 23, 2 };
            int sum = 0;
            for (int i = 0; i < intArray.Length; i++)
                {
                if (intArray[i] % 2 == 0)
                    {
                    sum += intArray[i];
                    }
                }
            //Console.WriteLine($"The sum of even elements: {sum}");
            //Console.ReadKey();

            // 2

            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] copyArray = new int[array1.Length];

            for (int i = 0; i < array1.Length; i++)
                {
                copyArray[i] = array1[i];

                }

            //Console.WriteLine("Initial Array: " + string.Join(", ",array1));
            //Console.WriteLine("Copied Array: " + string.Join(", ", copyArray));

            Console.ReadKey();

            // 3

            int[] elements = { 1, 2, 1, 3, 22, 112, 1, 6, 32, 32, 22, 112 };
            int[] uniqueElements = new int[elements.Length];
            int count = 0;

            for (int i = 0; i < elements.Length; i++)
                {
                bool isUnique = true;

                for (int j = 0; j < elements.Length; j++)
                    {
                    if (i != j && elements[i] == elements[j])
                        {
                        isUnique = false;
                        break;
                        }
                    }
                if (isUnique)
                    {
                    uniqueElements[count] = elements[i];
                    count++;
                    }
                }

            //Console.Write("Unique elements: ");
            //for (int i = 0; i < count; i++)
            //    {
            //    Console.Write(uniqueElements[i] + " ");
            //    }

            //Console.ReadKey();


            // 4 
            int[] numbers = { 1, 2, 3, 10, 7, 22, 90, 122, 88, 233 };

            int maxNumber = numbers[0];

            for(int i = 0; i < numbers.Length ; i++)
                {
                if( numbers[i] > maxNumber)
                    {
                    maxNumber = numbers[i];
                    }

                }
            //Console.WriteLine(maxNumber);
            //Console.ReadKey();

            // 5

            int[] numbers1 = { 2, 22, 654, 98, 65, 321 };
            int maxNumber1 = numbers1[0];
            int maxNumberIndex = 0;

            for(int i = 0; i < numbers1.Length ; i++)
                {
                if(numbers1[i] > maxNumber1)
                    {
                    maxNumber1 = numbers1[i];
                    maxNumberIndex = i;
                    }
                }
            //Console.WriteLine($"Max number is {maxNumber1} and its index is: {maxNumberIndex}");

            //Console.ReadKey();

            // 6 

            int[] intArray2 = { 1, 4, 2, 10, 900, 344, 776, 544, 232, 1022, 498 };

            for(int i = 0; i < intArray2.Length ; i++)
                {
                for(int j = i + 1; j < intArray2.Length ; j++)
                    {
                    if (intArray2[i] > intArray2[j])
                        {
                        int temp = intArray2[i];
                        intArray2[i] = intArray2[j];
                        intArray2[j] = temp;
                        }
                    }
                }
            Console.WriteLine("Result: " + string.Join(", ",intArray2));
            Console.ReadKey();




            }
        }
    }
