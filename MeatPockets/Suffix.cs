using ClassLibaray;

namespace Suffix
{
    class suffix
    {
        public static DiceRoll Dice = new DiceRoll();
        public static suf Suffixes(int Suffix_Dice, int Suffix_Mod, int CR)
        {
            int Suffix_Roll = Dice.D(Suffix_Dice) + Suffix_Mod;
            suf suf = new suf();;
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
                    suf.SuffixStat = "Items gain +3 hardness, +6";
                    suf.SuffixGP = 2500;

                }
                else if (durability <= 14)
                {

                    suf.SuffixName = "of Structures";
                    suf.SuffixStat = "Items gain +5 hardness, +12";
                    suf.SuffixGP = 5000;

                }
                

            } //Improved durability
            else if (Suffix_Roll <= 30)
            {
                //Affects movement

            } //Affects movement
            else if (Suffix_Roll <= 35)
            {
                //Increases hit points

            } //Increases hit points
            else if (Suffix_Roll <= 45)
            {
                //Increases ability scores

            } //Increases ability scores
            else if (Suffix_Roll <= 49)
            {
                //Cursed

            } //Cursed
            else if (Suffix_Roll <= 53)
            {
                //Improves recovery

            } //Improves recovery
            else if (Suffix_Roll <= 56)
            {
                //Affects spell preparation

            } //Affects spell preparation
            else if (Suffix_Roll <= 60)
            {
                //Affects spell casting in combat

            } //Affects spell casting in combat
            else if (Suffix_Roll <= 63)
            {
                //Improves treasure finding

            } //Improves treasure finding
            else if (Suffix_Roll <= 67)
            {
                //Improves light sources

            } //Improves light sources
            else if (Suffix_Roll <= 70)
            {
                //Reduces effects of hazards

            } //Reduces effects or hazards
            else if (Suffix_Roll <= 73)
            {
                //Increases damage

            } //Increases damage
            else if (Suffix_Roll <= 75)
            {
                //Improves minimum damage

            } //Improves minimum damage
            else if (Suffix_Roll <= 77)
            {
                //Affects attack speed

            } //Affects attack speed
            else if (Suffix_Roll <= 80)
            {
                //Adds effects to damaged foe

            } //Adds effects to damaged foe
            else if (Suffix_Roll <= 82)
            {
                //Restores on a successful hit

            } //Restores on a successful hit
            else if (Suffix_Roll <= 84)
            {
                //Causes damage to armor or weapons

            } //Causes damage to armor or weapons
            else if (Suffix_Roll <= 85)
            {
                //Affects weapon proficiences

            } //Affects weapon proficiences
            else if (Suffix_Roll <= 90)
            {
                //Affects available uses

            } //Affects available uses
            else if (Suffix_Roll <= 100)
            {
                //Allows the casting of a spell

            } //Allows the casting of a spell

            suf.rolls = Dice.rolls;
            return suf;
        }
    }
}