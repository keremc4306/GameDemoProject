using System;
using System.Collections.Generic;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer()
            {
                Id = 1,
                Name = "Nurullah",
                Surname = "Sütçü",
                BirthOfDay = "09.12.1994",
                TcNo = "20843290736",
                NickName = "Nuro"
            };
            Gamer gamer2 = new Gamer()
            {
                Id = 2,
                Name = "Ezgi",
                Surname = "Polat",
                BirthOfDay = "08.06.1992",
                TcNo = "16094678906",
                NickName = "EPolat"
            };

            List<Gamer> gamers = new List<Gamer>() { gamer1, gamer2 };
            GamerManager gamerManager = new GamerManager(new NewEstateUserValidationManager());
            gamerManager.Add(gamers);

            Game game1 = new Game() { Id = 1, Name = "PES20", Platform = "XBOX", Price = 90.6 };
            Game game2 = new Game() { Id = 2, Name = "Tetris", Platform = "PS-4", Price = 67.3 };

            List<Game> games = new List<Game>() { game1, game2 };

            Campaign campaign = new Campaign() { Id = 1, Name = "Black Friday", DiscountRate = 50, CampaignDetails = "Mayıs Sonuna Kadar" };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            Sales sales = new Sales();
            sales.Sell(games, gamer1, campaign);
        }
    }
}
