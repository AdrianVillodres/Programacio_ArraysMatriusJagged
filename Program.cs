namespace Arrays_Matrix_JaggedA
{
    public class Exercice
    {
        public static void Main()
        {
            const string IntroMsg = "Put a number and I will tell you how many times it appears in the array";
            const string NoNumberMsg = "The array doesn't contais that number";
            const string NumberMsg = "The array contains the number {0} {1} times";
            const string ErrorMsg = "Error, you must put a number between 1 and 9";

            Random rand = new Random();
            int[] arrayStraight = new int[10];
            int numRand;
            int aux;
            int numInput = 0;
            int counter = 0;
            bool isCorrect = true;

            for (int i = 0; i < arrayStraight.GetLength(0);i++)
            {
                numRand = rand.Next(1, 10);
                arrayStraight[i] = numRand;
            }

            for(int i = 1; i < arrayStraight.GetLength(0); i++)
            {
                for(int j = 0; j < arrayStraight.GetLength(0) - 1; j++)
                {
                    if (arrayStraight[j] > arrayStraight[j + 1])
                    {
                        aux = arrayStraight[j + 1];
                        arrayStraight[j + 1] = arrayStraight[j];
                        arrayStraight[j] = aux;
                    }
                }
            }

            Console.WriteLine(IntroMsg);
            try
            {
                numInput = Int32.Parse(Console.ReadLine());
            }
            catch (OverflowException)
            {
                Console.WriteLine(ErrorMsg);
                isCorrect = false;
            }
            catch (FormatException)
            {
                Console.WriteLine(ErrorMsg);
                isCorrect = false;
            }
            catch (Exception)
            {
                Console.WriteLine(ErrorMsg);
                isCorrect = false;
            }
            if (numInput < 1 || numInput > 9)
            {
                isCorrect = false;
            }

            if(isCorrect == true)
            {
                for(int i = 0; i < arrayStraight.GetLength(0); i++)
                {
                    if (arrayStraight[i] == numInput)
                    {
                        counter++;
                    }
                }

                if(counter > 0)
                {
                    Console.WriteLine(NumberMsg, numInput, counter);
                }
                else
                {
                    Console.WriteLine(NoNumberMsg);
                }

                for (int i = 0; i < arrayStraight.GetLength(0); i++)
                {
                    Console.Write($"{arrayStraight[i]} ");
                }
            }

            
        }
    }
}
