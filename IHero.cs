namespace _20200629_Superpowers
{
    interface IHero
    {
        string HeroName { get; set; }

        int HeroRank { get; set; }

        bool WillHeroWin(int enemyRank, string enemyName);

        void PrintWhoWins();
    }
}
