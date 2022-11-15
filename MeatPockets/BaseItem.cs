using ClassLibaray;
using Prefix;
using Suffix;
using Extras;

namespace BaseItem
{
    public class baseItem
    {     

        public static item Item(int i, string q, int CR)
        {
            int Prefix = 0;
            int Suffix = 0;
            item tre = new item();
            DiceRoll Dice = new DiceRoll();

            if (i < 8)
            {
                //Body Armor ---------------------------------------------------------------------------------------------------------------------------------
                int b = Dice.D(20) + CR;

                if (b <= 3)
                {
                    tre.Name = "Rags";
                    tre.Stat = "+1 AC (-1 Char checks";
                    tre.GP = 1;
                }
                else if (b <= 5)
                {
                    tre.Name = "Cape";
                    tre.Stat = "+1 AC";
                    tre.GP = 5;
                }
                else if (b <= 7)
                {
                    tre.Name = "Cloak";
                    tre.Stat = "+1 AC";
                    tre.GP = 15;
                }
                else if (b <= 11)
                {
                    tre.Name = "Robe";
                    tre.Stat = "+1 AC";
                    tre.GP = 20;
                }
                else if (b <= 14)
                {
                    tre.Name = "Quilted Armor";
                    tre.Stat = "+1 AC";
                    tre.GP = 25;
                }
                else if (b <= 16)
                {
                    tre.Name = "Leather Armor";
                    tre.Stat = "+2 AC";
                    tre.GP = 30;
                }
                else if (b <= 18)
                {
                    tre.Name = "Hard Leather Armor";
                    tre.Stat = "+3 AC";
                    tre.GP = 40;
                }
                else if (b <= 21)
                {
                    tre.Name = "Studded Leather Armor";
                    tre.Stat = "+3 AC";
                    tre.GP = 50;
                }
                else if (b <= 23)
                {
                    tre.Name = "Ring Mail";
                    tre.Stat = "+4 AC";
                    tre.GP = 100;
                }
                else if (b <= 25)
                {
                    tre.Name = "Scale Mail";
                    tre.Stat = "+4 AC";
                    tre.GP = 120;
                }
                else if (b <= 27)
                {
                    tre.Name = "Chain Mail";
                    tre.Stat = "+5 AC";
                    tre.GP = 150;
                }
                else if (b == 28)
                {
                    tre.Name = "Breast Plate";
                    tre.Stat = "+5 AC";
                    tre.GP = 200;
                }
                else if (b <= 30)
                {
                    tre.Name = "Splint Mail";
                    tre.Stat = "+6 AC";
                    tre.GP = 250;
                }
                else if (b <= 32)
                {
                    tre.Name = "Plate Mail";
                    tre.Stat = "+7 AC";
                    tre.GP = 600;
                }
                else if (b == 33)
                {
                    tre.Name = "Field Plate";
                    tre.Stat = "+8 AC";
                    tre.GP = 2000;
                }
                else if (b == 34)
                {
                    tre.Name = "Ancient Armor";
                    tre.Stat = "+9 AC, absorbs 1 point of damage per attack";
                    tre.GP = 3750;
                }
                else if (b == 35)
                {
                    tre.Name = "Gothic Plate";
                    tre.Stat = "+10 AC";
                    tre.GP = 4000;
                }
                else if (b >= 36)
                {
                    tre.Name = "Full Plate Mail";
                    tre.Stat = "+11 AC";
                    tre.GP = 5000;
                }
                Prefix = Dice.D(60);
                Suffix = Dice.D(60);
            }                //Body Armor
            if (i > 8 && i < 14)
            {
                //Head Protection ---------------------------------------------------------------------------------------------------------------------------------
                int h = Dice.D(20) + CR;
                if (h <= 10)
                {
                    tre.Name = "Cap";
                    tre.Stat = "+1 AC (not cumulative with any protection)";
                    tre.GP = 5;
                }
                else if (h <= 14)
                {
                    tre.Name = "Skull Cap";
                    tre.Stat = "+1 AC (not cumulative with armor)";
                    tre.GP = 10;
                }
                else if (h <= 18)
                {
                    tre.Name = "Helm";
                    tre.Stat = "+1 AC (not cumulative with armor)";
                    tre.GP = 15;
                }
                else if (h <= 20)
                {
                    tre.Name = "Mask";
                    tre.Stat = "+1 AC (not cumulative with armor)";
                    tre.GP = 20;
                }
                else if (h <= 25)
                {
                    tre.Name = "Full Helm";
                    tre.Stat = "+2 AC (not cumulative with armor)";
                    tre.GP = 30;
                }
                else if (h <= 29)
                {
                    tre.Name = "Crown";
                    tre.Stat = "+3 AC (not cumulative with armor)";
                    tre.GP = 50;
                }
                else if (h <= 32)
                {
                    tre.Name = "Bone Helm";
                    tre.Stat = "+3 AC (not cumulative with armor)";
                    tre.GP = 100;
                }
                else if (h >= 33)
                {
                    tre.Name = "Great Helm";
                    tre.Stat = "+4 AC (not cumulative with armor)";
                    tre.GP = 150;
                }
                Prefix = Dice.D(60);
                Suffix = Dice.D(60);
            }      //Head Protection
            if (i > 13 && i < 17)
            {
                //Foot Proctection ---------------------------------------------------------------------------------------------------------------------------------
                int f = Dice.D(20) + CR;

                if (f <= 12)
                {
                    tre.Name = "Leather Boots";
                    tre.Stat = "+1 AC (not cumulative with any protection/armor)";
                    tre.GP = 5;
                }
                else if (f <= 21)
                {
                    tre.Name = "Heavy Boots";
                    tre.Stat = "+1 AC (not cumulative with armor)";
                    tre.GP = 10;
                }
                else if (f <= 27)
                {
                    tre.Name = "Chain Boots";
                    tre.Stat = "+1 AC (not cumulative with armor)";
                    tre.GP = 15;
                }
                else if (f <= 32)
                {
                    tre.Name = "Light Plate Boots";
                    tre.Stat = "+1 AC (not cumulative with armor)";
                    tre.GP = 20;
                }
                else if (f >= 33)
                {
                    tre.Name = "Greaves";
                    tre.Stat = "+2 AC (not cumulative with armor)";
                    tre.GP = 30;
                }
                Prefix = Dice.D(60);
                Suffix = Dice.D(60);
            }     //Foot Protection
            if (i > 16 && i < 19)
            {
                //Hand Proctection -----------------------------------------------------------------------------------------------------------------------
                int h = Dice.D(20) + CR;

                if (h <= 12)
                {
                    tre.Name = "Gloves";
                    tre.Stat = "+1 AC (not cumulative with any protection)";
                    tre.GP = 5;
                }
                else if (h <= 21)
                {
                    tre.Name = "Heavy Gloves";
                    tre.Stat = "+1 AC (not cumulative with armor or shield)";
                    tre.GP = 10;
                }
                else if (h <= 27)
                {
                    tre.Name = "Chain Gloves";
                    tre.Stat = "+1 AC (not cumulative with armor or shield)";
                    tre.GP = 15;
                }
                else if (h <= 32)
                {
                    tre.Name = "Light Gauntlets";
                    tre.Stat = "+1 AC (not cumulative with armor or shield)";
                    tre.GP = 20;
                }
                else if (h >= 33)
                {
                    tre.Name = "Gauntlets";
                    tre.Stat = "+2 AC (not cumulative with armor or shield)";
                    tre.GP = 30;
                }
                Prefix = Dice.D(60);
                Suffix = Dice.D(60);
            }     //Hand Protection
            if (i > 18 && i < 21)
            {
                //Belts ---------------------------------------------------------------------------------------------------------------------------------
                int b = Dice.D(20) + CR;
                if (b <= 12)
                {
                    tre.Name = "Sash";
                    tre.Stat = "+1 AC (not cumulative with any protection/armor)";
                    tre.GP = 5;
                }
                else if (b <= 21)
                {
                    tre.Name = "Light Belt";
                    tre.Stat = "+1 AC (not cumulative with armor)";
                    tre.GP = 10;
                }
                else if (b <= 27)
                {
                    tre.Name = "Belt";
                    tre.Stat = "+1 AC (not cumulative with armor)";
                    tre.GP = 15;
                }
                else if (b <= 32)
                {
                    tre.Name = "Heavy Belt";
                    tre.Stat = "+1 AC (not cumulative with armor)";
                    tre.GP = 20;
                }
                else if (b >= 33)
                {
                    tre.Name = "Plate Belt";
                    tre.Stat = "+2 AC (not cumulative with armor)";
                    tre.GP = 30;
                }
                Prefix = Dice.D(60);
                Suffix = Dice.D(60);
            }     //Belts
            if (i > 20 && i < 26)
            {
                //Shields ---------------------------------------------------------------------------------------------------------------------------------
                int s = Dice.D(20) + CR;
                if (s <= 10)
                {
                    tre.Name = "Buckler";
                    tre.Stat = "+1 AC (negates hand protection)";
                    tre.GP = 10;
                }
                else if (s <= 16)
                {
                    tre.Name = "Small Shield";
                    tre.Stat = "+1 AC (negates hand protection)";
                    tre.GP = 15;
                }
                else if (s <= 21)
                {
                    tre.Name = "Large Shield";
                    tre.Stat = "+2 AC (negates hand protection)";
                    tre.GP = 20;
                }
                else if (s <= 25)
                {
                    tre.Name = "Kite Shield";
                    tre.Stat = "+3 AC (negates hand protection)";
                    tre.GP = 50;
                }
                else if (s <= 27)
                {
                    tre.Name = "Spiked Shield";
                    tre.Stat = "+3 AC (used as a 1d6 (x2) piercing weapon; negates hand protection)";
                    tre.GP = 100;
                }
                else if (s <= 29)
                {
                    tre.Name = "Bone Shield";
                    tre.Stat = "+3 AC (negates hand protection)";
                    tre.GP = 150;
                }
                else if (s <= 32)
                {
                    tre.Name = "Tower Shield (small)";
                    tre.Stat = "+4 AC (negates hand protection)";
                    tre.GP = 250;
                }
                else if (s <= 33)
                {
                    tre.Name = "Gothic Shield";
                    tre.Stat = "+2 AC (negates hand protection)";
                    tre.GP = 500;
                }
                Prefix = Dice.D(60);
                Suffix = Dice.D(60);
            }     //Shields
            if (26 <= i && i <= 30)
            {
                //Dagger ---------------------------------------------------------------------------------------------------------------------------------
                int d = Dice.D(20) + CR;
                if (d <= 10)
                {
                    int a = Dice.D(6) + Dice.D(6);
                    tre.Name = $"{a} Throwing Knifes";
                    tre.Stat = "1d3, crit 19-20/x2, 1 lb., Small, Piercing";
                    tre.GP = 2;
                    tre.Each = true;
                    tre.Amount = a;
                }
                else if (d <= 15)
                {
                    tre.Name = "Dagger";
                    tre.Stat = "1d4, crit 19-20/x2, 1 lb., Tiny, Piercing";
                    tre.GP = 5;
                }
                else if (d <= 17)
                {
                    tre.Name = "Dirk";
                    tre.Stat = "1d4, crit 19-20/x2, 2 lbs., Small, Piercing/Slashing";
                    tre.GP = 10;
                }
                else if (d <= 21)
                {
                    tre.Name = "Kris";
                    tre.Stat = "1d4, crit 19-20/x2, 2 lbs., Tiny, Piercing";
                    tre.GP = 15;
                }
                else if (d <= 32)
                {
                    int a = Dice.D(6) + Dice.D(6);
                    tre.Name = $"{a} Balanced Knife";
                    tre.Stat = "1d4, crit 19-20/x2, 1 lb., Small, Piercing";
                    tre.GP = 3;
                    tre.Each = true;
                    tre.Amount = a;
                }
                else if (d >= 33)
                {
                    tre.Name = "Blade";
                    tre.Stat = "1d6, crit 19-20/x2, 2 lbs., Small, Piercing/Slashing";
                    tre.GP = 20;
                }
                Prefix = Dice.D(60) + 25;
                Suffix = Dice.D(60) + 25;
            }   //Daggers
            if (31 <= i && i <= 40)
            {
                //Sword ---------------------------------------------------------------------------------------------------------------------------------
                int s = Dice.D(20) + CR;
                if (s <= 4)
                {
                    tre.Name = "Short Sword";
                    tre.Stat = "1d6, crit 19-20/x2, 3 lbs., Small, Piercing";
                    tre.GP = 10;
                }
                else if (s <= 7)
                {
                    tre.Name = "Saber";
                    tre.Stat = "1d6, crit 19-20/x2, 4 lbs., Medium, Slashing";
                    tre.GP = 30;
                }
                else if (s <= 10)
                {
                    tre.Name = "Scimitar";
                    tre.Stat = "1d6, crit 18-20/x2, 4 lbs., Medium, Slashing";
                    tre.GP = 20;
                }
                else if (s <= 13)
                {
                    tre.Name = "Falchion";
                    tre.Stat = "1d6, crit 18-20/x2, 6 lbs., Medium, Slashing";
                    tre.GP = 35;
                }
                else if (s <= 15)
                {
                    tre.Name = "Broad Sword";
                    tre.Stat = "1d8, crit 19-20/x2, 4 lbs., Medium, Slashing";
                    tre.GP = 75;
                }
                else if (s <= 17)
                {
                    tre.Name = "Longsword";
                    tre.Stat = "1d8, crit 19-20/x2, 4 lbs., Medium, Slashing";
                    tre.GP = 100;
                }
                else if (s <= 18)
                {
                    tre.Name = "Crystal Sword";
                    tre.Stat = "1d8, crit 18-20/x3, 5 lbs., Medium, Slashing";
                    tre.GP = 150;
                }
                else if (s <= 20)
                {
                    tre.Name = "Claymore 2H";
                    tre.Stat = "1d10, crit 19-20/x2, 15 lbs., Large, Slashing";
                    tre.GP = 150;
                }
                else if (s <= 24)
                {
                    tre.Name = "Two-Handed Sword 2H";
                    tre.Stat = "1d10, crit 19-20/x2, 15 lbs., Large, Slashing";
                    tre.GP = 175;
                }
                else if (s <= 26)
                {
                    tre.Name = "War Sword";
                    tre.Stat = "1d10, crit 19-20/x2, 4 lbs., Medium, Slashing";
                    tre.GP = 200;
                }
                else if (s <= 28)
                {
                    tre.Name = "Giant Sword 2H";
                    tre.Stat = "2d6, crit 19-20/x2, 15 lbs., Large, Slashing";
                    tre.GP = 250;
                }
                else if (s <= 30)
                {
                    tre.Name = "Bastard Sword 2H";
                    tre.Stat = "2d6, crit 19-20/x2, 10 lbs., Large, Slashing";
                    tre.GP = 250;
                }
                else if (s <= 32)
                {
                    tre.Name = "Flamberge 2H";
                    tre.Stat = "2d8, crit 19-20/x2, 15 lbs., Large, Slashing";
                    tre.GP = 300;
                }
                else if (s >= 33)
                {
                    tre.Name = "Great Sword 2H";
                    tre.Stat = "2d10, crit 19-20/x2, 15 lbs., Large, Slashing";
                    tre.GP = 500;
                }
                Prefix = Dice.D(60) + 25;
                Suffix = Dice.D(60) + 25;
            }   //Swords
            if (41 <= i && i <= 44)
            {
                //Clubs ---------------------------------------------------------------------------------------------------------------------------------
                int c = Dice.D(20) + CR;
                if (c <= 7)
                {
                    tre.Name = "CLub";
                    tre.Stat = "1d6, crit x2, 3 lbs., Medium, Bludgeoning";
                    tre.GP = 1;
                }
                else if (c <= 9)
                {
                    tre.Name = "Spiked Club";
                    tre.Stat = "1d6, crit x3, 5 lbs., Medium, Bludgeoning/Piercing";
                    tre.GP = 5;
                }
                else if (c <= 13)
                {
                    tre.Name = "Light Mace";
                    tre.Stat = "1d6, crit x2, 6 lbs., Small, Bludgeoning";
                    tre.GP = 10;
                }
                else if (c <= 17)
                {
                    tre.Name = "Scepter";
                    tre.Stat = "1d, crit x2, 4 lbs., Medium, Bludgeoning";
                    tre.GP = 20;
                }
                else if (c <= 19)
                {
                    tre.Name = "Morning Star";
                    tre.Stat = "1d8, crit x2, 8 lbs., Medium, Bludgeoning/Piercing";
                    tre.GP = 30;
                }
                else if (c <= 23)
                {
                    tre.Name = "Grand Scepter";
                    tre.Stat = "1d8, crit x2, 6 lbs., Medium, Bludgeoning";
                    tre.GP = 40;
                }
                else if (c <= 25)
                {
                    tre.Name = "Light Flail";
                    tre.Stat = "1d8, crit x2, 5 lbs., Medium, Bludgeoning";
                    tre.GP = 50;
                }
                else if (c <= 28)
                {
                    tre.Name = "War Hammer";
                    tre.Stat = "1d8, crit x3, 8 lbs., Medium, Bludgeoning";
                    tre.GP = 60;
                }
                else if (c <= 30)
                {
                    tre.Name = "Maul 2H";
                    tre.Stat = "1d10, crit x3, 25 lbs., Large, Bludgeoning";
                    tre.GP = 100;
                }
                else if (c <= 32)
                {
                    tre.Name = "War Scepter";
                    tre.Stat = "1d10, crit x2, 6 lbs., Medium, Bludgeoning";
                    tre.GP = 200;
                }
                else if (c <= 33)
                {
                    tre.Name = "Great Maul 2H";
                    tre.Stat = "2d6, crit x3, 30 lbs., Large, Bludgeoning";
                    tre.GP = 250;
                }
                Prefix = Dice.D(60) + 25;
                Suffix = Dice.D(60) + 25;
            }   //Clubs
            if (45 <= i && i <= 48)
            {
                //Javelins/Spears ---------------------------------------------------------------------------------------------------------------------------------
                int j = Dice.D(20) + CR;
                if (j <= 7)
                {
                    int a = Dice.D(4) + Dice.D(4);
                    tre.Name = $"{a} Light Javelin";
                    tre.Stat = "1d4, crit x2, Range 30 ft., 1 lb., Medium, Piercing";
                    tre.GP = 2;
                    tre.Each = true;
                    tre.Amount = a;
                }
                else if (j <= 10)
                {
                    tre.Name = "Short Spear";
                    tre.Stat = "1d6, crit x3, Range 20 ft., 3 lb., Medium, Piercing";
                    tre.GP = 20;
                }
                else if (j <= 13)
                {
                    tre.Name = "Long Spear 2H";
                    tre.Stat = "1d8, crit x3, 9 lb., Large, Piercing";
                    tre.GP = 40;
                }
                else if (j <= 17)
                {
                    int a = Dice.D(4) + Dice.D(4);
                    tre.Name = $"{a} Pilum";
                    tre.Stat = "1d6, crit x2, Range 20 ft., 4 lb., Medium, Piercing";
                    tre.GP = 3;
                    tre.Each = true;
                    tre.Amount = a;
                }
                else if (j <= 20)
                {
                    tre.Name = "Trident 2H";
                    tre.Stat = "1d12, crit x2, 15 lb., Large, Piercing";
                    tre.GP = 80;
                }
                else if (j <= 23)
                {
                    int a = Dice.D(4) + Dice.D(4);
                    tre.Name = $"{a} Light Glaives";
                    tre.Stat = "1d8, crit x2, Range 10 ft., 4 lb., Medium, Piercing";
                    tre.GP = 4;
                    tre.Each = true;
                    tre.Amount = a;
                }
                else if (j <= 26)
                {
                    tre.Name = "Brandistock 2H";
                    tre.Stat = "2d6, crit x3, 15 lb., Large, Piercing/Slashing";
                    tre.GP = 100;
                }
                else if (j <= 29)
                {
                    int a = Dice.D(4) + Dice.D(4);
                    tre.Name = $"{a} Throwing Spears";
                    tre.Stat = "1d8, crit x2, Range 30 ft., 3 lb., Medium, Piercing";
                    tre.GP = 5;
                    tre.Each = true;
                    tre.Amount = a;
                }
                else if (j <= 32)
                {
                    tre.Name = "Spetum 2H";
                    tre.Stat = "1d12, crit x3, 15 lb., Large, Piercing/Slashing";
                    tre.GP = 120;
                }
                else if (j >= 33)
                {
                    tre.Name = "Heavy Pike 2H";
                    tre.Stat = "1d12, crit x3, 12 lb., Large, Piercing";
                    tre.GP = 200;
                }
                Prefix = Dice.D(60) + 25;
                Suffix = Dice.D(60) + 25;
            }   //Javelins/Spears
            if (49 <= i && i <= 50)
            {
                //Polearms ---------------------------------------------------------------------------------------------------------------------------------
                int p = Dice.D(20) + CR;

                if (p <= 8)
                {
                    tre.Name = "Bardiche 2H";
                    tre.Stat = "1d8, crit x3, 10 lbs., Large, Slashing";
                    tre.GP = 20;
                }
                else if (p <= 14)
                {
                    tre.Name = "Voulge 2H";
                    tre.Stat = "2d4, crit x3, 15 lbs., Large, Slashing";
                    tre.GP = 40;
                }
                else if (p <= 20)
                {
                    tre.Name = "Scythe 2H";
                    tre.Stat = "2d4, crit x4, 12 lbs., Large, Piercing/Slashing";
                    tre.GP = 80;
                }
                else if (p <= 26)
                {
                    tre.Name = "Poleaxe 2H";
                    tre.Stat = "2d10, crit x3, 15 lbs., Large, Slashing";
                    tre.GP = 150;
                }
                else if (p <= 32)
                {
                    tre.Name = "Heavy Halberd 2H";
                    tre.Stat = "2d6, crit x3, 15 lbs., Large, Piercing/Slashing";
                    tre.GP = 200;
                }
                else if (p >= 33)
                {
                    tre.Name = "War Sycthe 2H";
                    tre.Stat = "2d6, crit x4, 15 lbs., Large, Piercing/Slashing";
                    tre.GP = 250;
                }
                Prefix = Dice.D(60) + 25;
                Suffix = Dice.D(60) + 25;
            }   //Polearms
            if (51 <= i && i <= 55)
            {
                //Axes ---------------------------------------------------------------------------------------------------------------------------------
                int x = Dice.D(20) + CR;

                if (x <= 5)
                {
                    tre.Name = "Light Hand Axe";
                    tre.Stat = "1d4, crit x3, 2 lbs., Small, Slashing";
                    tre.GP = 10;
                }
                else if (x <= 9)
                {
                    tre.Name = "Hand Axe";
                    tre.Stat = "1d6, crit x3, 4 lbs., Medium, Slashing";
                    tre.GP = 20;
                }
                else if (x <= 12)
                {
                    int a = Dice.D(4) + Dice.D(4);
                    tre.Name = $"{a} Light Throwing Axes";
                    tre.Stat = "1d4, crit x2, Range 10 ft., 2 lb., Small, Piercing";
                    tre.GP = 3;
                    tre.Each = true;
                    tre.Amount = a;
                }
                else if (x <= 16)
                {
                    tre.Name = "Large Axe 2H";
                    tre.Stat = "2d4, crit x3, 12 lbs., Large, Slashing";
                    tre.GP = 100;
                }
                else if (x <= 18)
                {
                    tre.Name = "Double Axe";
                    tre.Stat = "1d8, crit x3, 7 lbs., Medium, Slashing";
                    tre.GP = 40;
                }
                else if (x <= 20)
                {
                    tre.Name = "Military Pick";
                    tre.Stat = "1d6, crit x4, 6 lbs., Medium, Piercing";
                    tre.GP = 40;
                }
                else if (x <= 22)
                {
                    tre.Name = "Broad Axe 2H";
                    tre.Stat = "1d12, crit x3, 15 lbs., Large, Slashing";
                    tre.GP = 200;
                }
                else if (x <= 25)
                {
                    tre.Name = "Heavy Battle Axe 2H";
                    tre.Stat = "2d6, crit x3, 15 lbs., Large, Slashing";
                    tre.GP = 250;
                }
                else if (x <= 29)
                {
                    int a = Dice.D(4) + Dice.D(4);
                    tre.Name = $"{a} Balanced Throwing Axes";
                    tre.Stat = "1d6, crit x2, Range 10 ft., 4 lb., Medium, Piercing";
                    tre.GP = 4;
                    tre.Each = true;
                    tre.Amount = a;
                }
                else if (x <= 33)
                {
                    tre.Name = "War Axe";
                    tre.Stat = "1d10, crit x3, 10 lbs., Medium, Slashing";
                    tre.GP = 100;
                }
                else if (x <= 35)
                {
                    tre.Name = "Great Axe 2H";
                    tre.Stat = "2d8, crit x3, 20 lbs., Large, Slashing";
                    tre.GP = 350;
                }
                else if (x >= 36)
                {
                    tre.Name = "Giant Axe 2H";
                    tre.Stat = "2d10, crit x3, 25 lbs., Large, Slashing";
                    tre.GP = 450;
                }
                Prefix = Dice.D(60) + 25;
                Suffix = Dice.D(60) + 25;
            }   //Axes
            if (56 <= i && i <= 63)
            {
                //Bows ---------------------------------------------------------------------------------------------------------------------------------
                int b = Dice.D(20) + CR;

                if (b <= 7)
                {
                    tre.Name = "Short Bow";
                    tre.Stat = "1d6, crit x3, Range 60 ft., 2 lbs., Medium, Piercing";
                    tre.GP = 30;
                }
                else if (b <= 10)
                {
                    tre.Name = "Hunters Bow";
                    tre.Stat = "1d6, crit x3, Range 70 ft., 2 lbs., Medium, Piercing";
                    tre.GP = 50;
                }
                else if (b <= 13)
                {
                    tre.Name = "Long Bow";
                    tre.Stat = "1d8, crit x3, Range 100 ft., 3 lbs., Large, Piercing";
                    tre.GP = 75;
                }
                else if (b <= 20)
                {
                    int a = Dice.D(8) + Dice.D(8) + Dice.D(8) + Dice.D(8);
                    tre.Name = $"{a} Arrows";
                    tre.Stat = "Damage as per bow";
                    tre.GP = 1;
                    tre.Each = true;
                    tre.Amount = a;
                }
                else if (b <= 23)
                {
                    tre.Name = "Composite Bow";
                    tre.Stat = "1d8, crit x3, Range 110 ft., 3 lbs., Large, Piercing";
                    tre.GP = 100;
                }
                else if (b <= 26)
                {
                    tre.Name = "Short Battle Bow";
                    tre.Stat = "1d6 (+1 Strength Bow), crit x3, Range 70 ft., 2 lbs., Medium, Piercing";
                    tre.GP = 150;
                }
                else if (b <= 29)
                {
                    tre.Name = "Short War Bow";
                    tre.Stat = "1d6 (+2 Strenght Bow), crit x4, Range 70 ft., 2 lbs., Medium, Piercing";
                    tre.GP = 200;
                }
                else if (b <= 32)
                {
                    tre.Name = "Long Battle Bow";
                    tre.Stat = "1d8 (+1 Strength Bow), crit x3, Range 1100 ft., 3 lbs., Large, Piercing";
                    tre.GP = 250;
                }
                else if (b <= 33)
                {
                    tre.Name = "Long War Bow";
                    tre.Stat = "1d8 (+2 Strenght Bow), crit x3, Range 110 ft., 3 lbs., Large, Piercing";
                    tre.GP = 300;
                }
                Prefix = Dice.D(60) + 30;
                Suffix = Dice.D(60) + 30;
            }   //Bows
            if (64 <= i && i <= 65)
            {
                //Crossbows ---------------------------------------------------------------------------------------------------------------------------------
                int c = Dice.D(20) + CR;

                if (c <= 5)
                {
                    int a = Dice.D(6) + Dice.D(6) + Dice.D(6);
                    tre.Name = $"{a} Bolts";
                    tre.Stat = "Damage as per crossbow";
                    tre.GP = 1;
                    tre.Each = true;
                    tre.Amount = a;
                }
                else if (c <= 17)
                {
                    tre.Name = "Light Crossbow";
                    tre.Stat = "1d8, crit 19-20/x3, Range 80 ft., 6 lbs., Small, Piercing";
                    tre.GP = 70;
                }
                else if (c <= 22)
                {
                    int a = Dice.D(6) + Dice.D(6) + Dice.D(6);
                    tre.Name = $"{a} Bolts";
                    tre.Stat = "Damage as per crossbow";
                    tre.GP = 1;
                    tre.Each = true;
                    tre.Amount = a;
                }
                else if (c <= 32)
                {
                    tre.Name = "Heavy Crossbow";
                    tre.Stat = "1d10, crit 19-20/x3, Range 120 ft., 9 lbs., Medium, Piercing";
                    tre.GP = 150;
                }
                else if (c <= 33)
                {
                    int a = Dice.D(6) + Dice.D(6) + Dice.D(6);
                    tre.Name = $"{a} Bolts";
                    tre.Stat = "Damage as per crossbow";
                    tre.GP = 1;
                    tre.Each = true;
                    tre.Amount = a;
                }
                Prefix = Dice.D(60) + 30;
                Suffix = Dice.D(60) + 30;
            }   //Crossbows
            if (66 <= i && i <= 70)
            {
                //Wands ---------------------------------------------------------------------------------------------------------------------------------
                int w = Dice.D(20) + CR;
                if (w <= 13)
                {
                    tre.Name = "Wand";
                    tre.Stat = "1d2, crit x2, 1 lbs., Small, Bludgeoning";
                    tre.GP = 10;
                }
                else if (w <= 20)
                {
                    tre.Name = "Bone Wand";
                    tre.Stat = "1d3, crit x2, 1 lbs., Small, Bludgeoning";
                    tre.GP = 30;
                }
                else if (w <= 25)
                {
                    tre.Name = "Yew Wand";
                    tre.Stat = "1d3, crit x2, 1 lbs., Small, Bludgeoning";
                    tre.GP = 60;
                }
                else if (w >= 26)
                {
                    tre.Name = "Grim Wand";
                    tre.Stat = "1d4, crit x2, 1 lbs., Small, Bludgeoning";
                    tre.GP = 100;
                }
                Prefix = Dice.D(60) + 40;
                Suffix = Dice.D(60) + 40;
            }   //Wands
            if (71 <= i && i <= 75)
            {
                //Staves ---------------------------------------------------------------------------------------------------------------------------------
                int s = Dice.D(20) + CR;

                if (s <= 10)
                {
                    tre.Name = "Short Staff";
                    tre.Stat = "1d4, crit x2, 3 lbs., Medium, Bludgeoning";
                    tre.GP = 10;
                }
                else if (s <= 19)
                {
                    tre.Name = "Long Staff";
                    tre.Stat = "1d6, crit x2, 6 lbs., Large, Bludgeoning";
                    tre.GP = 30;
                }
                else if (s <= 26)
                {
                    tre.Name = "Gnarled Staff";
                    tre.Stat = "1d8, crit x2, 6 lbs., Large, Bludgeoning";
                    tre.GP = 50;
                }
                else if (s <= 32)
                {
                    tre.Name = "Battle Staff";
                    tre.Stat = "2d4, crit x2, 6 lbs., Large, Bludgeoning";
                    tre.GP = 100;
                }
                else if (s >= 33)
                {
                    tre.Name = "War Staff";
                    tre.Stat = "1d10, crit x2, 10 lbs., Large, Bludgeoning";
                    tre.GP = 200;
                }
                Prefix = Dice.D(60) + 40;
                Suffix = Dice.D(60) + 40;
            }   //Staves
            if (76 <= i && i <= 79)
            {
                //Accessories ---------------------------------------------------------------------------------------------------------------------------------
                int m = Dice.D(20) + CR;

                if (m <= 6)
                {
                    tre.Name = "Charm";
                    tre.Stat = "Has its when carried person";
                    tre.GP = 50;
                }
                else if (m <= 17)
                {
                    tre.Name = "Ring";
                    tre.Stat = "Worn on hand, one per hand";
                    tre.GP = 75;
                }
                else if (m <= 18)
                {
                    tre.Name = "Flag";
                    tre.Stat = "Draped over body, One per character";
                    tre.GP = 100;
                }
                else if (m <= 19)
                {
                    tre.Name = "Orb";
                    tre.Stat = "Worn on arm, one per character, can't use both shield and orb";
                    tre.GP = 150;
                }
                else if (m >= 20)
                {
                    tre.Name = "Amulet";
                    tre.Stat = "Worn on neck, one per character";
                    tre.GP = 200;
                }
                Prefix = Dice.D(40) + 30;
                Suffix = Dice.D(40) + 30;
            }   //Accessories
            if (i == 80)
            {
                //Gems ---------------------------------------------------------------------------------------------------------------------------------
                int g = Dice.D(20) + CR;

                if (g <= 7)
                {
                    tre.Name = "Chipped Jewel";
                    tre.Stat = smallItems.GemRoll();
                    tre.GP = 50;
                }
                else if (g <= 13)
                {
                    tre.Name = "Flawed Jewel";
                    tre.Stat = smallItems.GemRoll();
                    tre.GP = 100;
                }
                else if (g <= 19)
                {
                    tre.Name = "Jewel";
                    tre.Stat = smallItems.GemRoll();
                    tre.GP = 250;
                }
                else if (g <= 25)
                {
                    tre.Name = "Flawless Jewel";
                    tre.Stat = smallItems.GemRoll();
                    tre.GP = 500;
                }
                else if (g >= 26)
                {
                    tre.Name = "Perfect Jewel";
                    tre.Stat = smallItems.GemRoll();
                    tre.GP = 200;
                }
                Prefix = Dice.D(40) + 30;
                Suffix = Dice.D(40) + 30;
            }              //Gems
            if (81 <= i && i <= 90)
            {
                //Inscribed Spells ---------------------------------------------------------------------------------------------------------------------------------
                int s = Dice.D(20) + CR;

                if (s <= 17)
                {
                    tre.Name = "Scroll";
                    tre.Stat = "Can be read once to cast the spell, at minimum level necessart to cast spell";
                    tre.GP = 25;
                }
                else if (s <= 18)
                {
                    tre.Name = "Rune";
                    tre.Stat = "Set once as a trap, acts as aglpth of warding with the listed spell's effect";
                    tre.GP = 50;
                }
                else if (s >= 19)
                {
                    tre.Name = "Book";
                    tre.Stat = "Can be read once to gain the spell, or allows one improvement for its spell. First improvement is either +1 die of damage, +1 ability damage, or +2 points of healing. Second improvment is -2 save. Ignore improvements that don't apply.";
                    tre.GP = 100;
                }
                Prefix = -1;
                Suffix = Dice.D(10) + 90;
            }   //Inscribed spells
            if (91 <= i && i <= 100)
            {
                //Perishables ---------------------------------------------------------------------------------------------------------------------------------
                int p = Dice.D(100);
                bool OOR = false;

                if (p <= 8)
                {
                    smallItems.HealingPotion(CR);
                }
                else if (p <= 13)
                {
                    smallItems.ManaPotion(CR);
                }
                else if (p <= 16)
                {
                    tre.Name = "Rejuvenation Potion";
                    tre.Stat = "Heals 4d8+7 points of damage, restores 4 previously cast spell levels";
                    tre.GP = 100;
                }
                else if (p <= 18)
                {
                    tre.Name = "Full Rejuvenation Potion";
                    tre.Stat = "Heals 8d8+15 points of damage, restores 8 previously cast spell levels";
                    tre.GP = 500;
                }
                else if (p <= 19)
                {
                    tre.Name = "Antidote";
                    tre.Stat = "Restores 1d4 ability points lost to poison";
                    tre.GP = 100;
                }
                else if (p <= 20)
                {
                    tre.Name = "Full Antidote";
                    tre.Stat = "Resotes all ability points lost to poison";
                    tre.GP = 500;
                }
                else if (p <= 21)
                {
                    tre.Name = "Stamina Potion";
                    tre.Stat = "Negates current fatigue";
                    tre.GP = 100;
                }
                else if (p <= 22)
                {
                    tre.Name = "Full Stamina Potion";
                    tre.Stat = "Negates current fatigue, immune to fatigue-causing factors for 10 minutes";
                    tre.GP = 500;
                }
                else if (p <= 23)
                {
                    tre.Name = "Restoration Potion";
                    tre.Stat = "Heals all damage, dispels mind-influencing effects";
                    tre.GP = 2500;
                }
                else if (p <= 24)
                {
                    tre.Name = "Oil";
                    tre.Stat = "1d6 fire damage, 1 point splash, 50% failure chance";
                    tre.GP = 1;
                }
                else if (p <= 25)
                {
                    tre.Name = "Explosive Potion";
                    tre.Stat = "3d6 points of damage, 1d6 splash";
                    tre.GP = 100;
                }
                else if (p <= 26)
                {
                    tre.Name = "Fulminating Potion";
                    tre.Stat = "1d6 points of acid damage, splash 1, burns 1d4 rounds";
                    tre.GP = 25;
                }
                else if (p <= 27)
                {
                    tre.Name = "Rancid Gas Potion";
                    tre.Stat = "Fort DC 15, if fail take 1d4 point of temp Con damage. If a second inhaling is done before recovering and failing the save, take 1d6 points of Temp Con Damage";
                    tre.GP = 50;
                }
                else if (p <= 28)
                {
                    tre.Name = "Choking Gas Potion";
                    tre.Stat = "Fort DC 12, if fail take 1 point of temp Con damage. If a second inhaling is done before recovering and failing the save, take 1d6 points of Temp Con Damage";
                    tre.GP = 100;
                }
                else if (p <= 29)
                {
                    tre.Name = "Strangling Gas Potion";
                    tre.Stat = "Fort DC 18, if fail take 2d4 points of temp Con damage. If a second inhaling is done before recovering and failing the save, take 2d4 points of Temp Con Damage";
                    tre.GP = 500;
                }
                else if (p <= 30)
                {
                    tre.Name = "Acidic Potion";
                    tre.Stat = "1d6 acid, splash 1";
                    tre.GP = 10;
                }
                else if (p <= 31)
                {
                    tre.Name = "Energizing Herb";
                    tre.Stat = "+2 Strength for 10 minutes";
                    tre.GP = 500;
                }
                else if (p <= 32)
                {
                    tre.Name = "Strengthing Herb";
                    tre.Stat = "+3 Strength for 10 minutes";
                    tre.GP = 1000;
                }
                else if (p <= 33)
                {
                    tre.Name = "Empowering Herb";
                    tre.Stat = "+4 Strength for 10 minutes";
                    tre.GP = 1500;
                }
                else if (p <= 34)
                {
                    tre.Name = "Artful Herb";
                    tre.Stat = "+2 Dexterity for 10 minutes";
                    tre.GP = 500;
                }
                else if (p <= 35)
                {
                    tre.Name = "Skillful Herb";
                    tre.Stat = "+3 Dexterity for 10 minutes";
                    tre.GP = 1000;
                }
                else if (p <= 36)
                {
                    tre.Name = "Adroit Herb";
                    tre.Stat = "+4 Strength for 10 minutes";
                    tre.GP = 1500;
                }
                else if (p <= 37)
                {
                    tre.Name = "Stalwart Herb";
                    tre.Stat = "+2 Constitution for 10 minutes";
                    tre.GP = 500;
                }
                else if (p <= 38)
                {
                    tre.Name = "Hardy Herb";
                    tre.Stat = "+3 Constitution for 10 minutes";
                    tre.GP = 1000;
                }
                else if (p <= 39)
                {
                    tre.Name = "Robust Herb";
                    tre.Stat = "+4 Constitution for 10 minutes";
                    tre.GP = 1500;
                }
                else if (p <= 40)
                {
                    tre.Name = "Sage Herb";
                    tre.Stat = "+2 Intelligence for 10 minutes";
                    tre.GP = 500;
                }
                else if (p <= 41)
                {
                    tre.Name = "Shrewd Herb";
                    tre.Stat = "+3 Intelligence for 10 minutes";
                    tre.GP = 1000;
                }
                else if (p <= 42)
                {
                    tre.Name = "Vivid Herb";
                    tre.Stat = "+4 Intelligence for 10 minutes";
                    tre.GP = 1500;
                }
                else if (p <= 43)
                {
                    tre.Name = "Indigo Herb";
                    tre.Stat = "+2 save vs cold, -1/4 cold damage for 10 minutes";
                    tre.GP = 1500;
                }
                else if (p <= 44)
                {
                    tre.Name = "Cerulean Herb";
                    tre.Stat = "+4 save vs cold, -1/2 cold damage for 10 minutes";
                    tre.GP = 2000;
                }
                else if (p <= 45)
                {
                    tre.Name = "Russet Herb";
                    tre.Stat = "+2 save vs fire, -1/4 fire damage for 10 minutes";
                    tre.GP = 1500;
                }
                else if (p <= 46)
                {
                    tre.Name = "Vermilion Herb";
                    tre.Stat = "+4 save vs fire, -1/2 fire damage for 10 minutes";
                    tre.GP = 2000;
                }
                else if (p <= 47)
                {
                    tre.Name = "Crackling Herb";
                    tre.Stat = "+2 save vs lightning, -1/4 lightning damage for 10 minutes";
                    tre.GP = 1500;
                }
                else if (p <= 48)
                {
                    tre.Name = "Forked Herb";
                    tre.Stat = "+4 save vs lightning, -1/2 lightning damage for 10 minutes";
                    tre.GP = 2000;
                }
                else if (p <= 49)
                {
                    tre.Name = "Swart Herb";
                    tre.Stat = "+2 save vs spell, -1/4 spell damage for 10 minutes";
                    tre.GP = 1500;
                }
                else if (p <= 50)
                {
                    tre.Name = "Artamentous Herb";
                    tre.Stat = "+4 save vs spell, -1/2 spell damage for 10 minutes";
                    tre.GP = 2000;
                }
                else if (p <= 51)
                {
                    tre.Name = "Vital Herb";
                    tre.Stat = "+2 save vs Poison, no initial damage, last for 10 minutes";
                    tre.GP = 1500;
                }
                else if (p <= 52)
                {
                    tre.Name = "Enduring Herb";
                    tre.Stat = "+4 save vs Poison, no secondary damage, last for 10 minutes";
                    tre.GP = 2000;
                }
                else if (p <= 53)
                {
                    tre.Name = "Urgent Herb";
                    tre.Stat = "+2 speed initiative bonus for 10 minutes";
                    tre.GP = 500;
                }
                else if (p <= 54)
                {
                    tre.Name = "Fleet Herb";
                    tre.Stat = "+4 speed initiative bonus for 10 minutes";
                    tre.GP = 1000;
                }
                else if (p <= 55)
                {
                    tre.Name = "Brisk Herb";
                    tre.Stat = "+10 ft. speed bonus to move for 10 minutes";
                    tre.GP = 500;
                }
                else if (p <= 56)
                {
                    tre.Name = "Swift Herb";
                    tre.Stat = "+20 ft. speed bonus to move for 10 minutes";
                    tre.GP = 1000;
                }
                else if (p <= 57)
                {
                    tre.Name = "Dazzling Herb";
                    tre.Stat = "+1 1st level spell, cast within 10 minutes (spellcaster only)";
                    tre.GP = 500;
                }
                else if (p <= 58)
                {
                    tre.Name = "Fascinating Herb";
                    tre.Stat = "+1 2nd level spell, cast within 10 minutes (spellcaster only)";
                    tre.GP = 1000;
                }
                else if (p <= 59)
                {
                    tre.Name = "Bright Herb";
                    tre.Stat = "Bonus hit points, +50% of current for 10 minutes";
                    tre.GP = 500;
                }
                else if (p <= 60)
                {
                    tre.Name = "Solar Herb";
                    tre.Stat = "Bonus hit points, +100% of current for 10 minutes";
                    tre.GP = 1000;
                }
                else if (p <= 61)
                {
                    tre.Name = "Omniscient Herb";
                    tre.Stat = "+1 Intelligence for 10 minutes";
                    tre.GP = 500;
                }
                else if (p <= 62)
                {
                    tre.Name = "Mystical Herb";
                    tre.Stat = "All spell duration +50% if cast within 10 minutes";
                    tre.GP = 1500;
                }
                else if (p <= 63)
                {
                    tre.Name = "Arcane Herb";
                    tre.Stat = "All spell duration +50% if cast within 10 minutes";
                    tre.GP = 2000;
                }
                else if (p <= 65)
                {
                    tre.Name = "Strength Elixir";
                    tre.Stat = "+2 Strength for one day";
                    tre.GP = 5000;
                }
                else if (p <= 67)
                {
                    tre.Name = "Dexerity Elixir";
                    tre.Stat = "+2 Dexerity for one day";
                    tre.GP = 5000;
                }
                else if (p <= 69)
                {
                    tre.Name = "Vitality Elixir";
                    tre.Stat = "+2 Constitution for one day";
                    tre.GP = 5000;
                }
                else if (p <= 70)
                {
                    tre.Name = "Intelligence Elixir";
                    tre.Stat = "+2 Intelligence for one day";
                    tre.GP = 5000;
                }
                else if (p <= 71)
                {
                    tre.Name = "Chi Elixir";
                    tre.Stat = "+2 Wisdom for one day";
                    tre.GP = 5000;
                }
                else if (p <= 72)
                {
                    tre.Name = "Spectral Elixir";
                    tre.Stat = "+2 to all abilitie scores for one day";
                    tre.GP = 15000;
                }
                else if (p <= 73)
                {
                    tre.Name = "Fire Elixir";
                    tre.Stat = "+2 save vs. fire for one day";
                    tre.GP = 2500;
                }
                else if (p <= 74)
                {
                    tre.Name = "Ice Elixir";
                    tre.Stat = "+2 save vs. ice for one day";
                    tre.GP = 2500;
                }
                else if (p <= 75)
                {
                    tre.Name = "Lightning Elixir";
                    tre.Stat = "+2 save vs. lightning for one day";
                    tre.GP = 2500;
                }
                else if (p <= 76)
                {
                    tre.Name = "Magic Elixir";
                    tre.Stat = "+2 save vs. spell for one day";
                    tre.GP = 2500;
                }
                else if (p <= 77)
                {
                    tre.Name = "Psionic Elixir";
                    tre.Stat = "+2 save vs. mind-influencing effects for one day";
                    tre.GP = 2500;
                }
                else if (p <= 78)
                {
                    tre.Name = "Posion Elixir";
                    tre.Stat = "+2 save vs. posion for one day";
                    tre.GP = 2500;
                }
                else if (p <= 79)
                {
                    tre.Name = "Energy Elixir";
                    tre.Stat = "+2 all saves for one day";
                    tre.GP = 2500;
                }
                else if (p <= 80)
                {
                    tre.Name = "Accuracy Elixir";
                    tre.Stat = "+2 attack for one day";
                    tre.GP = 2500;
                }
                else if (p <= 81)
                {
                    tre.Name = "Damage Elixir";
                    tre.Stat = "+2 damage for one day";
                    tre.GP = 2500;
                }
                else if (p <= 82)
                {
                    tre.Name = "Defense Elixir";
                    tre.Stat = "+1 AC for one day";
                    tre.GP = 2500;
                }
                else if (p <= 83)
                {
                    tre.Name = "Life Elixir";
                    tre.Stat = "+5 to maximum hit points for one day";
                    tre.GP = 2500;
                }
                else if (p <= 84)
                {
                    tre.Name = "Power Elixir";
                    tre.Stat = "+0 1st-level spell slot (spellcaster only) for one day";
                    tre.GP = 2500;
                }
                else if (p <= 85)
                {
                    OOR = smallItems.OilOrResin();
                    if (OOR)
                    {
                        tre.Name = "Accuracy Resin";
                        tre.Stat = "+2 attack for 10 arrows for 10 minutes";
                        tre.GP = 1000;
                    }
                    tre.Name = "Accuracy Oil";
                    tre.Stat = "+2 attack for 1 weapon for 10 minutes";
                    tre.GP = 1000;
                }
                else if (p <= 86)
                {
                    OOR = smallItems.OilOrResin();
                    if (OOR)
                    {
                        tre.Name = "Precision Resin";
                        tre.Stat = "+3 attack for 10 arrows for 10 minutes";
                        tre.GP = 1500;
                    }
                    tre.Name = "Precision Oil";
                    tre.Stat = "+3 attack for 1 weapon for 10 minutes";
                    tre.GP = 1500;
                }
                else if (p <= 87)
                {
                    OOR = smallItems.OilOrResin();
                    if (OOR)
                    {
                        tre.Name = "Mastery Resin";
                        tre.Stat = "+4 attack for 10 arrows for 10 minutes";
                        tre.GP = 2000;
                    }
                    tre.Name = "Mastery Oil";
                    tre.Stat = "+4 attack for 1 weapon for 10 minutes";
                    tre.GP = 2000;
                }
                else if (p <= 88)
                {
                    OOR = smallItems.OilOrResin();
                    if (OOR)
                    {
                        tre.Name = "Sharpness Resin";
                        tre.Stat = "+2 damage for 10 arrows for 10 minutes";
                        tre.GP = 1000;
                    }
                    tre.Name = "Sharpness Oil";
                    tre.Stat = "+2 damage for 1 weapon for 10 minutes";
                    tre.GP = 1000;
                }
                else if (p <= 89)
                {
                    OOR = smallItems.OilOrResin();
                    if (OOR)
                    {
                        tre.Name = "Pain Resin";
                        tre.Stat = "+3 damage for 10 arrows for 10 minutes";
                        tre.GP = 1500;
                    }
                    tre.Name = "Pain Oil";
                    tre.Stat = "+3 damage for 1 weapon for 10 minutes";
                    tre.GP = 1500;
                }
                else if (p <= 90)
                {
                    OOR = smallItems.OilOrResin();
                    if (OOR)
                    {
                        tre.Name = "Savagery Resin";
                        tre.Stat = "+4 damage for 10 arrows for 10 minutes";
                        tre.GP = 2000;
                    }
                    tre.Name = "Savagery Oil";
                    tre.Stat = "+4 damage for 1 weapon for 10 minutes";
                    tre.GP = 2000;
                }
                else if (p <= 91)
                {
                    OOR = smallItems.OilOrResin();
                    if (OOR)
                    {
                        tre.Name = "Death Resin";
                        tre.Stat = "+5 damage for 10 arrows for 10 minutes";
                        tre.GP = 2000;
                    }
                    tre.Name = "Death Oil";
                    tre.Stat = "+5 damage for 1 weapon for 10 minutes";
                    tre.GP = 2500;
                }
                else if (p <= 92)
                {
                    tre.Name = "Hardening Oil";
                    tre.Stat = "anointed weapon give +2 AC for 10 minutes";
                    tre.GP = 1000;
                }
                else if (p <= 93)
                {
                    tre.Name = "Imperviousness Oil";
                    tre.Stat = "anointed weapon give +3 AC for 10 minutes";
                    tre.GP = 1500;
                }
                else if (p <= 94)
                {
                    tre.Name = "Immunity Oil";
                    tre.Stat = "anointed weapon give +4 AC for 10 minutes";
                    tre.GP = 2000;
                }
                else if (p <= 95)
                {
                    tre.Name = "Skill Oil";
                    tre.Stat = "Gains proficienct for this weapon for 10 minutes";
                    tre.GP = 1000;
                }
                else if (p <= 96)
                {
                    tre.Name = "Fortitude Oil";
                    tre.Stat = "Repairs all damage for one item";
                    tre.GP = 1000;
                }
                else if (p <= 97)
                {
                    tre.Name = "Blacksmith's Oil";
                    tre.Stat = "Item gains +5 hardness for 10 minutes";
                    tre.GP = 1500;
                }
                else if (p <= 98)
                {
                    tre.Name = "Permanence Oil";
                    tre.Stat = "Weapon becomes indestructible for one day";
                    tre.GP = 3000;
                }
                else if (p <= 99)
                {
                    tre.Name = "Enchantment Oil";
                    tre.Stat = "Weapon type permantly changed (roll 1d20+40 on Base Item table)";
                    tre.GP = 3500;
                }
                else if (p <= 100)
                {
                    if (q == "perishable")
                    {
                        item get1 = new item();
                        item get2 = new item();
                        get1 = Item(99, "perishable", CR);
                        get2 = Item(99, "perishable", CR);
                        string stat = $"{get1.Stat} and {get2.Stat}";
                        tre.Stat = stat;
                    }
                    else
                    {
                        //Monster Part
                        int part = Dice.D(12);
                        {
                            if (part == 1)
                            {
                                tre.Name = "Heart";
                            }
                            if (part == 2)
                            {
                                tre.Name = "Brain";
                            }
                            if (part == 3)
                            {
                                tre.Name = "Jawbone";
                            }
                            if (part == 4)
                            {
                                tre.Name = "Eye";
                            }
                            if (part == 5)
                            {
                                tre.Name = "Ear";
                            }
                            if (part == 6)
                            {
                                tre.Name = "Horn";
                            }
                            if (part == 7)
                            {
                                tre.Name = "Tail";
                            }
                            if (part == 8)
                            {
                                tre.Name = "Fang";
                            }
                            if (part == 9)
                            {
                                tre.Name = "Quill";
                            }
                            if (part == 10)
                            {
                                tre.Name = "Scalp";
                            }
                            if (part == 11)
                            {
                                tre.Name = "Spleen";
                            }
                            if (part == 12)
                            {
                                tre.Name = "Soul";
                            }
                        }
                        item get = new item();
                        get = Item(99, "perishable", CR);
                        tre.Stat = get.Stat;
                        tre.GP = 0;
                    }
                }
                Prefix = -1;
                Suffix = -1;
            }
            if (!(q == "none") && !(q == "perishable"))
            {
                pre pre = new pre();
                suf suf = new suf();
                if (q == "Prefix")
                {
                    pre = prefix.Prefixes(Prefix, CR);
                }
                if (q == "Suffix")
                {
                    suf = suffix.Suffixes(Suffix, CR);
                }
                if (q == "PrefixNSuffix")
                {
                    pre = prefix.Prefixes(Prefix, CR);
                    suf = suffix.Suffixes(Suffix, CR);
                }
                tre.PrefixName = pre.PrefixName;
                tre.PrefixStat = pre.PrefixStat;
                tre.PrefixGP = pre.PrefixGP;
                tre.rolls.AddRange(pre.rolls);

                tre.SuffixName = suf.SuffixName;
                tre.SuffixStat = suf.SuffixStat;
                tre.SuffixGP = suf.SuffixGP;
                tre.rolls.AddRange(suf.rolls);
            }

            tre.rolls = Dice.rolls;
            return tre;
        }
    }
}