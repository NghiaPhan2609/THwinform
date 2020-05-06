using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private PhanSo FormatToPhanSo(string ps) //get value form textbox then format to PhanSo 
        {
            string[] rs = ps.Split(new char[] {'/'});
            int x = Convert.ToInt32(rs[0]);
            int y = Convert.ToInt32(rs[1]);
            return new PhanSo(x, y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbX.Text.Equals("") || tbY.Text.Equals("")) //check if x or y is null
            {
                MessageBox.Show("x or y is null");
            }
            else
            {
                PhanSo ps1 = FormatToPhanSo(tbX.Text);
                PhanSo ps2 = FormatToPhanSo(tbY.Text);
                PhanSo rs = ps1 + ps2;
                lbResult.Text = rs.ToString();
            }
                
        }
    }
}
