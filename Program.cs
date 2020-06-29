using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200629_Superpowers
{
    interface IHero
    {
        string HeroName { get; set; }

        int HeroRank { get; set; }

        bool WillHeroWin(int enemyRank, string enemyName);

        void PrintWhoWins();
    }

    interface IVilain
    {
        string Name { get; set; }

        string Rank { get; set; }

        bool WillVilainWin(int enemyRank, string enemyName);

        void PrintWhoWins();
 
    }

    class Heojus : IHero
    {
        public string HeroName { get; set; }
        public int HeroRank { get; set; }

        public bool WillHeroWin(int enemyRank, string enemyName)
        {
            return true;
        }

        public void PrintWhoWins()
        {
            
        }
    }

    class AntiHerojus : IVilain
    {
        public string Name { get; set; }
        public string Rank { get; set; }     

        public void PrintWhoWins()
        {
            
        }

        public bool WillVilainWin(int enemyRank, string enemyName)
        {
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
