namespace Arrays_Matrix_JaggedA
{
    public class Exercice
    {
        public static void Main()
        {
            Random rand = new Random();
            int[] arrayStraight = new int[10];
            int[] arrayBackwards = new int[10];
            int numArray = 9;
            int numRand;

            for(int i = 0; i < arrayStraight.GetLength(0);i++)
            {
                numRand = rand.Next(1, 10);
                arrayStraight[i] = numRand;
                arrayBackwards[numArray] = numRand;
                numArray--;
            }
            for (int i = 0; i < arrayStraight.GetLength(0); i++)
            {
                Console.Write($"{arrayStraight[i]} ");
            }
            Console.WriteLine();
            for (int i = 0; i < arrayStraight.GetLength(0); i++)
            {
                Console.Write($"{arrayBackwards[i]} ");
            }

        }
    }
}
