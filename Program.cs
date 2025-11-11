namespace Arrays_Matrix_JaggedA
{
    public class Exercice
    {
        public static void Main()
        {
            const string MenuTitle = "AVAILABLE ITEMS IN THE SHOP";
            const string MenuCategories = "Name  Min.Level  Power  Weight(Kg)  Cost(€)  isRareItem  RareType";
       
            string[] arrayItems = {"Sword", "Shield", "Potion", "Bow" };
            string[] arrayRarity = {"Common", "Rare", "Legendary", "Ordinary" };
            Random rand = new Random();
            string name;
            int minLevel;
            int power;
            float weight;
            float cost;
            bool isRareItem;
            string rareType;
            int verify;
            int rarityNumber;

            Console.WriteLine(MenuTitle);
            Console.WriteLine(MenuCategories);

            for(int i = 0; i < arrayItems.GetLength(0); i++)
            {
                name = arrayItems[i];
                minLevel = rand.Next(1, 11);
                power = rand.Next(100, 501);
                weight = (float)rand.NextDouble();
                weight = (float)Math.Round(weight, 2);
                cost = (float)rand.NextDouble();
                cost = (float)Math.Round(cost, 2);
                verify = rand.Next(1, 3);
                if(verify == 1)
                {
                    isRareItem = true;
                }
                else
                {
                    isRareItem = false;
                }
                if(isRareItem == true)
                {
                    rarityNumber = rand.Next(0, 2);
                    rareType = arrayRarity[rarityNumber];
                }
                else
                {
                    rarityNumber = 3;
                    rareType = arrayRarity[rarityNumber];
                }
                Console.WriteLine($"{name}  {minLevel}          {power}     {weight}        {cost}€     {isRareItem}        {rareType}");
            }
        }
    }
}
