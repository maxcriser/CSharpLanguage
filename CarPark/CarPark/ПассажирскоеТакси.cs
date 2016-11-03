using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark
{
    class ПассажирскоеТакси : Машина
    {
        public int количествоПассажиров;
        public int стоимостьЗа5кмПоездки;

        public ПассажирскоеТакси(String тип, 
            String марка,
            String госНомер,
            int годВыпуска,
            int пробег,
            int расход,
            int количествоПассажиров,
            int стоимостьЗа5кмПоездки) : base(тип, марка,
                              госНомер,
                              годВыпуска,
                              пробег,
                              расход)
        {
            this.количествоПассажиров = количествоПассажиров;
            this.стоимостьЗа5кмПоездки = стоимостьЗа5кмПоездки;
        }

        public override string ToString()
        {
            return тип + " " + 
                марка + " " + 
                госНомер + " " + 
                годВыпуска + " " + 
                пробег + " " + 
                расход + " " + 
                количествоПассажиров + " " + 
                стоимостьЗа5кмПоездки;
        }
    }
}
