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
    bool noTreasure = false;
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
    } //Trap
    if (b > 1 && b < 11)
    {
        Console.WriteLine("no treasure");
        noTreasure = true;

    } // No Treasure
    if (b == 11)
    {
        //Healing Potion -------------------------------------------------------------------------------------------------------------------------------------------------------------------
        smallItems.HealingPotion(CR);
        noTreasure = true;

    } //Healing Potion
    if (b == 12)
    {
        //Mana Potion -------------------------------------------------------------------------------------------------------------------------------------------------------------------
        smallItems.ManaPotion(CR);
        noTreasure = true;

    } //Mana Potion
    if (b > 12 && b < 18)
    {
        Console.WriteLine($"{Dice.D(20) * CR + level * 25} Gold");
        noTreasure = true;

    } //Gold
    if (b > 17)
    {
        tre = new item();
        //Item -------------------------------------------------------------------------------------------------------------------------------------------------------------------
        int i = Dice.D(20) + CR;
        if (i < 16)
        {
            tre = Item(65, "n", CR);            
        }
        if (i > 15 && i < 18)
        {
            tre = Item(100, "P", CR);
        }
        if (i > 17 && i < 20)
        {
            tre = Item(100, "S", CR);
        }
        if (i > 19)
        {
            tre = Item(100, "PNS", CR);
        }        
    } //Item

    //Display Text    
    if (!noTreasure)
    {
        tre.GP = tre.GP + tre.SuffixGP + tre.PrefixGP;
        if (tre.PrefixName == "no prefix" && tre.SuffixName == "no suffix")
        {
            if (tre.Amount != -1)
            {
                Console.WriteLine($"{tre.Name}, {tre.Stat}, Worth {tre.GP * tre.Amount} GP ({tre.GP} each)");
            }
            else
            {
                Console.WriteLine($"{tre.Name}, {tre.Stat}, Worth {tre.GP} GP");
            }
        }
        else if (!(tre.PrefixName == "no prefix") && tre.SuffixName == "no suffix")
        {
            if (tre.Amount != -1)
            {
                Console.WriteLine($"{tre.PrefixName} {tre.Name}, {tre.Stat} and {tre.PrefixStat}, Worth {tre.GP * tre.Amount} GP ({tre.GP} each)");
            }
            else
            {
                Console.WriteLine($"{tre.PrefixName} {tre.Name}, {tre.Stat} and {tre.PrefixStat}, Worth {tre.GP} GP");
            }
        }
        else if (tre.PrefixName == "no prefix" && !(tre.SuffixName == "no suffix"))
        {
            if (tre.Amount != -1)
            {
                Console.WriteLine($"{tre.Name} {tre.SuffixName} , {tre.Stat} and {tre.SuffixStat}, Worth {tre.GP * tre.Amount} GP ({tre.GP} each)");
            }
            else
            {
                Console.WriteLine($"{tre.Name} {tre.SuffixName} , {tre.Stat} and {tre.SuffixStat}, Worth {tre.GP} GP");
            }
        }
        else if (!(tre.PrefixName == "no prefix") && !(tre.SuffixName == "no suffix"))
        {
            if (tre.Amount != -1)
            {
                Console.WriteLine($"{tre.PrefixName} {tre.Name} {tre.SuffixName} , {tre.Stat} and {tre.PrefixStat} and {tre.SuffixStat}, Worth {tre.GP * tre.Amount} GP ({tre.GP} each)");
            }
            else
            {
                Console.WriteLine($"{tre.PrefixName} {tre.Name} {tre.SuffixName} , {tre.Stat} and {tre.PrefixStat} and {tre.SuffixStat}, Worth {tre.GP} GP");
            }
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