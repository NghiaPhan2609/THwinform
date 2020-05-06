using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbtnNVKD_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNVKD.Checked)
            {
                lbSoHopDong.Visible = true;
                tbSoHopDong.Visible = true;
            }
            else
            {
                lbSoHopDong.Visible = false;
                tbSoHopDong.Visible = false;
            }
                
        }

        private void rbtnNVSX_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNVSX.Checked)
            {
                lbSoLuongSanPham.Visible = true;
                tbSoLuongSanPham.Visible = true;
            }
            else
            {
                lbSoLuongSanPham.Visible = false;
                tbSoLuongSanPham.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NhanVien nv;
            string maNV =  tbMaNV.Text;
            string tenNV = tbTenNV.Text;
            //check if NVKD is selected
            if(rbtnNVKD.Checked)
            {
                if (tbSoHopDong.Text.Equals(""))
                    MessageBox.Show("Luong is null");
                else
                {
                    int soHopDong = Convert.ToInt32(tbSoHopDong.Text);
                    nv = new NhanVienKinhDoanh(maNV, tenNV, soHopDong);
                    lbLuong.Text = nv.TinhLuong().ToString();
                }
            }
            //check if NVSX is selected
            if (rbtnNVSX.Checked)
            {
                if (tbSoLuongSanPham.Text.Equals(""))
                    MessageBox.Show("So luong san pham is null");
                else
                {
                    int soLuongSP = Convert.ToInt32(tbSoLuongSanPham.Text);
                    nv = new NhanVienSanXuat(maNV, tenNV, soLuongSP);
                    lbLuong.Text = nv.TinhLuong().ToString();
                }
            }
        }
    }
}
