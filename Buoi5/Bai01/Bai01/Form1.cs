using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbResult_Click(object sender, EventArgs e)
        {

        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            if(tboxX.Text.Equals("") || tboxY.Equals(""))
            {
                MessageBox.Show("x (and y) is/are null");
                
            }           
            else
            {
                double x = Convert.ToDouble(tboxX.Text);
                double y = Convert.ToDouble(tboxY.Text);
                double rs = Math.Pow(x, y);
                lbResult.Text = rs.ToString();
            }
            
            
        }
    }
}
