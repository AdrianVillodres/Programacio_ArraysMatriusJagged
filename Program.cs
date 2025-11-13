namespace Arrays_Matrix_JaggedA
{
    public class Exercice
    {
        public static void Main()
        {
            const string MenuDec = "==================================";
            const string KillStatsMsg = "Game kill stats";
            const string TextsMsg = "Player     Match1  Match2  Match3  Match4  Match5";
            const string StatsSeparation = "--------------------------";
            const int Rows = 4;
            const int Columns = 5;

            Random rand = new Random();
            string[] players = { "ShadowWolf", "PixelNinja", "CuberMage", "DragonSlayer" };
            int[,] kills = new int[Rows, Columns];

            for (int i = 0; i < kills.GetLength(0); i++)
            {
                for (int j = 0; j < kills.GetLength(1); j++)
                {
                    kills[i, j] = rand.Next(0, 11);
                }
            }
            Console.WriteLine(MenuDec);
            Console.WriteLine(KillStatsMsg);
            Console.WriteLine(MenuDec);
            Console.WriteLine();
            Console.WriteLine(TextsMsg);
            Console.WriteLine();
            Console.WriteLine(StatsSeparation);
            for (int i = 0; i < kills.GetLength(0); i++)
            {
                Console.Write($"{players[i]}\t");
                for (int j = 0; j < kills.GetLength(1); j++)
                {
                    Console.Write($"{kills[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine(StatsSeparation);
        }
    }
}

