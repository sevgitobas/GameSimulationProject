using GameSimulationProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationProject.Abstract
{
    public interface ISellService
    {
        void Calculate(List<Game> games);
        void ListGame(List<Game> games);
    }
}
