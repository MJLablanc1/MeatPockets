namespace ClassLibaray
{

    public class item
    {
        public string? Name;
        public string? Stat;
        public int GP;
        public int Amount;
        public bool Each = false;

        public string? PrefixName;
        public string? PrefixStat;
        public int PrefixGP;

        public string? SuffixName;
        public string? SuffixStat;
        public int SuffixGP;
    }

    public class pre
    {
        public string PrefixName = "";
        public string PrefixStat = "";
        public int PrefixGP = 0;
    }

    public class suf
    {
        public string SuffixName = "";
        public string SuffixStat = "";
        public int SuffixGP = 0;
    }

}