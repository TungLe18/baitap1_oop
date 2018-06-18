using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1_oop
{
    class KhachHang
    {
        private string maKH;
        private string tenKH;
        private int Sdt;

        public string MaKH
        {
            get
            {
                return maKH;
            }

            set
            {
                maKH = value;
            }
        }

        public string TenKH
        {
            get
            {
                return tenKH;
            }

            set
            {
                tenKH = value;
            }
        }

        public int Sdt1
        {
            get
            {
                return Sdt;
            }

            set
            {
                Sdt = value;
            }
        }

        public KhachHang(string makh, string tenkh,int sdt)
        {
            MaKH = makh;
            TenKH = tenkh;
            Sdt1 = sdt;
        }
        public KhachHang()
        {

        }
    }
}
