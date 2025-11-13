using System;

namespace Arrays_Matrix_JaggedA
{
    public class Exercice
    {
        public static void Main()
        {
            const string IntroMsg = "Welcome to the treasure explorer game!";
            const string IntroMsgCont = "A 10x10 map with hidden treasures has been generated and you have 3 attempts to get as many diamonds as possible…";
            const string MenuMsg = "Main menu";
            const string FirstOptionMsg = "I want to dig!";
            const string SecondOptionMsg = "Show me the map";
            const string ThirdOptionMsg = "Exit";
            const string DigMsg = "You chose to dig";
            const string RowInputMsg = "Put the row(0-9)";
            const string ColInputMsg = "Put the column(0-9)";
            const string DiggingMsg = "Digging in these coordenates ({0},{1})...";
            const string TreasureFoundMsg = "You found a treasure!";
            const string TreasureNotFoundMsg = "There's nothing here :(!";
            const string NoMoreTriesMsg = "You run out of tries!";
            const string TotalTreasuresMsg = "You found a total of {0} treasures";
            const string ActualMapMsg = "Actual map:";
            const string MenuErrorMsg = "Error, it has to be an integer number between 1 and 3";
            const string RowColrrorMsg = "Error, it has to be an integer number between 0 and 9";
            const int ROWS = 10;
            const int COLS = 10;
            int treasureSecretNumber = 5;

            string[,] map = new string[ROWS, COLS];
            Random rand = new Random();
            int randomNumber = 0;
            bool isTeasure = false;
            int num;
            int rowInput = 0;
            int colInput = 0;
            int treasureCount = 0;
            int tries = 3;
            bool treasueF = false;

            num = 1;
            
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

            while (num != 3 && tries > 0)
            {
                Console.WriteLine(IntroMsg);
                Console.WriteLine(IntroMsgCont);
                Console.WriteLine(MenuMsg);
                Console.WriteLine(FirstOptionMsg);
                Console.WriteLine(SecondOptionMsg);
                Console.WriteLine(ThirdOptionMsg);
                Console.WriteLine();
                try
                {
                    num = Int32.Parse(Console.ReadLine());
                }
                catch(OverflowException)
                {
                    Console.WriteLine(MenuErrorMsg);
                }
                catch (FormatException)
                {
                    Console.WriteLine(MenuErrorMsg);
                }
                catch
                {
                    Console.WriteLine(MenuErrorMsg);
                }

                switch (num)
                {
                    case 1:
                        Console.WriteLine(DigMsg);
                        Console.WriteLine(RowInputMsg);
                        try
                        {
                            rowInput = Int32.Parse(Console.ReadLine());
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine(RowColrrorMsg);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine(RowColrrorMsg);
                        }
                        catch
                        {
                            Console.WriteLine(RowColrrorMsg);
                        }
                        if(rowInput < 0 || rowInput > 9)
                        {
                            Console.WriteLine(RowColrrorMsg);
                        }
                        else
                        {
                            Console.WriteLine(ColInputMsg);
                            try
                            {
                                colInput = Int32.Parse(Console.ReadLine());
                            }
                            catch (OverflowException)
                            {
                                Console.WriteLine(RowColrrorMsg);
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine(RowColrrorMsg);
                            }
                            catch
                            {
                                Console.WriteLine(RowColrrorMsg);
                            }
                            if (colInput < 0 || colInput > 9)
                            {
                                Console.WriteLine(RowColrrorMsg);
                            }
                            else
                            {
                                Console.WriteLine(DiggingMsg, rowInput, colInput);
                                Thread.Sleep(2000);
                                if (map[rowInput, colInput] == "*")
                                {
                                    Console.WriteLine(TreasureFoundMsg);
                                    treasureCount++;
                                    tries--;
                                }
                                else
                                {
                                    Console.WriteLine(TreasureNotFoundMsg);
                                    tries--;
                                }
                                Console.WriteLine();
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine(ActualMapMsg);
                        for (int i = 0; i < map.GetLength(0); i++)
                        {
                            for (int j = 0; j < map.GetLength(1); j++)
                            {
                                Console.Write($"{map[i, j]} ");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine(MenuErrorMsg);
                        break;
                }
            }
            Console.WriteLine(NoMoreTriesMsg);
            Console.WriteLine(TotalTreasuresMsg, treasureCount);

        }
    }
}
