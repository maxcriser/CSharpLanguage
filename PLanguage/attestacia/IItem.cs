using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attestacia
{
    interface IItem
    {
        void setName1(String str);

        void setName2(String str);

        void setInt1(int i);

        void setInt2(int i);

        void setInt3(int i);

        String getName1();

        String getName2();

        int getInt1();

        int getInt2();

        int getInt3();
    }
}
