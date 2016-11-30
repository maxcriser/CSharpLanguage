using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    public class User
    {
        public String username;
        public String password;

        public User(String username, String password)
        {
            this.username = username;
            this.password = password;
        }
    }
}
