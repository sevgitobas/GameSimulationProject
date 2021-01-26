using GameSimulationProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationProject.Abstract
{
    public abstract class BasePlayerManager : IPlayerService
    {
        public void Add(Player player)
        {
            Console.WriteLine("Veritabanına kaydedildi : " + player.FirstName);
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Oyuncu silindi : " + player.FirstName);
        }
        public void UpDate(Player player)
        {
            Console.WriteLine("Bilgileriniz güncellendi. Player-" + player.FirstName);
        }
    }
}
