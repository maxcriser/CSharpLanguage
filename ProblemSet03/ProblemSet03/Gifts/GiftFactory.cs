using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProblemSet03.Sweets;
using ProblemSet03.Gifts;

namespace ProblemSet03
{
    class GiftFactory
    {
        private GiftFactory() { }
        private const int NUM_SWEETS_CHRISTMAS_GIFT = 25;
        private const int NUM_SWEETS_BIRTHDAY_GIFT = 30;
        private const int NUM_SWEETS_DEFAULT = 20;

        public static ChristmasGift GetChristmasGift()
        {
            AbstractSweet[] sweets = new AbstractSweet[NUM_SWEETS_CHRISTMAS_GIFT];
            Random rnd = new Random();
            for (int i = 0; i <= 10; i++)
            {
                sweets[i] = new Candy(rnd.Next(0xFFFFFF));
            }
            HashSet<AbstractSweet.Filling> cookieFillings = new HashSet<AbstractSweet.Filling>();
            cookieFillings.Add(AbstractSweet.Filling.Chocolate);
            cookieFillings.Add(AbstractSweet.Filling.Nut);
            for (int i = 11; i <= 20; i++)
            {
                sweets[i] = new Cookie(cookieFillings);
            }
            sweets[21] = new Waffle();
            sweets[22] = new Waffle();
            sweets[23] = new Marshmallow(Marshmallow.Flavors.Banana);
            sweets[24] = new Marshmallow(Marshmallow.Flavors.Lemon);
            return new ChristmasGift((new Gift.Builder()).AddSweets(sweets).Build());
        }

        public static BirthdayGift GetBirthdayGift()
        {
            AbstractSweet[] sweets = new AbstractSweet[NUM_SWEETS_BIRTHDAY_GIFT];
            Random rnd = new Random();
            HashSet<AbstractSweet.Filling> cookieFillings = new HashSet<AbstractSweet.Filling>();
            cookieFillings.Add(AbstractSweet.Filling.Chocolate);
            cookieFillings.Add(AbstractSweet.Filling.Nut);
            cookieFillings.Add(AbstractSweet.Filling.Fudge);
            for (int i = 0; i <= 10; i++)
            {
                sweets[i] = new Cookie(cookieFillings);
            }
            for (int i = 11; i <= 20; i++)
            {
                sweets[i] = new Waffle();
            }
            for (int i = 21; i <= 25; i++)
            {
                sweets[i] = new Chocolate(Chocolate.ChocolateType.Milky, AbstractSweet.Filling.Nut);
            }
            for (int i = 26; i < 30; i++)
            {
                Marshmallow.Flavors flavor = Marshmallow.Flavors.Vanilla;
                switch (rnd.Next(4))
                {
                    case 0:
                        flavor = Marshmallow.Flavors.Banana;
                        break;
                    case 1:
                        flavor = Marshmallow.Flavors.Lemon;
                        break;
                    case 2:
                        flavor = Marshmallow.Flavors.Orange;
                        break;
                    case 3:
                        flavor = Marshmallow.Flavors.Strawberry;
                        break;
                }
                sweets[i] = new Marshmallow(flavor);
            }
            return new BirthdayGift((new Gift.Builder()).AddSweets(sweets).Build());
        }

        public static RandomGift GetRandomGift()
        {
            AbstractSweet[] sweets = new AbstractSweet[NUM_SWEETS_DEFAULT];
            Random rnd = new Random();
            HashSet<AbstractSweet.Filling> cookieFillings = new HashSet<AbstractSweet.Filling>();
            cookieFillings.Add(AbstractSweet.Filling.Nut);
            int numCookies = rnd.Next(6);
            int numMarshmallows = rnd.Next(4);
            int numWaffles = rnd.Next(4);
            int numChocolate = rnd.Next(6);
            int numCandies = NUM_SWEETS_DEFAULT - numCookies - numMarshmallows - numChocolate - numWaffles;
            int sweetsAdded = 0;
            for (int i = sweetsAdded; i < numCookies; i++)
            {
                sweets[i] = new Cookie(cookieFillings);
                sweetsAdded++;
            }
            int bound = sweetsAdded + numMarshmallows;
            for (int i = sweetsAdded; i < bound; i++)
            {
                Marshmallow.Flavors flavor = Marshmallow.Flavors.Vanilla;
                switch (rnd.Next(4))
                {
                    case 0:
                        flavor = Marshmallow.Flavors.Banana;
                        break;
                    case 1:
                        flavor = Marshmallow.Flavors.Lemon;
                        break;
                    case 2:
                        flavor = Marshmallow.Flavors.Orange;
                        break;
                    case 3:
                        flavor = Marshmallow.Flavors.Strawberry;
                        break;
                }
                sweets[i] = new Marshmallow(flavor);
                sweetsAdded++;
            }
            bound = sweetsAdded + numWaffles;
            for (int i = sweetsAdded; i < bound; i++)
            {
                sweets[i] = new Waffle();
                sweetsAdded++;
            }
            bound = sweetsAdded + numChocolate;
            for (int i = sweetsAdded; i < bound; i++)
            {
                Chocolate.ChocolateType type;
                AbstractSweet.Filling filling;
                if (rnd.Next(2) == 0)
                {
                    type = Chocolate.ChocolateType.Milky;
                    filling = AbstractSweet.Filling.Nut;
                }
                else
                {
                    type = Chocolate.ChocolateType.Bitter;
                    filling = AbstractSweet.Filling.Fudge;
                }
                sweets[i] = new Chocolate(type, filling);
                sweetsAdded++;
            }
            for (int i = sweetsAdded; i < NUM_SWEETS_DEFAULT; i++)
            {
                sweets[i] = new Candy(rnd.Next(0xFFFFFF));
            }
            return new RandomGift((new Gift.Builder()).AddSweets(sweets).Build());
        }
    }
}
