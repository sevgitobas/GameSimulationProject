using GameSimulationProject.Abstract;
using GameSimulationProject.Concrete;
using GameSimulationProject.Entities;
using System;
using System.Collections.Generic;

namespace GameSimulationProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string karsılama = "Oyun sistemine hoşgeldiniz!";
            Console.WriteLine(karsılama);

            IPlayerService playerService = new PlayerManager(new ValidationServiceManager());
            playerService.Add(new Player { Id = 1, FirstName = "Yıldız", LastName = "Yılmaz", 
                DateofBirth = new DateTime(1990, 5, 20), TcNo = 12345678910}); //ekleme
            
            Player player = new Player {Id = 2, FirstName = "Şahika", LastName = "Ekinci", 
                DateofBirth = new DateTime(1988, 4, 12), TcNo = 54628731084};
            playerService.Delete(player); //silme
            
            playerService.UpDate(new Player
            {
                Id = 2,
                FirstName = "Ender",
                LastName = "Çelebi",
                DateofBirth = new DateTime(1987, 1, 21),
                TcNo = 165549820135
            }); //güncelleme

            Game game1 = new Game() { Id = 1, GameName = "Harry Potter", GameCategory = "Simülasyon", Price = 19.40 };
            Game game2 = new Game() { Id = 2, GameName = "Mario", GameCategory = "Macera", Price = 25.90 };

            List<Game> games = new List<Game> { game1, game2 };

            ISellService sellService = new GameManager();
            sellService.ListGame(games);
            sellService.Calculate(games);

        }
    }
}
