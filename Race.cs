using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mario_Kart_Punkterechner
{
    internal class Race
    {
        private string[] spots = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" };
        private string placements;
        private string enemyPlacements1;
        private string enemyPlacements2;
        private string enemyPlacements3;
        private string enemyPlacements4;
        private string enemyPlacements5;
        private string format;
        private string track;
        private int score;
        private int enemyScore;
        private int enemyScore2;
        private int enemyScore3;
        private int enemyScore4;
        private int enemyScore5;
        public string Track { get => track; }
        public int Score { get => score; }
        public int EnemyScore { get => enemyScore; }
        public int EnemyScore2 { get => enemyScore2; }
        public int EnemyScore3 { get => enemyScore3; }
        public int EnemyScore4 { get => enemyScore4; }
        public int EnemyScore5 { get => enemyScore5; }
        public string Placements { get => placements; }
        public string EnemyPlacements1 { get => enemyPlacements1; }
        public string EnemyPlacements2 { get => enemyPlacements2; }
        public string EnemyPlacements3 { get => enemyPlacements3; }
        public string EnemyPlacements4 { get => enemyPlacements4; }
        public string EnemyPlacements5 { get => enemyPlacements5; }

        // 6v6, 5v5, 4v4, 3v3, 2v2
        public Race(string p, string f)
        {
            placements = p;
            format = f;
            track = "";
            InitScore();
        }

        // 4v4...
        public Race(string p, string f, string ep)
        {
            placements = p;
            format = f;
            enemyPlacements1 = ep;
            InitScore();
        }

        // 3v3...
        public Race(string p, string f, string ep, string ep2)
        {
            placements = p;
            format = f;
            enemyPlacements1 = ep;
            enemyPlacements2 = ep2;
            InitScore();
        }

        // 2v2...
        public Race(string p, string f, string ep, string ep2, string ep3, string ep4)
        {
            placements = p;
            format = f;
            enemyPlacements1 = ep;
            enemyPlacements2 = ep2;
            enemyPlacements3 = ep3;
            enemyPlacements4 = ep4;
            InitScore();
        }

        public string[] GetPlacements(int scoreNeeded, out string[] mirror)
        {
            switch(scoreNeeded)
            {
                case 0:
                    string[] pl = placements.Split(' ');
                    mirror = new string[pl.Length];
                    foreach (string placement in pl)
                    {
                        foreach (string spot in spots)
                        {
                            int i = 0;
                            if (!placement.Contains(spot) && !mirror.Contains(spot))
                            {
                                mirror[i] = placement;
                                i++;
                            }
                        }
                    }
                    return pl;
                case 1:
                    pl = enemyPlacements1.Split(' ');
                    mirror = new string[pl.Length];
                    foreach (string placement in pl)
                    {
                        foreach (string spot in spots)
                        {
                            int i = 0;
                            if (!placement.Contains(spot) && !mirror.Contains(spot))
                            {
                                mirror[i] = placement;
                                i++;
                            }
                        }
                    }
                    return pl;
                case 2:
                    pl = enemyPlacements2.Split(' ');
                    mirror = new string[pl.Length];
                    foreach (string placement in pl)
                    {
                        foreach (string spot in spots)
                        {
                            int i = 0;
                            if (!placement.Contains(spot) && !mirror.Contains(spot))
                            {
                                mirror[i] = placement;
                                i++;
                            }
                        }
                    }
                    return pl;
                case 3:
                    pl = enemyPlacements3.Split(' ');
                    mirror = new string[pl.Length];
                    foreach (string placement in pl)
                    {
                        foreach (string spot in spots)
                        {
                            int i = 0;
                            if (!placement.Contains(spot) && !mirror.Contains(spot))
                            {
                                mirror[i] = placement;
                                i++;
                            }
                        }
                    }
                    return pl;
                case 4:
                    pl = enemyPlacements4.Split(' ');
                    mirror = new string[pl.Length];
                    foreach (string placement in pl)
                    {
                        foreach (string spot in spots)
                        {
                            int i = 0;
                            if (!placement.Contains(spot) && !mirror.Contains(spot))
                            {
                                mirror[i] = placement;
                                i++;
                            }
                        }
                    }
                    return pl;
                case 5:
                    pl = enemyPlacements5.Split(' ');
                    mirror = new string[pl.Length];
                    foreach (string placement in pl)
                    {
                        foreach (string spot in spots)
                        {
                            int i = 0;
                            if (!placement.Contains(spot) && !mirror.Contains(spot))
                            {
                                mirror[i] = placement;
                                i++;
                            }
                        }
                    }
                    return pl;
                default:
                    throw new Exception("An unexpected error has occured.");
            }
        }

        public int GetDifferenz(int team)
        {
            switch(team)
            {
                case 0:
                    return score - enemyScore;
                case 1:
                    return score - enemyScore2;
                case 2:
                    return score - enemyScore3;
                case 3:
                    return score - enemyScore4;
                case 4:
                    return score - enemyScore5;
                default:
                    return -255;
            }
        }

        public void SetTrack(string tr)
        {
            track = tr;
        }

        public void InitScore()
        {
            int maxScore6v6 = 82;
            int maxScore5v5 = 58;
            int maxScore4v4 = 39;
            int maxScore3v3 = 22;
            int maxScore2v2 = 11;
            int total = 0;
            string[] pl = GetPlacements(0, out string[] waste);
            Exception ex = new Exception("Invalid amount of placements for team 1.");
            Exception ex2 = new Exception("Invalid amount of placements for team 2.");

            switch (format)
            {
                case "6v6":
                    foreach (string score in pl)
                    {
                        if (pl.Length != 6) throw ex;
                        switch (score)
                        {
                            case "1":
                                total += 15;
                                break;
                            case "2":
                                total += 12;
                                break;
                            case "3":
                                total += 10;
                                break;
                            case "4":
                                total += 9;
                                break;
                            case "5":
                                total += 8;
                                break;
                            case "6":
                                total += 7;
                                break;
                            case "7":
                                total += 6;
                                break;
                            case "8":
                                total += 5;
                                break;
                            case "9":
                                total += 4;
                                break;
                            case "10":
                                total += 3;
                                break;
                            case "11":
                                total += 2;
                                break;
                            case "12":
                                total += 1;
                                break;
                        }
                    }
                    score = total;
                    enemyScore = maxScore6v6 - total;
                    break;
                case "5v5":
                    foreach (string score in pl)
                    {
                        if (pl.Length != 5) throw ex;
                        switch (score)
                        {
                            case "1":
                                total += 12;
                                break;
                            case "2":
                                total += 10;
                                break;
                            case "3":
                                total += 8;
                                break;
                            case "4":
                                total += 7;
                                break;
                            case "5":
                                total += 6;
                                break;
                            case "6":
                                total += 5;
                                break;
                            case "7":
                                total += 4;
                                break;
                            case "8":
                                total += 3;
                                break;
                            case "9":
                                total += 2;
                                break;
                            case "10":
                                total += 1;
                                break;
                        }
                    }
                    score = total;
                    enemyScore = maxScore5v5 - total;
                    break;
                case "4v4":
                    foreach (string score in pl)
                    {
                        if (pl.Length != 4) throw ex;
                        switch (score)
                        {
                            case "1":
                                total += 10;
                                break;
                            case "2":
                                total += 8;
                                break;
                            case "3":
                                total += 6;
                                break;
                            case "4":
                                total += 5;
                                break;
                            case "5":
                                total += 4;
                                break;
                            case "6":
                                total += 3;
                                break;
                            case "7":
                                total += 2;
                                break;
                            case "8":
                                total += 1;
                                break;
                        }
                    }
                    score = total;
                    enemyScore = maxScore4v4 - total;
                    break;
                case "3v3":
                    foreach (string score in pl)
                    {
                        if (pl.Length != 3) throw ex;
                        switch (score)
                        {
                            case "1":
                                total += 7;
                                break;
                            case "2":
                                total += 5;
                                break;
                            case "3":
                                total += 4;
                                break;
                            case "4":
                                total += 3;
                                break;
                            case "5":
                                total += 2;
                                break;
                            case "6":
                                total += 1;
                                break;
                        }
                    }
                    score = total;
                    enemyScore = maxScore3v3 - total;
                    break;
                case "2v2":
                    foreach (string score in pl)
                    {
                        if (pl.Length != 2) throw ex;
                        switch (score)
                        {
                            case "1":
                                total += 5;
                                break;
                            case "2":
                                total += 3;
                                break;
                            case "3":
                                total += 2;
                                break;
                            case "4":
                                total += 1;
                                break;
                        }
                    }
                    score = total;
                    enemyScore = maxScore2v2 - total;
                    break;
                case "4v4...":
                    foreach (string score in pl)
                    {
                        if(pl.Length != 4) throw ex;
                        switch (score)
                        {
                            case "1":
                                total += 15;
                                break;
                            case "2":
                                total += 12;
                                break;
                            case "3":
                                total += 10;
                                break;
                            case "4":
                                total += 9;
                                break;
                            case "5":
                                total += 8;
                                break;
                            case "6":
                                total += 7;
                                break;
                            case "7":
                                total += 6;
                                break;
                            case "8":
                                total += 5;
                                break;
                            case "9":
                                total += 4;
                                break;
                            case "10":
                                total += 3;
                                break;
                            case "11":
                                total += 2;
                                break;
                            case "12":
                                total += 1;
                                break;
                        }
                    }
                    score = total;
                    total = 0;
                    string[] epl = GetPlacements(1, out string[] w);
                    foreach (string score in epl)
                    {
                        if (epl.Length != 4) throw ex2;
                        switch (score)
                        {
                            case "1":
                                total += 15;
                                break;
                            case "2":
                                total += 12;
                                break;
                            case "3":
                                total += 10;
                                break;
                            case "4":
                                total += 9;
                                break;
                            case "5":
                                total += 8;
                                break;
                            case "6":
                                total += 7;
                                break;
                            case "7":
                                total += 6;
                                break;
                            case "8":
                                total += 5;
                                break;
                            case "9":
                                total += 4;
                                break;
                            case "10":
                                total += 3;
                                break;
                            case "11":
                                total += 2;
                                break;
                            case "12":
                                total += 1;
                                break;
                        }
                    }
                    enemyScore = total;
                    enemyScore2 = maxScore6v6 - score - enemyScore;
                    break;
                case "3v3...":
                    foreach (string score in pl)
                    {
                        if (pl.Length != 3) throw ex;
                        switch (score)
                        {
                            case "1":
                                total += 15;
                                break;
                            case "2":
                                total += 12;
                                break;
                            case "3":
                                total += 10;
                                break;
                            case "4":
                                total += 9;
                                break;
                            case "5":
                                total += 8;
                                break;
                            case "6":
                                total += 7;
                                break;
                            case "7":
                                total += 6;
                                break;
                            case "8":
                                total += 5;
                                break;
                            case "9":
                                total += 4;
                                break;
                            case "10":
                                total += 3;
                                break;
                            case "11":
                                total += 2;
                                break;
                            case "12":
                                total += 1;
                                break;
                        }
                    }
                    score = total;
                    total = 0;
                    epl = GetPlacements(1, out string[] w2);
                    foreach (string score in epl)
                    {
                        if (epl.Length != 3) throw ex2;
                        switch (score)
                        {
                            case "1":
                                total += 15;
                                break;
                            case "2":
                                total += 12;
                                break;
                            case "3":
                                total += 10;
                                break;
                            case "4":
                                total += 9;
                                break;
                            case "5":
                                total += 8;
                                break;
                            case "6":
                                total += 7;
                                break;
                            case "7":
                                total += 6;
                                break;
                            case "8":
                                total += 5;
                                break;
                            case "9":
                                total += 4;
                                break;
                            case "10":
                                total += 3;
                                break;
                            case "11":
                                total += 2;
                                break;
                            case "12":
                                total += 1;
                                break;
                        }
                    }
                    enemyScore = total;
                    total = 0;
                    epl = GetPlacements(2, out string[] w3);
                    foreach (string score in epl)
                    {
                        if (epl.Length != 3) throw ex2;
                        switch (score)
                        {
                            case "1":
                                total += 15;
                                break;
                            case "2":
                                total += 12;
                                break;
                            case "3":
                                total += 10;
                                break;
                            case "4":
                                total += 9;
                                break;
                            case "5":
                                total += 8;
                                break;
                            case "6":
                                total += 7;
                                break;
                            case "7":
                                total += 6;
                                break;
                            case "8":
                                total += 5;
                                break;
                            case "9":
                                total += 4;
                                break;
                            case "10":
                                total += 3;
                                break;
                            case "11":
                                total += 2;
                                break;
                            case "12":
                                total += 1;
                                break;
                        }
                    }
                    enemyScore2 = total;
                    enemyScore3 = maxScore6v6 - score - enemyScore - enemyScore2;
                    break;
                case "2v2...":
                    foreach (string score in pl)
                    {
                        if (pl.Length != 2) throw ex;
                        switch (score)
                        {
                            case "1":
                                total += 15;
                                break;
                            case "2":
                                total += 12;
                                break;
                            case "3":
                                total += 10;
                                break;
                            case "4":
                                total += 9;
                                break;
                            case "5":
                                total += 8;
                                break;
                            case "6":
                                total += 7;
                                break;
                            case "7":
                                total += 6;
                                break;
                            case "8":
                                total += 5;
                                break;
                            case "9":
                                total += 4;
                                break;
                            case "10":
                                total += 3;
                                break;
                            case "11":
                                total += 2;
                                break;
                            case "12":
                                total += 1;
                                break;
                        }
                    }
                    score = total;
                    total = 0;
                    epl = GetPlacements(1, out string[] w5);
                    foreach (string score in epl)
                    {
                        if (pl.Length != 2) throw ex;
                        switch (score)
                        {
                            case "1":
                                total += 15;
                                break;
                            case "2":
                                total += 12;
                                break;
                            case "3":
                                total += 10;
                                break;
                            case "4":
                                total += 9;
                                break;
                            case "5":
                                total += 8;
                                break;
                            case "6":
                                total += 7;
                                break;
                            case "7":
                                total += 6;
                                break;
                            case "8":
                                total += 5;
                                break;
                            case "9":
                                total += 4;
                                break;
                            case "10":
                                total += 3;
                                break;
                            case "11":
                                total += 2;
                                break;
                            case "12":
                                total += 1;
                                break;
                        }
                    }
                    enemyScore = total;
                    total = 0;
                    epl = GetPlacements(2, out string[] w6);
                    foreach (string score in epl)
                    {
                        if (pl.Length != 2) throw ex;
                        switch (score)
                        {
                            case "1":
                                total += 15;
                                break;
                            case "2":
                                total += 12;
                                break;
                            case "3":
                                total += 10;
                                break;
                            case "4":
                                total += 9;
                                break;
                            case "5":
                                total += 8;
                                break;
                            case "6":
                                total += 7;
                                break;
                            case "7":
                                total += 6;
                                break;
                            case "8":
                                total += 5;
                                break;
                            case "9":
                                total += 4;
                                break;
                            case "10":
                                total += 3;
                                break;
                            case "11":
                                total += 2;
                                break;
                            case "12":
                                total += 1;
                                break;
                        }
                    }
                    enemyScore2 = total;
                    total = 0;
                    epl = GetPlacements(3, out string[] w7);
                    foreach (string score in epl)
                    {
                        if (pl.Length != 2) throw ex;
                        switch (score)
                        {
                            case "1":
                                total += 15;
                                break;
                            case "2":
                                total += 12;
                                break;
                            case "3":
                                total += 10;
                                break;
                            case "4":
                                total += 9;
                                break;
                            case "5":
                                total += 8;
                                break;
                            case "6":
                                total += 7;
                                break;
                            case "7":
                                total += 6;
                                break;
                            case "8":
                                total += 5;
                                break;
                            case "9":
                                total += 4;
                                break;
                            case "10":
                                total += 3;
                                break;
                            case "11":
                                total += 2;
                                break;
                            case "12":
                                total += 1;
                                break;
                        }
                    }
                    enemyScore3 = total;
                    total = 0;
                    epl = GetPlacements(4, out string[] w8);
                    foreach (string score in epl)
                    {
                        if (pl.Length != 2) throw ex;
                        switch (score)
                        {
                            case "1":
                                total += 15;
                                break;
                            case "2":
                                total += 12;
                                break;
                            case "3":
                                total += 10;
                                break;
                            case "4":
                                total += 9;
                                break;
                            case "5":
                                total += 8;
                                break;
                            case "6":
                                total += 7;
                                break;
                            case "7":
                                total += 6;
                                break;
                            case "8":
                                total += 5;
                                break;
                            case "9":
                                total += 4;
                                break;
                            case "10":
                                total += 3;
                                break;
                            case "11":
                                total += 2;
                                break;
                            case "12":
                                total += 1;
                                break;
                        }
                    }
                    enemyScore4 = total;
                    enemyScore5 = maxScore6v6 - score - enemyScore - enemyScore2 - enemyScore3 - enemyScore4;
                    break;
            }
        }
    }
}
