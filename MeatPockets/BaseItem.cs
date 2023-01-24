using ClassLibaray;
using Prefix;
using Suffix;
using Extras;

namespace BaseItem
{
    public class baseItem
    {

        public static item Item(int Item_Roll, string q, int CR)
        {
            int Prefix_Dice = 0;
            int Prefix_Mod = 0;
            int Suffix_Dice = 0;
            int Suffix_Mod = 0;
            item Treasure = new item();
            DiceRoll Dice = new DiceRoll();

            if (Item_Roll < 8)
            {
                //Body Armor ---------------------------------------------------------------------------------------------------------------------------------
                int Body_Armor = Dice.D(20) + CR;

                if (Body_Armor <= 3)
                {
                    Treasure.Name = "Rags";
                    Treasure.Stat = "+1 AC (-1 Char checks";
                    Treasure.GP = 1;
                }
                else if (Body_Armor <= 5)
                {
                    Treasure.Name = "Cape";
                    Treasure.Stat = "+1 AC";
                    Treasure.GP = 5;
                }
                else if (Body_Armor <= 7)
                {
                    Treasure.Name = "Cloak";
                    Treasure.Stat = "+1 AC";
                    Treasure.GP = 15;
                }
                else if (Body_Armor <= 11)
                {
                    Treasure.Name = "Robe";
                    Treasure.Stat = "+1 AC";
                    Treasure.GP = 20;
                }
                else if (Body_Armor <= 14)
                {
                    Treasure.Name = "Quilted Armor";
                    Treasure.Stat = "+1 AC";
                    Treasure.GP = 25;
                }
                else if (Body_Armor <= 16)
                {
                    Treasure.Name = "Leather Armor";
                    Treasure.Stat = "+2 AC";
                    Treasure.GP = 30;
                }
                else if (Body_Armor <= 18)
                {
                    Treasure.Name = "Hard Leather Armor";
                    Treasure.Stat = "+3 AC";
                    Treasure.GP = 40;
                }
                else if (Body_Armor <= 21)
                {
                    Treasure.Name = "Studded Leather Armor";
                    Treasure.Stat = "+3 AC";
                    Treasure.GP = 50;
                }
                else if (Body_Armor <= 23)
                {
                    Treasure.Name = "Ring Mail";
                    Treasure.Stat = "+4 AC";
                    Treasure.GP = 100;
                }
                else if (Body_Armor <= 25)
                {
                    Treasure.Name = "Scale Mail";
                    Treasure.Stat = "+4 AC";
                    Treasure.GP = 120;
                }
                else if (Body_Armor <= 27)
                {
                    Treasure.Name = "Chain Mail";
                    Treasure.Stat = "+5 AC";
                    Treasure.GP = 150;
                }
                else if (Body_Armor == 28)
                {
                    Treasure.Name = "Breast Plate";
                    Treasure.Stat = "+5 AC";
                    Treasure.GP = 200;
                }
                else if (Body_Armor <= 30)
                {
                    Treasure.Name = "Splint Mail";
                    Treasure.Stat = "+6 AC";
                    Treasure.GP = 250;
                }
                else if (Body_Armor <= 32)
                {
                    Treasure.Name = "Plate Mail";
                    Treasure.Stat = "+7 AC";
                    Treasure.GP = 600;
                }
                else if (Body_Armor == 33)
                {
                    Treasure.Name = "Field Plate";
                    Treasure.Stat = "+8 AC";
                    Treasure.GP = 2000;
                }
                else if (Body_Armor == 34)
                {
                    Treasure.Name = "Ancient Armor";
                    Treasure.Stat = "+9 AC, absorbs 1 point of damage per attack";
                    Treasure.GP = 3750;
                }
                else if (Body_Armor == 35)
                {
                    Treasure.Name = "Gothic Plate";
                    Treasure.Stat = "+10 AC";
                    Treasure.GP = 4000;
                }
                else if (Body_Armor >= 36)
                {
                    Treasure.Name = "Full Plate Mail";
                    Treasure.Stat = "+11 AC";
                    Treasure.GP = 5000;
                }
                Prefix_Dice = 60;
                Suffix_Dice =60;
            }                //Body Armor
            if (Item_Roll > 8 && Item_Roll < 14)
            {
                //Head Protection ---------------------------------------------------------------------------------------------------------------------------------
                int Head_Piece = Dice.D(20) + CR;
                if (Head_Piece <= 10)
                {
                    Treasure.Name = "Cap";
                    Treasure.Stat = "+1 AC (not cumulative with any protection)";
                    Treasure.GP = 5;
                }
                else if (Head_Piece <= 14)
                {
                    Treasure.Name = "Skull Cap";
                    Treasure.Stat = "+1 AC (not cumulative with armor)";
                    Treasure.GP = 10;
                }
                else if (Head_Piece <= 18)
                {
                    Treasure.Name = "Helm";
                    Treasure.Stat = "+1 AC (not cumulative with armor)";
                    Treasure.GP = 15;
                }
                else if (Head_Piece <= 20)
                {
                    Treasure.Name = "Mask";
                    Treasure.Stat = "+1 AC (not cumulative with armor)";
                    Treasure.GP = 20;
                }
                else if (Head_Piece <= 25)
                {
                    Treasure.Name = "Full Helm";
                    Treasure.Stat = "+2 AC (not cumulative with armor)";
                    Treasure.GP = 30;
                }
                else if (Head_Piece <= 29)
                {
                    Treasure.Name = "Crown";
                    Treasure.Stat = "+3 AC (not cumulative with armor)";
                    Treasure.GP = 50;
                }
                else if (Head_Piece <= 32)
                {
                    Treasure.Name = "Bone Helm";
                    Treasure.Stat = "+3 AC (not cumulative with armor)";
                    Treasure.GP = 100;
                }
                else if (Head_Piece >= 33)
                {
                    Treasure.Name = "Great Helm";
                    Treasure.Stat = "+4 AC (not cumulative with armor)";
                    Treasure.GP = 150;
                }
                Prefix_Dice = 60;
                Suffix_Dice = 60;
            }      //Head Protection
            if (Item_Roll > 13 && Item_Roll < 17)
            {
                //Foot Proctection ---------------------------------------------------------------------------------------------------------------------------------
                int Foot_Piece = Dice.D(20) + CR;

                if (Foot_Piece <= 12)
                {
                    Treasure.Name = "Leather Boots";
                    Treasure.Stat = "+1 AC (not cumulative with any protection/armor)";
                    Treasure.GP = 5;
                }
                else if (Foot_Piece <= 21)
                {
                    Treasure.Name = "Heavy Boots";
                    Treasure.Stat = "+1 AC (not cumulative with armor)";
                    Treasure.GP = 10;
                }
                else if (Foot_Piece <= 27)
                {
                    Treasure.Name = "Chain Boots";
                    Treasure.Stat = "+1 AC (not cumulative with armor)";
                    Treasure.GP = 15;
                }
                else if (Foot_Piece <= 32)
                {
                    Treasure.Name = "Light Plate Boots";
                    Treasure.Stat = "+1 AC (not cumulative with armor)";
                    Treasure.GP = 20;
                }
                else if (Foot_Piece >= 33)
                {
                    Treasure.Name = "Greaves";
                    Treasure.Stat = "+2 AC (not cumulative with armor)";
                    Treasure.GP = 30;
                }
                Prefix_Dice = 60;
                Suffix_Dice = 60;
            }     //Foot Protection
            if (Item_Roll > 16 && Item_Roll < 19)
            {
                //Hand Proctection -----------------------------------------------------------------------------------------------------------------------
                int Hand_Piece = Dice.D(20) + CR;

                if (Hand_Piece <= 12)
                {
                    Treasure.Name = "Gloves";
                    Treasure.Stat = "+1 AC (not cumulative with any protection)";
                    Treasure.GP = 5;
                }
                else if (Hand_Piece <= 21)
                {
                    Treasure.Name = "Heavy Gloves";
                    Treasure.Stat = "+1 AC (not cumulative with armor or shield)";
                    Treasure.GP = 10;
                }
                else if (Hand_Piece <= 27)
                {
                    Treasure.Name = "Chain Gloves";
                    Treasure.Stat = "+1 AC (not cumulative with armor or shield)";
                    Treasure.GP = 15;
                }
                else if (Hand_Piece <= 32)
                {
                    Treasure.Name = "Light Gauntlets";
                    Treasure.Stat = "+1 AC (not cumulative with armor or shield)";
                    Treasure.GP = 20;
                }
                else if (Hand_Piece >= 33)
                {
                    Treasure.Name = "Gauntlets";
                    Treasure.Stat = "+2 AC (not cumulative with armor or shield)";
                    Treasure.GP = 30;
                }
                Prefix_Dice = 60;
                Suffix_Dice = 60;
            }     //Hand Protection
            if (Item_Roll > 18 && Item_Roll < 21)
            {
                //Belts ---------------------------------------------------------------------------------------------------------------------------------
                int Belt = Dice.D(20) + CR;
                if (Belt <= 12)
                {
                    Treasure.Name = "Sash";
                    Treasure.Stat = "+1 AC (not cumulative with any protection/armor)";
                    Treasure.GP = 5;
                }
                else if (Belt <= 21)
                {
                    Treasure.Name = "Light Belt";
                    Treasure.Stat = "+1 AC (not cumulative with armor)";
                    Treasure.GP = 10;
                }
                else if (Belt <= 27)
                {
                    Treasure.Name = "Belt";
                    Treasure.Stat = "+1 AC (not cumulative with armor)";
                    Treasure.GP = 15;
                }
                else if (Belt <= 32)
                {
                    Treasure.Name = "Heavy Belt";
                    Treasure.Stat = "+1 AC (not cumulative with armor)";
                    Treasure.GP = 20;
                }
                else if (Belt >= 33)
                {
                    Treasure.Name = "Plate Belt";
                    Treasure.Stat = "+2 AC (not cumulative with armor)";
                    Treasure.GP = 30;
                }
                Prefix_Dice = 60;
                Suffix_Dice = 60;
            }     //Belts
            if (Item_Roll > 20 && Item_Roll < 26)
            {
                //Shields ---------------------------------------------------------------------------------------------------------------------------------
                int Shield = Dice.D(20) + CR;
                if (Shield <= 10)
                {
                    Treasure.Name = "Buckler";
                    Treasure.Stat = "+1 AC (negates hand protection)";
                    Treasure.GP = 10;
                }
                else if (Shield <= 16)
                {
                    Treasure.Name = "Small Shield";
                    Treasure.Stat = "+1 AC (negates hand protection)";
                    Treasure.GP = 15;
                }
                else if (Shield <= 21)
                {
                    Treasure.Name = "Large Shield";
                    Treasure.Stat = "+2 AC (negates hand protection)";
                    Treasure.GP = 20;
                }
                else if (Shield <= 25)
                {
                    Treasure.Name = "Kite Shield";
                    Treasure.Stat = "+3 AC (negates hand protection)";
                    Treasure.GP = 50;
                }
                else if (Shield <= 27)
                {
                    Treasure.Name = "Spiked Shield";
                    Treasure.Stat = "+3 AC (used as a 1d6 (x2) piercing weapon; negates hand protection)";
                    Treasure.GP = 100;
                }
                else if (Shield <= 29)
                {
                    Treasure.Name = "Bone Shield";
                    Treasure.Stat = "+3 AC (negates hand protection)";
                    Treasure.GP = 150;
                }
                else if (Shield <= 32)
                {
                    Treasure.Name = "Tower Shield (small)";
                    Treasure.Stat = "+4 AC (negates hand protection)";
                    Treasure.GP = 250;
                }
                else if (Shield <= 33)
                {
                    Treasure.Name = "Gothic Shield";
                    Treasure.Stat = "+2 AC (negates hand protection)";
                    Treasure.GP = 500;
                }
                Prefix_Dice = 60;
                Suffix_Dice = 60;
            }     //Shields
            if (26 <= Item_Roll && Item_Roll <= 30)
            {
                //Dagger ---------------------------------------------------------------------------------------------------------------------------------
                int d = Dice.D(20) + CR;
                if (d <= 10)
                {
                    int a = Dice.D(6) + Dice.D(6);
                    Treasure.Name = $"{a} Throwing Knifes";
                    Treasure.Stat = "1d3, crit 19-20/x2, 1 lb., Small, Piercing";
                    Treasure.GP = 2;
                    Treasure.Each = true;
                    Treasure.Amount = a;
                }
                else if (d <= 15)
                {
                    Treasure.Name = "Dagger";
                    Treasure.Stat = "1d4, crit 19-20/x2, 1 lb., Tiny, Piercing";
                    Treasure.GP = 5;
                }
                else if (d <= 17)
                {
                    Treasure.Name = "Dirk";
                    Treasure.Stat = "1d4, crit 19-20/x2, 2 lbs., Small, Piercing/Slashing";
                    Treasure.GP = 10;
                }
                else if (d <= 21)
                {
                    Treasure.Name = "Kris";
                    Treasure.Stat = "1d4, crit 19-20/x2, 2 lbs., Tiny, Piercing";
                    Treasure.GP = 15;
                }
                else if (d <= 32)
                {
                    int a = Dice.D(6) + Dice.D(6);
                    Treasure.Name = $"{a} Balanced Knife";
                    Treasure.Stat = "1d4, crit 19-20/x2, 1 lb., Small, Piercing";
                    Treasure.GP = 3;
                    Treasure.Each = true;
                    Treasure.Amount = a;
                }
                else if (d >= 33)
                {
                    Treasure.Name = "Blade";
                    Treasure.Stat = "1d6, crit 19-20/x2, 2 lbs., Small, Piercing/Slashing";
                    Treasure.GP = 20;
                }
                Prefix_Dice = 60;
                Prefix_Mod = 25;
                Suffix_Dice = 60;
                Suffix_Mod = 25;
            }   //Daggers
            if (31 <= Item_Roll && Item_Roll <= 40)
            {
                //Sword ---------------------------------------------------------------------------------------------------------------------------------
                int Sword = Dice.D(20) + CR;
                if (Sword <= 4)
                {
                    Treasure.Name = "Short Sword";
                    Treasure.Stat = "1d6, crit 19-20/x2, 3 lbs., Small, Piercing";
                    Treasure.GP = 10;
                }
                else if (Sword <= 7)
                {
                    Treasure.Name = "Saber";
                    Treasure.Stat = "1d6, crit 19-20/x2, 4 lbs., Medium, Slashing";
                    Treasure.GP = 30;
                }
                else if (Sword <= 10)
                {
                    Treasure.Name = "Scimitar";
                    Treasure.Stat = "1d6, crit 18-20/x2, 4 lbs., Medium, Slashing";
                    Treasure.GP = 20;
                }
                else if (Sword <= 13)
                {
                    Treasure.Name = "Falchion";
                    Treasure.Stat = "1d6, crit 18-20/x2, 6 lbs., Medium, Slashing";
                    Treasure.GP = 35;
                }
                else if (Sword <= 15)
                {
                    Treasure.Name = "Broad Sword";
                    Treasure.Stat = "1d8, crit 19-20/x2, 4 lbs., Medium, Slashing";
                    Treasure.GP = 75;
                }
                else if (Sword <= 17)
                {
                    Treasure.Name = "Longsword";
                    Treasure.Stat = "1d8, crit 19-20/x2, 4 lbs., Medium, Slashing";
                    Treasure.GP = 100;
                }
                else if (Sword <= 18)
                {
                    Treasure.Name = "Crystal Sword";
                    Treasure.Stat = "1d8, crit 18-20/x3, 5 lbs., Medium, Slashing";
                    Treasure.GP = 150;
                }
                else if (Sword <= 20)
                {
                    Treasure.Name = "Claymore 2H";
                    Treasure.Stat = "1d10, crit 19-20/x2, 15 lbs., Large, Slashing";
                    Treasure.GP = 150;
                }
                else if (Sword <= 24)
                {
                    Treasure.Name = "Two-Handed Sword 2H";
                    Treasure.Stat = "1d10, crit 19-20/x2, 15 lbs., Large, Slashing";
                    Treasure.GP = 175;
                }
                else if (Sword <= 26)
                {
                    Treasure.Name = "War Sword";
                    Treasure.Stat = "1d10, crit 19-20/x2, 4 lbs., Medium, Slashing";
                    Treasure.GP = 200;
                }
                else if (Sword <= 28)
                {
                    Treasure.Name = "Giant Sword 2H";
                    Treasure.Stat = "2d6, crit 19-20/x2, 15 lbs., Large, Slashing";
                    Treasure.GP = 250;
                }
                else if (Sword <= 30)
                {
                    Treasure.Name = "Bastard Sword 2H";
                    Treasure.Stat = "2d6, crit 19-20/x2, 10 lbs., Large, Slashing";
                    Treasure.GP = 250;
                }
                else if (Sword <= 32)
                {
                    Treasure.Name = "Flamberge 2H";
                    Treasure.Stat = "2d8, crit 19-20/x2, 15 lbs., Large, Slashing";
                    Treasure.GP = 300;
                }
                else if (Sword >= 33)
                {
                    Treasure.Name = "Great Sword 2H";
                    Treasure.Stat = "2d10, crit 19-20/x2, 15 lbs., Large, Slashing";
                    Treasure.GP = 500;
                }
                Prefix_Dice = 60;
                Prefix_Mod = 25;
                Suffix_Dice = 60;
                Suffix_Mod = 25;
            }   //Swords
            if (41 <= Item_Roll && Item_Roll <= 44)
            {
                //Clubs ---------------------------------------------------------------------------------------------------------------------------------
                int Club = Dice.D(20) + CR;
                if (Club <= 7)
                {
                    Treasure.Name = "CLub";
                    Treasure.Stat = "1d6, crit x2, 3 lbs., Medium, Bludgeoning";
                    Treasure.GP = 1;
                }
                else if (Club <= 9)
                {
                    Treasure.Name = "Spiked Club";
                    Treasure.Stat = "1d6, crit x3, 5 lbs., Medium, Bludgeoning/Piercing";
                    Treasure.GP = 5;
                }
                else if (Club <= 13)
                {
                    Treasure.Name = "Light Mace";
                    Treasure.Stat = "1d6, crit x2, 6 lbs., Small, Bludgeoning";
                    Treasure.GP = 10;
                }
                else if (Club <= 17)
                {
                    Treasure.Name = "Scepter";
                    Treasure.Stat = "1d, crit x2, 4 lbs., Medium, Bludgeoning";
                    Treasure.GP = 20;
                }
                else if (Club <= 19)
                {
                    Treasure.Name = "Morning Star";
                    Treasure.Stat = "1d8, crit x2, 8 lbs., Medium, Bludgeoning/Piercing";
                    Treasure.GP = 30;
                }
                else if (Club <= 23)
                {
                    Treasure.Name = "Grand Scepter";
                    Treasure.Stat = "1d8, crit x2, 6 lbs., Medium, Bludgeoning";
                    Treasure.GP = 40;
                }
                else if (Club <= 25)
                {
                    Treasure.Name = "Light Flail";
                    Treasure.Stat = "1d8, crit x2, 5 lbs., Medium, Bludgeoning";
                    Treasure.GP = 50;
                }
                else if (Club <= 28)
                {
                    Treasure.Name = "War Hammer";
                    Treasure.Stat = "1d8, crit x3, 8 lbs., Medium, Bludgeoning";
                    Treasure.GP = 60;
                }
                else if (Club <= 30)
                {
                    Treasure.Name = "Maul 2H";
                    Treasure.Stat = "1d10, crit x3, 25 lbs., Large, Bludgeoning";
                    Treasure.GP = 100;
                }
                else if (Club <= 32)
                {
                    Treasure.Name = "War Scepter";
                    Treasure.Stat = "1d10, crit x2, 6 lbs., Medium, Bludgeoning";
                    Treasure.GP = 200;
                }
                else if (Club <= 33)
                {
                    Treasure.Name = "Great Maul 2H";
                    Treasure.Stat = "2d6, crit x3, 30 lbs., Large, Bludgeoning";
                    Treasure.GP = 250;
                }
                Prefix_Dice = 60;
                Prefix_Mod = 25;
                Suffix_Dice = 60;
                Suffix_Mod = 25;
            }   //Clubs
            if (45 <= Item_Roll && Item_Roll <= 48)
            {
                //Javelins/Spears ---------------------------------------------------------------------------------------------------------------------------------
                int Spear = Dice.D(20) + CR;
                if (Spear <= 7)
                {
                    int a = Dice.D(4) + Dice.D(4);
                    Treasure.Name = $"{a} Light Javelin";
                    Treasure.Stat = "1d4, crit x2, Range 30 ft., 1 lb., Medium, Piercing";
                    Treasure.GP = 2;
                    Treasure.Each = true;
                    Treasure.Amount = a;
                }
                else if (Spear <= 10)
                {
                    Treasure.Name = "Short Spear";
                    Treasure.Stat = "1d6, crit x3, Range 20 ft., 3 lb., Medium, Piercing";
                    Treasure.GP = 20;
                }
                else if (Spear <= 13)
                {
                    Treasure.Name = "Long Spear 2H";
                    Treasure.Stat = "1d8, crit x3, 9 lb., Large, Piercing";
                    Treasure.GP = 40;
                }
                else if (Spear <= 17)
                {
                    int a = Dice.D(4) + Dice.D(4);
                    Treasure.Name = $"{a} Pilum";
                    Treasure.Stat = "1d6, crit x2, Range 20 ft., 4 lb., Medium, Piercing";
                    Treasure.GP = 3;
                    Treasure.Each = true;
                    Treasure.Amount = a;
                }
                else if (Spear <= 20)
                {
                    Treasure.Name = "Trident 2H";
                    Treasure.Stat = "1d12, crit x2, 15 lb., Large, Piercing";
                    Treasure.GP = 80;
                }
                else if (Spear <= 23)
                {
                    int a = Dice.D(4) + Dice.D(4);
                    Treasure.Name = $"{a} Light Glaives";
                    Treasure.Stat = "1d8, crit x2, Range 10 ft., 4 lb., Medium, Piercing";
                    Treasure.GP = 4;
                    Treasure.Each = true;
                    Treasure.Amount = a;
                }
                else if (Spear <= 26)
                {
                    Treasure.Name = "Brandistock 2H";
                    Treasure.Stat = "2d6, crit x3, 15 lb., Large, Piercing/Slashing";
                    Treasure.GP = 100;
                }
                else if (Spear <= 29)
                {
                    int a = Dice.D(4) + Dice.D(4);
                    Treasure.Name = $"{a} Throwing Spears";
                    Treasure.Stat = "1d8, crit x2, Range 30 ft., 3 lb., Medium, Piercing";
                    Treasure.GP = 5;
                    Treasure.Each = true;
                    Treasure.Amount = a;
                }
                else if (Spear <= 32)
                {
                    Treasure.Name = "Spetum 2H";
                    Treasure.Stat = "1d12, crit x3, 15 lb., Large, Piercing/Slashing";
                    Treasure.GP = 120;
                }
                else if (Spear >= 33)
                {
                    Treasure.Name = "Heavy Pike 2H";
                    Treasure.Stat = "1d12, crit x3, 12 lb., Large, Piercing";
                    Treasure.GP = 200;
                }
                Prefix_Dice = 60;
                Prefix_Mod = 25;
                Suffix_Dice = 60;
                Suffix_Mod = 25;
            }   //Javelins/Spears
            if (49 <= Item_Roll && Item_Roll <= 50)
            {
                //Polearms ---------------------------------------------------------------------------------------------------------------------------------
                int Polearm = Dice.D(20) + CR;

                if (Polearm <= 8)
                {
                    Treasure.Name = "Bardiche 2H";
                    Treasure.Stat = "1d8, crit x3, 10 lbs., Large, Slashing";
                    Treasure.GP = 20;
                }
                else if (Polearm <= 14)
                {
                    Treasure.Name = "Voulge 2H";
                    Treasure.Stat = "2d4, crit x3, 15 lbs., Large, Slashing";
                    Treasure.GP = 40;
                }
                else if (Polearm <= 20)
                {
                    Treasure.Name = "Scythe 2H";
                    Treasure.Stat = "2d4, crit x4, 12 lbs., Large, Piercing/Slashing";
                    Treasure.GP = 80;
                }
                else if (Polearm <= 26)
                {
                    Treasure.Name = "Poleaxe 2H";
                    Treasure.Stat = "2d10, crit x3, 15 lbs., Large, Slashing";
                    Treasure.GP = 150;
                }
                else if (Polearm <= 32)
                {
                    Treasure.Name = "Heavy Halberd 2H";
                    Treasure.Stat = "2d6, crit x3, 15 lbs., Large, Piercing/Slashing";
                    Treasure.GP = 200;
                }
                else if (Polearm >= 33)
                {
                    Treasure.Name = "War Sycthe 2H";
                    Treasure.Stat = "2d6, crit x4, 15 lbs., Large, Piercing/Slashing";
                    Treasure.GP = 250;
                }
                Prefix_Dice = 60;
                Prefix_Mod = 25;
                Suffix_Dice = 60;
                Suffix_Mod = 25;
            }   //Polearms
            if (51 <= Item_Roll && Item_Roll <= 55)
            {
                //Axes ---------------------------------------------------------------------------------------------------------------------------------
                int Axe = Dice.D(20) + CR;

                if (Axe <= 5)
                {
                    Treasure.Name = "Light Hand Axe";
                    Treasure.Stat = "1d4, crit x3, 2 lbs., Small, Slashing";
                    Treasure.GP = 10;
                }
                else if (Axe <= 9)
                {
                    Treasure.Name = "Hand Axe";
                    Treasure.Stat = "1d6, crit x3, 4 lbs., Medium, Slashing";
                    Treasure.GP = 20;
                }
                else if (Axe <= 12)
                {
                    int a = Dice.D(4) + Dice.D(4);
                    Treasure.Name = $"{a} Light Throwing Axes";
                    Treasure.Stat = "1d4, crit x2, Range 10 ft., 2 lb., Small, Piercing";
                    Treasure.GP = 3;
                    Treasure.Each = true;
                    Treasure.Amount = a;
                }
                else if (Axe <= 16)
                {
                    Treasure.Name = "Large Axe 2H";
                    Treasure.Stat = "2d4, crit x3, 12 lbs., Large, Slashing";
                    Treasure.GP = 100;
                }
                else if (Axe <= 18)
                {
                    Treasure.Name = "Double Axe";
                    Treasure.Stat = "1d8, crit x3, 7 lbs., Medium, Slashing";
                    Treasure.GP = 40;
                }
                else if (Axe <= 20)
                {
                    Treasure.Name = "Military Pick";
                    Treasure.Stat = "1d6, crit x4, 6 lbs., Medium, Piercing";
                    Treasure.GP = 40;
                }
                else if (Axe <= 22)
                {
                    Treasure.Name = "Broad Axe 2H";
                    Treasure.Stat = "1d12, crit x3, 15 lbs., Large, Slashing";
                    Treasure.GP = 200;
                }
                else if (Axe <= 25)
                {
                    Treasure.Name = "Heavy Battle Axe 2H";
                    Treasure.Stat = "2d6, crit x3, 15 lbs., Large, Slashing";
                    Treasure.GP = 250;
                }
                else if (Axe <= 29)
                {
                    int a = Dice.D(4) + Dice.D(4);
                    Treasure.Name = $"{a} Balanced Throwing Axes";
                    Treasure.Stat = "1d6, crit x2, Range 10 ft., 4 lb., Medium, Piercing";
                    Treasure.GP = 4;
                    Treasure.Each = true;
                    Treasure.Amount = a;
                }
                else if (Axe <= 33)
                {
                    Treasure.Name = "War Axe";
                    Treasure.Stat = "1d10, crit x3, 10 lbs., Medium, Slashing";
                    Treasure.GP = 100;
                }
                else if (Axe <= 35)
                {
                    Treasure.Name = "Great Axe 2H";
                    Treasure.Stat = "2d8, crit x3, 20 lbs., Large, Slashing";
                    Treasure.GP = 350;
                }
                else if (Axe >= 36)
                {
                    Treasure.Name = "Giant Axe 2H";
                    Treasure.Stat = "2d10, crit x3, 25 lbs., Large, Slashing";
                    Treasure.GP = 450;
                }
                Prefix_Dice = 60;
                Prefix_Mod = 25;
                Suffix_Dice = 60;
                Suffix_Mod = 25;
            }   //Axes
            if (56 <= Item_Roll && Item_Roll <= 63)
            {
                //Bows ---------------------------------------------------------------------------------------------------------------------------------
                int Bow = Dice.D(20) + CR;

                if (Bow <= 7)
                {
                    Treasure.Name = "Short Bow";
                    Treasure.Stat = "1d6, crit x3, Range 60 ft., 2 lbs., Medium, Piercing";
                    Treasure.GP = 30;
                }
                else if (Bow <= 10)
                {
                    Treasure.Name = "Hunters Bow";
                    Treasure.Stat = "1d6, crit x3, Range 70 ft., 2 lbs., Medium, Piercing";
                    Treasure.GP = 50;
                }
                else if (Bow <= 13)
                {
                    Treasure.Name = "Long Bow";
                    Treasure.Stat = "1d8, crit x3, Range 100 ft., 3 lbs., Large, Piercing";
                    Treasure.GP = 75;
                }
                else if (Bow <= 20)
                {
                    int a = Dice.D(8) + Dice.D(8) + Dice.D(8) + Dice.D(8);
                    Treasure.Name = $"{a} Arrows";
                    Treasure.Stat = "Damage as per bow";
                    Treasure.GP = 1;
                    Treasure.Each = true;
                    Treasure.Amount = a;
                }
                else if (Bow <= 23)
                {
                    Treasure.Name = "Composite Bow";
                    Treasure.Stat = "1d8, crit x3, Range 110 ft., 3 lbs., Large, Piercing";
                    Treasure.GP = 100;
                }
                else if (Bow <= 26)
                {
                    Treasure.Name = "Short Battle Bow";
                    Treasure.Stat = "1d6 (+1 Strength Bow), crit x3, Range 70 ft., 2 lbs., Medium, Piercing";
                    Treasure.GP = 150;
                }
                else if (Bow <= 29)
                {
                    Treasure.Name = "Short War Bow";
                    Treasure.Stat = "1d6 (+2 Strenght Bow), crit x4, Range 70 ft., 2 lbs., Medium, Piercing";
                    Treasure.GP = 200;
                }
                else if (Bow <= 32)
                {
                    Treasure.Name = "Long Battle Bow";
                    Treasure.Stat = "1d8 (+1 Strength Bow), crit x3, Range 1100 ft., 3 lbs., Large, Piercing";
                    Treasure.GP = 250;
                }
                else if (Bow <= 33)
                {
                    Treasure.Name = "Long War Bow";
                    Treasure.Stat = "1d8 (+2 Strenght Bow), crit x3, Range 110 ft., 3 lbs., Large, Piercing";
                    Treasure.GP = 300;
                }
                Prefix_Dice = 60;
                Prefix_Mod = 30;
                Suffix_Dice = 60;
                Suffix_Mod = 30;
            }   //Bows
            if (64 <= Item_Roll && Item_Roll <= 65)
            {
                //Crossbows ---------------------------------------------------------------------------------------------------------------------------------
                int Crossbow = Dice.D(20) + CR;

                if (Crossbow <= 5)
                {
                    int a = Dice.D(6) + Dice.D(6) + Dice.D(6);
                    Treasure.Name = $"{a} Bolts";
                    Treasure.Stat = "Damage as per crossbow";
                    Treasure.GP = 1;
                    Treasure.Each = true;
                    Treasure.Amount = a;
                }
                else if (Crossbow <= 17)
                {
                    Treasure.Name = "Light Crossbow";
                    Treasure.Stat = "1d8, crit 19-20/x3, Range 80 ft., 6 lbs., Small, Piercing";
                    Treasure.GP = 70;
                }
                else if (Crossbow <= 22)
                {
                    int a = Dice.D(6) + Dice.D(6) + Dice.D(6);
                    Treasure.Name = $"{a} Bolts";
                    Treasure.Stat = "Damage as per crossbow";
                    Treasure.GP = 1;
                    Treasure.Each = true;
                    Treasure.Amount = a;
                }
                else if (Crossbow <= 32)
                {
                    Treasure.Name = "Heavy Crossbow";
                    Treasure.Stat = "1d10, crit 19-20/x3, Range 120 ft., 9 lbs., Medium, Piercing";
                    Treasure.GP = 150;
                }
                else if (Crossbow <= 33)
                {
                    int a = Dice.D(6) + Dice.D(6) + Dice.D(6);
                    Treasure.Name = $"{a} Bolts";
                    Treasure.Stat = "Damage as per crossbow";
                    Treasure.GP = 1;
                    Treasure.Each = true;
                    Treasure.Amount = a;
                }
                Prefix_Dice = 60;
                Prefix_Mod = 30;
                Suffix_Dice = 60;
                Suffix_Mod = 30;
            }   //Crossbows
            if (66 <= Item_Roll && Item_Roll <= 70)
            {
                //Wands ---------------------------------------------------------------------------------------------------------------------------------
                int Wand = Dice.D(20) + CR;
                if (Wand <= 13)
                {
                    Treasure.Name = "Wand";
                    Treasure.Stat = "1d2, crit x2, 1 lbs., Small, Bludgeoning";
                    Treasure.GP = 10;
                }
                else if (Wand <= 20)
                {
                    Treasure.Name = "Bone Wand";
                    Treasure.Stat = "1d3, crit x2, 1 lbs., Small, Bludgeoning";
                    Treasure.GP = 30;
                }
                else if (Wand <= 25)
                {
                    Treasure.Name = "Yew Wand";
                    Treasure.Stat = "1d3, crit x2, 1 lbs., Small, Bludgeoning";
                    Treasure.GP = 60;
                }
                else if (Wand >= 26)
                {
                    Treasure.Name = "Grim Wand";
                    Treasure.Stat = "1d4, crit x2, 1 lbs., Small, Bludgeoning";
                    Treasure.GP = 100;
                }
                Prefix_Dice = 60;
                Prefix_Mod = 40;
                Suffix_Dice = 60;
                Suffix_Mod = 40;
            }   //Wands
            if (71 <= Item_Roll && Item_Roll <= 75)
            {
                //Staves ---------------------------------------------------------------------------------------------------------------------------------
                int Staff = Dice.D(20) + CR;

                if (Staff <= 10)
                {
                    Treasure.Name = "Short Staff";
                    Treasure.Stat = "1d4, crit x2, 3 lbs., Medium, Bludgeoning";
                    Treasure.GP = 10;
                }
                else if (Staff <= 19)
                {
                    Treasure.Name = "Long Staff";
                    Treasure.Stat = "1d6, crit x2, 6 lbs., Large, Bludgeoning";
                    Treasure.GP = 30;
                }
                else if (Staff <= 26)
                {
                    Treasure.Name = "Gnarled Staff";
                    Treasure.Stat = "1d8, crit x2, 6 lbs., Large, Bludgeoning";
                    Treasure.GP = 50;
                }
                else if (Staff <= 32)
                {
                    Treasure.Name = "Battle Staff";
                    Treasure.Stat = "2d4, crit x2, 6 lbs., Large, Bludgeoning";
                    Treasure.GP = 100;
                }
                else if (Staff >= 33)
                {
                    Treasure.Name = "War Staff";
                    Treasure.Stat = "1d10, crit x2, 10 lbs., Large, Bludgeoning";
                    Treasure.GP = 200;
                }
                Prefix_Dice = 60;
                Prefix_Mod = 40;
                Suffix_Dice = 60;
                Suffix_Mod = 40;
            }   //Staves
            if (76 <= Item_Roll && Item_Roll <= 79)
            {
                //Accessories ---------------------------------------------------------------------------------------------------------------------------------
                int Accessory = Dice.D(20) + CR;

                if (Accessory <= 6)
                {
                    Treasure.Name = "Charm";
                    Treasure.Stat = "Has its when carried person";
                    Treasure.GP = 50;
                }
                else if (Accessory <= 17)
                {
                    Treasure.Name = "Ring";
                    Treasure.Stat = "Worn on hand, one per hand";
                    Treasure.GP = 75;
                }
                else if (Accessory <= 18)
                {
                    Treasure.Name = "Flag";
                    Treasure.Stat = "Draped over body, One per character";
                    Treasure.GP = 100;
                }
                else if (Accessory <= 19)
                {
                    Treasure.Name = "Orb";
                    Treasure.Stat = "Worn on arm, one per character, can't use both shield and orb";
                    Treasure.GP = 150;
                }
                else if (Accessory >= 20)
                {
                    Treasure.Name = "Amulet";
                    Treasure.Stat = "Worn on neck, one per character";
                    Treasure.GP = 200;
                }
                Prefix_Dice = 40;
                Prefix_Mod = 30;
                Suffix_Dice = 40;
                Suffix_Mod = 30;
            }   //Accessories
            if (Item_Roll == 80)
            {
                //Gems ---------------------------------------------------------------------------------------------------------------------------------
                int Gem = Dice.D(20) + CR;

                if (Gem <= 7)
                {
                    Treasure.Name = "Chipped Jewel";
                    Treasure.Stat = smallItems.GemRoll();
                    Treasure.GP = 50;
                }
                else if (Gem <= 13)
                {
                    Treasure.Name = "Flawed Jewel";
                    Treasure.Stat = smallItems.GemRoll();
                    Treasure.GP = 100;
                }
                else if (Gem <= 19)
                {
                    Treasure.Name = "Jewel";
                    Treasure.Stat = smallItems.GemRoll();
                    Treasure.GP = 250;
                }
                else if (Gem <= 25)
                {
                    Treasure.Name = "Flawless Jewel";
                    Treasure.Stat = smallItems.GemRoll();
                    Treasure.GP = 500;
                }
                else if (Gem >= 26)
                {
                    Treasure.Name = "Perfect Jewel";
                    Treasure.Stat = smallItems.GemRoll();
                    Treasure.GP = 200;
                }
                Prefix_Dice = 40;
                Prefix_Mod = 30;
                Suffix_Dice = 40;
                Suffix_Mod = 30;
            }              //Gems
            if (81 <= Item_Roll && Item_Roll <= 90)
            {
                //Inscribed Spells ---------------------------------------------------------------------------------------------------------------------------------
                int s = Dice.D(20) + CR;

                if (s <= 17)
                {
                    Treasure.Name = "Scroll";
                    Treasure.Stat = "Can be read once to cast the spell, at minimum level necessart to cast spell";
                    Treasure.GP = 25;
                }
                else if (s <= 18)
                {
                    Treasure.Name = "Rune";
                    Treasure.Stat = "Set once as a trap, acts as aglpth of warding with the listed spell's effect";
                    Treasure.GP = 50;
                }
                else if (s >= 19)
                {
                    Treasure.Name = "Book";
                    Treasure.Stat = "Can be read once to gain the spell, or allows one improvement for its spell. First improvement is either +1 die of damage, +1 ability damage, or +2 points of healing. Second improvment is -2 save. Ignore improvements that don't apply.";
                    Treasure.GP = 100;
                }
                Prefix_Dice = -1;
                Suffix_Dice = 10;
                Suffix_Mod = 90;
            }   //Inscribed spells
            if (91 <= Item_Roll && Item_Roll <= 100) 
            {
                //Perishables
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
                    Treasure.Name = "Rejuvenation Potion";
                    Treasure.Stat = "Heals 4d8+7 points of damage, restores 4 previously cast spell levels";
                    Treasure.GP = 100;
                }
                else if (p <= 18)
                {
                    Treasure.Name = "Full Rejuvenation Potion";
                    Treasure.Stat = "Heals 8d8+15 points of damage, restores 8 previously cast spell levels";
                    Treasure.GP = 500;
                }
                else if (p <= 19)
                {
                    Treasure.Name = "Antidote";
                    Treasure.Stat = "Restores 1d4 ability points lost to poison";
                    Treasure.GP = 100;
                }
                else if (p <= 20)
                {
                    Treasure.Name = "Full Antidote";
                    Treasure.Stat = "Resotes all ability points lost to poison";
                    Treasure.GP = 500;
                }
                else if (p <= 21)
                {
                    Treasure.Name = "Stamina Potion";
                    Treasure.Stat = "Negates current fatigue";
                    Treasure.GP = 100;
                }
                else if (p <= 22)
                {
                    Treasure.Name = "Full Stamina Potion";
                    Treasure.Stat = "Negates current fatigue, immune to fatigue-causing factors for 10 minutes";
                    Treasure.GP = 500;
                }
                else if (p <= 23)
                {
                    Treasure.Name = "Restoration Potion";
                    Treasure.Stat = "Heals all damage, dispels mind-influencing effects";
                    Treasure.GP = 2500;
                }
                else if (p <= 24)
                {
                    Treasure.Name = "Oil";
                    Treasure.Stat = "1d6 fire damage, 1 point splash, 50% failure chance";
                    Treasure.GP = 1;
                }
                else if (p <= 25)
                {
                    Treasure.Name = "Explosive Potion";
                    Treasure.Stat = "3d6 points of damage, 1d6 splash";
                    Treasure.GP = 100;
                }
                else if (p <= 26)
                {
                    Treasure.Name = "Fulminating Potion";
                    Treasure.Stat = "1d6 points of acid damage, splash 1, burns 1d4 rounds";
                    Treasure.GP = 25;
                }
                else if (p <= 27)
                {
                    Treasure.Name = "Rancid Gas Potion";
                    Treasure.Stat = "Fort DC 15, if fail take 1d4 point of temp Con damage. If a second inhaling is done before recovering and failing the save, take 1d6 points of Temp Con Damage";
                    Treasure.GP = 50;
                }
                else if (p <= 28)
                {
                    Treasure.Name = "Choking Gas Potion";
                    Treasure.Stat = "Fort DC 12, if fail take 1 point of temp Con damage. If a second inhaling is done before recovering and failing the save, take 1d6 points of Temp Con Damage";
                    Treasure.GP = 100;
                }
                else if (p <= 29)
                {
                    Treasure.Name = "Strangling Gas Potion";
                    Treasure.Stat = "Fort DC 18, if fail take 2d4 points of temp Con damage. If a second inhaling is done before recovering and failing the save, take 2d4 points of Temp Con Damage";
                    Treasure.GP = 500;
                }
                else if (p <= 30)
                {
                    Treasure.Name = "Acidic Potion";
                    Treasure.Stat = "1d6 acid, splash 1";
                    Treasure.GP = 10;
                }
                else if (p <= 31)
                {
                    Treasure.Name = "Energizing Herb";
                    Treasure.Stat = "+2 Strength for 10 minutes";
                    Treasure.GP = 500;
                }
                else if (p <= 32)
                {
                    Treasure.Name = "Strengthing Herb";
                    Treasure.Stat = "+3 Strength for 10 minutes";
                    Treasure.GP = 1000;
                }
                else if (p <= 33)
                {
                    Treasure.Name = "Empowering Herb";
                    Treasure.Stat = "+4 Strength for 10 minutes";
                    Treasure.GP = 1500;
                }
                else if (p <= 34)
                {
                    Treasure.Name = "Artful Herb";
                    Treasure.Stat = "+2 Dexterity for 10 minutes";
                    Treasure.GP = 500;
                }
                else if (p <= 35)
                {
                    Treasure.Name = "Skillful Herb";
                    Treasure.Stat = "+3 Dexterity for 10 minutes";
                    Treasure.GP = 1000;
                }
                else if (p <= 36)
                {
                    Treasure.Name = "Adroit Herb";
                    Treasure.Stat = "+4 Strength for 10 minutes";
                    Treasure.GP = 1500;
                }
                else if (p <= 37)
                {
                    Treasure.Name = "Stalwart Herb";
                    Treasure.Stat = "+2 Constitution for 10 minutes";
                    Treasure.GP = 500;
                }
                else if (p <= 38)
                {
                    Treasure.Name = "Hardy Herb";
                    Treasure.Stat = "+3 Constitution for 10 minutes";
                    Treasure.GP = 1000;
                }
                else if (p <= 39)
                {
                    Treasure.Name = "Robust Herb";
                    Treasure.Stat = "+4 Constitution for 10 minutes";
                    Treasure.GP = 1500;
                }
                else if (p <= 40)
                {
                    Treasure.Name = "Sage Herb";
                    Treasure.Stat = "+2 Intelligence for 10 minutes";
                    Treasure.GP = 500;
                }
                else if (p <= 41)
                {
                    Treasure.Name = "Shrewd Herb";
                    Treasure.Stat = "+3 Intelligence for 10 minutes";
                    Treasure.GP = 1000;
                }
                else if (p <= 42)
                {
                    Treasure.Name = "Vivid Herb";
                    Treasure.Stat = "+4 Intelligence for 10 minutes";
                    Treasure.GP = 1500;
                }
                else if (p <= 43)
                {
                    Treasure.Name = "Indigo Herb";
                    Treasure.Stat = "+2 save vs cold, -1/4 cold damage for 10 minutes";
                    Treasure.GP = 1500;
                }
                else if (p <= 44)
                {
                    Treasure.Name = "Cerulean Herb";
                    Treasure.Stat = "+4 save vs cold, -1/2 cold damage for 10 minutes";
                    Treasure.GP = 2000;
                }
                else if (p <= 45)
                {
                    Treasure.Name = "Russet Herb";
                    Treasure.Stat = "+2 save vs fire, -1/4 fire damage for 10 minutes";
                    Treasure.GP = 1500;
                }
                else if (p <= 46)
                {
                    Treasure.Name = "Vermilion Herb";
                    Treasure.Stat = "+4 save vs fire, -1/2 fire damage for 10 minutes";
                    Treasure.GP = 2000;
                }
                else if (p <= 47)
                {
                    Treasure.Name = "Crackling Herb";
                    Treasure.Stat = "+2 save vs lightning, -1/4 lightning damage for 10 minutes";
                    Treasure.GP = 1500;
                }
                else if (p <= 48)
                {
                    Treasure.Name = "Forked Herb";
                    Treasure.Stat = "+4 save vs lightning, -1/2 lightning damage for 10 minutes";
                    Treasure.GP = 2000;
                }
                else if (p <= 49)
                {
                    Treasure.Name = "Swart Herb";
                    Treasure.Stat = "+2 save vs spell, -1/4 spell damage for 10 minutes";
                    Treasure.GP = 1500;
                }
                else if (p <= 50)
                {
                    Treasure.Name = "Artamentous Herb";
                    Treasure.Stat = "+4 save vs spell, -1/2 spell damage for 10 minutes";
                    Treasure.GP = 2000;
                }
                else if (p <= 51)
                {
                    Treasure.Name = "Vital Herb";
                    Treasure.Stat = "+2 save vs Poison, no initial damage, last for 10 minutes";
                    Treasure.GP = 1500;
                }
                else if (p <= 52)
                {
                    Treasure.Name = "Enduring Herb";
                    Treasure.Stat = "+4 save vs Poison, no secondary damage, last for 10 minutes";
                    Treasure.GP = 2000;
                }
                else if (p <= 53)
                {
                    Treasure.Name = "Urgent Herb";
                    Treasure.Stat = "+2 speed initiative bonus for 10 minutes";
                    Treasure.GP = 500;
                }
                else if (p <= 54)
                {
                    Treasure.Name = "Fleet Herb";
                    Treasure.Stat = "+4 speed initiative bonus for 10 minutes";
                    Treasure.GP = 1000;
                }
                else if (p <= 55)
                {
                    Treasure.Name = "Brisk Herb";
                    Treasure.Stat = "+10 ft. speed bonus to move for 10 minutes";
                    Treasure.GP = 500;
                }
                else if (p <= 56)
                {
                    Treasure.Name = "Swift Herb";
                    Treasure.Stat = "+20 ft. speed bonus to move for 10 minutes";
                    Treasure.GP = 1000;
                }
                else if (p <= 57)
                {
                    Treasure.Name = "Dazzling Herb";
                    Treasure.Stat = "+1 1st level spell, cast within 10 minutes (spellcaster only)";
                    Treasure.GP = 500;
                }
                else if (p <= 58)
                {
                    Treasure.Name = "Fascinating Herb";
                    Treasure.Stat = "+1 2nd level spell, cast within 10 minutes (spellcaster only)";
                    Treasure.GP = 1000;
                }
                else if (p <= 59)
                {
                    Treasure.Name = "Bright Herb";
                    Treasure.Stat = "Bonus hit points, +50% of current for 10 minutes";
                    Treasure.GP = 500;
                }
                else if (p <= 60)
                {
                    Treasure.Name = "Solar Herb";
                    Treasure.Stat = "Bonus hit points, +100% of current for 10 minutes";
                    Treasure.GP = 1000;
                }
                else if (p <= 61)
                {
                    Treasure.Name = "Omniscient Herb";
                    Treasure.Stat = "+1 Intelligence for 10 minutes";
                    Treasure.GP = 500;
                }
                else if (p <= 62)
                {
                    Treasure.Name = "Mystical Herb";
                    Treasure.Stat = "All spell duration +50% if cast within 10 minutes";
                    Treasure.GP = 1500;
                }
                else if (p <= 63)
                {
                    Treasure.Name = "Arcane Herb";
                    Treasure.Stat = "All spell duration +50% if cast within 10 minutes";
                    Treasure.GP = 2000;
                }
                else if (p <= 65)
                {
                    Treasure.Name = "Strength Elixir";
                    Treasure.Stat = "+2 Strength for one day";
                    Treasure.GP = 5000;
                }
                else if (p <= 67)
                {
                    Treasure.Name = "Dexerity Elixir";
                    Treasure.Stat = "+2 Dexerity for one day";
                    Treasure.GP = 5000;
                }
                else if (p <= 69)
                {
                    Treasure.Name = "Vitality Elixir";
                    Treasure.Stat = "+2 Constitution for one day";
                    Treasure.GP = 5000;
                }
                else if (p <= 70)
                {
                    Treasure.Name = "Intelligence Elixir";
                    Treasure.Stat = "+2 Intelligence for one day";
                    Treasure.GP = 5000;
                }
                else if (p <= 71)
                {
                    Treasure.Name = "Chi Elixir";
                    Treasure.Stat = "+2 Wisdom for one day";
                    Treasure.GP = 5000;
                }
                else if (p <= 72)
                {
                    Treasure.Name = "Spectral Elixir";
                    Treasure.Stat = "+2 to all abilitie scores for one day";
                    Treasure.GP = 15000;
                }
                else if (p <= 73)
                {
                    Treasure.Name = "Fire Elixir";
                    Treasure.Stat = "+2 save vs. fire for one day";
                    Treasure.GP = 2500;
                }
                else if (p <= 74)
                {
                    Treasure.Name = "Ice Elixir";
                    Treasure.Stat = "+2 save vs. ice for one day";
                    Treasure.GP = 2500;
                }
                else if (p <= 75)
                {
                    Treasure.Name = "Lightning Elixir";
                    Treasure.Stat = "+2 save vs. lightning for one day";
                    Treasure.GP = 2500;
                }
                else if (p <= 76)
                {
                    Treasure.Name = "Magic Elixir";
                    Treasure.Stat = "+2 save vs. spell for one day";
                    Treasure.GP = 2500;
                }
                else if (p <= 77)
                {
                    Treasure.Name = "Psionic Elixir";
                    Treasure.Stat = "+2 save vs. mind-influencing effects for one day";
                    Treasure.GP = 2500;
                }
                else if (p <= 78)
                {
                    Treasure.Name = "Posion Elixir";
                    Treasure.Stat = "+2 save vs. posion for one day";
                    Treasure.GP = 2500;
                }
                else if (p <= 79)
                {
                    Treasure.Name = "Energy Elixir";
                    Treasure.Stat = "+2 all saves for one day";
                    Treasure.GP = 2500;
                }
                else if (p <= 80)
                {
                    Treasure.Name = "Accuracy Elixir";
                    Treasure.Stat = "+2 attack for one day";
                    Treasure.GP = 2500;
                }
                else if (p <= 81)
                {
                    Treasure.Name = "Damage Elixir";
                    Treasure.Stat = "+2 damage for one day";
                    Treasure.GP = 2500;
                }
                else if (p <= 82)
                {
                    Treasure.Name = "Defense Elixir";
                    Treasure.Stat = "+1 AC for one day";
                    Treasure.GP = 2500;
                }
                else if (p <= 83)
                {
                    Treasure.Name = "Life Elixir";
                    Treasure.Stat = "+5 to maximum hit points for one day";
                    Treasure.GP = 2500;
                }
                else if (p <= 84)
                {
                    Treasure.Name = "Power Elixir";
                    Treasure.Stat = "+0 1st-level spell slot (spellcaster only) for one day";
                    Treasure.GP = 2500;
                }
                else if (p <= 85)
                {
                    OOR = smallItems.OilOrResin();
                    if (OOR)
                    {
                        Treasure.Name = "Accuracy Resin";
                        Treasure.Stat = "+2 attack for 10 arrows for 10 minutes";
                        Treasure.GP = 1000;
                    }
                    Treasure.Name = "Accuracy Oil";
                    Treasure.Stat = "+2 attack for 1 weapon for 10 minutes";
                    Treasure.GP = 1000;
                }
                else if (p <= 86)
                {
                    OOR = smallItems.OilOrResin();
                    if (OOR)
                    {
                        Treasure.Name = "Precision Resin";
                        Treasure.Stat = "+3 attack for 10 arrows for 10 minutes";
                        Treasure.GP = 1500;
                    }
                    Treasure.Name = "Precision Oil";
                    Treasure.Stat = "+3 attack for 1 weapon for 10 minutes";
                    Treasure.GP = 1500;
                }
                else if (p <= 87)
                {
                    OOR = smallItems.OilOrResin();
                    if (OOR)
                    {
                        Treasure.Name = "Mastery Resin";
                        Treasure.Stat = "+4 attack for 10 arrows for 10 minutes";
                        Treasure.GP = 2000;
                    }
                    Treasure.Name = "Mastery Oil";
                    Treasure.Stat = "+4 attack for 1 weapon for 10 minutes";
                    Treasure.GP = 2000;
                }
                else if (p <= 88)
                {
                    OOR = smallItems.OilOrResin();
                    if (OOR)
                    {
                        Treasure.Name = "Sharpness Resin";
                        Treasure.Stat = "+2 damage for 10 arrows for 10 minutes";
                        Treasure.GP = 1000;
                    }
                    Treasure.Name = "Sharpness Oil";
                    Treasure.Stat = "+2 damage for 1 weapon for 10 minutes";
                    Treasure.GP = 1000;
                }
                else if (p <= 89)
                {
                    OOR = smallItems.OilOrResin();
                    if (OOR)
                    {
                        Treasure.Name = "Pain Resin";
                        Treasure.Stat = "+3 damage for 10 arrows for 10 minutes";
                        Treasure.GP = 1500;
                    }
                    Treasure.Name = "Pain Oil";
                    Treasure.Stat = "+3 damage for 1 weapon for 10 minutes";
                    Treasure.GP = 1500;
                }
                else if (p <= 90)
                {
                    OOR = smallItems.OilOrResin();
                    if (OOR)
                    {
                        Treasure.Name = "Savagery Resin";
                        Treasure.Stat = "+4 damage for 10 arrows for 10 minutes";
                        Treasure.GP = 2000;
                    }
                    Treasure.Name = "Savagery Oil";
                    Treasure.Stat = "+4 damage for 1 weapon for 10 minutes";
                    Treasure.GP = 2000;
                }
                else if (p <= 91)
                {
                    OOR = smallItems.OilOrResin();
                    if (OOR)
                    {
                        Treasure.Name = "Death Resin";
                        Treasure.Stat = "+5 damage for 10 arrows for 10 minutes";
                        Treasure.GP = 2000;
                    }
                    Treasure.Name = "Death Oil";
                    Treasure.Stat = "+5 damage for 1 weapon for 10 minutes";
                    Treasure.GP = 2500;
                }
                else if (p <= 92)
                {
                    Treasure.Name = "Hardening Oil";
                    Treasure.Stat = "anointed weapon give +2 AC for 10 minutes";
                    Treasure.GP = 1000;
                }
                else if (p <= 93)
                {
                    Treasure.Name = "Imperviousness Oil";
                    Treasure.Stat = "anointed weapon give +3 AC for 10 minutes";
                    Treasure.GP = 1500;
                }
                else if (p <= 94)
                {
                    Treasure.Name = "Immunity Oil";
                    Treasure.Stat = "anointed weapon give +4 AC for 10 minutes";
                    Treasure.GP = 2000;
                }
                else if (p <= 95)
                {
                    Treasure.Name = "Skill Oil";
                    Treasure.Stat = "Gains proficienct for this weapon for 10 minutes";
                    Treasure.GP = 1000;
                }
                else if (p <= 96)
                {
                    Treasure.Name = "Fortitude Oil";
                    Treasure.Stat = "Repairs all damage for one item";
                    Treasure.GP = 1000;
                }
                else if (p <= 97)
                {
                    Treasure.Name = "Blacksmith's Oil";
                    Treasure.Stat = "Item gains +5 hardness for 10 minutes";
                    Treasure.GP = 1500;
                }
                else if (p <= 98)
                {
                    Treasure.Name = "Permanence Oil";
                    Treasure.Stat = "Weapon becomes indestructible for one day";
                    Treasure.GP = 3000;
                }
                else if (p <= 99)
                {
                    Treasure.Name = "Enchantment Oil";
                    Treasure.Stat = "Weapon type permantly changed (roll 1d20+40 on Base Item table)";
                    Treasure.GP = 3500;
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
                        Treasure.Stat = stat;
                    }
                    else
                    {
                        //Monster Part
                        int part = Dice.D(12);
                        {
                            if (part == 1)
                            {
                                Treasure.Name = "Heart";
                            }
                            if (part == 2)
                            {
                                Treasure.Name = "Brain";
                            }
                            if (part == 3)
                            {
                                Treasure.Name = "Jawbone";
                            }
                            if (part == 4)
                            {
                                Treasure.Name = "Eye";
                            }
                            if (part == 5)
                            {
                                Treasure.Name = "Ear";
                            }
                            if (part == 6)
                            {
                                Treasure.Name = "Horn";
                            }
                            if (part == 7)
                            {
                                Treasure.Name = "Tail";
                            }
                            if (part == 8)
                            {
                                Treasure.Name = "Fang";
                            }
                            if (part == 9)
                            {
                                Treasure.Name = "Quill";
                            }
                            if (part == 10)
                            {
                                Treasure.Name = "Scalp";
                            }
                            if (part == 11)
                            {
                                Treasure.Name = "Spleen";
                            }
                            if (part == 12)
                            {
                                Treasure.Name = "Soul";
                            }
                        }
                        item get = new item();
                        get = Item(99, "perishable", CR);
                        Treasure.Stat = get.Stat;
                        Treasure.GP = 0;
                    }
                }
                Prefix_Dice =  -1;
                Suffix_Dice = -1;
            } //Perishables
            if (!(q == "none") && !(q == "perishable"))
            {
                pre pre = new pre();
                suf suf = new suf();
                if (q == "Prefix")
                {
                    pre = prefix.Prefixes(Prefix_Dice, Prefix_Mod, CR);
                }
                if (q == "Suffix")
                {
                    suf = suffix.Suffixes(Suffix_Dice, Suffix_Mod, CR);
                }
                if (q == "PrefixNSuffix")
                {
                    pre = prefix.Prefixes(Prefix_Dice, Prefix_Mod, CR);
                    suf = suffix.Suffixes(Suffix_Dice, Suffix_Mod, CR);
                }
                Treasure.PrefixName = pre.PrefixName;
                Treasure.PrefixStat = pre.PrefixStat;
                Treasure.PrefixGP = pre.PrefixGP;
                Treasure.rolls.AddRange(pre.rolls);

                Treasure.SuffixName = suf.SuffixName;
                Treasure.SuffixStat = suf.SuffixStat;
                Treasure.SuffixGP = suf.SuffixGP;
                Treasure.rolls.AddRange(suf.rolls);
            }

            Treasure.rolls = Dice.rolls;
            return Treasure;
        }
    }
}