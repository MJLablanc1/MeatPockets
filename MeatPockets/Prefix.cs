using ClassLibaray;

namespace Prefix
{
    class prefix
    {
        public static DiceRoll Dice = new DiceRoll();
        public static pre Prefixes(int p, int CR)
        {
            pre pre = new pre();
            int a = Dice.D(20) + CR;
            if (p <= 20)
            {
                //Improves Armor Class

            } //Improves Armor Class
            else if (p <= 35)
            {
                //Improves Saving Throws

            } //Improves Saving Throws
            else if (p <= 39)
            {
                //Affects foe's reactions

            } //Affects foe's reactions
            else if (p <= 40)
            {
                //Affects Fatigue

            } //Affects Fatigue
            else if (p <= 45)
            {
                //Improves skills and spells

            } //Improves skills and spells
            else if (p <= 49)
            {
                //Cursed
                // how do?
            } //Cursed
            else if (p <= 50)
            {
                //Capricious
                pre = Prefixes(Dice.D(100), CR);
            } //Capricious
            else if (p <= 55)
            {
                //Affects visibility

            } //Affects visibilty
            else if (p <= 60)
            {
                //Affects number of castable spells

            } //Affects number of castable spells
            else if (p <= 62)
            {
                //Affects magical items

            } //Affects magical items
            else if (p <= 70)
            {
                //Affects the users personal statistics 

            } //Affects the users personal statistics
            else if (p <= 77)
            {
                //Improves attack scores

            } //Improves attack scores
            else if (p <= 82)
            {
                //Has improved damage

            } //Has improved damage
            else if (p <= 90)
            {
                //Improved attack scores and has improved damage

            } //Improved attack scores and has improved damage
            else if (p <= 100)
            {
                //Affects item's charges

            } //Affects item's charges
            
            pre.rolls = Dice.rolls;
            return pre;
        }
    }
}