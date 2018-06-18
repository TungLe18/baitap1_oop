using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1_oop
{
    class SanPham
    {
        private string MaSP;
        private string TuaDe;
        private string NhaSanXXuat;
        private double GiaBan;

        public string MaSP1
        {
            get
            {
                return MaSP;
            }

            set
            {
                MaSP = value;
            }
        }

        public string TuaDe1
        {
            get
            {
                return TuaDe;
            }

            set
            {
                TuaDe = value;
            }
        }

        public string NhaSanXXuat1
        {
            get
            {
                return NhaSanXXuat;
            }

            set
            {
                NhaSanXXuat = value;
            }
        }

        public double GiaBan1
        {
            get
            {
                return GiaBan;
            }

            set
            {
                GiaBan = value;
            }
        }

        public SanPham()
        {

        }
        public SanPham(string masp,string tuade,string nhasanxuat,double giaban)
        {
            MaSP = masp;
            TuaDe = tuade;
            NhaSanXXuat = nhasanxuat;
            GiaBan = giaban;
        }
    }
}
