using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    class NhanVienKinhDoanh : NhanVien
    {
        private static int luongCoBan = 4000000;
        private int soHopDong;

        public NhanVienKinhDoanh(string maNV, string tenNV, int soHopDong) : base(maNV, tenNV)
        {
            this.soHopDong = soHopDong;
        }

        public NhanVienKinhDoanh()
        {
        }

        public static int LuongCoBan { get => luongCoBan; set => luongCoBan = value; }
        public int SoHopDong { get => soHopDong; set => soHopDong = value; }

        public override double TinhLuong()
        {
            return luongCoBan + soHopDong * 500000;
        }
    }
}
