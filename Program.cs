namespace Arrays_Matrix_JaggedA
{
    public class Exercice
    {
        public static void Main()
        {
            const string IntroMsg = "List pokemon = 1 | exit = 0";
            const string ErrorMsg = "Error, you must put an integer number between 0 and 1";
            const string PokedexMsg = "Your pokedex contains:";
            const string PkdxErrorMsg = "Error, you must put an integer between 1 and 15";
            const string ReleaseMsg = "Which pokemon you want to release? Enter the index: ";
            const string PkmnReleasedMsg = "You released {0}";
            const string PkmnReleasedEmptyMsg = "The index {0} is empty. There's no Pokémon in that slot to release.";
            const string NoPkmn = "empty";

            int op;
            int index;
            string[] pokemonList = new string[] { "Pikachu", "Charmander", "Squirtle", "Bulbasaur", "Eevee", "Jigglypuff", "Meowth", "Psyduck", "Snorlax", "Gengar", "Machop", "Magikarp", "Vulpix", "Onix", "Abra"};

            Console.WriteLine(IntroMsg);
            op = 2;
            while(op != 0)
            {
                try
                {
                    op = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine(ErrorMsg);
                }
                catch (OverflowException)
                {
                    Console.WriteLine(ErrorMsg);
                }
                catch (Exception)
                {
                    Console.WriteLine(ErrorMsg);
                }

                switch (op)
                {
                    case 1:
                        index = 0;
                        Console.WriteLine(PokedexMsg);
                        for (int i = 0; i < pokemonList.GetLength(0); i++)
                        {
                            Console.WriteLine(pokemonList[i]);
                        }
                        Console.WriteLine(ReleaseMsg);
                        try
                        {
                            index = Int32.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine(ErrorMsg);
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine(ErrorMsg);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine(ErrorMsg);
                        }
                        if(index > 0 && index < 16)
                        {
                            for (int i = 0; i < pokemonList.GetLength(0); i++)
                            {
                                if (i == index && pokemonList[i] != "empty")
                                {
                                    Console.WriteLine(PkmnReleasedMsg, pokemonList[i]);
                                    pokemonList[i] = NoPkmn;
                                }
                                else
                                {
                                    Console.WriteLine(PkmnReleasedEmptyMsg, i);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine(PkdxErrorMsg);
                        }
                        break;
                    case 0:

                        break;
                    default:
                        Console.WriteLine(ErrorMsg);
                        break;
                }
                
            }
            
        }
    }
}
