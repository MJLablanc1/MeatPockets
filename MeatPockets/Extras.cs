using ClassLibaray;

namespace Extras
{
    class smallItems
    {
        public static ClassLibaray.DiceRoll Dice = new ClassLibaray.DiceRoll();
        public static void HealingPotion(int CR)
        {
            int h = Dice.D(20) + CR;
            if (h < 7)
            {
                Console.WriteLine("Minor healing potion (1d4+1), GP 75");
            }
            if (h > 6 && h < 11)
            {
                Console.WriteLine("Light healing potion (2d8+3), GP 125");
            }
            if (h > 10 && h < 21)
            {
                Console.WriteLine("Healing potion (4d8+7), GP 250");
            }
            if (h > 20 && h < 31)
            {
                Console.WriteLine("Greater healing potion (6d8+12), GP 350");
            }
            if (h > 30)
            {
                Console.WriteLine("Super healing potion (8d8+15), GP 500");
            }
        }

        public static void ManaPotion(int CR)
        {
            int m = Dice.D(20) + CR;
            if (m < 7)
            {
                Console.WriteLine("Minor mana potion (1 spell level), GP 75");
            }
            if (m > 6 && m < 11)
            {
                Console.WriteLine("Light mana potion (2 spell levels), GP 125");
            }
            if (m > 10 && m < 21)
            {
                Console.WriteLine("Mana potion (4 spell levels), GP 250");
            }
            if (m > 20 && m < 31)
            {
                Console.WriteLine("Greater mana potion (6 spell levels), GP 350");
            }
            if (m > 30)
            {
                Console.WriteLine("Super mana potion (8 spell levels), GP 500");
            }
            Console.WriteLine("Regenerated spell levels can be split, but not saved or over level caster to they could not already cast.");
        }
        public static string GemRoll()
        {
            int r = Dice.D(6);
            if (r == 1)
            {
                return "Amethyst";
            }
            if (r == 2)
            {
                return "Diamond";
            }
            if (r == 3)
            {
                return "Emerald";
            }
            if (r == 4)
            {
                return "Ruby";
            }
            if (r == 5)
            {
                return "Sapphire";
            }
            if (r == 6)
            {
                return "Topaz";
            }
            return "missed gem roll";
        }

        public static bool OilOrResin()
        {
            if (Dice.D(2) == 2)
            {
                return true;
            }
            return false;
        }
    }
}