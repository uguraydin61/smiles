using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Smiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string read = File.ReadAllText(".../../smiley_content.json");
            JavaScriptSerializer tercuman = new JavaScriptSerializer();
            List<RootObject > list = new List<RootObject >();
            list  = tercuman.Deserialize<List<RootObject >>(read);
            int sayi = 0;
            foreach (var item in list )
            {
                Button btn = new Button();
                btn.Width = 120;
                btn.Height = 40;
                btn.BackColor = Color.GreenYellow;
                string json = item.items[0].art + Environment .NewLine +item.category;
                btn.Text = json;
                flowLayoutPanel1.Controls.Add(btn);

            }
        }
    }
}
