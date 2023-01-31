namespace ClassLibaray
{

    public class DiceRoll
    {
        public List<int> rolls = new List<int>();
        Random Dice = new Random();
        public int D(int N)
        {
            int r = 0;
            if (N == -1)
            {
                Console.WriteLine("skipped a die roll");
            }
            else
            {
                r = Dice.Next(N) + 1;
                rolls.Add(r);
            }            
            return r;
        }

        public int D(int D, int N)
        {
            int r = 0;
            for (int i = 0; i < D; i++)
            {
                r += Dice.Next(N) + 1;
                rolls.Add(r);
            }            
            return r;
        }
    }

    public class item
    {
        public string Name = "no name";
        public string Stat = "missing stat";
        public int GP = -1;
        public int Amount = -1;
        public bool Each = false;

        public string PrefixName = "no prefix";
        public string PrefixStat = "no prefix stat";
        public int PrefixGP = -1;

        public string SuffixName = "no suffix";
        public string SuffixStat = "no suffix stat";
        public int SuffixGP = -1;
        public List<int> rolls = new List<int>();
    }

    public class pre
    {
        public string PrefixName = "";
        public string PrefixStat = "";
        public int PrefixGP = 0;
        public List<int> rolls = new List<int>();
    }

    public class suf
    {
        public string SuffixName = "";
        public string SuffixStat = "";
        public int SuffixGP = 0;
        public List<int> rolls = new List<int>();
    }

}