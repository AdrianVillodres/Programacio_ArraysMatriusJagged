namespace Arrays_Matrix_JaggedA
{
    public class Exercice
    {
        public static void Main()
        {
            const string GlobalPointsMsg = "Global total points of the tournament: {0}" ; 

            Random rand = new Random();
            int[][] scores = new int[4][];
            scores[0] = new int[3];
            scores[1] = new int[5];
            scores[2] = new int[2];
            scores[3] = new int[4];
            string[] names = {"LunaBlade", "IronFist", "ShadowNova", "PixelMage"};
            float[] avgs = new float[4];
            float avg = 0f;
            int totalPoints = 0;
            int counter = 0;

            for (int i = 0; i < scores.Length; i++)
            {
                for (int j = 0; j < scores[i].Length; j++)
                {
                    scores[i][j] = rand.Next(0, 101);
                    totalPoints += scores[i][j];
                    avg += scores[i][j];
                    totalPoints += scores[i][j];
                    counter++;
                }
                avgs[i] = avg / counter;
                avg = 0;
                counter = 0;
            }

            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write($"{names[i]}: ");
                for (int j = 0; j < scores[i].Length; j++)
                {
                    Console.Write($"{scores[i][j]} "); 
                }
                Console.WriteLine($"-> Average: {avgs[i]}");
            }
            Console.WriteLine(GlobalPointsMsg, totalPoints);
        }
    }
}
