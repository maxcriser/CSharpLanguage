using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainToHellMOFA
{
    class Minivan : Car
    {
        public int countWheels;
        public int countDoors;

        public Minivan(String type, int cost, int speed, int exp, int capacity, int countDoors) : base(type, cost, speed, exp)
        {
            this.countWheels = capacity;
            this.countDoors = countDoors;
        }

        public override string ToString()
        {
            return type + " " + cost + " " + speed + " " + exp + " " + countWheels + " " + countDoors;
        }
    }
}
