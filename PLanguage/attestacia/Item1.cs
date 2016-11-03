using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attestacia
{
    class Item1 : IItem
    {
        String name1;
        String name2;
        int int1;
        int int2;
        int int3;

        public void setName1(String str)
        {
            name1 = str;
        }

        public void setName2(String str)
        {
            name2 = str;
        }

        public void setInt1(int i)
        {
            int1 = i;
        }

        public void setInt2(int i)
        {
            int2 = i;
        }

        public void setInt3(int i)
        {
            int3 = i;
        }

        public string getName1()
        {
            return name1;
        }

        public string getName2()
        {
            return name2;
        }

        public int getInt1()
        {
            return int1;
        }

        public int getInt2()
        {
            return int2;
        }

        public int getInt3()
        {
            return int2;
        }
    }
}
