using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            SanPham[] listBang = new SanPham[5];
            SanPham[] listDia = new SanPham[5];
            SanPham[] listSach = new SanPham[5];

            List<HoaDon> listHD = new List<HoaDon>();

            List<double> tienBang = new List<double>();
            List<double> tienDia = new List<double>();
            List<double> tienSach = new List<double>();

            listBang[0] = new Bang("B00", "BTD0", "BNSX0", 1000, "30 phút");
            listBang[1] = new Bang("B01", "BTD1", "BNSX1", 1000, "20 phút");
            listBang[2] = new Bang("B02", "BTD2", "BNSX2", 2000, "30 phút");
            listBang[3] = new Bang("B03", "BTD3", "BNSX3", 3000, "40 phút");
            listBang[4] = new Bang("B04", "BTD4", "BNSX4", 4000, "50 phút");

            listDia[0] = new Dia("D00", "DTD0", "DNSX0", 3000, "10 phút");
            listDia[1] = new Dia("D01", "DTD1", "DNSX1", 5000, "90 phút");
            listDia[2] = new Dia("D02", "DTD2", "DNSX2", 6000, "70 phút");
            listDia[3] = new Dia("D03", "DTD3", "DNSX3", 7000, "150 phút");
            listDia[4] = new Dia("D04", "DTD4", "DNSX4", 8000, "30 phút");

            listSach[0] = new Sach("S00", "STD0", "SNSX0", 60000, "STTC0", 120);
            listSach[1] = new Sach("S01", "STD1", "SNSX1", 10000, "STTC1", 70);
            listSach[2] = new Sach("S02", "STD2", "SNSX2", 50000, "STTC3", 520);
            listSach[3] = new Sach("S03", "STD3", "SNSX3", 70000, "STTC4", 420);
            listSach[4] = new Sach("S04", "STD4", "SNSX4", 80000, "STTC5", 220);

            while (true)
            {
                Console.WriteLine("\n 1.Nhap thong tin \n 2. In thong tin \n 3.Tong So luong \n 4. Tong tien \n 0. Thoat");
                Console.WriteLine("Moi chon 1 2 3 4 0");
                int chon;
                chon = int.Parse(Console.ReadLine());
                HoaDon hoadon = new HoaDon();
                switch (chon)
                {
                    case 1:
                        {
                            hoadon.Nhap(listBang, listDia, listSach);
                            listHD.Add(hoadon);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\n Danh sach hoa don:");
                            for (int i = 0; i < listHD.Count; i++)
                            {
                                listHD[i].Xuat();

                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("\n Khach hnag mua nhieu nhat:");
                            hoadon.TongSoLuong(listHD);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("\n Tong tien:");
                            listHD[0].TongTienTheoLoai();
                            break;
                        }
                    case 0:
                        {

                            break;
                        }

                }
                Console.ReadLine();
                Console.Clear();

            }


        }
    }
}
