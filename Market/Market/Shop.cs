using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market
{
    public partial class Shop : Form
    {
        String username;
        String password;

        public Shop(String username, String password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

    }
}
