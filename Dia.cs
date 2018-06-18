using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1_oop
{
    class Dia:SanPham
    {
        string thoiGian;
        public Dia(string masp, string tuade, string nhasanxuat, double giaban, string thoigian) : base(masp, tuade, nhasanxuat, giaban)
        {
            ThoiGian = thoigian;
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
        public Dia()
        {

        }
    }
}
