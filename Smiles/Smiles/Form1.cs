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
            List<Item> list = new List<Item>();
            list  = tercuman.Deserialize<List<Item>>(read);
            
            foreach (var item in list )
            {
                Button btn = new Button();
                string json = item.art.ToString()+Environment.NewLine+item.name.ToString();
                btn.Text = json;
                flowLayoutPanel1.Controls.Add(btn);
                

            }
        }
    }
}
