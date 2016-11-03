using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark
{
    public abstract class Машина
    {
        public String тип;
        public String марка;
        public String госНомер;
        public int годВыпуска;
        public int пробег;
        public int расход;

        public Машина(String тип, String марка, String госНомер, int годВыпуска, int пробег, int расход)
        {
            this.тип = тип;
            this.марка = марка;
            this.госНомер = госНомер;
            this.годВыпуска = годВыпуска;
            this.пробег = пробег;
            this.расход = расход;
        }
    }
}