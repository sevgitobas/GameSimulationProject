using GameSimulationProject.Abstract;
using GameSimulationProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationProject.Concrete
{
    public class GameManager : ISellService
    {
        public void Calculate(List<Game> games)
        {
            double i = 0;
            foreach (var price in games)
            {
                i = i + price.Price;
            }
            Console.WriteLine("Fatura tutarınız : " + i);
        }

        public void ListGame(List<Game> games)
        {
            Console.WriteLine("\nOyun listesi listeleniyor...");
            foreach (var game in games)
            {
                Console.WriteLine(game.GameCategory + " kategorisinden "+ game.GameName + " oyunu "+ 
                    game.Price + " TL'dir. Id No = " + game.Id);
            }
        }

    }
}
