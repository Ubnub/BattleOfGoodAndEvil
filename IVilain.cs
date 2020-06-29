namespace _20200629_Superpowers
{
    interface IVilain
    {
        string Name { get; set; }

        string Rank { get; set; }

        bool WillVilainWin(int enemyRank, string enemyName);

        void PrintWhoWins();
 
    }
}
