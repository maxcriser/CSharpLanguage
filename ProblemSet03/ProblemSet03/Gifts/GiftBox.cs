using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProblemSet03.Gifts
{
    class GiftBox : Box
    {
        protected Gift innerGift;

        protected GiftBox() { }

        public GiftBox(int length, int width, int height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public Gift GetGift()
        {
            if (!IsOpened) throw new InvalidOperationException();
            else {
                return innerGift;
            }
        }

        public void AddGift(Gift userGift)
        {
            innerGift = userGift;
        }
    }
}
