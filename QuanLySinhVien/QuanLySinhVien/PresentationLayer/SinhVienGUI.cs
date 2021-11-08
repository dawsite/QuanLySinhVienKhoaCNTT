using System;
using System.Collections.Generic;
using System.Text;
using QuanLySinhVien.BusinessLayer;
using QuanLySinhVien.Entities;
using QuanLySinhVien.Utilities;

namespace QuanLySinhVien.PresentationLayer
{
    public class SinhVienGUI
    {
        private SinhVienBLL svBLL = new SinhVienBLL();

        #region Nhập thông tin lớp học thêm
        public SinhVien Nhap1()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t╔═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.Write("\t\t║                        ");
            Console.Write("                              ▐▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▌                                                        ");
            Console.WriteLine("║");
            Console.Write("\t\t║                        ");
            Console.Write("                              ▐        SINH VIÊN        ▌                                                        ");
            Console.WriteLine("║");
            Console.Write("\t\t║                        ");
            Console.Write("                              ▐▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▌                                                        ");
            Console.WriteLine("║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║  MSV           :                                ║                                       ║");
            Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════════════════╝                                       ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║  HỌ TÊN        :                                ║                                       ║");
            Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════════════════╝                                       ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║  GIỚI TÍNH     :                                ║                                       ║");
            Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════════════════╝                                       ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║  ĐỊA CHỈ       :                                ║                                       ║");
            Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════════════════╝                                       ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║  NGÀY SINH     :                                ║                                       ║");
            Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════════════════╝                                       ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║  SĐT           :                                ║                                       ║");
            Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════════════════╝                                       ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║  MÃ LỚP        :                                ║                                       ║");
            Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════════════════╝                                       ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║                                                 ║                                       ║");
            Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════════════════╝                                       ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            SinhVien sv = new SinhVien();


            do
            {
                Console.SetCursorPosition(82, 13);
                sv.MaSinhVien = Console.ReadLine();
                if (svBLL.maSinhVienHopLe(sv.MaSinhVien) == false)
                {
                    Console.SetCursorPosition(65, 35);
                    Console.WriteLine("Mã sinh viên đã tồn tại, nhập lại");
                    Console.SetCursorPosition(82, 13);
                    Console.WriteLine("                                ");
                }
            } while (svBLL.maSinhVienHopLe(sv.MaSinhVien) == false);
            Console.SetCursorPosition(65, 35);
            Console.WriteLine("                                                ");


            do
            {
                Console.SetCursorPosition(82, 16);
                sv.HoTen = Console.ReadLine();
                if (svBLL.chuoiSinhVienHopLe(sv.HoTen) == false)
                {
                    Console.SetCursorPosition(65, 35);
                    Console.WriteLine("Họ tên không hợp lệ, nhập lại");
                    Console.SetCursorPosition(82, 16);
                    Console.WriteLine("                                ");
                }
            } while (svBLL.chuoiSinhVienHopLe(sv.HoTen) == false);
            Console.SetCursorPosition(65, 35);
            Console.WriteLine("                                                ");

            do
            {
                Console.SetCursorPosition(82, 19);
                sv.GioiTinh = Console.ReadLine();
                if (svBLL.gioiTinhHopLe(sv.GioiTinh) == false)
                {
                    Console.SetCursorPosition(65, 35);
                    Console.WriteLine("Giới tính không hợp lệ, nhập lại");
                    Console.SetCursorPosition(82, 19);
                    Console.WriteLine("                                ");
                }
            } while (svBLL.gioiTinhHopLe(sv.GioiTinh) == false);
            Console.SetCursorPosition(65, 35);
            Console.WriteLine("                                                ");

            do
            {
                Console.SetCursorPosition(82, 22);
                sv.DiaChi = Console.ReadLine();
                if (svBLL.chuoiSinhVienHopLe(sv.DiaChi) == false)
                {
                    Console.SetCursorPosition(65, 35);
                    Console.WriteLine("Địa chỉ không hợp lệ, nhập lại");
                    Console.SetCursorPosition(82, 22);
                    Console.WriteLine("                                ");
                }
            } while (svBLL.chuoiSinhVienHopLe(sv.DiaChi) == false);
            Console.SetCursorPosition(65, 35);
            Console.WriteLine("                                                ");


            do
            {
                Console.SetCursorPosition(82, 25);
                sv.NgaySinh = Console.ReadLine();
                if (svBLL.namSinhHopLe(sv.NgaySinh) == false)
                {
                    Console.SetCursorPosition(65, 35);
                    Console.WriteLine("Ngày sinh không hợp lệ, nhập lại");
                    Console.SetCursorPosition(82, 25);
                    Console.WriteLine("                                ");
                }
            } while (svBLL.namSinhHopLe(sv.NgaySinh) == false);
            Console.SetCursorPosition(65, 35);
            Console.WriteLine("                                                ");


            do
            {
                Console.SetCursorPosition(82, 28);
                sv.SDT = Console.ReadLine();
                if (svBLL.sdtHopLe(sv.SDT) == false)
                {
                    Console.SetCursorPosition(65, 35);
                    Console.WriteLine("SDT không hợp lệ, nhập lại");
                    Console.SetCursorPosition(82, 28);
                    Console.WriteLine("                                ");
                }
            } while (svBLL.sdtHopLe(sv.SDT) == false);
            Console.SetCursorPosition(65, 35);
            Console.WriteLine("                                                ");


            do
            {
                Console.SetCursorPosition(82, 31);
                sv.MaLop = Console.ReadLine();
                if (svBLL.maLopHopLe1(sv.MaLop) == true)
                {
                    Console.SetCursorPosition(65, 35);
                    Console.WriteLine("Mã lớp không tồn tại, nhập lại");
                    Console.SetCursorPosition(82, 31);
                    Console.WriteLine("                                ");
                }
            } while (svBLL.maLopHopLe1(sv.MaLop) == true);
            Console.SetCursorPosition(65, 35);
            Console.WriteLine("                                                ");


            return sv;
        }
        #endregion

        #region Nhập thông tin lớp học sửa
        public SinhVien Nhap2(string id)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t╔═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.Write("\t\t║                        ");
            Console.Write("                              ▐▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▌                                                        ");
            Console.WriteLine("║");
            Console.Write("\t\t║                        ");
            Console.Write("                              ▐        SINH VIÊN        ▌                                                        ");
            Console.WriteLine("║");
            Console.Write("\t\t║                        ");
            Console.Write("                              ▐▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▌                                                        ");
            Console.WriteLine("║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║  MSV           :                                ║                                       ║");
            Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════════════════╝                                       ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║  HỌ TÊN        :                                ║                                       ║");
            Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════════════════╝                                       ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║  GIỚI TÍNH     :                                ║                                       ║");
            Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════════════════╝                                       ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║  ĐỊA CHỈ       :                                ║                                       ║");
            Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════════════════╝                                       ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║  NGÀY SINH     :                                ║                                       ║");
            Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════════════════╝                                       ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║  SĐT           :                                ║                                       ║");
            Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════════════════╝                                       ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║  MÃ LỚP        :                                ║                                       ║");
            Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════════════════╝                                       ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║                                                 ║                                       ║");
            Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════════════════╝                                       ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            SinhVien sv = new SinhVien();

            Console.SetCursorPosition(82, 13);
            sv.MaSinhVien = id;
            Console.WriteLine(id);



            do
            {
                Console.SetCursorPosition(82, 16);
                sv.HoTen = Console.ReadLine();
                if (svBLL.chuoiSinhVienHopLe(sv.HoTen) == false)
                {
                    Console.SetCursorPosition(65, 35);
                    Console.WriteLine("Họ tên không hợp lệ, nhập lại");
                    Console.SetCursorPosition(82, 16);
                    Console.WriteLine("                                ");
                }
            } while (svBLL.chuoiSinhVienHopLe(sv.HoTen) == false);
            Console.SetCursorPosition(65, 35);
            Console.WriteLine("                                                ");

            do
            {
                Console.SetCursorPosition(82, 19);
                sv.GioiTinh = Console.ReadLine();
                if (svBLL.gioiTinhHopLe(sv.GioiTinh) == false)
                {
                    Console.SetCursorPosition(65, 35);
                    Console.WriteLine("Giới tính không hợp lệ, nhập lại");
                    Console.SetCursorPosition(82, 19);
                    Console.WriteLine("                                ");
                }
            } while (svBLL.gioiTinhHopLe(sv.GioiTinh) == false);
            Console.SetCursorPosition(65, 35);
            Console.WriteLine("                                                ");

            do
            {
                Console.SetCursorPosition(82, 22);
                sv.DiaChi = Console.ReadLine();
                if (svBLL.chuoiSinhVienHopLe(sv.DiaChi) == false)
                {
                    Console.SetCursorPosition(65, 35);
                    Console.WriteLine("Địa chỉ không hợp lệ, nhập lại");
                    Console.SetCursorPosition(82, 22);
                    Console.WriteLine("                                ");
                }
            } while (svBLL.chuoiSinhVienHopLe(sv.DiaChi) == false);
            Console.SetCursorPosition(65, 35);
            Console.WriteLine("                                                ");


            do
            {
                Console.SetCursorPosition(82, 25);
                sv.NgaySinh = Console.ReadLine();
                if (svBLL.namSinhHopLe(sv.NgaySinh) == false)
                {
                    Console.SetCursorPosition(65, 35);
                    Console.WriteLine("Ngày sinh không hợp lệ, nhập lại");
                    Console.SetCursorPosition(82, 25);
                    Console.WriteLine("                                ");
                }
            } while (svBLL.namSinhHopLe(sv.NgaySinh) == false);
            Console.SetCursorPosition(65, 35);
            Console.WriteLine("                                                ");


            do
            {
                Console.SetCursorPosition(82, 28);
                sv.SDT = Console.ReadLine();
                if (svBLL.sdtHopLe(sv.SDT) == false)
                {
                    Console.SetCursorPosition(65, 35);
                    Console.WriteLine("SDT không hợp lệ, nhập lại");
                    Console.SetCursorPosition(82, 28);
                    Console.WriteLine("                                ");
                }
            } while (svBLL.sdtHopLe(sv.SDT) == false);
            Console.SetCursorPosition(65, 35);
            Console.WriteLine("                                                ");


            do
            {
                Console.SetCursorPosition(82, 31);
                sv.MaLop = Console.ReadLine();
                if (svBLL.maLopHopLe1(sv.MaLop) == true)
                {
                    Console.SetCursorPosition(65, 35);
                    Console.WriteLine("Mã lớp không tồn tại, nhập lại");
                    Console.SetCursorPosition(82, 31);
                    Console.WriteLine("                                ");
                }
            } while (svBLL.maLopHopLe1(sv.MaLop) == true);
            Console.SetCursorPosition(65, 35);
            Console.WriteLine("                                                ");


            return sv;
        }
        #endregion 

        #region Menu quản lý sinh viên
        public void Menu()
        {
            Console.Clear();
            int check = 0;
            while (check == 0)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t\t╔═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("\t\t║                                                                                                                                   ║");
                Console.WriteLine("\t\t║                                                                                                                                   ║");
                Console.WriteLine("\t\t║                                                                                                                                   ║");
                Console.WriteLine("\t\t║                                                                                                                                   ║");
                Console.Write("\t\t║                        ");
                Console.Write("                              ▐▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▌                                                      ");
                Console.WriteLine("║");
                Console.Write("\t\t║                        ");
                Console.Write("                              ▐   QUẢN LÝ SINH VIÊN ▌                                                      ");
                Console.WriteLine("║");
                Console.Write("\t\t║                        ");
                Console.Write("                              ▐▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▌                                                      ");
                Console.WriteLine("║");
                Console.WriteLine("\t\t║                                                                                                                                   ║");
                Console.WriteLine("\t\t║                                                                                                                                   ║");
                Console.WriteLine("\t\t║                                                                                                                                   ║");
                Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════╗                                             ║");
                Console.WriteLine("\t\t║                                               ║     1.Nhập thông tin sinh viên      ║                                             ║");
                Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════╝                                             ║");
                Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════╗                                             ║");
                Console.WriteLine("\t\t║                                               ║     2.Hiển thị thông tin sinh viên  ║                                             ║");
                Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════╝                                             ║");
                Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════╗                                             ║");
                Console.WriteLine("\t\t║                                               ║     3.Tìm kiếm sinh viên            ║                                             ║");
                Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════╝                                             ║");
                Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════╗                                             ║");
                Console.WriteLine("\t\t║                                               ║     4.Sửa thông tin sinh viên       ║                                             ║");
                Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════╝                                             ║");
                Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════╗                                             ║");
                Console.WriteLine("\t\t║                                               ║     5.Xóa thông tin sinh viên       ║                                             ║");
                Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════╝                                             ║");
                Console.WriteLine("\t\t║                                                                                                                                   ║");
                Console.WriteLine("\t\t║                                                                                                                                   ║");
                Console.WriteLine("\t\t║                                                                                                                                   ║");
                Console.WriteLine("\t\t║                                                                                                                                   ║");
                Console.WriteLine("\t\t║                                                                                                                                   ║");
                Console.WriteLine("\t\t║                                                                                                                                   ║");
                Console.WriteLine("\t\t╚═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.WriteLine("\t\t╔═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("\t\t║     Mời bạn chọn chức năng:                                                                                                       ║");
                Console.WriteLine("\t\t╚═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                Console.SetCursorPosition(45, 36);
                int mode = int.Parse(Console.ReadLine());
                switch (mode)
                {
                    case 1:
                        Console.WriteLine();
                        Them();
                        Console.Write("\t\tNhấn phím bất kì để tiếp tục\n\t\t");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        hienThi();
                        Console.Write("\n\t\tNhấn phím bất kì để tiếp tục\n\t\t");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        hienThi();
                        string id1;
                        do
                        {
                            Console.Write("\t\tNhập mã sinh viên cần tìm kiếm thông tin: ");
                            id1 = Console.ReadLine();
                            if (svBLL.maSinhVienHopLe(id1) == true) Console.WriteLine("\t\tMã sinh viên không tồn tại,nhập lại");
                        } while (svBLL.maSinhVienHopLe(id1) == true);
                        timKiem(id1);
                        Console.WriteLine("\t\tNhấn phím bất kì để tiếp tục\n\t\t");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 4:
                        Console.Clear();
                        hienThi();
                        Console.WriteLine("\t\tSửa thông tin sinh viên");
                        string id2;
                        do
                        {
                            Console.Write("\t\tNhập mã sinh viên cần sửa thông tin: ");
                            id2 = Console.ReadLine();
                            if (svBLL.maSinhVienHopLe(id2) == true) Console.WriteLine("\t\tMã sinh viên không tồn tại,nhập lại");
                        } while (svBLL.maSinhVienHopLe(id2) == true);
                        Sua(id2);
                        Console.WriteLine("\t\tNhấn phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        hienThi();
                        string id3;
                        do
                        {
                            Console.Write("\t\tNhập mã sinh viên cần xóa thông tin: ");
                            id3 = Console.ReadLine();
                            if (svBLL.maSinhVienHopLe(id3) == true) Console.WriteLine("\t\tMã sinh viên không tồn tại,nhập lại");
                        } while (svBLL.maSinhVienHopLe(id3) == true);
                        Xoa(id3); Console.WriteLine("\t\tNhấn phím bất kì để tiếp tục");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 0:
                        check = 1;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\t\tSai cú pháp!");
                        break;

                }

            }
        }
        #endregion

        #region Thêm thông tin lớp
        public void Them()
        {
            Console.Clear();
            string check = "y";
            while (check == "y")
            {
                do
                {
                    Console.Clear();
                    SinhVien sv = Nhap1();
                    svBLL.themDS(sv);
                    Console.Clear();
                    hienThi();
                    Console.WriteLine("\t\tBạn đã nhập thành công!");
                    Console.Write("\t\tBạn có muốn nhập tiếp (y/n) : ");
                    check = Console.ReadLine().ToLower();
                    if (check == "n")
                        break;
                } while (true);
            }
        }
        #endregion

        #region Hiển thị thông tin các lớp học
        public void hienThi()
        {
            Console.Clear();
            List<SinhVien> sv = svBLL.layDS();
            Table table = new Table(120);
            Console.WriteLine("\t\t================================================= THÔNG TIN SINH VIÊN ===================================================");
            Console.WriteLine();
            table.PrintLine();
            table.PrintTitle("MÃ SINH VIÊN", "HỌ TÊN", "GIỚI TÍNH","ĐỊA CHỈ","NGÀY SINH","SĐT","MÃ LỚP");
            table.PrintLine();
            sv.Reverse();
            foreach (SinhVien ttin in sv)
            {
                table.PrintRow(ttin.MaSinhVien,ttin.HoTen,ttin.GioiTinh,ttin.DiaChi,ttin.NgaySinh,ttin.SDT,ttin.MaLop);
            }
            table.PrintLine();
            Console.WriteLine();
            Console.WriteLine("\t\t==========================================================================================================================\n");
        }
        #endregion

        #region Tìm kiếm thông tin lớp học
        public void timKiem(string id)
        {
            Console.Clear();
            List<SinhVien> sv = svBLL.layDS();
            Table table = new Table(120);
            Console.WriteLine("\t\t=================================================== THÔNG TIN SINH VIÊN  =================================================");
            Console.WriteLine();
            table.PrintLine();
            table.PrintTitle("MÃ SINH VIÊN", "HỌ TÊN", "GIỚI TÍNH", "ĐỊA CHỈ", "NGÀY SINH", "SĐT", "MÃ LỚP");
            table.PrintLine();
            sv.Reverse();
            foreach (SinhVien ttin in sv)
            {
                if (ttin.MaSinhVien == id)
                {
                    table.PrintRow(ttin.MaSinhVien, ttin.HoTen, ttin.GioiTinh, ttin.DiaChi, ttin.NgaySinh, ttin.SDT, ttin.MaLop);
                }
            }
            table.PrintLine();
            Console.WriteLine();
            Console.WriteLine("\t\t==========================================================================================================================\n");

        }
        #endregion

        #region Sửa thông tin lớp học
        public void Sua(string id)
        {
            Console.Clear();
            SinhVien sv = Nhap2(id);
            svBLL.suaDS(id, sv);
            Console.Clear();
            hienThi();
            Console.WriteLine("\t\tBạn đã sửa thành công!");
        }
        #endregion

        #region Xóa thông tin sinh viên
        public void Xoa(string id3)
        {
            svBLL.xoaDS(id3);
            Console.WriteLine("\t\tXóa thành công");
        }
        #endregion

    }
}
