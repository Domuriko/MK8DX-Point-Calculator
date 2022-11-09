using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mario_Kart_Punkterechner
{
    internal class War
    {
        private List<Race> races;
        private string home;
        private string guest;
        private string team3;
        private string team4;
        private string team5;
        private string team6;
        private string format;
        public string Home { get => home; }
        public string Guest { get => guest; }
        public string Team3 { get => team3; }
        public string Team4 { get => team4; }
        public string Team5 { get => team5; }
        public string Team6 { get => team6; }

        public War(string h, string g, string f)
        {
            races = new List<Race>();
            home = h;
            guest = g;
            format = f;
        }

        public War(string h, string g, string f, string t)
        {
            races = new List<Race>();
            home = h;
            guest = g;
            team3 = t;
            format = f;
        }

        public War(string h, string g, string f, string t, string t2)
        {
            races = new List<Race>();
            home = h;
            guest = g;
            team3 = t;
            team4 = t2;
            format = f;
        }

        public War(string h, string g, string f, string t, string t2, string t3)
        {
            races = new List<Race>();
            home = h;
            guest = g;
            team3 = t;
            team4 = t2;
            team5 = t3;
            format = f;
        }

        public War(string h, string g, string f, string t, string t2, string t3, string t4)
        {
            races = new List<Race>();
            home = h;
            guest = g;
            team3 = t;
            team4 = t2;
            team5 = t3;
            team6 = t4;
            format = f;
        }

        public void AddRace(Race race)
        {
            races.Add(race);
        }

        public int GetDifferenz(int team)
        {
            int total = 0;
            foreach (Race r in races)
            {
                total += r.GetDifferenz(team);
            }
            return total;
        }

        public int GetFullScore()
        {
            int total = 0;
            foreach (Race r in races)
            {
                total += r.Score;
            }
            return total;
        }

        public int GetFullEnemyScore(int team)
        {
            switch(team)
            {
                case 1:
                    int total = 0;
                    foreach (Race r in races)
                    {
                        total += r.EnemyScore;
                    }
                    return total;
                case 2:
                    total = 0;
                    foreach (Race r in races)
                    {
                        total += r.EnemyScore2;
                    }
                    return total;
                case 3:
                    total = 0;
                    foreach (Race r in races)
                    {
                        total += r.EnemyScore3;
                    }
                    return total;
                case 4:
                    total = 0;
                    foreach (Race r in races)
                    {
                        total += r.EnemyScore4;
                    }
                    return total;
                case 5:
                    total = 0;
                    foreach (Race r in races)
                    {
                        total += r.EnemyScore5;
                    }
                    return total;
                default: return 0;
            }
        }
    }
}
