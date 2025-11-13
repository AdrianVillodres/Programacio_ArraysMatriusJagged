using System.Text;

namespace Arrays_Matrix_JaggedA
{
    public class Exercice
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            const int Rows = 5;
            const int Columns = 5;
            const string DefZone = "🛡️";
            const string AtkZone = "⚔️";
            const string Tower = "🗼";
            const string Cave = "🕳️";
            const string NeutralZone = "🌿";
            const string ExtraResource = "💎";
            const string EmptyZone = "➖";

            int[] tropes = {0,1,2,3,4,5,6,7,8,9};
            string[,] map = new string[Rows, Columns];
            string[][] regions = new string[3][];
            regions[0] = new string[4];
            regions[1] = new string[2];
            regions[2] = new string[3];

            for(int i=0; i < tropes.GetLength(0); i++)
            {
                if (tropes[i]%2 == 0)
                {
                    Console.Write($"{DefZone} ");
                }
                else
                {
                    Console.Write($"{AtkZone} ");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for(int j = 0; j < map.GetLength(1); j++)
                {
                    if(i % 2 == 0 && j % 2 == 0)
                    {
                        Console.Write($"{Tower} ");
                    }else if(i % 2 != 0 && j % 2 != 0)
                    {
                        Console.Write($"{Cave} ");
                    }
                    else
                    {
                        Console.Write($"{NeutralZone} ");
                    }
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            //par buit impar extrasource
            for (int i = 0; i < regions.Length; i++)
            {
                for (int j = 0; j < regions.Length; j++)
                {
                    if (i % 2 == 0 && j % 2 == 0)
                    {
                        Console.Write($"{ExtraResource} ");
                    }
                    else if (i % 2 != 0 && j % 2 != 0)
                    {
                        Console.Write($"{EmptyZone} ");
                    }

                }
                Console.WriteLine("");
            }

        }
    }
}
