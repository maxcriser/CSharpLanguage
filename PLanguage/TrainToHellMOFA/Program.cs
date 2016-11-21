using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainToHellMOFA
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxiStation taxiStation = new TaxiStation(@"D:\TaxiStation.txt");
            taxiStation.sortByExp();

            for (int i = 0; i < taxiStation.cars.Count; i++)
            {
                Console.WriteLine(taxiStation.cars[i].type + " "
                            + taxiStation.cars[i].cost + " "
                            + taxiStation.cars[i].speed + " "
                            + taxiStation.cars[i].exp + " ");
            }

            int cost = taxiStation.costTaxiStation();
            Console.WriteLine("COST = " + cost);

            int min = 0;
            int max = 0;
            do
            {
                Console.Write("Input min: ");
                min = int.Parse(Console.ReadLine());

                Console.Write("Input max: ");
                max = int.Parse(Console.ReadLine());

            } while ((min < 1 || max < 1) || (min > max));

            List<Car> rangeCars = taxiStation.getRangeCars(min, max);

            for (int i = 0; i < rangeCars.Count; i++)
            {
                Console.WriteLine(rangeCars[i].type + " " 
                            + rangeCars[i].speed + " ");
            }

            Console.ReadKey();
        }
    }
}
