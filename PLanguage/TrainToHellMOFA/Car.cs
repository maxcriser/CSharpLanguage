using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainToHellMOFA
{
    public abstract class Car
    {
        public String type;
        public int cost;
        public int speed;
        public int exp;

        public Car(String type, int cost, int speed, int exp)
        {
            this.type = type;
            this.cost = cost;
            this.speed = speed;
            this.exp = exp;
        }
    }
}
