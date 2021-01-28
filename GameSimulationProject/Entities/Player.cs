using GameSimulationProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationProject.Entities
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long TcNo { get; set; }
        public DateTime DateofBirth { get; set; }

    }
}
