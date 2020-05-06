using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    abstract class NhanVien
    {
        protected string maNV;
        protected string tenNV;

        public NhanVien(string maNV, string tenNV)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
        }

        public NhanVien()
        {
        }

        public abstract double TinhLuong();
    }
}
