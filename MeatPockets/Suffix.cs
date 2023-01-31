using ClassLibaray;

namespace Suffix
{
    class suffix
    {
        public static DiceRoll Dice = new DiceRoll();
        public static suf Suffixes(int Suffix_Dice, int Suffix_Mod, int CR)
        {
            suf suf = new suf();
            if (Suffix_Dice == -1)
            {
                return suf;
            }
            int Suffix_Roll = Dice.D(Suffix_Dice) + Suffix_Mod;
            
            if (Suffix_Roll <= 20)
            {
                //Reduces damage taken
                int reduce = Dice.D(20) + CR;
                if (reduce <= 11)
                {
                    suf.SuffixName = "of Health";
                    suf.SuffixStat = "-1 point of damage taken from each attack";
                    suf.SuffixGP = 2500;
                }
                else if (reduce <= 17)
                {
                    suf.SuffixName = "of Protection";
                    suf.SuffixStat = "-2 point of damage taken from each attack";
                    suf.SuffixGP = 5000;
                }
                else if (reduce <= 22)
                {
                    suf.SuffixName = "of Absorption";
                    suf.SuffixStat = "-3 point of damage taken from each attack";
                    suf.SuffixGP = 7500;
                }
                else if (reduce <= 26)
                {
                    suf.SuffixName = "of Life";
                    suf.SuffixStat = "-4 point of damage taken from each attack";
                    suf.SuffixGP = 10000;
                }
                else if (reduce > 26)
                {
                    suf.SuffixName = "of Deflection";
                    suf.SuffixStat = "-5 point of damage taken from each attack";
                    suf.SuffixGP = 12500;
                }

            } //Reduces damage taken
            else if (Suffix_Roll <= 25)
            {
                //Has an effect when attacked
                int effect = Dice.D(20) + CR;
                if (effect <= 10)
                {
                    suf.SuffixName = "of Thorns";
                    suf.SuffixStat = "Successful melee attacks againt the wearer deal 1d4 points of damage to the attacker";
                    suf.SuffixGP = 5000;
                }
                else if (effect <= 18)
                {
                    suf.SuffixName = "of Spikes";
                    suf.SuffixStat = "Successful melee attacks againt the wearer deal 2d4 points of damage to the attacker";
                    suf.SuffixGP = 7500;
                }
                else if (effect > 18)
                {
                    suf.SuffixName = "of Blocking";
                    suf.SuffixStat = "+2 AC when attacking; +4 AC when not attacking";
                    suf.SuffixGP = 10000;
                }

            } //Has an effect when attacked
            else if (Suffix_Roll <= 27)
            {
                //Improved durability
                int durability = Dice.D(20) + CR;
                if (durability <= 10)
                {
                    suf.SuffixName = "of Sturdness";
                    suf.SuffixStat = "Items gain +3 hardness, +6 Dur.";
                    suf.SuffixGP = 2500;
                }
                else if (durability <= 14)
                {
                    suf.SuffixName = "of Structures";
                    suf.SuffixStat = "Items gain +5 hardness, +12 Dur.";
                    suf.SuffixGP = 5000;
                }
                else if (durability <= 17)
                {
                    suf.SuffixName = "of the Ages";
                    suf.SuffixStat = "Item cannot carried be damaged or destoyed";
                    suf.SuffixGP = 7500;
                }
                else if (durability <= 19)
                {
                    suf.SuffixName = "of Bonding";
                    suf.SuffixStat = "All items carried gain +3 hardness rating, +6 Dur.";
                    suf.SuffixGP = 7500;
                }
                else if (durability > 19)
                {
                    suf.SuffixName = "of Unity";
                    suf.SuffixStat = "All items carried gain +5 hardness rating, +12 Dur.";
                    suf.SuffixGP = 10000;
                }

            } //Improved durability
            else if (Suffix_Roll <= 30)
            {
                //Affects movement
                int movement = Dice.D(20) + CR;
                if (movement <= 8)
                {
                    suf.SuffixName = "of Pacing";
                    suf.SuffixStat = "+50% Move";
                    suf.SuffixGP = 2000;
                }
                else if (movement <= 10)
                {
                    suf.SuffixName = "of the Horse";
                    suf.SuffixStat = "Halve all exhaustion penalties from movements";
                    suf.SuffixGP = 3000;
                }
                else if (movement <= 14)
                {
                    suf.SuffixName = "of the Ox";
                    suf.SuffixStat = "Running doesn't cause exhaustion";
                    suf.SuffixGP = 5000;
                }
                else if (movement <= 19)
                {
                    suf.SuffixName = "of Speed";
                    suf.SuffixStat = "+100% move, +2 dodge bonus, can't be caught flat-footed";
                    suf.SuffixGP = 10000;
                }
                else if (movement > 19)
                {
                    suf.SuffixName = "of Haste";
                    suf.SuffixStat = "+150% move, +4 dodge bonus, 1 extra partial action per round";
                    suf.SuffixGP = 15000;
                }

            } //Affects movement
            else if (Suffix_Roll <= 35)
            {
                //Increases hit points
                int HP = Dice.D(20) + CR;
                if (HP <= 8)
                {
                    suf.SuffixName = "of the Jackal";
                    suf.SuffixStat = "+4 hit points";
                    suf.SuffixGP = 2500;
                }
                else if (HP <= 13)
                {
                    suf.SuffixName = "of the Fox";
                    suf.SuffixStat = "+6 hit points";
                    suf.SuffixGP = 5000;
                }
                else if (HP <= 17)
                {
                    suf.SuffixName = "of the Jaguar";
                    suf.SuffixStat = "+8 hit points";
                    suf.SuffixGP = 7500;
                }
                else if (HP <= 21)
                {
                    suf.SuffixName = "of the Wold";
                    suf.SuffixStat = "+10 hit points";
                    suf.SuffixGP = 10000;
                }
                else if (HP <= 23)
                {
                    suf.SuffixName = "of the Eagle";
                    suf.SuffixStat = "+12 hit points";
                    suf.SuffixGP = 1250;
                }
                else if (HP <= 25)
                {
                    suf.SuffixName = "of the Tiger";
                    suf.SuffixStat = "+15 hit points";
                    suf.SuffixGP = 15000;
                }
                else if (HP <= 27)
                {
                    suf.SuffixName = "of the Lion";
                    suf.SuffixStat = "+18 hit points";
                    suf.SuffixGP = 17500;
                }
                else if (HP <= 29)
                {
                    suf.SuffixName = "of the Mammoth";
                    suf.SuffixStat = "+20 hit points";
                    suf.SuffixGP = 20000;
                }
                else if (HP <= 31)
                {
                    suf.SuffixName = "of the Whale";
                    suf.SuffixStat = "+25 hit points";
                    suf.SuffixGP = 22500;
                }
                else if (HP > 31)
                {
                    suf.SuffixName = "of the Colossus";
                    suf.SuffixStat = "+30 hit points";
                    suf.SuffixGP = 25000;
                }

            } //Increases hit points
            else if (Suffix_Roll <= 45)
            {
                //Increases ability scores
                int ability = Dice.D(20) + CR;
                if (ability <= 2)
                {
                    suf.SuffixName = "of Vitality";
                    suf.SuffixStat = "+1 Constitution";
                    suf.SuffixGP = 2500;
                }
                else if (ability <= 4)
                {
                    suf.SuffixName = "of Dexterity";
                    suf.SuffixStat = "+1 Dexterity";
                    suf.SuffixGP = 2500;
                }
                else if (ability <= 6)
                {
                    suf.SuffixName = "of Energy";
                    suf.SuffixStat = "+1 Intelligence";
                    suf.SuffixGP = 2500;
                }
                else if (ability <= 8)
                {
                    suf.SuffixName = "of Strength";
                    suf.SuffixStat = "+1 Strength";
                    suf.SuffixGP = 2500;
                }
                else if (ability <= 10)
                {
                    suf.SuffixName = "of the Lynx";
                    suf.SuffixStat = "+1 Wisdom";
                    suf.SuffixGP = 2500;
                }
                else if (ability <= 12)
                {
                    suf.SuffixName = "of Zest";
                    suf.SuffixStat = "+2 Constitution";
                    suf.SuffixGP = 5000;
                }
                else if (ability <= 14)
                {
                    suf.SuffixName = "of Skill";
                    suf.SuffixStat = "+2 Dexterity";
                    suf.SuffixGP = 5000;
                }
                else if (ability <= 16)
                {
                    suf.SuffixName = "of Mind";
                    suf.SuffixStat = "+2 Intelligence";
                    suf.SuffixGP = 5000;
                }
                else if (ability <= 18)
                {
                    suf.SuffixName = "of Might";
                    suf.SuffixStat = "+2 Strength";
                    suf.SuffixGP = 5000;
                }
                else if (ability <= 20)
                {
                    suf.SuffixName = "of the Leopard";
                    suf.SuffixStat = "+2 Wisdom";
                    suf.SuffixGP = 5000;
                }
                else if (ability == 21)
                {
                    suf.SuffixName = "of Vim";
                    suf.SuffixStat = "+3 Constitution";
                    suf.SuffixGP = 7500;
                }
                else if (ability == 22)
                {
                    suf.SuffixName = "of Accuracy";
                    suf.SuffixStat = "+3 Dexterity";
                    suf.SuffixGP = 7500;
                }
                else if (ability == 23)
                {
                    suf.SuffixName = "of Brillance";
                    suf.SuffixStat = "+3 Intelligence";
                    suf.SuffixGP = 7500;
                }
                else if (ability == 24)
                {
                    suf.SuffixName = "of Power";
                    suf.SuffixStat = "+3 Strength";
                    suf.SuffixGP = 7500;
                }
                else if (ability == 25)
                {
                    suf.SuffixName = "of the Jaguar";
                    suf.SuffixStat = "+3 Wisdom";
                    suf.SuffixGP = 7500;
                }
                else if (ability == 26)
                {
                    suf.SuffixName = "of Vigor";
                    suf.SuffixStat = "+4 Constitution";
                    suf.SuffixGP = 10000;
                }
                else if (ability == 27)
                {
                    suf.SuffixName = "of Precision";
                    suf.SuffixStat = "+4 Dexterity";
                    suf.SuffixGP = 10000;
                }
                else if (ability == 28)
                {
                    suf.SuffixName = "of Sorcery";
                    suf.SuffixStat = "+4 Intelligence";
                    suf.SuffixGP = 10000;
                }
                else if (ability == 29)
                {
                    suf.SuffixName = "of the Giant";
                    suf.SuffixStat = "+4 Strength";
                    suf.SuffixGP = 10000;
                }
                else if (ability == 30)
                {
                    suf.SuffixName = "of the Tiger";
                    suf.SuffixStat = "+4 Wisdom";
                    suf.SuffixGP = 10000;
                }
                else if (ability == 31)
                {
                    suf.SuffixName = "of Life";
                    suf.SuffixStat = "+5 Constitution";
                    suf.SuffixGP = 12500;
                }
                else if (ability == 32)
                {
                    suf.SuffixName = "of Perfection";
                    suf.SuffixStat = "+5 Dexterity";
                    suf.SuffixGP = 12500;
                }
                else if (ability == 33)
                {
                    suf.SuffixName = "of Wizardy";
                    suf.SuffixStat = "+5 Intelligence";
                    suf.SuffixGP = 12500;
                }
                else if (ability == 34)
                {
                    suf.SuffixName = "of the Titan";
                    suf.SuffixStat = "+5 Strength";
                    suf.SuffixGP = 12500;
                }
                else if (ability == 35)
                {
                    suf.SuffixName = "of the Lion";
                    suf.SuffixStat = "+5 Wisdom";
                    suf.SuffixGP = 12500;
                }
                else if (ability == 36)
                {
                    suf.SuffixName = "of the Sky";
                    suf.SuffixStat = "+1 to all ability scores";
                    suf.SuffixGP = 15000;
                }
                else if (ability == 37)
                {
                    suf.SuffixName = "of the Moon";
                    suf.SuffixStat = "+2 to all ability scores";
                    suf.SuffixGP = 20000;
                }
                else if (ability == 38)
                {
                    suf.SuffixName = "of the Stars";
                    suf.SuffixStat = "+3 to all ability scores";
                    suf.SuffixGP = 30000;
                }
                else if (ability == 39)
                {
                    suf.SuffixName = "of the Heavens";
                    suf.SuffixStat = "+4 to all ability scores";
                    suf.SuffixGP = 40000;
                }
                else if (ability == 40)
                {
                    suf.SuffixName = "of the Zodiac";
                    suf.SuffixStat = "+5 to all ability scores";
                    suf.SuffixGP = 50000;
                }

            } //Increases ability scores
            else if (Suffix_Roll <= 49)
            {
                //Cursed
                int curse = Dice.D(Suffix_Dice) + Suffix_Mod;
                if (curse <= 15)
                {
                    suf.SuffixName = "of Tears";
                    suf.SuffixStat = "+1 point of damage taken with each attack";
                    suf.SuffixGP = 1;
                }
                else if (curse <= 25)
                {
                    suf.SuffixName = "of Pain";
                    suf.SuffixStat = "+2 points of damage taken each attack";
                    suf.SuffixGP = 1;
                }
                else if (curse <= 27)
                {
                    suf.SuffixName = "of Brittleness";
                    suf.SuffixStat = "Item's usaul hardness reduced to 0";
                    suf.SuffixGP = 1;
                }
                else if (curse <= 29)
                {
                    suf.SuffixName = "of Decay";
                    suf.SuffixStat = "+2 damage. item's usual hardness rating reduced to 0";
                    suf.SuffixGP = 1;
                }
                else if (curse <= 30)
                {
                    suf.SuffixName = "of Fragility";
                    suf.SuffixStat = "one first use in combat, item is destroyed";
                    suf.SuffixGP = 1;
                }
                else if (curse <= 40)
                {
                    suf.SuffixName = "of the Vulture";
                    suf.SuffixStat = Dice.D(6) +" hit points";
                    suf.SuffixGP = 1;
                }
                else if (curse <= 42)
                {
                    suf.SuffixName = "of Disease";
                    suf.SuffixStat = "-1 Constitution";
                    suf.SuffixGP = 1;
                }
                else if (curse <= 44)
                {
                    suf.SuffixName = "of Atrophy";
                    suf.SuffixStat = "-1 Dexterity";
                    suf.SuffixGP = 1;
                }
                else if (curse <= 46)
                {
                    suf.SuffixName = "of Dyslexia";
                    suf.SuffixStat = "-1 Intelligence";
                    suf.SuffixGP = 1;
                }
                else if (curse <= 48)
                {
                    suf.SuffixName = "of Weakness";
                    suf.SuffixStat = "-1 Strength";
                    suf.SuffixGP = 1;
                }
                else if (curse <= 50)
                {
                    suf.SuffixName = "of the Cat";
                    suf.SuffixStat = "-1 Wisdom";
                    suf.SuffixGP = 1;
                }
                else if (curse <= 51)
                {
                    suf.SuffixName = "of the Pit";
                    suf.SuffixStat = "-1 all ability scores";
                    suf.SuffixGP = 1;
                }
                else if (curse <= 52)
                {
                    suf.SuffixName = "of the Illness";
                    suf.SuffixStat = "-2 Constitution";
                    suf.SuffixGP = 1;
                }
                else if (curse <= 53)
                {
                    suf.SuffixName = "of Paralysis";
                    suf.SuffixStat = "-2 Dexterity";
                    suf.SuffixGP = 1;
                }
                else if (curse <= 54)
                {
                    suf.SuffixName = "of Draining";
                    suf.SuffixStat = "-2 Intelligence";
                    suf.SuffixGP = 1;
                }
                else if (curse <= 55)
                {
                    suf.SuffixName = "of Frailty";
                    suf.SuffixStat = "-2 Strength";
                    suf.SuffixGP = 1;
                }
                else if (curse <= 56)
                {
                    suf.SuffixName = "of the Rat";
                    suf.SuffixStat = "-2 Wisdom";
                    suf.SuffixGP = 1;
                }
                else if (curse <= 57)
                {
                    suf.SuffixName = "of Trouble";
                    suf.SuffixStat = "-2 to all ability scores";
                    suf.SuffixGP = 1;
                }
                else if (curse <= 58)
                {
                    suf.SuffixName = "of Pox";
                    suf.SuffixStat = "Owner cannot regain hit points while item is carried";
                    suf.SuffixGP = 1;
                }
                else if (curse <= 59)
                {
                    suf.SuffixName = "of Corruption";
                    suf.SuffixStat = "Owner cannot restore cast spells whiel item is carried";
                    suf.SuffixGP = 1;
                }
                else if (curse <= 60)
                {
                    suf.SuffixName = "of Infection";
                    suf.SuffixStat = "Spells that affect the user's mind last until dispelled";
                    suf.SuffixGP = 1;
                }
                else if (curse <= 61)
                {
                    suf.SuffixName = "of Ruin";
                    suf.SuffixStat = "1 spell per day must be prepared as if 1 level higher";
                    suf.SuffixGP = 1;
                }
                else if (curse <= 62)
                {
                    suf.SuffixName = "of Exposed";
                    suf.SuffixStat = "2 spell per day must be prepared as if 1 level higher";
                    suf.SuffixGP = 1;
                }
                else if (curse <= 64)
                {
                    suf.SuffixName = "of Discord";
                    suf.SuffixStat = "Spells cast in one action now take a full round";
                    suf.SuffixGP = 1;
                }
                else if (curse <= 67)
                {
                    suf.SuffixName = "of the Night";
                    suf.SuffixStat = "Any light source carried by user has a -10 ft. radius";
                    suf.SuffixGP = 1;
                }
                else if (curse <= 69)
                {
                    suf.SuffixName = "of the Dark";
                    suf.SuffixStat = "Any light source carried by user has a -20 ft. radius";
                    suf.SuffixGP = 1;
                }
                else if (curse <= 70)
                {
                    suf.SuffixName = "of the Void";
                    suf.SuffixStat = "Any light source carried by user -30 ft. radius";
                    suf.SuffixGP = 1;
                }
                else if (curse <= 80)
                {
                    suf.SuffixName = "of Passivity";
                    suf.SuffixStat = "-4 penalty when attacking with this item";
                    suf.SuffixGP = 1;
                }
                else if (curse <= 90)
                {
                    suf.SuffixName = "of the Snail";
                    suf.SuffixStat = "User attacks once per two rounds when using this item";
                    suf.SuffixGP = 1;
                }
                else if (curse > 90)
                {
                    suf.SuffixName = "of the Fool";
                    suf.SuffixStat = "One random spell per day vanishes after spell prepared";
                    suf.SuffixGP = 1;
                }

            } //Cursed
            else if (Suffix_Roll <= 53)
            {
                //Improves recovery
                int recovery = Dice.D(20) + CR;
                if (recovery <= 15)
                {
                    suf.SuffixName = "of Regeneration";
                    suf.SuffixStat = "User regains 1 lost hit point per round";
                    suf.SuffixGP = 10000;
                }
                else if (recovery > 15)
                {
                    suf.SuffixName = "of Regrowth";
                    suf.SuffixStat = "User regains 1 temporary ability damage per 10 minutes";
                    suf.SuffixGP = 17500;
                }

            } //Improves recovery
            else if (Suffix_Roll <= 56)
            {
                //Affects spell preparation
                int preparation = Dice.D(20) + CR;
                if (preparation <= 10)
                {
                    suf.SuffixName = "of Warding";
                    suf.SuffixStat = "1 spell per day prepared as if 1 level lower";
                    suf.SuffixGP = 5000;
                }
                else if (preparation <= 22)
                {
                    suf.SuffixName = "of the Sentinel";
                    suf.SuffixStat = "2 spells per day prepared as if each 1 level lower";
                    suf.SuffixGP = 7500;
                }
                else if (preparation <= 28)
                {
                    suf.SuffixName = "of Guarding";
                    suf.SuffixStat = "3 spells per day prepared as if each 1 level lower";
                    suf.SuffixGP = 10000;
                }
                else if (preparation <= 34)
                {
                    suf.SuffixName = "of Negation";
                    suf.SuffixStat = "4 spells per day prepared as if each 1 level lower";
                    suf.SuffixGP = 12500;
                }
                else if (preparation > 34)
                {
                    suf.SuffixName = "of the Sentinel";
                    suf.SuffixStat = "5 spells per day prepared as if each 1 level lower";
                    suf.SuffixGP = 15000;
                }

            } //Affects spell preparation
            else if (Suffix_Roll <= 60)
            {
                //Affects spell casting in combat
                int casting = Dice.D(20) + CR;
                if (casting <= 9)
                {
                    suf.SuffixName = "of the Apprentice";
                    suf.SuffixStat = "+2 enhancement bonus to Concentration skill checks";
                    suf.SuffixGP = 2500;
                }
                else if (casting <= 13)
                {
                    suf.SuffixName = "of the Magus";
                    suf.SuffixStat = "+4 enhancement bonus to Concentration skill checks";
                    suf.SuffixGP = 5000;
                }
                else if (casting <= 16)
                {
                    suf.SuffixName = "of Balance";
                    suf.SuffixStat = "Immunity to trip attacks and entanglements";
                    suf.SuffixGP = 7500;
                }
                else if (casting <= 18)
                {
                    suf.SuffixName = "of Stability";
                    suf.SuffixStat = "Immunity to stuns, trip attacks, and entanglements";
                    suf.SuffixGP = 10000;
                }
                else if (casting > 18)
                {
                    suf.SuffixName = "of Harmony";
                    suf.SuffixStat = "Immunity to stuns, disarms, trip attacks, and entanglements";
                    suf.SuffixGP = 20000;
                }

            } //Affects spell casting in combat
            else if (Suffix_Roll <= 63)
            {
                //Improves treasure finding
                int treasure = Dice.D(20) + CR;
                if (treasure <= 10)
                {
                    suf.SuffixName = "of Greed";
                    suf.SuffixStat = "CR is + 2 for random gold on Base table";
                    suf.SuffixGP = 7500;
                }
                else if (treasure <= 18)
                {
                    suf.SuffixName = "of Chance";
                    suf.SuffixStat = "CR is +2 for random magic item on tables";
                    suf.SuffixGP = 10000;
                }
                else if (treasure <= 26)
                {
                    suf.SuffixName = "of Wealth";
                    suf.SuffixStat = "CR is +4 for random gold on Base tables";
                    suf.SuffixGP = 10000;
                }
                else if (treasure > 26)
                {
                    suf.SuffixName = "of Chance";
                    suf.SuffixStat = "CR is +4 for random magic item on tables";
                    suf.SuffixGP = 12500;
                }

            } //Improves treasure finding
            else if (Suffix_Roll <= 67)
            {
                //Improves light sources
                int light = Dice.D(20) + CR;
                if (light <= 13)
                {
                    suf.SuffixName = "of Light";
                    suf.SuffixStat = "Any light source carried by user is +10 ft. radius";
                    suf.SuffixGP = 2500;
                }
                else if (light <= 18)
                {
                    suf.SuffixName = "of Radiance";
                    suf.SuffixStat = "Any light source carried by user +20 ft.radius";
                    suf.SuffixGP = 3750;
                }
                else if (light > 18)
                {
                    suf.SuffixName = "of the Sun";
                    suf.SuffixStat = "Any light source carried by user +30 ft.radius";
                    suf.SuffixGP = 5000;
                }

            } //Improves light sources
            else if (Suffix_Roll <= 70)
            {
                //Reduces effects of hazards
                int hazard = Dice.D(20) + CR;
                if (hazard <= 8)
                {
                    suf.SuffixName = "of the Thief";
                    suf.SuffixStat = "+5 to Disable Device checks; 1/2 damage form traps";
                    suf.SuffixGP = 3750;
                }
                else if (hazard <= 14)
                {
                    suf.SuffixName = "of Warmth";
                    suf.SuffixStat = "Immune to nondamaging cold effects";
                    suf.SuffixGP = 5000;
                }
                else if (hazard <= 18)
                {
                    suf.SuffixName = "of Remedy";
                    suf.SuffixStat = "+2 saves vs. poison";
                    suf.SuffixGP = 5000;
                }
                else if (hazard <= 21)
                {
                    suf.SuffixName = "of Amelioration";
                    suf.SuffixStat = "+5 saves vs. poison";
                    suf.SuffixGP = 7500;
                }
                else if (hazard <= 23)
                {
                    suf.SuffixName = "of Defiance";
                    suf.SuffixStat = "+8 saves vs. poison";
                    suf.SuffixGP = 10000;
                }
                else if (hazard > 23)
                {
                    suf.SuffixName = "of Purging";
                    suf.SuffixStat = "+3 saves vs. poison; 1/day slow poison for 1d4 hours";
                    suf.SuffixGP = 12500;
                }

            } //Reduces effects or hazards
            else if (Suffix_Roll <= 73)
            {
                //Increases damage
                int damage = Dice.D(20) + CR;
                if (damage <= 4)
                {
                    suf.SuffixName = "of Craftmanship";
                    suf.SuffixStat = "+1 damage";
                    suf.SuffixGP = 2500;
                }
                else if (damage <= 8)
                {
                    suf.SuffixName = "of Quality";
                    suf.SuffixStat = "+1 damage. +2 damage vs. Large or bigger creatures";
                    suf.SuffixGP = 3750;
                }
                else if (damage <= 11)
                {
                    suf.SuffixName = "of Maiming";
                    suf.SuffixStat = "+2 damage";
                    suf.SuffixGP = 5000;
                }
                else if (damage <= 14)
                {
                    suf.SuffixName = "of Slaying";
                    suf.SuffixStat = "+2 damage. +3 damage vs. Large or bigger creatures";
                    suf.SuffixGP = 6250;
                }
                else if (damage <= 17)
                {
                    suf.SuffixName = "of Gore";
                    suf.SuffixStat = "+3 damage";
                    suf.SuffixGP = 7500;
                }
                else if (damage <= 18)
                {
                    suf.SuffixName = "of Devastation";
                    suf.SuffixStat = "If maximum base damage is rolled then triple damage";
                    suf.SuffixGP = 8750;
                }
                else if (damage <= 19)
                {
                    suf.SuffixName = "of the Jester";
                    suf.SuffixStat = "Multiply damage by 1d4; on a 4, no damage is dealt";
                    suf.SuffixGP = 10000;
                }
                else if (damage <= 22)
                {
                    suf.SuffixName = "of Carnage";
                    suf.SuffixStat = "+4 damage";
                    suf.SuffixGP = 10000;
                }
                else if (damage > 22)
                {
                    suf.SuffixName = "of Slaughter";
                    suf.SuffixStat = "+5 damage";
                    suf.SuffixGP = 12500;
                }

            } //Increases damage
            else if (Suffix_Roll <= 75)
            {
                //Improves minimum damage
                int minimum = Dice.D(20) + CR;
                if (minimum <= 8)
                {
                    suf.SuffixName = "of Measure";
                    suf.SuffixStat = "Minimum base damage with this item is +2";
                    suf.SuffixGP = 2500;
                }
                else if (minimum <= 15)
                {
                    suf.SuffixName = "of Worth";
                    suf.SuffixStat = "Minimum base damage with this item is +3";
                    suf.SuffixGP = 5000;
                }
                else if (minimum <= 20)
                {
                    suf.SuffixName = "of Excellence";
                    suf.SuffixStat = "Minimum base damage with this item is +4";
                    suf.SuffixGP = 7500;
                }
                else if (minimum > 21)
                {
                    suf.SuffixName = "of Performance";
                    suf.SuffixStat = "Minimum base damage with this item is +5";
                    suf.SuffixGP = 10000;
                }

            } //Improves minimum damage
            else if (Suffix_Roll <= 77)
            {
                //Affects attack speed
                int speed = Dice.D(20) + CR;
                if (speed <= 8)
                {
                    suf.SuffixName = "of Readiness";
                    suf.SuffixStat = "+1 speed initiative bonus";
                    suf.SuffixGP = 2500;
                }
                else if (speed <= 15)
                {
                    suf.SuffixName = "of Alacrity";
                    suf.SuffixStat = "+2 speed initiative bonus";
                    suf.SuffixGP = 3750;
                }
                else if (speed <= 19)
                {
                    suf.SuffixName = "of Swiftness";
                    suf.SuffixStat = "+3 speed initiative bonus";
                    suf.SuffixGP = 5000;
                }
                else if (speed > 19)
                {
                    suf.SuffixName = "of Quickness";
                    suf.SuffixStat = "+4 speed initiative bonus";
                    suf.SuffixGP = 7500;
                }

            } //Affects attack speed
            else if (Suffix_Roll <= 80)
            {
                //Adds effects to damaged foe
                int foe = Dice.D(20) + CR;
                if (foe <= 3)
                {
                    suf.SuffixName = "of Frost";
                    suf.SuffixStat = "+1d6 points of cold damge";
                    suf.SuffixGP = 2500;
                }
                else if (foe <= 6)
                {
                    suf.SuffixName = "of Flame";
                    suf.SuffixStat = "+1d6 points of fire damage";
                    suf.SuffixGP = 2500;
                }
                else if (foe <= 9)
                {
                    suf.SuffixName = "of Shock";
                    suf.SuffixStat = "+1d6 points of lightning damage";
                    suf.SuffixGP = 2500;
                }
                else if (foe <= 12)
                {
                    suf.SuffixName = "of Blight";
                    suf.SuffixStat = "+1d6 points of damage";
                    suf.SuffixGP = 2500;
                }
                else if (foe <= 14)
                {
                    suf.SuffixName = "of Ice";
                    suf.SuffixStat = "+2d6 points of cold damge";
                    suf.SuffixGP = 5000;
                }
                else if (foe <= 16)
                {
                    suf.SuffixName = "of Fire";
                    suf.SuffixStat = "+2d6 points of fire damage";
                    suf.SuffixGP = 5000;
                }
                else if (foe <= 18)
                {
                    suf.SuffixName = "of Lightning";
                    suf.SuffixStat = "+2d6 points of lightning damage";
                    suf.SuffixGP = 5000;
                }
                else if (foe <= 20)
                {
                    suf.SuffixName = "of Venom";
                    suf.SuffixStat = "+2d6 points of damage";
                    suf.SuffixGP = 5000;
                }
                else if (foe <= 21)
                {
                    suf.SuffixName = "of the Glacier";
                    suf.SuffixStat = "+3d6 points of cold damge";
                    suf.SuffixGP = 7500;
                }
                else if (foe <= 22)
                {
                    suf.SuffixName = "of Burning";
                    suf.SuffixStat = "+3d6 points of fire damage";
                    suf.SuffixGP = 7500;
                }
                else if (foe <= 23)
                {
                    suf.SuffixName = "of Thundering";
                    suf.SuffixStat = "+3d6 points of lightning damage";
                    suf.SuffixGP = 7500;
                }
                else if (foe <= 24)
                {
                    suf.SuffixName = "of Pestilence";
                    suf.SuffixStat = "+3d6 points of damage";
                    suf.SuffixGP = 7500;
                }
                else if (foe <= 25)
                {
                    suf.SuffixName = "of Vileness";
                    suf.SuffixStat = "Wounds caused must be healed magically, negates regeneration";
                    suf.SuffixGP = 7500;
                }
                else if (foe <= 26)
                {
                    suf.SuffixName = "of the Crusaders";
                    suf.SuffixStat = "+1 cumulative damage per successful consecutive attack against same foe";
                    suf.SuffixGP = 10000;
                }
                else if (foe <= 27)
                {
                    suf.SuffixName = "of Destrucation";
                    suf.SuffixStat = "Foe takes extra damage equal to 20 - foes AC (min 0)";
                    suf.SuffixGP = 10000;
                }
                else if (foe <= 28)
                {
                    suf.SuffixName = "of Peril";
                    suf.SuffixStat = "Foe takes double damage, wielder takes normal damage";
                    suf.SuffixGP = 12500;
                }
                else if (foe <= 30)
                {
                    suf.SuffixName = "of the Bear";
                    suf.SuffixStat = "Hit knocks foe 10 ft. bakc (out of melee range)";
                    suf.SuffixGP = 12500;
                }
                else if (foe > 30)
                {
                    suf.SuffixName = "of the Grizzly";
                    suf.SuffixStat = "Hit knocks foe 20 ft. bakc (out of melee range)";
                    suf.SuffixGP = 15000;
                }
            } //Adds effects to damaged foe
            else if (Suffix_Roll <= 82)
            {
                //Restores on a successful hit
                int restore = Dice.D(20) + CR;
                if (restore <= 5)
                {
                    suf.SuffixName = "of the Leech";
                    suf.SuffixStat = "Successful hit heals user 1d4 hit points";
                    suf.SuffixGP = 7500;
                }
                else if (restore <= 9)
                {
                    suf.SuffixName = "of the Claw";
                    suf.SuffixStat = "Successful hit against spellcaster restores 3 spell levels of user's sorceress (Arcane) spells";
                    suf.SuffixGP = 10000;
                }
                else if (restore <= 13)
                {
                    suf.SuffixName = "of the Bat";
                    suf.SuffixStat = "Successful hit against spellcaster restores 3 spell levels of user's necromancer (Divine) spells";
                    suf.SuffixGP = 10000;
                }
                else if (restore <= 17)
                {
                    suf.SuffixName = "of Blood";
                    suf.SuffixStat = "Successful hit heals user 1d6 hit points";
                    suf.SuffixGP = 10000;
                }
                else if (restore <= 20)
                {
                    suf.SuffixName = "of the Talon";
                    suf.SuffixStat = "Successful hit against spellcaster restores one of user's cast sorceress (Arcane) spells";
                    suf.SuffixGP = 12500;
                }
                else if (restore <= 23)
                {
                    suf.SuffixName = "of the Vampire";
                    suf.SuffixStat = "Successful hit against spellcaster restores one of user's cast necromancer (Divine) spells";
                    suf.SuffixGP = 12500;
                }
                else if (restore > 24)
                {
                    suf.SuffixName = "of the Locust";
                    suf.SuffixStat = "Successful hit heals user 2d4 hit points";
                    suf.SuffixGP = 15000;
                }

            } //Restores on a successful hit
            else if (Suffix_Roll <= 84)
            {
                //Causes damage to armor or weapons
                int sunder = Dice.D(20) + CR;
                if (sunder <= 7)
                {
                    suf.SuffixName = "of Piercing";
                    suf.SuffixStat = "Foe's armor destroyed, Fortitude save negates (DC is damage dealt)";
                    suf.SuffixGP = 10000;
                }
                else if (sunder <= 14)
                {
                    suf.SuffixName = "of Breaking";
                    suf.SuffixStat = "Foe's weapon destroyed, Fortitude save negates (DC is damage dealt)";
                    suf.SuffixGP = 12500;
                }
                else if (sunder <= 21)
                {
                    suf.SuffixName = "of Puncturing";
                    suf.SuffixStat = "Foe's armor destroyed, Fortitude save negates (DC is damage dealt + 5)";
                    suf.SuffixGP = 12500;
                }
                else if (sunder <= 28)
                {
                    suf.SuffixName = "of Smashing";
                    suf.SuffixStat = "Foe's weapon destroyed, Fortitude save negates (DC is damage dealt + 5)";
                    suf.SuffixGP = 15000;
                }
                else if (sunder > 28)
                {
                    suf.SuffixName = "of Bashing";
                    suf.SuffixStat = "Foe's armor destroyed, Fortitude save negates (DC is damage dealt + 10)";
                    suf.SuffixGP = 17500;
                }

            } //Causes damage to armor or weapons
            else if (Suffix_Roll <= 85)
            {
                //Affects weapon proficiences
                int proficiences = Dice.D(20) + CR;
                if (proficiences <= 13)
                {
                    suf.SuffixName = "of Ease";
                    suf.SuffixStat = "User gains proficiency for item";
                    suf.SuffixGP = 5000;
                }
                else if (proficiences > 13)
                {
                    suf.SuffixName = "of Simplicity";
                    suf.SuffixStat = "User gains proficieny and Weapon Focus for item";
                    suf.SuffixGP = 10000;
                }

            } //Affects weapon proficiences
            else if (Suffix_Roll <= 90)
            {
                //Affects available uses
                int uses = Dice.D(20) + CR;
                if (uses <= 13)
                {
                    suf.SuffixName = "of Many";
                    suf.SuffixStat = "fire one charge/arrow per round for free (others cost/must be provided)";
                    suf.SuffixGP = 7500;
                }
                else if (uses > 13)
                {
                    suf.SuffixName = "of Plenty";
                    suf.SuffixStat = "fire two charges/arrows per round for free (others cost/must be provided)";
                    suf.SuffixGP = 15000;
                }

            } //Affects available uses
            else if (Suffix_Roll > 90)
            {
                //Allows the casting of a spell
                int casting = Dice.D(20) + CR;
                if (casting <= 7)
                {
                    suf.SuffixName = "of (spell name)";
                    suf.SuffixStat = "random 1st level spell";
                    suf.SuffixGP = 2500;
                }
                else if (casting <= 12)
                {
                    suf.SuffixName = "of (spell name)";
                    suf.SuffixStat = "random 2nd level spell";
                    suf.SuffixGP = 5000;
                }
                else if (casting <= 16)
                {
                    suf.SuffixName = "of (spell name)";
                    suf.SuffixStat = "random 3nd level spell";
                    suf.SuffixGP = 7500;
                }
                else if (casting <= 18)
                {
                    suf.SuffixName = "of (spell name)";
                    suf.SuffixStat = "random 4nd level spell";
                    suf.SuffixGP = 10000;
                }
                else if (casting <= 20)
                {
                    suf.SuffixName = "of (spell name)";
                    suf.SuffixStat = "random 5nd level spell";
                    suf.SuffixGP = 12500;
                }
                else if (casting <= 24)
                {
                    suf.SuffixName = "of (spell name)";
                    suf.SuffixStat = "random 6nd level spell";
                    suf.SuffixGP = 15000;
                }
                else if (casting <= 27)
                {
                    suf.SuffixName = "of (spell name)";
                    suf.SuffixStat = "random 7nd level spell";
                    suf.SuffixGP = 17500;
                }
                else if (casting > 27)
                {
                    suf.SuffixName = "of (spell name)";
                    suf.SuffixStat = "random 8nd level spell";
                    suf.SuffixGP = 20000;
                }

                suf.SuffixStat += "\n*Scrolls and runes have 1/10 of listed GP. Books have 1/5 of listed GP value. " +
                                  $"\n**Wands and staves ahve a maximum ${Dice.D(10,10)} charges, all are rechargeable (except inscribed scrolls)";

            } //Allows the casting of a spell

            suf.rolls = Dice.rolls;
            return suf;
        }
    }
}