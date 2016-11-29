using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet03.Gifts
{
    class RandomGift : GiftBox
    {
        private RandomGift() { }

        public RandomGift(Gift gift)
        {
            innerGift = gift;
            Random rnd = new Random();
            Width = rnd.Next(25, 100);
            Height = rnd.Next(25, 60);
            Length = rnd.Next(25, 100);
        }
    }
}
