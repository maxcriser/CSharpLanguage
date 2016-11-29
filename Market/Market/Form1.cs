using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Market
{
    public partial class Form1 : Form
    {
        private string admin = @"admin.xml";
        public Form1()
        {
            InitializeComponent();

            XMLEditor.CreateXml(Constants.ownerPATH + admin);

            XmlDocument document = new XmlDocument();
            document.Load(Constants.ownerPATH + admin);

            XmlNode element = document.CreateElement("user");
            document.DocumentElement.AppendChild(element);
            XmlAttribute attribute = document.CreateAttribute("admin");
            attribute.Value = "0";
            element.Attributes.Append(attribute);

            XmlNode subElement1 = document.CreateElement("login"); // даём имя
            subElement1.InnerText = "maxcriser"; // и значение
            element.AppendChild(subElement1); // и указываем кому принадлежит
            
            XmlNode subElement2 = document.CreateElement("password");
            subElement2.InnerText = "maxim12Guest345";
            element.AppendChild(subElement2);

            document.Save(Constants.ownerPATH + admin);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            startForm1(Constants.owner);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startForm1(Constants.customer);
        }

        void startForm1(String type)
        {
            this.Hide();
            Signin signin = new Signin(type);
            signin.ShowDialog();
            this.Close();
        }
    }
}
