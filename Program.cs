using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200629_Superpowers
{

    class Supementas : IHero
    {
        public string HeroName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int HeroRank { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void PrintWhoWins()
        {
            Console.WriteLine("me");
        }

        public bool WillHeroWin(int enemyRank, string enemyName)
        {
            return true;
        }
    }


    class Herojus : IHero
    {
        public string HeroName { get;  }
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
        {
        }
    }
}
