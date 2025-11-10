namespace Arrays_Matrix_JaggedA
{
    public class Exercice
    {
        public static void Main()
        {
            const int size = 20;

            Random rand = new Random();
            int[] nums = new int[size];

            for(int i = 0; i < size; i++)
            {
                nums[i] = rand.Next(1,100);
            }
            for (int i = 0; i < size; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    Console.Write($"{nums[i]} ");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    Console.Write($"{nums[i]} ");
                }
            }

        }
    }
}
