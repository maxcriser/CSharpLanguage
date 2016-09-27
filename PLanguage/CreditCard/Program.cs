using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard
{
    public class Program
    {
        static bool CheckAmericanExpress(String number, out string invalid) // AE
        {
            invalid = "INVALID";
            if (number.Length == 15 && (number.StartsWith("34") || number.StartsWith("37")))
            {
                invalid = "AMERICAN EXPRESS";
                return true;
            }
            return false;
        }

        static bool CheckMasterCard(String number, out string invalid) // MC
        {
            invalid = "INVALID";
            if (number.Length == 16 && (number.StartsWith("51") || number.StartsWith("52") || number.StartsWith("53") || number.StartsWith("54") || number.StartsWith("55")))
            {
                invalid = "MASTER CARD";
                return true;
            }
            return false;
        }

        static bool CheckVisa(String number, out string invalid) // Visa
        {
            invalid = "INVALID";
            if ((number.Length == 13 || number.Length == 16) && number.StartsWith("4"))
            {
                invalid = "VISA";
                return true;
            }
            return false;
        }

        static bool CheckValidator(String number)
        {
            int result = 0;
            int uneven;
            for (int i = 0; i < number.Length; i++)
            {
                uneven = 0;
                int val = number[i] - '0';
                if (i % 2 == 0)
                {
                    result += val;
                }
                else
                {
                    uneven = val * 2;
                    if (uneven > 9)
                    {
                        result += uneven % 10;
                        result += uneven / 10;
                    }
                    else
                    {
                        result += uneven;
                    }
                }
            }
            return (result % 10 == 0) ? true : false;
        }

        public static void Main(string[] args)
        {
            Console.Write("Number: ");
            String invalid = "INVALID";
            String number = Console.ReadLine();
            long numberCard;
            while (!long.TryParse(number, out numberCard))
            {
                Console.Write("Retry: ");
                number = Console.ReadLine();
            };
            if (CheckVisa(number, out invalid) || CheckMasterCard(number,out invalid) || CheckAmericanExpress(number, out invalid))
            {
                if (CheckValidator(number)) Console.WriteLine(invalid);
                else Console.WriteLine(invalid);
            }
            else
            {
                Console.WriteLine(invalid);
            }
        }
    }
}
