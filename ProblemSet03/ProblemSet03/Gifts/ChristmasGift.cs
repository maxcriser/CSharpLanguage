using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet03.Gifts
{
    class ChristmasGift : GiftBox
    {

        private ChristmasGift() { }

        public ChristmasGift(Gift gift)
        {
            innerGift = gift;
            Width = 50;
            Height = 50;
            Length = 75;
        }
    }
}
