using GameSimulationProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationProject.Abstract
{
    public interface IGamerValidationService
    {
        bool Validate(Player player);
    }
}
