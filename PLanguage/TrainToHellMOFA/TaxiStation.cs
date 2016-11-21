using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TrainToHellMOFA
{
    class TaxiStation
    {

        class SortByExp : Comparer<Car>
        {
            public override int Compare(Car cur, Car next)
            {
                if (cur.exp < next.exp) return -1;
                else if (cur.exp > next.exp) return 1;
                else return 0;
            }
        }

        public List<Car> cars;
        private String PATH;

        public TaxiStation(String PATH)
        {
            this.PATH = PATH;
            cars = new List<Car>();
            readCars();
        }

        public List<Car> getRangeCars(int min, int max)
        {
            List<Car> curCars = new List<Car>();

            foreach(Car c in cars)
            {
                if(c.speed <= max && c.speed >= min)
                {
                    curCars.Add(c);
                }
            }

            return curCars;
        }

        public void sortByExp()
        {
            SortByExp methodSortByExp = new SortByExp();
            cars.Sort(methodSortByExp);
        }

        public int costTaxiStation()
        {
            int curCost = 0;

            foreach (Car w in cars)
            {
                curCost += w.cost;
            }
            return curCost;
        }

        public List<Car> readCars()
        {
            List<Car> ourCars = new List<Car>();
            StreamReader stream = new StreamReader(PATH, Encoding.GetEncoding(1251));
            while (!stream.EndOfStream)
            {
                String line = stream.ReadLine().ToLower();
                String[] array = line.Split();

                if (array[0].Equals("passenger"))
                {
                    Passenger pCar = new Passenger(
                        array[0],
                        Int32.Parse(array[1]),
                        Int32.Parse(array[2]),
                        Int32.Parse(array[3]),
                        Int32.Parse(array[4]),
                        Int32.Parse(array[5])
                        );
                    ourCars.Add(pCar);
                }
                else
                {
                    Minivan minivan = new Minivan(
                        array[0],
                        Int32.Parse(array[1]),
                        Int32.Parse(array[2]),
                        Int32.Parse(array[3]),
                        Int32.Parse(array[4]),
                        Int32.Parse(array[5])
                        );
                    ourCars.Add(minivan);

                }
            }
            cars = ourCars;
            return ourCars;
        }
    }
}
