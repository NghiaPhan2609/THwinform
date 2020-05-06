using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    class PhanSo
    {
        private int tu, mau;

        public int Tu { get => tu; set => tu = value; }
        public int Mau { get => mau; set => mau = value; }

        public PhanSo()
        {

        }

        public PhanSo(int tu, int mau)
        {
            this.tu = tu;
            this.mau = mau;
        }

        public void RutGon()
        {
            int ucln = UCLN(tu, mau);
            tu /= ucln;
            mau /= ucln;
        }

        private int UCLN(int a, int b)
        {
            if (b == 0)
                return a;
            return UCLN(b, a % b);
        }

        public static PhanSo operator +(PhanSo ps1, PhanSo ps2)
        {
            PhanSo rs = new PhanSo(ps1.tu * ps2.mau + ps2.tu * ps1.mau, ps1.mau * ps2.mau);
            rs.RutGon();
            return rs;
        }

        public override string ToString()
        {
            return $"{tu}/{mau}";
        }
    }
}
