using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CarPark
{
    class СортировкаПоПробегу : Comparer<Машина>
    {
        public override int Compare(Машина текущая, Машина следующуя)
        {
            if (текущая.пробег < следующуя.пробег) return -1;
            else if (текущая.пробег > следующуя.пробег) return 1;
            else return 0;
        }
    }

    public class Таксопарк
    {
        public List<Машина> машиныЫЫЫ;
        private String путь;

        public Таксопарк(String путь)
        {
            this.путь = путь;
            машиныЫЫЫ = new List<Машина>();
            читаемТачки();
        }

        public void сортПоПробегу()
        {
            СортировкаПоПробегу самыйчёткийметод = new СортировкаПоПробегу();
            машиныЫЫЫ.Sort(самыйчёткийметод);
        }

        public void удалитьСтарушек(int год)
        {
            List<Машина> тача = машиныЫЫЫ;
            for (int i = 0; i < тача.Count; i++)
            {
                int x = тача[i].годВыпуска;
                if (x < год)
                {
                    тача.RemoveAt(i);
                }
            }
            машиныЫЫЫ = тача;
        }

        public int кОплатеПассажирскоеТакси(int дальностьПоездки, int стоимостьЗа5км)
        {
            int заОдинКм = стоимостьЗа5км / 5;
            return дальностьПоездки * заОдинКм;
        }

        public int кОплатеГрузовоеТакси(int стоимостьЗаЧас, int количествоЧасов)
        {
            // обычно берут на целую ночь, поэтому (мои поправки, извините, не удержался)
            if (количествоЧасов == 12)
            {
                return 100; // друзья рассказывали
            }
            // если я правильно понял условие, то
            if (количествоЧасов > 1)
            {
                return стоимостьЗаЧас + (количествоЧасов * стоимостьЗаЧас / 2);
            }
            else
            {
                return стоимостьЗаЧас;
            }
        }

        public void пишемТачки(string выписка)
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"D:\Не новый текстовый документ.txt"))
            {
                for (int i = 0; i < машиныЫЫЫ.Count; i++)
                {
                    file.WriteLine(машиныЫЫЫ[i].тип + " "
                        + машиныЫЫЫ[i].марка + " "
                        + машиныЫЫЫ[i].госНомер + " "
                        + машиныЫЫЫ[i].годВыпуска + " "
                        + машиныЫЫЫ[i].тип + " "
                        + машиныЫЫЫ[i].пробег + " "
                        + машиныЫЫЫ[i].тип + " "
                        + машиныЫЫЫ[i].расход);
                    //// получить доступ к другим полям
                }
            }
        }

        public List<Машина> читаемТачки()
        {
            List<Машина> тачки = new List<Машина>();
            StreamReader stream = new StreamReader(путь, Encoding.GetEncoding(1251));
            while (!stream.EndOfStream)
            {
                String line = stream.ReadLine().ToLower();
                String[] array = line.Split();

                if (array[0].Equals("пассажирское"))
                {
                    ПассажирскоеТакси пТакси = new ПассажирскоеТакси(
                        array[0],
                        array[1],
                        array[2],
                        Int32.Parse(array[3]),
                        Int32.Parse(array[4]),
                        Int32.Parse(array[5]),
                        Int32.Parse(array[6]),
                        Int32.Parse(array[7])
                        );
                    тачки.Add(пТакси);
                }
                else
                {
                    ГрузовоеТакси гТакси = new ГрузовоеТакси(
                        array[0],
                        array[1],
                        array[2],
                        Int32.Parse(array[3]),
                        Int32.Parse(array[4]),
                        Int32.Parse(array[5]),
                        Int32.Parse(array[6]),
                        Int32.Parse(array[7])
                        );
                    тачки.Add(гТакси);
                }

            }
            машиныЫЫЫ = тачки;
            return тачки;
        }


    }
}
