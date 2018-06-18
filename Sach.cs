using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1_oop
{
    class Sach:SanPham
    {
        private string tenTacGia;
        private int soTrang;

        public string TenTacGia
        {
            get
            {
                return tenTacGia;
            }

            set
            {
                tenTacGia = value;
            }
        }

        public int SoTrang
        {
            get
            {
                return soTrang;
            }

            set
            {
                soTrang = value;
            }
        }

        public Sach(string masp, string tuade, string nhasanxuat, double giaban, string tentacgia,int sotrang) : base(masp, tuade, nhasanxuat, giaban)
        {
            TenTacGia = tentacgia;
            SoTrang = sotrang;
        }
        public Sach()
        {

        }

    }
}
