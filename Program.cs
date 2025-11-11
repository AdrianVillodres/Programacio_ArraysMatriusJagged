namespace Arrays_Matrix_JaggedA
{
    public class Exercice
    {
        public static void Main()
        {
            const int ROWS = 10;
            const int COLS = 10;
            int treasureSecretNumber = 5;

            string[,] map = new string[ROWS, COLS];
            Random rand = new Random();
            int randomNumber = 0;
            bool isTeasure = false;

            for(int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    randomNumber = rand.Next(1, 21);
                    if(randomNumber == treasureSecretNumber)
                    {
                        map[i, j] = "*";
                        isTeasure = true;
                    }
                    else
                    {
                        map[i, j] = "0";
                    }
                }
            }
            if (!isTeasure)
            {
                map[5, 4] = "*";
            }

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write($"{map[i, j]} ");
                }
                Console.WriteLine("");
            }


        }
    }
}
