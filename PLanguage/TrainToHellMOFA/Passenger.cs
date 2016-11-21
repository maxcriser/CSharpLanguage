using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainToHellMOFA
{
    class Passenger : Car
    {
        public int capacity;
        public int countDrivers;

        public Passenger(String type, int cost, int speed, int exp, int capacity, int countDrivers) : base(type, cost, speed, exp)
        {
            this.capacity = capacity;
            this.countDrivers = countDrivers;
        }

        public override string ToString()
        {
            return type + " " + cost + " " + speed + " " + exp + " " + capacity + " " + countDrivers;
        }
    }
}
