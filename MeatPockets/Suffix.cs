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

            } //Reduces damage taken
            else if (Suffix_Roll <= 25)
            {
                //Has an effect when attacked

            } //Has an effect when attacked
            else if (Suffix_Roll <= 27)
            {
                //Improved durability

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