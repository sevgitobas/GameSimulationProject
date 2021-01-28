using GameSimulationProject.Abstract;
using GameSimulationProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationProject.Concrete
{
    public class PlayerManager : IPlayerService
    {
        IGamerValidationService _gamerValidationService;

        public PlayerManager(IGamerValidationService gamerValidationService)
        {
            _gamerValidationService = gamerValidationService;
        }

        public void Add(Player player)
        {
            if (_gamerValidationService.Validate(player)==true)
            {
                Console.WriteLine("Oyuncu eklendi : " + player.FirstName);
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt yapılamadı.");
            }
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Oyuncu silindi : " + player.FirstName);
        }

        public void UpDate(Player player)
        {
            Console.WriteLine("Oyuncu güncellendi : " + player.FirstName);
        }
    }
}
