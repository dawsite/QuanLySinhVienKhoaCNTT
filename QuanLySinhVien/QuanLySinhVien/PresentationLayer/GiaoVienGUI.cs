using System;
using System.Collections.Generic;
using System.Text;
using QuanLySinhVien.BusinessLayer;
using QuanLySinhVien.Entities;
using QuanLySinhVien.Utilities;

namespace QuanLySinhVien.PresentationLayer
{
    public class GiaoVienGUI
    {
        private GiangVienBLL gvBLL = new GiangVienBLL();

        #region Nhập thông tin lớp học thêm
        public GiangVien Nhap1()
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
            Console.Write("                              ▐       GIẢNG VIÊN        ▌                                                        ");
            Console.WriteLine("║");
            Console.Write("\t\t║                        ");
            Console.Write("                              ▐▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▌                                                        ");
            Console.WriteLine("║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║  MGV           :                                ║                                       ║");
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
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║                                                 ║                                       ║");
            Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════════════════╝                                       ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            GiangVien gv = new GiangVien();


            do
            {
                Console.SetCursorPosition(82, 13);
                gv.MaGiangVien = Console.ReadLine();
                if (gvBLL.maGiangVienHopLe(gv.MaGiangVien) == false)
                {
                    Console.SetCursorPosition(65, 35);
                    Console.WriteLine("Mã giảng viên đã tồn tại, nhập lại");
                    Console.SetCursorPosition(82, 13);
                    Console.WriteLine("                                ");
                }
            } while (gvBLL.maGiangVienHopLe(gv.MaGiangVien) == false);
            Console.SetCursorPosition(65, 35);
            Console.WriteLine("                                                ");


            do
            {
                Console.SetCursorPosition(82, 16);
                gv.HoTen = Console.ReadLine();
                if (gvBLL.chuoiGiangVienHopLe(gv.HoTen) == false)
                {
                    Console.SetCursorPosition(65, 35);
                    Console.WriteLine("Họ tên không hợp lệ, nhập lại");
                    Console.SetCursorPosition(82, 16);
                    Console.WriteLine("                                ");
                }
            } while (gvBLL.chuoiGiangVienHopLe(gv.HoTen) == false);
            Console.SetCursorPosition(65, 35);
            Console.WriteLine("                                                ");

            do
            {
                Console.SetCursorPosition(82, 19);
                gv.GioiTinh = Console.ReadLine();
                if (gvBLL.gioiTinhHopLe(gv.GioiTinh) == false)
                {
                    Console.SetCursorPosition(65, 35);
                    Console.WriteLine("Giới tính không hợp lệ, nhập lại");
                    Console.SetCursorPosition(82, 19);
                    Console.WriteLine("                                ");
                }
            } while (gvBLL.gioiTinhHopLe(gv.GioiTinh) == false);
            Console.SetCursorPosition(65, 35);
            Console.WriteLine("                                                ");

            do
            {
                Console.SetCursorPosition(82, 22);
                gv.DiaChi = Console.ReadLine();
                if (gvBLL.chuoiGiangVienHopLe(gv.DiaChi) == false)
                {
                    Console.SetCursorPosition(65, 35);
                    Console.WriteLine("Địa chỉ không hợp lệ, nhập lại");
                    Console.SetCursorPosition(82, 22);
                    Console.WriteLine("                                ");
                }
            } while (gvBLL.chuoiGiangVienHopLe(gv.DiaChi) == false);
            Console.SetCursorPosition(65, 35);
            Console.WriteLine("                                                ");


            do
            {
                Console.SetCursorPosition(82, 25);
                gv.NgaySinh = Console.ReadLine();
                if (gvBLL.namSinhHopLe(gv.NgaySinh) == false)
                {
                    Console.SetCursorPosition(65, 35);
                    Console.WriteLine("Ngày sinh không hợp lệ, nhập lại");
                    Console.SetCursorPosition(82, 25);
                    Console.WriteLine("                                ");
                }
            } while (gvBLL.namSinhHopLe(gv.NgaySinh) == false);
            Console.SetCursorPosition(65, 35);
            Console.WriteLine("                                                ");


            do
            {
                Console.SetCursorPosition(82, 28);
                gv.SDT = Console.ReadLine();
                if (gvBLL.sdtHopLe(gv.SDT) == false)
                {
                    Console.SetCursorPosition(65, 35);
                    Console.WriteLine("SDT không hợp lệ, nhập lại");
                    Console.SetCursorPosition(82, 28);
                    Console.WriteLine("                                ");
                }
            } while (gvBLL.sdtHopLe(gv.SDT) == false);
            Console.SetCursorPosition(65, 35);
            Console.WriteLine("                                                ");


            


            return gv;
        }
        #endregion

        #region Nhập thông tin lớp học sửa
        public GiangVien Nhap2(string id)
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
            Console.Write("                              ▐       GIẢNG VIÊN        ▌                                                        ");
            Console.WriteLine("║");
            Console.Write("\t\t║                        ");
            Console.Write("                              ▐▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▌                                                        ");
            Console.WriteLine("║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║  MGV           :                                ║                                       ║");
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
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║                                                 ║                                       ║");
            Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════════════════╝                                       ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            GiangVien gv = new GiangVien();


            Console.SetCursorPosition(82, 13);
            gv.MaGiangVien = id;
            Console.WriteLine(id);


            do
            {
                Console.SetCursorPosition(82, 16);
                gv.HoTen = Console.ReadLine();
                if (gvBLL.chuoiGiangVienHopLe(gv.HoTen) == false)
                {
                    Console.SetCursorPosition(65, 35);
                    Console.WriteLine("Họ tên không hợp lệ, nhập lại");
                    Console.SetCursorPosition(82, 16);
                    Console.WriteLine("                                ");
                }
            } while (gvBLL.chuoiGiangVienHopLe(gv.HoTen) == false);
            Console.SetCursorPosition(65, 35);
            Console.WriteLine("                                                ");

            do
            {
                Console.SetCursorPosition(82, 19);
                gv.GioiTinh = Console.ReadLine();
                if (gvBLL.gioiTinhHopLe(gv.GioiTinh) == false)
                {
                    Console.SetCursorPosition(65, 35);
                    Console.WriteLine("Giới tính không hợp lệ, nhập lại");
                    Console.SetCursorPosition(82, 19);
                    Console.WriteLine("                                ");
                }
            } while (gvBLL.gioiTinhHopLe(gv.GioiTinh) == false);
            Console.SetCursorPosition(65, 35);
            Console.WriteLine("                                                ");

            do
            {
                Console.SetCursorPosition(82, 22);
                gv.DiaChi = Console.ReadLine();
                if (gvBLL.chuoiGiangVienHopLe(gv.DiaChi) == false)
                {
                    Console.SetCursorPosition(65, 35);
                    Console.WriteLine("Địa chỉ không hợp lệ, nhập lại");
                    Console.SetCursorPosition(82, 22);
                    Console.WriteLine("                                ");
                }
            } while (gvBLL.chuoiGiangVienHopLe(gv.DiaChi) == false);
            Console.SetCursorPosition(65, 35);
            Console.WriteLine("                                                ");


            do
            {
                Console.SetCursorPosition(82, 25);
                gv.NgaySinh = Console.ReadLine();
                if (gvBLL.namSinhHopLe(gv.NgaySinh) == false)
                {
                    Console.SetCursorPosition(65, 35);
                    Console.WriteLine("Ngày sinh không hợp lệ, nhập lại");
                    Console.SetCursorPosition(82, 25);
                    Console.WriteLine("                                ");
                }
            } while (gvBLL.namSinhHopLe(gv.NgaySinh) == false);
            Console.SetCursorPosition(65, 35);
            Console.WriteLine("                                                ");


            do
            {
                Console.SetCursorPosition(82, 28);
                gv.SDT = Console.ReadLine();
                if (gvBLL.sdtHopLe(gv.SDT) == false)
                {
                    Console.SetCursorPosition(65, 35);
                    Console.WriteLine("SDT không hợp lệ, nhập lại");
                    Console.SetCursorPosition(82, 28);
                    Console.WriteLine("                                ");
                }
            } while (gvBLL.sdtHopLe(gv.SDT) == false);
            Console.SetCursorPosition(65, 35);
            Console.WriteLine("                                                ");





            return gv;
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
                    GiangVien gv = Nhap1();
                    gvBLL.themDS(gv);
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
            List<GiangVien> gv = gvBLL.layDS();
            Table table = new Table(120);
            Console.WriteLine("\t\t================================================= THÔNG TIN GIẢNG VIÊN ===================================================");
            Console.WriteLine();
            table.PrintLine();
            table.PrintTitle("MÃ GIẢNG VIÊN", "HỌ TÊN", "GIỚI TÍNH", "ĐỊA CHỈ", "NGÀY SINH", "SĐT");
            table.PrintLine();
            gv.Reverse();
            foreach (GiangVien ttin in gv)
            {
                table.PrintRow(ttin.MaGiangVien, ttin.HoTen, ttin.GioiTinh, ttin.DiaChi, ttin.NgaySinh, ttin.SDT);
            }
            table.PrintLine();
            Console.WriteLine();
            Console.WriteLine("\t\t==========================================================================================================================\n");
        }
        #endregion

        #region Tìm kiếm thông tin giảng viên
        public void timKiem(string id)
        {
            Console.Clear();
            List<GiangVien> gv = gvBLL.layDS();
            Table table = new Table(120);
            Console.WriteLine("\t\t=================================================== THÔNG TIN GIẢNG VIÊN  =================================================");
            Console.WriteLine();
            table.PrintLine();
            table.PrintTitle("MÃ SINH VIÊN", "HỌ TÊN", "GIỚI TÍNH", "ĐỊA CHỈ", "NGÀY SINH", "SĐT");
            table.PrintLine();
            gv.Reverse();
            foreach (GiangVien ttin in gv)
            {
                if (ttin.MaGiangVien == id)
                {
                    table.PrintRow(ttin.MaGiangVien, ttin.HoTen, ttin.GioiTinh, ttin.DiaChi, ttin.NgaySinh, ttin.SDT);
                }
            }
            table.PrintLine();
            Console.WriteLine();
            Console.WriteLine("\t\t==========================================================================================================================\n");

        }
        #endregion

        #region Sửa thông tin giảng viên
        public void Sua(string id)
        {
            Console.Clear();
            GiangVien gv = Nhap2(id);
            gvBLL.suaDS(id, gv);
            Console.Clear();
            hienThi();
            Console.WriteLine("\t\tBạn đã sửa thành công!");
        }
        #endregion

        #region Xóa thông tin giảng viên
        public void Xoa(string id3)
        {
            gvBLL.xoaDS(id3);
            Console.WriteLine("\t\tXóa thành công");
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
                Console.Write("                              ▐   QUẢN LÝ GIÁO VIÊN ▌                                                      ");
                Console.WriteLine("║");
                Console.Write("\t\t║                        ");
                Console.Write("                              ▐▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▌                                                      ");
                Console.WriteLine("║");
                Console.WriteLine("\t\t║                                                                                                                                   ║");
                Console.WriteLine("\t\t║                                                                                                                                   ║");
                Console.WriteLine("\t\t║                                                                                                                                   ║");
                Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════╗                                             ║");
                Console.WriteLine("\t\t║                                               ║     1.Nhập thông tin giáo viên      ║                                             ║");
                Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════╝                                             ║");
                Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════╗                                             ║");
                Console.WriteLine("\t\t║                                               ║     2.Hiển thị thông tin giáo viên  ║                                             ║");
                Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════╝                                             ║");
                Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════╗                                             ║");
                Console.WriteLine("\t\t║                                               ║     3.Tìm kiếm giáo viên            ║                                             ║");
                Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════╝                                             ║");
                Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════╗                                             ║");
                Console.WriteLine("\t\t║                                               ║     4.Sửa thông tin giáo viên       ║                                             ║");
                Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════╝                                             ║");
                Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════╗                                             ║");
                Console.WriteLine("\t\t║                                               ║     5.Xóa thông tin giáo viên       ║                                             ║");
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
                            Console.Write("\t\tNhập mã giảng viên cần tìm kiếm thông tin: ");
                            id1 = Console.ReadLine();
                            if (gvBLL.maGiangVienHopLe(id1) == true) Console.WriteLine("\t\tMã giảng viên không tồn tại,nhập lại");
                        } while (gvBLL.maGiangVienHopLe(id1) == true);
                        timKiem(id1);
                        Console.WriteLine("\t\tNhấn phím bất kì để tiếp tục\n\t\t");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 4:
                        Console.Clear();
                        hienThi();
                        Console.WriteLine("\t\tSửa thông tin giảng viên");
                        string id2;
                        do
                        {
                            Console.Write("\t\tNhập mã giảng viên cần sửa thông tin: ");
                            id2 = Console.ReadLine();
                            if (gvBLL.maGiangVienHopLe(id2) == true) Console.WriteLine("\t\tMã giảng viên không tồn tại,nhập lại");
                        } while (gvBLL.maGiangVienHopLe(id2) == true);
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
                            Console.Write("\t\tNhập mã giảng viên cần xóa thông tin: ");
                            id3 = Console.ReadLine();
                            if (gvBLL.maGiangVienHopLe(id3) == true) Console.WriteLine("\t\tMã giảng viên không tồn tại,nhập lại");
                        } while (gvBLL.maGiangVienHopLe(id3) == true);
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
    }
}
