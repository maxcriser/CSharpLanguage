using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet03.Gifts
{
    class BirthdayGift : GiftBox
    {

        private BirthdayGift() { }

        public BirthdayGift(Gift gift)
        {
            innerGift = gift;
            Width = 100;
            Height = 70;
            Length = 80;
        }
    }
}
