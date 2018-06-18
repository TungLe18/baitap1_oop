using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1_oop
{
    class Bang:SanPham
    {
        string thoiGian;
        public Bang(string masp, string tuade,string nhasanxuat,double giaban,string thoigian) : base(masp, tuade, nhasanxuat, giaban)
        {
            thoiGian = thoigian;
        }

        public string ThoiGian
        {
            get
            {
                return thoiGian;
            }

            set
            {
                thoiGian = value;
            }
        }
        public Bang()
        {

        }
    }
}
