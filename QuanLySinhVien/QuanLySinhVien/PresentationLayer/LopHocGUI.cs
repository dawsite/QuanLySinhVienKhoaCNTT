using System;
using System.Collections.Generic;
using System.Text;
using QuanLySinhVien.BusinessLayer;
using QuanLySinhVien.Entities;
using QuanLySinhVien.Utilities;

namespace QuanLySinhVien.PresentationLayer
{
    public class LopHocGUI
    {
        private LopHocBLL lhBLL = new LopHocBLL();

        #region Menu quản lý lớp
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
                Console.Write("                              ▐   QUẢN LÝ LỚP HỌC   ▌                                                      ");
                Console.WriteLine("║");
                Console.Write("\t\t║                        ");
                Console.Write("                              ▐▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▌                                                      ");
                Console.WriteLine("║");
                Console.WriteLine("\t\t║                                                                                                                                   ║");
                Console.WriteLine("\t\t║                                                                                                                                   ║");
                Console.WriteLine("\t\t║                                                                                                                                   ║");
                Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════╗                                             ║");
                Console.WriteLine("\t\t║                                               ║     1.Nhập thông tin lớp học        ║                                             ║");
                Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════╝                                             ║");
                Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════╗                                             ║");
                Console.WriteLine("\t\t║                                               ║     2.Hiển thị thông tin lớp học    ║                                             ║");
                Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════╝                                             ║");
                Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════╗                                             ║");
                Console.WriteLine("\t\t║                                               ║     3.Tìm kiếm lớp học              ║                                             ║");
                Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════╝                                             ║");
                Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════╗                                             ║");
                Console.WriteLine("\t\t║                                               ║     4.Sửa thông tin lớp học         ║                                             ║");
                Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════╝                                             ║");
                Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════╗                                             ║");
                Console.WriteLine("\t\t║                                               ║     5.Xóa thông tin lớp học         ║                                             ║");
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
                            Console.Write("\t\tNhập mã lớp cần tìm kiếm thông tin: ");
                            id1 = Console.ReadLine();
                            if (lhBLL.maLopHopLe(id1) == true) Console.WriteLine("\t\tMã lớp không tồn tại,nhập lại");
                        } while (lhBLL.maLopHopLe(id1) == true);
                        timKiem(id1); 
                        Console.WriteLine("\t\tNhấn phím bất kì để tiếp tục\n\t\t"); 
                        Console.ReadLine(); 
                        Console.Clear();
                        break;

                    case 4:
                        Console.Clear();
                        hienThi();
                        Console.WriteLine("\t\tSửa thông tin lớp học");
                        string id2;
                        do
                        {
                            Console.Write("\t\tNhập mã lớp cần sửa thông tin: ");
                            id2 = Console.ReadLine();
                            if (lhBLL.maLopHopLe(id2) == true) Console.WriteLine("\t\tMã lớp không tồn tại,nhập lại");
                        } while (lhBLL.maLopHopLe(id2) == true);
                        Sua(id2); 
                        Console.WriteLine("\t\tNhấn phím bất kì để tiếp tục"); 
                        Console.ReadLine(); 
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        hienThi();
                        string id3;
                        SinhVienBLL x = new SinhVienBLL();
                        do
                        {
                            Console.Write("\n\t\tNhập mã lớp cần xóa thông tin: ");
                            id3 = Console.ReadLine();
                            if (lhBLL.maLopHopLe(id3) == true) Console.WriteLine("\t\tMã lớp không tồn tại,nhập lại");
                            if (x.siSoSinhVienLop(id3) != 0) Console.WriteLine("\t\tTồn tại sinh viên thuộc lớp học, không thể xóa");
                        } while (lhBLL.maLopHopLe(id3) == true|| x.siSoSinhVienLop(id3) != 0);
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
                    LopHoc lh = Nhap1();
                    lhBLL.themDS(lh);
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
            List<LopHoc> lh = lhBLL.layDS();
            Table table = new Table(120);
            Console.WriteLine("\t\t=================================================== THÔNG TIN LỚP HỌC ===================================================");
            Console.WriteLine();
            table.PrintLine();
            table.PrintTitle("MÃ LỚP", "TÊN LỚP", "CHUYÊN NGÀNH");
            table.PrintLine();
            lh.Reverse();
            foreach (LopHoc ttin in lh)
            {
                table.PrintRow(ttin.MaLop.ToString(), ttin.TenLop, ttin.ChuyenNganh);
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
            List<LopHoc> lh = lhBLL.layDS();
            Table table = new Table(120);
            Console.WriteLine("\t\t=================================================== THÔNG TIN LỚP HỌC ===================================================");
            Console.WriteLine();
            table.PrintLine();
            table.PrintTitle("MÃ LỚP", "TÊN LỚP", "CHUYÊN NGÀNH");
            table.PrintLine();
            lh.Reverse();
            foreach (LopHoc ttin in lh)
            {
                if(ttin.MaLop==id)
                {
                    table.PrintRow(ttin.MaLop.ToString(), ttin.TenLop, ttin.ChuyenNganh);
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
            LopHoc lh = Nhap2(id);
            lhBLL.suaDS(id, lh);
            Console.Clear();
            hienThi();
            Console.WriteLine("\t\tBạn đã sửa thành công!");
        }
        #endregion

        #region Xóa thông tin lớp học
        public void Xoa(string id3)
        {

            lhBLL.xoaDS(id3);
            Console.WriteLine("\t\tXóa thành công");
        }
        #endregion

        #region Nhập thông tin lớp học thêm
        public LopHoc Nhap1()
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
            Console.Write("                              ▐        LỚP HỌC          ▌                                                        ");
            Console.WriteLine("║");
            Console.Write("\t\t║                        ");
            Console.Write("                              ▐▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▌                                                        ");
            Console.WriteLine("║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║  MÃ LỚP        :                                ║                                       ║");
            Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════════════════╝                                       ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║  TÊN LỚP       :                                ║                                       ║");
            Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════════════════╝                                       ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║  CHUYÊN NGÀNH  :                                ║                                       ║");
            Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════════════════╝                                       ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║                                                 ║                                       ║");
            Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════════════════╝                                       ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            LopHoc lh = new LopHoc();
            do
            {
                Console.SetCursorPosition(82, 13);
                lh.MaLop = Console.ReadLine();
                if (lhBLL.maLopHopLe(lh.MaLop) == false)
                {
                    Console.SetCursorPosition(68, 23);
                    Console.WriteLine("Mã lớp đã tồn tại, nhập lại");
                    Console.SetCursorPosition(82, 13);
                    Console.WriteLine("                                ");
                }
            } while (lhBLL.maLopHopLe(lh.MaLop) == false);
            Console.SetCursorPosition(65, 23);
            Console.WriteLine("                                                ");


            do
            {
                Console.SetCursorPosition(82, 16);
                lh.TenLop = Console.ReadLine();
                if (lhBLL.tenLopHopLe(lh.TenLop) == false)
                {
                    Console.SetCursorPosition(65, 23);
                    Console.WriteLine("Tên lớp không hợp lệ, nhập lại");
                    Console.SetCursorPosition(82, 16);
                    Console.WriteLine("                                ");
                }
            } while (lhBLL.tenLopHopLe(lh.TenLop) == false);
            Console.SetCursorPosition(65, 23);
            Console.WriteLine("                                                ");


            do
            {
                Console.SetCursorPosition(82, 19);
                lh.ChuyenNganh = Console.ReadLine();
                if (lhBLL.chuyenNganhHopLe(lh.ChuyenNganh) == false)
                {
                    Console.SetCursorPosition(65, 23);
                    Console.WriteLine("Chuyên ngành không tồn tại, nhập lại");
                    Console.SetCursorPosition(82, 19);
                    Console.WriteLine("                                ");
                }
            } while (lhBLL.chuyenNganhHopLe(lh.ChuyenNganh) == false);

            return lh;
        }
        #endregion 

        #region Nhập thông tin lớp học sửa
        public LopHoc Nhap2(string id)
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
            Console.Write("                              ▐        LỚP HỌC          ▌                                                        ");
            Console.WriteLine("║");
            Console.Write("\t\t║                        ");
            Console.Write("                              ▐▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▌                                                        ");
            Console.WriteLine("║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║  MÃ LỚP        :                                ║                                       ║");
            Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════════════════╝                                       ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║  TÊN LỚP       :                                ║                                       ║");
            Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════════════════╝                                       ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║  CHUYÊN NGÀNH  :                                ║                                       ║");
            Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════════════════╝                                       ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║                                                 ║                                       ║");
            Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════════════════╝                                       ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            LopHoc lh = new LopHoc();

            Console.SetCursorPosition(82, 13);
            lh.MaLop = id;
            Console.WriteLine(id);

            Console.SetCursorPosition(65, 23);
            Console.WriteLine("                                                ");


            do
            {
                Console.SetCursorPosition(82, 16);
                lh.TenLop = Console.ReadLine();
                if (lhBLL.tenLopHopLe(lh.TenLop) == false)
                {
                    Console.SetCursorPosition(65, 23);
                    Console.WriteLine("Tên lớp không hợp lệ, nhập lại");
                    Console.SetCursorPosition(82, 16);
                    Console.WriteLine("                                ");
                }
            } while (lhBLL.tenLopHopLe(lh.TenLop) == false);
            Console.SetCursorPosition(65, 23);
            Console.WriteLine("                                                ");


            do
            {
                Console.SetCursorPosition(82, 19);
                lh.ChuyenNganh = Console.ReadLine();
                if (lhBLL.chuyenNganhHopLe(lh.ChuyenNganh) == false)
                {
                    Console.SetCursorPosition(65, 23);
                    Console.WriteLine("Chuyên ngành không tồn tại, nhập lại");
                    Console.SetCursorPosition(82, 19);
                    Console.WriteLine("                                ");
                }
            } while (lhBLL.chuyenNganhHopLe(lh.ChuyenNganh) == false);

            return lh;
        }
        #endregion 
    }
}
