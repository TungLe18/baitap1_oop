using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1_oop
{
    class HoaDon
    {
       private string maHD;
        private string ngayBan;
        private int maKH;
        private string matHang;
        private int soLuong;
        private double tongTien;

        public string MaHD
        {
            get
            {
                return maHD;
            }

            set
            {
                maHD = value;
            }
        }

        public string NgayBan
        {
            get
            {
                return ngayBan;
            }

            set
            {
                ngayBan = value;
            }
        }

        public int MaKH
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

        public string MatHang
        {
            get
            {
                return matHang;
            }

            set
            {
                matHang = value;
            }
        }

        public int SoLuong
        {
            get
            {
                return soLuong;
            }

            set
            {
                soLuong = value;
            }
        }

        public double TongTien
        {
            get
            {
                return tongTien;
            }

            set
            {
                tongTien = value;
            }
        }

        public HoaDon(string mahoadon,string ngayban,int makh,string mathang,int soluong,double tongtien)
        {
            MaHD = mahoadon;
            NgayBan = ngayban;
            MaKH = makh;
            MatHang = mathang;
            SoLuong = soluong;
            TongTien = tongtien;
        }
        //khoi tao lop
        Bang bang = new Bang();
        Dia dia = new Dia();
        Sach sach = new Sach();


        List<string> danhsachHD = new List<string>();

        List<double> tienOnho = new List<double>();
        List<double> tienBangOnho = new List<double>();
        List<double> tienDiaOnho = new List<double>();
        List<double> tienSachOnho = new List<double>();



        List<int> soluongloaiSP = new List<int>();
        List<int> tongsoluong = new List<int>();


        double tongtienall = 0;
        int tongsl = 0;

       
        public void Nhap(SanPham[] listBang, SanPham[] listDia, SanPham[] listSach)
        {
            Console.WriteLine("Nhap ma hoa don: ");
            MaHD = Console.ReadLine();
            Console.WriteLine("Nhap ma khach");
            MaKH =int.Parse( Console.ReadLine());
            Console.WriteLine("Nhap ngay ban:");
            NgayBan = Console.ReadLine();
            int so= 0;
            int soluong = 0;
            while (so==0)
            {
                Console.WriteLine("Chon san pham can mua:\n 1. Bang ,\n 2.Dia, \n 3. Sach,\n 4. Tong tien \n 0.Thoat");
                int sp = int.Parse(Console.ReadLine());
                double tongtienBangGan = 0;
                double tongtienDiaGan = 0;
                double tongtienSachGan = 0;



                switch (sp)
                {
                    case 1:
                        {   Console.WriteLine("Nhap ma bang:");
                        bang.MaSP1 = Console.ReadLine();
                        danhsachHD.Add(bang.MaSP1);
                        Console.WriteLine("Nhap so luong:");
                        SoLuong = int.Parse(Console.ReadLine());
                        soluongloaiSP.Add(SoLuong);

                          
                            for (int i = 0; i < danhsachHD.Count; i++)
                        {
                            for (int j = 0; i < listBang.Length; j++)
                            {
                                if (listBang[j].MaSP1 == danhsachHD[i])
                                {
                                    tongtienBangGan = soluongloaiSP[i] * listBang[j].GiaBan1;
                                }
                            }
                        }
                        tienOnho.Add(tongtienBangGan);
                        tienBangOnho.Add(tongtienBangGan);
                        tongtienBangGan += soLuong;
                        break;
                }
                    case 2:
                        {   Console.WriteLine("Nhap ma dia:");
                        dia.MaSP1 = Console.ReadLine();
                        danhsachHD.Add(dia.MaSP1);
                        Console.WriteLine("Nhap so luong:");
                        SoLuong = int.Parse(Console.ReadLine());
                        soluongloaiSP.Add(SoLuong);

                        

                        for (int i = 0; i < danhsachHD.Count; i++)
                        {
                            for (int j = 0; i < listDia.Length; j++)
                            {
                                if (listDia[j].MaSP1 == danhsachHD[i])
                                {
                                    tongtienDiaGan = soluongloaiSP[i] * listDia[j].GiaBan1;
                                }
                            }
                        }
                        tienOnho.Add(tongtienDiaGan);
                        tienDiaOnho.Add(tongtienDiaGan);
                        tongtienDiaGan += soLuong;
                        break;
                }
                    case 3:
                        { 
                        Console.WriteLine("Nhap ma Sach:");
                        sach.MaSP1 = Console.ReadLine();
                        danhsachHD.Add(sach.MaSP1);
                        Console.WriteLine("Nhap so luong:");
                        SoLuong = int.Parse(Console.ReadLine());
                        soluongloaiSP.Add(SoLuong);


                        for (int i = 0; i < danhsachHD.Count; i++)
                        {
                            for (int j = 0; i < listSach.Length; j++)
                            {
                                if (listSach[j].MaSP1 == danhsachHD[i])
                                {
                                    tongtienSachGan = soluongloaiSP[i] * listSach[j].GiaBan1;
                                }
                            }
                        }
                        tienOnho.Add(tongtienSachGan);
                        tienSachOnho.Add(tongtienSachGan);
                        tongtienSachGan += soLuong;
                        break;
                          }
                    case 4:
                        {
                            double tienBangTong = 0, tienDiaTong = 0,tienSachTong = 0;
                            for (int i = 0; i < tienBangOnho.Count; i++)
                            {
                                tienBangTong += tienBangOnho[i];
                            }

                            for (int i = 0; i < tienDiaOnho.Count; i++)
                            {
                                tienDiaTong += tienDiaOnho[i];
                            }

                            for (int i = 0; i < tienSachOnho.Count; i++)
                            {
                                tienSachTong += tienSachOnho[i];
                            }

                            Console.WriteLine("\n Tong tien bang:{0}", tienBangTong, "\n Tong tien dia: {0}", tienDiaTong, "Tong tien sach:{0}", tienSachTong);

                            break;
                            
                         }
                    case 0:
                        {
                            so = 1;
                            break;
                        }






            }

                tongtienall = tongtienBangGan + tongtienDiaGan + tongtienSachGan;
                if (tongtienall > 200000)
                {
                    tongtienall = tongtienall - (tongtienall * 15 / 100);
                }


            }
            tongsoluong.Add(soluong);

        }

        public void Xuat()
        {
            string xuat = "\n Ma hoa don : " + MaHD + "\n Ma khach hang" + MaKH + "\n Ngay ban:" + NgayBan;
            for(int i = 0; i < danhsachHD.Count; i++)
            {
                xuat += "\n Loai hang:" + danhsachHD[i] + "\n So luong :" + soLuong + "\n Thanh tien:" + tongTien;
            }
            double tienXuat = 0;
            for (int i=0; i<danhsachHD.Count;i++)
            {
                tienXuat += tienOnho[i];
            }
            Console.WriteLine("\n Tong tien:", tienXuat);   
                
        }

        public void TongTienTheoLoai()
        {
            double tBang = 0, tDia = 0, tSach = 0;
           for(int i=0;i<tienBangOnho.Count;i++)
            {
                tBang = tienBangOnho[i];
            }
            for (int i = 0; i < tienDiaOnho.Count; i++)
            {
                tDia = tienDiaOnho[i];
            }
            for (int i = 0; i < tienSachOnho.Count; i++)
            {
                tSach = tienSachOnho[i];
            }

            Console.WriteLine("\n Tong tien bang:"+tBang + "\n Tong tien dia:" + tDia + "\n Tong tien sach:" + tSach);
        }

        public void TongSoLuong(List<HoaDon> lst)
        {
            List<HoaDon> listHD = new List<HoaDon>();
            listHD.Add(lst[0]);
            for(int i = 0; i < lst.Count; i++)
            {
                int sodem = 0;
                for(int j = 0; j < listHD.Count; j++)
                {
                    if (listHD[j].MaKH == lst[i].MaKH)
                    {
                        sodem++;
                        listHD[i].tongsl += lst[i].MaKH;
                    }
                }
                if (sodem == 0)
                {
                    listHD.Add(lst[i]);
                }
            }
            int Max = listHD[0].tongsl;
            for(int i = 0; i < listHD.Count; i++)
            {
                if (Max < listHD[i].tongsl)
                {
                    Max = listHD[i].tongsl;
                }

            }
            for (int i = 0; i < listHD.Count; i++)
            {
                if (Max < listHD[i].tongsl)
                {
                    Console.WriteLine("\n Ma khach hang :" + listHD[i].MaKH + "co" + listHD[i].tongsl);
                }
            }
        }
        class DanhSachLoaiHang
        {
            public int soLuong;
            public string Name;

            public DanhSachLoaiHang()
            {
                soLuong = 0;
                Name = "";
            }
            public DanhSachLoaiHang(int soluong,string name)
            {
                this.soLuong = soluong;
                this.Name = name;
            }
            public void XuatDSLH()
            {
                Console.WriteLine("\n So luong:");
                soLuong =int.Parse( Console.ReadLine());
                Console.WriteLine("\n Ten :");
                Name = Console.ReadLine();

            }
        }
        public HoaDon()
        {

        }
    }
}
