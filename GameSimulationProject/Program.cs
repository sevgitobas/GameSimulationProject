using GameSimulationProject.Abstract;
using GameSimulationProject.Concrete;
using GameSimulationProject.Entities;
using System;

namespace GameSimulationProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BasePlayerManager basePlayerManager = new PlayerManager();
            basePlayerManager.Add(new Player { Id = 1, FirstName = "Yıldız", LastName = "Yılmaz", 
                DateofBirth = new DateTime(1990, 5, 20), TcNo = "12345678910"}); //ekleme
            
            Player player = new Player {Id = 2, FirstName = "Şahika", LastName = "Ekinci", 
                DateofBirth = new DateTime(1988, 4, 12), TcNo = "54628731084"};
            basePlayerManager.Delete(player); //silme
            
            basePlayerManager.UpDate(new Player
            {
                Id = 2,
                FirstName = "Ender",
                LastName = "Çelebi",
                DateofBirth = new DateTime(1987, 1, 21),
                TcNo = "165549820135"
            }); //güncelleme
        }
    }
}
