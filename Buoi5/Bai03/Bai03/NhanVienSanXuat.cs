using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    class NhanVienSanXuat : NhanVien
    {
        private int soLuongSanPhan;
        public NhanVienSanXuat(string maNV, string tenNV, int soLuongSanPhan) : base(maNV, tenNV)
        {
            this.soLuongSanPhan = soLuongSanPhan;
        }

        public override double TinhLuong()
        {
            double luong = soLuongSanPhan * 1000;
            if (soLuongSanPhan >= 3000)
                luong += (luong * 0.05);
            return luong;
        }
    }
}
