using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark
{
    class ГрузовоеТакси : Машина
    {
        public int грузоподъёмность;
        public int стоимостьЗаЧас; // странно звучит данное сочетание (или сочИтание, лень гуглить) слов

        public ГрузовоеТакси(String тип, 
            String марка,
            String госНомер,
            int годВыпуска,
            int пробег,
            int расход,
            int грузоподъёмность,
            int стоимостьЗаЧас) : base(тип, марка,
                              госНомер,
                              годВыпуска,
                              пробег,
                              расход)
        {
            this.грузоподъёмность = грузоподъёмность;
            this.стоимостьЗаЧас = стоимостьЗаЧас;
        }

        public override string ToString()
        {
            return тип + " " +
                марка + " " +
                госНомер + " " +
                годВыпуска + " " +
                пробег + " " +
                расход + " " +
                грузоподъёмность + " " +
                стоимостьЗаЧас;
        }
    }
}
