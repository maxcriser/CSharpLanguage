using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSet03.Gifts
{
    abstract class Box
    {
        public int Width { get; protected set; }
        public int Height { get; protected set; }
        public int Length { get; protected set; }
        public bool IsOpened { get; protected set; }

        public int GetVolume()
        {
            return Width * Height * Length;
        }

        public void Open()
        {
            if (IsOpened) throw new InvalidOperationException();
            else
            {
                IsOpened = true;
            }
        }
    }
}
