using System.Collections.Generic;
using static BaseItem.baseItem;
using ClassLibaray;
using Extras;
using pretext;



int CR = 0;
int level = 0;
string input = "x";
DiceRoll Dice = new DiceRoll();

Intial();

void Intial()
{
    instuction.getText();
    Console.WriteLine();
    Console.Write("Party level: ");
    level = int.Parse(Console.ReadLine());
    Console.Write("Challenge Rating: ");
    CR = int.Parse(Console.ReadLine());
    Console.WriteLine();
}

void RollsToString()
{
    string RTS = "";
    foreach (var roll in Dice.rolls)
    {
        RTS += roll.ToString() + ", ";
    }
    RTS = RTS.Substring(0, RTS.Length - 2);
    Console.WriteLine("Dice rolls: " + RTS);
    Dice.rolls.Clear();
}
//Main
do
{
    item tre = new item();

    //Base Treasure
    int b = Dice.D(20);
    if (b == 1)
    {
        //Trap -------------------------------------------------------------------------------------------------------------------------------------------------------------------
        int t = Dice.D(20) + CR;
        Console.WriteLine("TRAP");
        if (t < 16)
        {
            Console.WriteLine(Dice.D(6) * level + $" fire damage to all within 5 feet, Reflex save for half damage (DC = {10 + level})");
        }
        if (t > 15 && t < 20)
        {
            Console.WriteLine($"Missile deals {Dice.D(4) + level} points of damage, Relfex save for half damage (DC = {10 + level})");
        }
        if (t > 20)
        {
            int g = Dice.D(6) + CR;
            if (g < 3)
            {
                Console.WriteLine("Choking Gas");
                Console.WriteLine($"Fort DC 15, if fail take {Dice.D(4)} point of temp Con damage. If a second inhaling is done before recovering and failing the save, take {Dice.D(6)} points of Temp Con Damage");
            }
            if (g > 2 && g < 5)
            {
                Console.WriteLine("Rancid Gas");
                Console.WriteLine($"Fort DC 12, if fail take 1 point of temp Con damage. If a second inhaling is done before recovering and failing the save, take {Dice.D(6)} points of Temp Con Damage");
            }
            if (g > 4)
            {
                Console.WriteLine("Stangling Gas");
                Console.WriteLine($"Fort DC 18, if fail take {Dice.D(4) + Dice.D(4)} points of temp Con damage. If a second inhaling is done before recovering and failing the save, take {Dice.D(4) + Dice.D(4)} points of Temp Con Damage");
            }

        }
    }
    if (b > 1 && b < 11)
    {
        Console.WriteLine("No Treasure");
    }
    if (b == 11)
    {
        //Healing Potion -------------------------------------------------------------------------------------------------------------------------------------------------------------------
        smallItems.HealingPotion(CR);
    }
    if (b == 12)
    {
        //Mana Potion -------------------------------------------------------------------------------------------------------------------------------------------------------------------
        smallItems.ManaPotion(CR);
    }
    if (b > 12 && b < 18)
    {
        Console.WriteLine($"{Dice.D(20) * CR + level * 25} Gold");
    }
    if (b > 17)
    {
        //Item -------------------------------------------------------------------------------------------------------------------------------------------------------------------
        int i = Dice.D(20) + CR;
        if (i < 16)
        {
            tre = Item(Dice.D(60), "none", CR);
        }
        if (i > 15 && i < 18)
        {
            tre = Item(Dice.D(100), "Prefix", CR);
        }
        if (i > 17 && i < 20)
        {
            tre = Item(Dice.D(100), "Suffix", CR);
        }
        if (i > 19)
        {
            tre = Item(Dice.D(100), "PrefixNSuffix", CR);
        }

        //Display Text
        //still need prefix and suffix descriptions
        tre.GP = tre.GP + tre.SuffixGP + tre.PrefixGP;
        if (tre.Each)
        {
            Console.WriteLine($"{tre.Name}, {tre.Stat}, Worth {tre.GP * tre.Amount} GP ({tre.GP} each)");
        }
        else
        {
            Console.WriteLine($"{tre.Name}, {tre.Stat}, Worth {tre.GP} GP");
        }
    }

    Dice.rolls.AddRange(tre.rolls);

    RollsToString();
    Console.WriteLine("\nNext Gen? (x to quit, p to change party level or CR)");
    input = Console.ReadLine();
    if (input.ToLower() == "p")
    {
        Intial();
    }
} while (!(input.ToLower() == "x"));