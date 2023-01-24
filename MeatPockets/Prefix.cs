using ClassLibaray;

namespace Prefix
{
    class prefix
    {
        public static DiceRoll Dice = new DiceRoll();
        public static pre Prefixes(int Prefix_Dice,int Prefix_Mod, int CR)
        {

            int Prefix_Roll = 0;
            pre pre = new pre();
            if (Prefix_Roll <= 20)
            {                
                //Improves Armor Class
                int AC = Dice.D(20) + CR;
                if(AC < 6){
                    pre.PrefixName = "Sturdy";
                    pre.PrefixStat = "+1 AC";
                    pre.PrefixGP = 2000;
                }
                else if(AC > 5 && AC < 11){
                    pre.PrefixName = "Fine";
                    pre.PrefixStat = "+1 AC";
                    pre.PrefixGP = 2500;
                }
                else if (AC > 10 && AC < 13)
                {
                    pre.PrefixName = "Strong";
                    pre.PrefixStat = "+1 AC, +2 against missiles";
                    pre.PrefixGP = 3750;
                }
                else if (AC > 12 && AC < 17)
                {
                    pre.PrefixName = "Grand";
                    pre.PrefixStat = "+2 AC";
                    pre.PrefixGP = 5000;
                }
                else if (AC > 16 && AC < 19)
                {
                    pre.PrefixName = "Valiant";
                    pre.PrefixStat = "+2 AC, +3 against missiles";
                    pre.PrefixGP = 6250;
                }
                else if (AC > 18 && AC < 22)
                {
                    pre.PrefixName = "Glorious";
                    pre.PrefixStat = "+3 AC";
                    pre.PrefixGP = 7500;
                }
                else if (AC > 21 && AC < 23)
                {
                    pre.PrefixName = "Blessed";
                    pre.PrefixStat = "+3 AC, +4 against missiles";
                    pre.PrefixGP = 8750;
                }
                else if (AC > 22 && AC < 25)
                {
                    pre.PrefixName = "Awesome";
                    pre.PrefixStat = "+4 AC";
                    pre.PrefixGP = 10000;
                }
                else if (AC > 24 && AC < 27)
                {
                    pre.PrefixName = "Saintly";
                    pre.PrefixStat = "+4 AC, +5 against missiles";
                    pre.PrefixGP = 12500;
                }
                else if (AC > 26 && AC < 29)
                {
                    pre.PrefixName = "Holy";
                    pre.PrefixStat = "+5 AC";
                    pre.PrefixGP = 15000;
                }
                else if (AC > 28)
                {
                    pre.PrefixName = "Godly";
                    pre.PrefixStat = "+5 AC, +6 against missiles";
                    pre.PrefixGP = 17500;
                }

            } //Improves Armor Class
            else if (Prefix_Roll <= 35)
            {
                //Improves Saving Throws
                int ST = Dice.D(20) + CR;
                if(ST == 1)
                {
                    pre.PrefixName = "Tawny";
                    pre.PrefixStat = "+1 save vs. acid";
                    pre.PrefixGP = 2000;
                }
                if (ST == 2)
                {
                    pre.PrefixName = "Azure";
                    pre.PrefixStat = "+1 save vs. cold";
                    pre.PrefixGP = 2000;
                }
                if (ST == 3)
                {
                    pre.PrefixName = "Crimson";
                    pre.PrefixStat = "+1 save vs. fire";
                    pre.PrefixGP = 2000;
                }
                if (ST == 4)
                {
                    pre.PrefixName = "Ocher";
                    pre.PrefixStat = "+1 save vs. lightning";
                    pre.PrefixGP = 2000;
                }
                if (ST == 5)
                {
                    pre.PrefixName = "Pearl";
                    pre.PrefixStat = "+1 save vs. mind-influencing effects";
                    pre.PrefixGP = 2000;
                }
                if (ST == 6)
                {
                    pre.PrefixName = "Beryl";
                    pre.PrefixStat = "+1 save vs. poison";
                    pre.PrefixGP = 2000;
                }
                if (ST == 7)
                {
                    pre.PrefixName = "Coal";
                    pre.PrefixStat = "+1 save vs. spells";
                    pre.PrefixGP = 2000;
                }
                if (ST == 8)
                {
                    pre.PrefixName = "Jasmine";
                    pre.PrefixStat = "+2 save vs. acid";
                    pre.PrefixGP = 4000;
                }
                if (ST == 9)
                {
                    pre.PrefixName = "Lapis";
                    pre.PrefixStat = "+2 save vs. cold";
                    pre.PrefixGP = 4000;
                }
                if (ST == 10)
                {
                    pre.PrefixName = "Burgundy";
                    pre.PrefixStat = "+2 save vs. fire";
                    pre.PrefixGP = 4000;
                }
                if (ST == 11)
                {
                    pre.PrefixName = "Tangerine";
                    pre.PrefixStat = "+2 save vs. lightning";
                    pre.PrefixGP = 4000;
                }
                if (ST == 12)
                {
                    pre.PrefixName = "Ivory";
                    pre.PrefixStat = "+2 save vs. mind-influencing effects";
                    pre.PrefixGP = 4000;
                }
                if (ST == 13)
                {
                    pre.PrefixName = "Jade";
                    pre.PrefixStat = "+2 save vs. poison";
                    pre.PrefixGP = 4000;
                }
                if (ST == 14)
                {
                    pre.PrefixName = "Jet";
                    pre.PrefixStat = "+2 save vs. spells";
                    pre.PrefixGP = 4000;
                }
                if (ST == 15)
                {
                    pre.PrefixName = "Pyrite";
                    pre.PrefixStat = "+3 save vs. acid and -1/4 acid damage";
                    pre.PrefixGP = 6000;
                }
                if (ST == 16)
                {
                    pre.PrefixName = "Cobalt";
                    pre.PrefixStat = "+3 save vs. cold and -1/4 cold damage";
                    pre.PrefixGP = 6000;
                }
                if (ST == 17)
                {
                    pre.PrefixName = "Garnet";
                    pre.PrefixStat = "+3 save vs. fire and -1/4 fire damage";
                    pre.PrefixGP = 6000;
                }
                if (ST == 18)
                {
                    pre.PrefixName = "Coral";
                    pre.PrefixStat = "+3 save vs. lightning and -1/4 lightning damage";
                    pre.PrefixGP = 6000;
                }
                if (ST == 19)
                {
                    pre.PrefixName = "Crystal";
                    pre.PrefixStat = "+3 save vs. mind-influencing effects";
                    pre.PrefixGP = 6000;
                }
                if (ST == 20)
                {
                    pre.PrefixName = "Viridian";
                    pre.PrefixStat = "+3 save vs. poison and ignore initial posion damage";
                    pre.PrefixGP = 6000;
                }
                if (ST == 21)
                {
                    pre.PrefixName = "Ebony";
                    pre.PrefixStat = "+3 save vs. spells and -1/4 spell damage";
                    pre.PrefixGP = 6000;
                }
                if (ST == 22)
                {
                    pre.PrefixName = "Crysolite";
                    pre.PrefixStat = "+4 save vs. acid and -1/2 acid damage";
                    pre.PrefixGP = 8000;
                }
                if (ST == 23)
                {
                    pre.PrefixName = "Sapphire";
                    pre.PrefixStat = "+4 save vs. cold and -1/2 cold damage";
                    pre.PrefixGP = 8000;
                }
                if (ST == 24)
                {
                    pre.PrefixName = "Ruby";
                    pre.PrefixStat = "+4 save vs. fire and -1/2 fire damage";
                    pre.PrefixGP = 6000;
                }
                if (ST == 25)
                {
                    pre.PrefixName = "Amber";
                    pre.PrefixStat = "+4 save vs. lightning and -1/2 lightning damage";
                    pre.PrefixGP = 8000;
                }
                if (ST == 26)
                {
                    pre.PrefixName = "Diamond";
                    pre.PrefixStat = "+4 save vs. mind-influencing effects";
                    pre.PrefixGP = 8000;
                }
                if (ST == 27)
                {
                    pre.PrefixName = "Emerald";
                    pre.PrefixStat = "+4 save vs. poison and ignore secondary posion damage";
                    pre.PrefixGP = 8000;
                }
                if (ST == 28)
                {
                    pre.PrefixName = "Obsidian";
                    pre.PrefixStat = "+4 save vs. spells and -1/2 spell damage";
                    pre.PrefixGP = 8000;
                }
                if (ST == 29)
                {
                    pre.PrefixName = "Topaz";
                    pre.PrefixStat = "+2 to all saves";
                    pre.PrefixGP = 10000;
                }
                if (ST == 30)
                {
                    pre.PrefixName = "Prismatic";
                    pre.PrefixStat = "+3 to all saves";
                    pre.PrefixGP = 15000;
                }
                if (ST > 31)
                {
                    pre.PrefixName = "Skull";
                    pre.PrefixStat = "+4 to all saves";
                    pre.PrefixGP = 18000;
                }

            } //Improves Saving Throws
            else if (Prefix_Roll <= 39)
            {
                //Affects foe's reactions
                int FR = Dice.D(20) + CR;
                if (FR <= 6)
                {
                    pre.PrefixName = "Subduing";
                    pre.PrefixStat = "Chosen foe flatfooted next round; Will save (DC 15) negates";
                    pre.PrefixGP = 5000;
                }
                else if (FR <= 10)
                {
                    pre.PrefixName = "Wearying";
                    pre.PrefixStat = "Chosen foe flatfooted 1d4 rounds; Will save (DC 20) negates";
                    pre.PrefixGP = 10000;
                }
                else if (FR <= 11)
                {
                    pre.PrefixName = "Phasing";
                    pre.PrefixStat = "Chosen foe deals half damage 1d4 rounds; Will save (DC 25) negates";
                    pre.PrefixGP = 10000;
                }
                else if (FR <= 12)
                {
                    pre.PrefixName = "Kicking";
                    pre.PrefixStat = "Attacking unarmed does not provoke attacks of opportunity";
                    pre.PrefixGP = 10000;
                }
                else if (FR <= 16)
                {
                    pre.PrefixName = "Depleting";
                    pre.PrefixStat = "Chosen foe takes -20 initiative penalty for 2d4 rounds; Will save (DC 25) negates";
                    pre.PrefixGP = 10000;
                }
                else if (FR <= 19)
                {
                    pre.PrefixName = "Howling";
                    pre.PrefixStat = "Chosen foe takes fear affect; Will save (DC 18) negates";
                    pre.PrefixGP = 12500;
                }
                else if (FR <= 20)
                {
                    pre.PrefixName = "Choas";
                    pre.PrefixStat = "Chosen foe changes tp random new alignment for 1d4+1 rounds; Will save (DC 20) negates";
                    pre.PrefixGP = 12500;
                }
                else if (FR <= 23)
                {
                    pre.PrefixName = "Subjugating";
                    pre.PrefixStat = "Chosen foe can only take [artial actions for 2d4 rounds; Will save (DC 28) negates";
                    pre.PrefixGP = 12500;
                }
                else if (FR <= 26)
                {
                    pre.PrefixName = "Fatiguing";
                    pre.PrefixStat = "Chosen foe takes decrepify for 1d4 rounds; Will save (DC 25) negates";
                    pre.PrefixGP = 12500;
                }
                else if (FR <= 29)
                {
                    pre.PrefixName = "Exhausting";
                    pre.PrefixStat = "Chosen foe takes decrepify for 2d4 rounds; Will save (DC 28) negates";
                    pre.PrefixGP = 15000;
                }
                else if (FR > 29)
                {
                    pre.PrefixName = "Overwhelming";
                    pre.PrefixStat = "Chosen foe takes decrepify for 3d4 rounds; Will save (DC 30) negates";
                    pre.PrefixGP = 17500;
                }

            } //Affects foe's reactions
            else if (Prefix_Roll <= 40)
            {
                //Affects Fatigue
                int AF = Dice.D(20) + CR;
                if (AF <= 10)
                {
                    pre.PrefixName = "Tireless";
                    pre.PrefixStat = "You recover from being tired in half the time";
                    pre.PrefixGP = 2000;
                }
                else
                {
                    pre.PrefixName = "Rugged";
                    pre.PrefixStat = "You are immune to fatigue";
                    pre.PrefixGP = 4000;
                }

            } //Affects Fatigue
            else if (Prefix_Roll <= 45)
            {
                //Improves skills and spells
                int SS = Dice.D(20) + CR;
                if (SS <= 3)
                {
                    pre.PrefixName = "Fletcher's";
                    pre.PrefixStat = "+1 ranged attack/rank with class skills(amazons only)";
                    pre.PrefixGP = 2500;
                }
                else if (SS <= 6)
                {
                    pre.PrefixName = "Slayer's";
                    pre.PrefixStat = "+1 melee attack/rank with class skills(barbarians only)";
                    pre.PrefixGP = 2500;
                }
                else if (SS <= 9)
                {
                    pre.PrefixName = "Summoner's";
                    pre.PrefixStat = "+1 spell level/rank with class skills(necromancers only)";
                    pre.PrefixGP = 2500;
                }
                else if (SS <= 12)
                {
                    pre.PrefixName = "Monks's";
                    pre.PrefixStat = "+1 melee level/rank with class skills(paladins only)";
                    pre.PrefixGP = 2500;
                }
                else if (SS <= 15)
                {
                    pre.PrefixName = "Angel's";
                    pre.PrefixStat = "+1 spell level/rank with class skills(sorceresses only)";
                    pre.PrefixGP = 2500;
                }
                else if (SS <= 17)
                {
                    pre.PrefixName = "Archers's";
                    pre.PrefixStat = "+2 ranged attack/rank with class skills(amazons only)";
                    pre.PrefixGP = 5000;
                }
                else if (SS <= 19)
                {
                    pre.PrefixName = "Berserker's";
                    pre.PrefixStat = "+2 melee attack/rank with class skills(barbarians only)";
                    pre.PrefixGP = 5000;
                }
                else if (SS <= 21)
                {
                    pre.PrefixName = "Necromancer's";
                    pre.PrefixStat = "+2 spell level/rank with class skills(necromancers only)";
                    pre.PrefixGP = 5000;
                }
                else if (SS <= 23)
                {
                    pre.PrefixName = "Priest's";
                    pre.PrefixStat = "+2 melee level/rank with class skills(paladins only)";
                    pre.PrefixGP = 5000;
                }
                else if (SS > 23)
                {
                    pre.PrefixName = "Arch-Angel's";
                    pre.PrefixStat = "+2 spell level/rank with class skills(sorceresses only)";
                    pre.PrefixGP = 5000;
                }

            } //Improves skills and spells
            else if (Prefix_Roll <= 49)
            {
                //Cursed
                int Curse = Dice.D(Prefix_Dice) + Prefix_Mod;
                if (Curse <= 15)
                {
                    pre.PrefixName = "Rusted";
                    pre.PrefixStat = "-1 AC";
                    pre.PrefixGP = 1;
                }
                else if (Curse <= 25)
                {
                    pre.PrefixName = "Vulnerable";
                    pre.PrefixStat = "-2 AC";
                    pre.PrefixGP = 1;
                }
                else if (Curse <= 35)
                {
                    pre.PrefixName = "Glass";
                    pre.PrefixStat = "-2 to all saves";
                    pre.PrefixGP = 1;
                }
                else if (Curse <= 45)
                {
                    pre.PrefixName = "Hyena's";
                    pre.PrefixStat = "User cannot cast spells";
                    pre.PrefixGP = 1;
                }
                else if (Curse <= 55)
                {
                    pre.PrefixName = "Frog's";
                    pre.PrefixStat = "-1 spell level";
                    pre.PrefixGP = 1;
                }
                else if (Curse <= 70)
                {
                    pre.PrefixName = "Pitch";
                    pre.PrefixStat = "Any light source carried by user has a -10ft. radius";
                    pre.PrefixGP = 1;
                }
                else if (Curse <= 75)
                {
                    pre.PrefixName = "Brass";
                    pre.PrefixStat = "-1 attack";
                    pre.PrefixGP = 1;
                }
                else if (Curse <= 77)
                {
                    pre.PrefixName = "Tin";
                    pre.PrefixStat = "-2 attack";
                    pre.PrefixGP = 1;
                }
                else if (Curse <= 78)
                {
                    pre.PrefixName = "Crystalline";
                    pre.PrefixStat = "When weapons deals damage roll 1d6; on a 6, the weapon deals no damage and is destroyed";
                    pre.PrefixGP = 1;
                }
                else if (Curse <= 81)
                {
                    pre.PrefixName = "Weak";
                    pre.PrefixStat = "Base damage is halved (round down)";
                    pre.PrefixGP = 1;
                }
                else if (Curse <= 83)
                {
                    pre.PrefixName = "Bent";
                    pre.PrefixStat = "Base damage is reduced to 1";
                    pre.PrefixGP = 1;
                }
                else if (Curse <= 85)
                {
                    pre.PrefixName = "Useless";
                    pre.PrefixStat = "Attacking with this item causes no damage";
                    pre.PrefixGP = 1;
                }
                else if (Curse <= 88)
                {
                    pre.PrefixName = "Dull";
                    pre.PrefixStat = "-1 attack and base damage is halved (round down)";
                    pre.PrefixGP = 1;
                }
                else if (Curse > 88 )
                {
                    pre.PrefixName = "Clumsy";
                    pre.PrefixStat = "-2 attack and base damage is reduved to 1";
                    pre.PrefixGP = 1;
                }
            } //Cursed
            else if (Prefix_Roll <= 50)
            {
                //Capricious
                int _PrefixDice = 100;
                int _PrefixMod = 0;
                pre = Prefixes(_PrefixDice,_PrefixMod, CR);
            } //Capricious
            else if (Prefix_Roll <= 55)
            {
                //Affects visibility
                int vis = Dice.D(20) + CR;
                if (vis <= 6)
                {
                    pre.PrefixName = "Glowing";
                    pre.PrefixStat = "glows to a 30-ft. radius";
                    pre.PrefixGP = 2500;
                }
                else if (vis <= 12)
                {
                    pre.PrefixName = "Oracular";
                    pre.PrefixStat = "Constant 'see invisibility' to 60 ft.";
                    pre.PrefixGP = 5000;
                }
                else if (vis <= 17)
                {
                    pre.PrefixName = "Unseen";
                    pre.PrefixStat = "User is invisible to all beings more than 30 ft. away";
                    pre.PrefixGP = 7500;
                }
                else if (vis <= 21)
                {
                    pre.PrefixName = "Hidden";
                    pre.PrefixStat = "User is invisible to all beings more than 20 ft. away";
                    pre.PrefixGP = 10000;
                }
                else if (vis <= 24)
                {
                    pre.PrefixName = "Veiled";
                    pre.PrefixStat = "User is invisible to all beings more than 10 ft. away";
                    pre.PrefixGP = 12500;
                }
                else if (vis >= 25)
                {
                    pre.PrefixName = "Stalking";
                    pre.PrefixStat = "User  is invisible on any round he or she does not move, attack, or cast a spell";
                    pre.PrefixGP = 15000;
                }

            } //Affects visibilty
            else if (Prefix_Roll <= 60)
            {
                //Affects number of castable spells
                int spells = Dice.D(20) + CR;
                if (spells <= 5)
                {
                    pre.PrefixName = "Lizard's";
                    pre.PrefixStat = "+1 spell level (if user can cast spells)";
                    pre.PrefixGP = 2500;
                }
                else if (spells <= 9)
                {
                    pre.PrefixName = "Spider's";
                    pre.PrefixStat = "+2 spell level per day (if user can cast spells)";
                    pre.PrefixGP = 5000;
                }
                else if (spells <= 13)
                {
                    pre.PrefixName = "Raven's";
                    pre.PrefixStat = "+3 spell level per day (if user can cast spells)";
                    pre.PrefixGP = 7500;
                }
                else if (spells <= 17)
                {
                    pre.PrefixName = "Snake's";
                    pre.PrefixStat = "+4 spell level per day (if user can cast spells)";
                    pre.PrefixGP = 10000;
                }
                else if (spells <= 21)
                {
                    pre.PrefixName = "Serpant's";
                    pre.PrefixStat = "+5 spell level per day (if user can cast spells)";
                    pre.PrefixGP = 12500;
                }
                else if (spells <= 24)
                {
                    pre.PrefixName = "Drake's";
                    pre.PrefixStat = "+6 spell level per day (if user can cast spells)";
                    pre.PrefixGP = 15000;
                }
                else if (spells <= 26)
                {
                    pre.PrefixName = "Dragon's";
                    pre.PrefixStat = "+7 spell level per day (if user can cast spells)";
                    pre.PrefixGP = 17500;
                }
                else if (spells == 27)
                {
                    pre.PrefixName = "Wyrm's";
                    pre.PrefixStat = "+8 spell level per day (if user can cast spells)";
                    pre.PrefixGP = 20000;
                }
                else if (spells == 28)
                {
                    pre.PrefixName = "Hydra's";
                    pre.PrefixStat = "+9 spell level per day (if user can cast spells)";
                    pre.PrefixGP = 22500;
                }
                else if (spells <= 30)
                {
                    pre.PrefixName = "Devious";
                    pre.PrefixStat = "When user casts a spell, there is a 1 in 10 that full preparation is restored";
                    pre.PrefixGP = 22500;
                }
                else if (spells == 31)
                {
                    pre.PrefixName = "Fortitied";
                    pre.PrefixStat = "When user casts a spell, there is a 1 in 4 chance that full preparation is restored";
                    pre.PrefixGP = 25000;
                }
                else if (spells == 32)
                {
                    pre.PrefixName = "Triumphant";
                    pre.PrefixStat = "When you kill a foe in melee, you gain back 1 spell of your choice";
                    pre.PrefixGP = 25000;
                }
                else if (spells >= 33)
                {
                    pre.PrefixName = "Vulpine";
                    pre.PrefixStat = "User reduces any damage by 1/4 if he or she loses one prepared spell";
                    pre.PrefixGP = 27500;
                }
            } //Affects number of castable spells
            else if (Prefix_Roll <= 62)
            {
                //Affects magical items
                int magic = Dice.D(20) + CR;
                if (magic <= 6)
                {
                    pre.PrefixName = "Extending";
                    pre.PrefixStat = "Doubles the duration of herbs";
                    pre.PrefixGP = 2500;
                }
                else if (magic <= 12)
                {
                    pre.PrefixName = "Chrono";
                    pre.PrefixStat = "Doubles the duration of oils and resins";
                    pre.PrefixGP = 2500;
                }
                else if (magic <= 15)
                {
                    pre.PrefixName = "Fortuitous";
                    pre.PrefixStat = "+1 CR on base treasure table"; //problematic
                    pre.PrefixGP = 5000;
                }
                else if (magic <= 19)
                {
                    pre.PrefixName = "Augmenting";
                    pre.PrefixStat = "Doubles the effect of herbs";
                    pre.PrefixGP = 5000;
                }
                else if (magic >= 20)
                {
                    pre.PrefixName = "Catalyzing";
                    pre.PrefixStat = "Doubles the effect of oils and resins";
                    pre.PrefixGP = 2500;
                }

            } //Affects magical items
            else if (Prefix_Roll <= 70)
            {
                //Affects the users personal statistics 
                int stat = Dice.D(20) + CR;
                if (stat <= 2)
                {
                    pre.PrefixName = "Blue";
                    pre.PrefixStat = "+1 save vs. cold";
                    pre.PrefixGP = 2000;
                }
                else if (stat <= 4)
                {
                    pre.PrefixName = "Red";
                    pre.PrefixStat = "+1 save vs. fire";
                    pre.PrefixGP = 2000;
                }
                else if (stat <= 6)
                {
                    pre.PrefixName = "Orange";
                    pre.PrefixStat = "+1 save vs. lightning";
                    pre.PrefixGP = 2000;
                }
                else if (stat <= 8)
                {
                    pre.PrefixName = "White";
                    pre.PrefixStat = "+1 save vs. mind-influencing effect";
                    pre.PrefixGP = 2000;
                }
                else if (stat <= 10)
                {
                    pre.PrefixName = "Green";
                    pre.PrefixStat = "+1 save vs. poison";
                    pre.PrefixGP = 2000;
                }
                else if (stat <= 12)
                {
                    pre.PrefixName = "Black";
                    pre.PrefixStat = "+1 save vs. spell";
                    pre.PrefixGP = 2000;
                }
                else if (stat <= 14)
                {
                    pre.PrefixName = "Tough";
                    pre.PrefixStat = "+1 Constitution";
                    pre.PrefixGP = 2500;
                }
                else if (stat <= 16)
                {
                    pre.PrefixName = "Swift";
                    pre.PrefixStat = "+1 Dexterity";
                    pre.PrefixGP = 2500;
                }
                else if (stat <= 18)
                {
                    pre.PrefixName = "Brilliant";
                    pre.PrefixStat = "+1 Intelligence";
                    pre.PrefixGP = 2500;
                }
                else if (stat <= 20)
                {
                    pre.PrefixName = "Mighty";
                    pre.PrefixStat = "+1 Strength";
                    pre.PrefixGP = 2500;
                }
                else if (stat <= 22)
                {
                    pre.PrefixName = "Vibrant";
                    pre.PrefixStat = "+1 Wisdom";
                    pre.PrefixGP = 2500;
                }
                else if (stat <= 24)
                {
                    pre.PrefixName = "Forceful";
                    pre.PrefixStat = "+1 Charisma";
                    pre.PrefixGP = 2500;
                }
                else if (stat <= 26)
                {
                    pre.PrefixName = "Resilient";
                    pre.PrefixStat = "+1 AC";
                    pre.PrefixGP = 2500;
                }
                else if (stat <= 28)
                {
                    pre.PrefixName = "Silver";
                    pre.PrefixStat = "+1 attack";
                    pre.PrefixGP = 2500;
                }
                else if (stat <= 30)
                {
                    pre.PrefixName = "Muscular";
                    pre.PrefixStat = "+1 melee damage";
                    pre.PrefixGP = 2500;
                }
                else if (stat > 30)
                {
                    pre.PrefixName = "Healthy";
                    pre.PrefixStat = "+5 hit points";
                    pre.PrefixGP = 2500;
                }

            } //Affects the users personal statistics
            else if (Prefix_Roll <= 77)
            {
                //Improves attack scores
                int attack = Dice.D(20) + CR;
                if (attack <= 6)
                {
                    pre.PrefixName = "Bronze";
                    pre.PrefixStat = "+1 attack";
                    pre.PrefixGP = 2500;
                }
                else if (attack <= 8)
                {
                    pre.PrefixName = "Iron";
                    pre.PrefixStat = "+1 attack, +2 vs. undead and demonic creatures";
                    pre.PrefixGP = 3750;
                }
                else if (attack <= 13)
                {
                    pre.PrefixName = "Silver";
                    pre.PrefixStat = "+2 attack";
                    pre.PrefixGP = 5000;
                }
                else if (attack <= 15)
                {
                    pre.PrefixName = "Steel";
                    pre.PrefixStat = "+2 attack, +3 vs. undead and demonic creatures";
                    pre.PrefixGP = 6250;
                }
                else if (attack <= 19)
                {
                    pre.PrefixName = "Gold";
                    pre.PrefixStat = "+2 attack";
                    pre.PrefixGP = 7500;
                }
                else if (attack <= 21)
                {
                    pre.PrefixName = "Platinum";
                    pre.PrefixStat = "+3 attack, +a vs. undead and demonic creatures";
                    pre.PrefixGP = 8750;
                }
                else if (attack <= 25)
                {
                    pre.PrefixName = "Mithril";
                    pre.PrefixStat = "+4 attack";
                    pre.PrefixGP = 10000;
                }
                else if (attack <= 30)
                {
                    pre.PrefixName = "Meteoric";
                    pre.PrefixStat = "+5 attack";
                    pre.PrefixGP = 12500;
                }
                else if (attack > 30)
                {
                    pre.PrefixName = "Weird";
                    pre.PrefixStat = "+5 attack, extra successful hit on natural 20";
                    pre.PrefixGP = 15000;
                }

            } //Improves attack scores
            else if (Prefix_Roll <= 82)
            {
                //Has improved damage
                int damage = Dice.D(20) + CR;
                if (damage <= 5)
                {
                    pre.PrefixName = "Jagged";
                    pre.PrefixStat = "+1 damage";
                    pre.PrefixGP = 2500;
                }
                else if (damage <= 9)
                {
                    pre.PrefixName = "Deadly";
                    pre.PrefixStat = "+1 damage, increase threat range by 1";
                    pre.PrefixGP = 5000;
                }
                if (damage <= 13)
                {
                    pre.PrefixName = "Vicious";
                    pre.PrefixStat = "+2 damage";
                    pre.PrefixGP = 5000;
                }
                else if (damage <= 17)
                {
                    pre.PrefixName = "Heavy";
                    pre.PrefixStat = "+2 damage, increase threat range by 1";
                    pre.PrefixGP = 7500;
                }
                if (damage <= 21)
                {
                    pre.PrefixName = "Brutal";
                    pre.PrefixStat = "+3 damage";
                    pre.PrefixGP = 7500;
                }
                else if (damage <= 25)
                {
                    pre.PrefixName = "Massive";
                    pre.PrefixStat = "+3 damage, increase threat range by 1";
                    pre.PrefixGP = 10000;
                }
                if (damage <= 29)
                {
                    pre.PrefixName = "Savage";
                    pre.PrefixStat = "+4 damage, increase threat range by 1";
                    pre.PrefixGP = 12500;
                }
                else if (damage <= 33)
                {
                    pre.PrefixName = "Ruthless";
                    pre.PrefixStat = "+4 damage, increase threat range by 2";
                    pre.PrefixGP = 15000;
                }
                if (damage > 33)
                {
                    pre.PrefixName = "Merciless";
                    pre.PrefixStat = "+5 damage, increase threat range by 2";
                    pre.PrefixGP = 17500;
                }

            } //Has improved damage
            else if (Prefix_Roll <= 90)
            {
                //Improved attack scores and has improved damage
                int improve = Dice.D(20) + CR;
                if (improve <= 5)
                {
                    pre.PrefixName = "Sharp";
                    pre.PrefixStat = "+1 attack; increase threat range by 1";
                    pre.PrefixGP = 5000;
                }
                else if (improve <= 9)
                {
                    pre.PrefixName = "Fine";
                    pre.PrefixStat = "+1 attack; increase threat range by 2";
                    pre.PrefixGP = 7500;
                }
                else if (improve <= 13)
                {
                    pre.PrefixName = "Warrior's";
                    pre.PrefixStat = "+2 attack; increase threat range by 1";
                    pre.PrefixGP = 10000;
                }
                else if (improve <= 17)
                {
                    pre.PrefixName = "Soldier's";
                    pre.PrefixStat = "+2 attack; increase threat range by 2";
                    pre.PrefixGP = 12500;
                }
                else if (improve <= 21)
                {
                    pre.PrefixName = "Knight's";
                    pre.PrefixStat = "+3 attack; increase threat range by 1";
                    pre.PrefixGP = 15000;
                }
                else if (improve <= 25)
                {
                    pre.PrefixName = "Master's";
                    pre.PrefixStat = "+3 attack; increase threat range by 2";
                    pre.PrefixGP = 17500;
                }
                else if (improve <= 29)
                {
                    pre.PrefixName = "Doppelganger's";
                    pre.PrefixStat = "for each attack, roll a 1d4 and add it to attack and damage totals";
                    pre.PrefixGP = 20000;
                }
                else if (improve <= 33)
                {
                    pre.PrefixName = "Lord's";
                    pre.PrefixStat = "+4 attack; increase threat range by 1";
                    pre.PrefixGP = 20000;
                }
                else if (improve <= 37)
                {
                    pre.PrefixName = "Champion's";
                    pre.PrefixStat = "+4 attack; increase threat range by 2";
                    pre.PrefixGP = 22500;
                }
                else if (improve > 37)
                {
                    pre.PrefixName = "King's";
                    pre.PrefixStat = "+5 attack; increase threat range by 1";
                    pre.PrefixGP = 25000;
                }

            } //Improved attack scores and has improved damage
            else if (Prefix_Roll <= 100)
            {
                //Affects item's charges
                int charges = Dice.D(20) + CR;
                if (charges <= 15)
                {
                    pre.PrefixName = "Plentiful";
                    pre.PrefixStat = "Twices normal maximum charges";
                    pre.PrefixGP = 7500;
                }
                else if (charges <= 16)
                {
                    pre.PrefixName = "Jester's";
                    pre.PrefixStat = "Casts a random spell from Suffic table 91-100"; //confer
                    pre.PrefixGP = 10000;
                }
                else if (charges > 16)
                {
                    pre.PrefixName = "Bountiful";
                    pre.PrefixStat = "Three times normal maximum charges";
                    pre.PrefixGP = 12500;
                }
            } //Affects item's charges

            pre.rolls = Dice.rolls;
            return pre;
        }
    }
}