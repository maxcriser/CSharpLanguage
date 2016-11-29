using ProblemSet03.Gifts;
using ProblemSet03.Sweets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet03
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramMenu();
        }

        static void ProgramMenu()
        {
            ChristmasGift christmasGift = GiftFactory.GetChristmasGift();
            BirthdayGift birthdayGift = GiftFactory.GetBirthdayGift();
            RandomGift randomGift = GiftFactory.GetRandomGift();
            christmasGift.Open();
            birthdayGift.Open();
            randomGift.Open();
            Gift gift = christmasGift.GetGift();
            Console.WriteLine("===========Christmas Gift. Weight " + gift.GetWeight() + "===========");
            Console.WriteLine("===========Sort by weight============");
            gift.SortByWeight();
            PrintArray(gift.Sweets);
            Console.WriteLine("===========Sort by percent of sugar============");
            gift.SortByPercentOfSugar();
            PrintArray(gift.Sweets);
            Console.WriteLine("===========Birthday Gift. Weight " + birthdayGift.GetGift().GetWeight() + "===========");
            PrintArray(birthdayGift.GetGift().Sweets);
            Console.WriteLine("===========Random Gift. Weight " + randomGift.GetGift().GetWeight() + "===========");
            PrintArray(randomGift.GetGift().Sweets);
            Console.WriteLine("\nType 'pack' to pack your own gift, or something another to quit");
            string command = Console.ReadLine();
            if (command.Equals("pack"))
            {
                Console.WriteLine("\n\n\nFirst of all, let's define a box for a gift");
                Console.WriteLine("Type it's length, width and height: ");
                int length = 0;
                int width = 0;
                int height = 0;
                while (length != 0 && width != 0 && height != 0)
                {
                    string value = Console.ReadLine();
                    try
                    {
                        if (length == 0)
                            length = Int32.Parse(value);
                        if (width == 0)
                            width = Int32.Parse(value);
                        if (height == 0)
                            height = Int32.Parse(value);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Number is not valid. Try once more!");
                    }
                }
                GiftBox box = new GiftBox(length, width, height);
                Console.WriteLine("Good! Box is created. Let's fill it with your own gift!");
                List<AbstractSweet> sweets = new List<AbstractSweet>();
                string cmd = String.Empty;
                bool outFlag = false;
                while (!outFlag)
                {
                    Console.WriteLine("What do you want to add? (Type 'end' to end with filling)");
                    Console.WriteLine("1) Candy");
                    Console.WriteLine("2) Cookie");
                    Console.WriteLine("3) Marshmallow");
                    Console.WriteLine("4) Waffle");
                    Console.WriteLine("5) Chocolate");
                    int sweetType = 0;
                    while (sweetType == 0)
                    {
                        cmd = Console.ReadLine();
                        if (cmd.Equals("end"))
                        {
                            outFlag = true;
                            break;
                        }
                        try
                        {
                            sweetType = Int32.Parse(cmd);
                            if (!(sweetType >= 1 && sweetType <= 5)) throw new Exception();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Wrong menu item! Try again");
                            sweetType = 0;
                        }
                    }
                    switch (sweetType)
                    {
                        case 1:
                            {
                                Random rnd = new Random();
                                Candy candy = new Candy(rnd.Next(0xFFFFFF));
                                sweets.Add(candy);
                            }
                            break;
                        case 2:
                            {
                                HashSet<AbstractSweet.Filling> fillings = new HashSet<AbstractSweet.Filling>();
                                fillings.Add(AbstractSweet.Filling.Chocolate);
                                Cookie cookie = new Cookie(fillings);
                                sweets.Add(cookie);
                            }
                            break;
                        case 3:
                            {
                                Marshmallow marshmallow = new Marshmallow(Marshmallow.Flavors.Strawberry);
                                sweets.Add(marshmallow);
                            }
                            break;
                        case 4:
                            {
                                Waffle waffle = new Waffle();
                                sweets.Add(waffle);
                            }
                            break;
                        case 5:
                            {
                                Chocolate chocolate = new Chocolate(Chocolate.ChocolateType.Milky, AbstractSweet.Filling.Nut);
                                sweets.Add(chocolate);
                            }
                            break;
                    }
                }
                Console.WriteLine("Okay, you added all what you wanted. Let's pack all!");
                Gift userGift = (new Gift.Builder()).AddSweets(sweets).Build();
                Console.WriteLine("And put all in a box!");
                box.AddGift(userGift);
                Console.WriteLine("The End! Let's see what do you created!");
                Console.WriteLine("===========User's Gift===========");
                Console.WriteLine("Weight: " + userGift.GetWeight());
                Console.WriteLine("Average percent of sugar: " + userGift.GetAveragePercentOfSugar());
                Console.WriteLine("Sweets in gift: ");
                PrintArray(userGift.Sweets);
                Console.ReadLine();
            }
        }

        static void PrintArray(List<AbstractSweet> sweets)
        {
            foreach (var sweet in sweets)
            {
                Console.WriteLine(sweet);
            }
        }
    }
}
