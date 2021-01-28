using GameSimulationProject.Abstract;
using GameSimulationProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationProject.Concrete
{
    public class ValidationServiceManager : IGamerValidationService
    {

        public bool Validate(Player player)
        {
            if (player.FirstName=="Yıldız" && player.LastName=="Yılmaz" && player.TcNo == 12345678910)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
