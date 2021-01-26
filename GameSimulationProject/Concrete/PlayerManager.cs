using GameSimulationProject.Abstract;
using GameSimulationProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationProject.Concrete
{
    public class PlayerManager : BasePlayerManager
    {
        private Player player;
        public virtual void Add()
        {
            CheckIfRealPerson(player);
            Console.WriteLine("eklendi");
        }

        private bool CheckIfRealPerson(Player player)
        {
            return true;
        }
    }
}
