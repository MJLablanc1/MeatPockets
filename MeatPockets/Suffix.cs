using ClassLibaray;

namespace Suffix
{
    class suffix
    {
        public static DiceRoll Dice = new DiceRoll();
        public static suf Suffixes(int s, int CR)
        {
            suf suf = new suf();
            int a = Dice.D(20) + CR;
            if (s <= 20)
            {
                //Reduces damage taken

            } //Reduces damage taken
            else if (s <= 25)
            {
                //Has an effect when attacked

            } //Has an effect when attacked
            else if (s <= 27)
            {
                //Improved durability

            } //Improved durability
            else if (s <= 30)
            {
                //Affects movement

            } //Affects movement
            else if (s <= 35)
            {
                //Increases hit points

            } //Increases hit points
            else if (s <= 45)
            {
                //Increases ability scores

            } //Increases ability scores
            else if (s <= 49)
            {
                //Cursed

            } //Cursed
            else if (s <= 53)
            {
                //Improves recovery

            } //Improves recovery
            else if (s <= 56)
            {
                //Affects spell preparation

            } //Affects spell preparation
            else if (s <= 60)
            {
                //Affects spell casting in combat

            } //Affects spell casting in combat
            else if (s <= 63)
            {
                //Improves treasure finding

            } //Improves treasure finding
            else if (s <= 67)
            {
                //Improves light sources

            } //Improves light sources
            else if (s <= 70)
            {
                //Reduces effects of hazards

            } //Reduces effects or hazards
            else if (s <= 73)
            {
                //Increases damage

            } //Increases damage
            else if (s <= 75)
            {
                //Improves minimum damage

            } //Improves minimum damage
            else if (s <= 77)
            {
                //Affects attack speed

            } //Affects attack speed
            else if (s <= 80)
            {
                //Adds effects to damaged foe

            } //Adds effects to damaged foe
            else if (s <= 82)
            {
                //Restores on a successful hit

            } //Restores on a successful hit
            else if (s <= 84)
            {
                //Causes damage to armor or weapons

            } //Causes damage to armor or weapons
            else if (s <= 85)
            {
                //Affects weapon proficiences

            } //Affects weapon proficiences
            else if (s <= 90)
            {
                //Affects available uses

            } //Affects available uses
            else if (s <= 100)
            {
                //Allows the casting of a spell

            } //Allows the casting of a spell

            suf.rolls = Dice.rolls;
            return suf;
        }
    }
}