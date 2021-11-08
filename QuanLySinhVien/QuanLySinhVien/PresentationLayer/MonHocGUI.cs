using System;
using System.Collections.Generic;
using System.Text;
using QuanLySinhVien.BusinessLayer;
using QuanLySinhVien.Entities;
using QuanLySinhVien.Utilities;

namespace QuanLySinhVien.PresentationLayer
{
    public class MonHocGUI
    {
        private MonHocBLL mhBLL = new MonHocBLL();

        #region Nhập thông tin môn học thêm
        public MonHoc Nhap1()
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
            Console.Write("                              ▐        MÔN HỌC          ▌                                                        ");
            Console.WriteLine("║");
            Console.Write("\t\t║                        ");
            Console.Write("                              ▐▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▌                                                        ");
            Console.WriteLine("║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║  MÃ MÔN        :                                ║                                       ║");
            Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════════════════╝                                       ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║  TÊN MÔN       :                                ║                                       ║");
            Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════════════════╝                                       ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║  SỐ TÍN CHỈ    :                                ║                                       ║");
            Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════════════════╝                                       ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║  MGV           :                                ║                                       ║");
            Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════════════════╝                                       ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║                                                 ║                                       ║");
            Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════════════════╝                                       ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            MonHoc mh = new MonHoc();
            do
            {
                Console.SetCursorPosition(82, 13);
                mh.MaMonHoc = Console.ReadLine();
                if (mhBLL.maMonHopLe(mh.MaMonHoc) == false)
                {
                    Console.SetCursorPosition(68, 26);
                    Console.WriteLine("Mã môn học không hợp lệ, nhập lại");
                    Console.SetCursorPosition(82, 13);
                    Console.WriteLine("                                ");
                }
            } while (mhBLL.maMonHopLe(mh.MaMonHoc) == false);
            Console.SetCursorPosition(65, 26);
            Console.WriteLine("                                                ");

            if (mhBLL.maMonHopLe1(mh.MaMonHoc) == false)
            {

                Console.SetCursorPosition(82, 16);
                mh.TenMonHoc = mhBLL.timMonHoc(mh.MaMonHoc).TenMonHoc;
                Console.WriteLine(mhBLL.timMonHoc(mh.MaMonHoc).TenMonHoc);


                Console.SetCursorPosition(82, 19);
                mh.SoTC = mhBLL.timMonHoc(mh.MaMonHoc).SoTC;
                Console.WriteLine(mhBLL.timMonHoc(mh.MaMonHoc).SoTC.ToString());
            }
            else
            {
                do
                {
                    Console.SetCursorPosition(82, 16);
                    mh.TenMonHoc = Console.ReadLine();
                    if (mhBLL.chuoiMonHopLe(mh.TenMonHoc) == false)
                    {
                        Console.SetCursorPosition(65, 26);
                        Console.WriteLine("Tên môn học không hợp lệ, nhập lại");
                        Console.SetCursorPosition(82, 16);
                        Console.WriteLine("                                ");
                    }
                } while (mhBLL.chuoiMonHopLe(mh.TenMonHoc) == false);
                Console.SetCursorPosition(65, 26);
                Console.WriteLine("                                                ");
                

                do
                {
                    Console.SetCursorPosition(82, 19);
                    mh.SoTC = int.Parse(Console.ReadLine());
                    if (mhBLL.soTinChiHopLe(mh.SoTC) == false)
                    {
                        Console.SetCursorPosition(65, 26);
                        Console.WriteLine("Số tín chỉ không hợp lệ, nhập lại");
                        Console.SetCursorPosition(82, 19);
                        Console.WriteLine("                                ");
                    }
                } while (mhBLL.soTinChiHopLe(mh.SoTC) == false);
                Console.SetCursorPosition(65, 26);
                Console.WriteLine("                                                ");
            }

            do
            {
                Console.SetCursorPosition(82, 22);
                mh.MaGiangVien = Console.ReadLine();
                if (mhBLL.maGiaoVienHopLe(mh.MaGiangVien) == true)
                {
                    Console.SetCursorPosition(65, 26);
                    Console.WriteLine("Mã giáo viên không tồn tại, nhập lại");
                    Console.SetCursorPosition(82, 22);
                    Console.WriteLine("                                ");
                }
                if (mhBLL.maGiaoVienHopLe(mh.MaMonHoc, mh.MaGiangVien) == false)
                {
                    Console.SetCursorPosition(65, 26);
                    Console.WriteLine("MGV vừa nhập đã quản lý môn học, nhập lại");
                    Console.SetCursorPosition(82, 22);
                    Console.WriteLine("                                ");
                }
            } while (mhBLL.maGiaoVienHopLe(mh.MaMonHoc, mh.MaGiangVien) == false|| mhBLL.maGiaoVienHopLe(mh.MaGiangVien) == true);
            Console.SetCursorPosition(65, 26);
            Console.WriteLine("                                                ");

            return mh;
        }
        #endregion
        
        #region Nhập thông tin môn học sửa
        public MonHoc Nhap2(string id)
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
            Console.Write("                              ▐        MÔN HỌC          ▌                                                        ");
            Console.WriteLine("║");
            Console.Write("\t\t║                        ");
            Console.Write("                              ▐▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▌                                                        ");
            Console.WriteLine("║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║  MÃ MÔN        :                                ║                                       ║");
            Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════════════════╝                                       ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║  TÊN MÔN       :                                ║                                       ║");
            Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════════════════╝                                       ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║  SỐ TÍN CHỈ    :                                ║                                       ║");
            Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════════════════╝                                       ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║  MGV           :                                ║                                       ║");
            Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════════════════╝                                       ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════════════════╗                                       ║");
            Console.WriteLine("\t\t║                                               ║                                                 ║                                       ║");
            Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════════════════╝                                       ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t║                                                                                                                                         ║");
            Console.WriteLine("\t\t╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            MonHoc mh = new MonHoc();


            Console.SetCursorPosition(82, 13);
            mh.MaMonHoc = id;
            Console.WriteLine(id);
            Console.SetCursorPosition(65, 26);
            Console.WriteLine("                                                ");

            do
            {
                Console.SetCursorPosition(82, 16);
                mh.TenMonHoc = Console.ReadLine();
                if (mhBLL.chuoiMonHopLe(mh.TenMonHoc) == false)
                {
                    Console.SetCursorPosition(65, 26);
                    Console.WriteLine("Tên môn học không hợp lệ, nhập lại");
                    Console.SetCursorPosition(82, 16);
                    Console.WriteLine("                                ");
                }
            } while (mhBLL.chuoiMonHopLe(mh.TenMonHoc) == false);
            Console.SetCursorPosition(65, 26);
            Console.WriteLine("                                                ");


            do
            {
                Console.SetCursorPosition(82, 19);
                mh.SoTC = int.Parse(Console.ReadLine());
                if (mhBLL.soTinChiHopLe(mh.SoTC) == false)
                {
                    Console.SetCursorPosition(65, 26);
                    Console.WriteLine("Số tín chỉ không hợp lệ, nhập lại");
                    Console.SetCursorPosition(82, 19);
                    Console.WriteLine("                                ");
                }
            } while (mhBLL.soTinChiHopLe(mh.SoTC) == false);
            Console.SetCursorPosition(65, 26);
            Console.WriteLine("                                                ");


            do
            {
                Console.SetCursorPosition(82, 22);
                mh.MaGiangVien = Console.ReadLine();
                if (mhBLL.maGiaoVienHopLe(mh.MaGiangVien) == true)
                {
                    Console.SetCursorPosition(65, 26);
                    Console.WriteLine("Mã giáo viên không tồn tại, nhập lại");
                    Console.SetCursorPosition(82, 22);
                    Console.WriteLine("                                ");
                }
                if (mhBLL.maGiaoVienHopLe(mh.MaMonHoc, mh.MaGiangVien) == false)
                {
                    Console.SetCursorPosition(65, 26);
                    Console.WriteLine("MGV vừa nhập đã quản lý môn học, nhập lại");
                    Console.SetCursorPosition(82, 22);
                    Console.WriteLine("                                ");
                }
            } while (mhBLL.maGiaoVienHopLe(mh.MaMonHoc, mh.MaGiangVien) == false || mhBLL.maGiaoVienHopLe(mh.MaGiangVien) == true);
            Console.SetCursorPosition(65, 26);
            Console.WriteLine("                                                ");


            return mh;
        }
        #endregion 

        #region Thêm thông tin môn học
        public void Them()
        {
            Console.Clear();
            string check = "y";
            while (check == "y")
            {
                do
                {
                    Console.Clear();
                    MonHoc mh = Nhap1();
                    mhBLL.themDS(mh);
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

        #region Hiển thị thông tin các môn học
        public void hienThi()
        {
            Console.Clear();
            List<MonHoc> mh = mhBLL.layDS();
            Table table = new Table(120);
            Console.WriteLine("\t\t=================================================== THÔNG TIN MÔN HỌC ===================================================");
            Console.WriteLine();
            table.PrintLine();
            table.PrintTitle("MÃ MÔN", "TÊN MÔN HỌC", "SỐ TÍN CHỈ","MÃ GIÁO VIÊN");
            table.PrintLine();
            mh.Reverse();
            foreach (MonHoc ttin in mh)
            {
                table.PrintRow(ttin.MaMonHoc,ttin.TenMonHoc,ttin.SoTC.ToString(),ttin.MaGiangVien);
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
            List<MonHoc> mh = mhBLL.layDS();
            Table table = new Table(120);
            Console.WriteLine("\t\t=================================================== THÔNG TIN MÔN HỌC ===================================================");
            Console.WriteLine();
            table.PrintLine();
            table.PrintTitle("MÃ MÔN", "TÊN MÔN HỌC", "SỐ TÍN CHỈ", "MÃ GIÁO VIÊN");
            table.PrintLine();
            mh.Reverse();
            foreach (MonHoc ttin in mh)
            {
                if (ttin.MaMonHoc == id)
                {
                    table.PrintRow(ttin.MaMonHoc, ttin.TenMonHoc, ttin.SoTC.ToString(), ttin.MaGiangVien);
                }
            }
            table.PrintLine();
            Console.WriteLine();
            Console.WriteLine("\t\t==========================================================================================================================\n");

        }
        #endregion

        #region Sửa thông tin môn học
        public void Sua(string id)
        {
            Console.Clear();
            MonHoc mh = Nhap2(id);
            mhBLL.suaDS(id, mh);
            Console.Clear();
            hienThi();
            Console.WriteLine("\t\tBạn đã sửa thành công!");
        }
        #endregion

        #region Xóa thông tin môn học
        public void Xoa(string id3)
        {

            mhBLL.xoaDS(id3);
            Console.WriteLine("\t\tXóa thành công");
        }
        #endregion

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
                Console.Write("                              ▐   QUẢN LÝ MÔN HỌC   ▌                                                      ");
                Console.WriteLine("║");
                Console.Write("\t\t║                        ");
                Console.Write("                              ▐▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▌                                                      ");
                Console.WriteLine("║");
                Console.WriteLine("\t\t║                                                                                                                                   ║");
                Console.WriteLine("\t\t║                                                                                                                                   ║");
                Console.WriteLine("\t\t║                                                                                                                                   ║");
                Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════╗                                             ║");
                Console.WriteLine("\t\t║                                               ║     1.Nhập thông tin môn học        ║                                             ║");
                Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════╝                                             ║");
                Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════╗                                             ║");
                Console.WriteLine("\t\t║                                               ║     2.Hiển thị thông tin môn học    ║                                             ║");
                Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════╝                                             ║");
                Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════╗                                             ║");
                Console.WriteLine("\t\t║                                               ║     3.Tìm kiếm môn học              ║                                             ║");
                Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════╝                                             ║");
                Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════╗                                             ║");
                Console.WriteLine("\t\t║                                               ║     4.Sửa thông tin môn học         ║                                             ║");
                Console.WriteLine("\t\t║                                               ╚═════════════════════════════════════╝                                             ║");
                Console.WriteLine("\t\t║                                               ╔═════════════════════════════════════╗                                             ║");
                Console.WriteLine("\t\t║                                               ║     5.Xóa thông tin môn học         ║                                             ║");
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
                            Console.Write("\t\tNhập mã môn học cần tìm kiếm thông tin: ");
                            id1 = Console.ReadLine();
                            if (mhBLL.maMonHopLe1(id1) == true) Console.WriteLine("\t\tMã môn học không tồn tại,nhập lại");
                        } while (mhBLL.maMonHopLe1(id1) == true);
                        timKiem(id1);
                        Console.WriteLine("\t\tNhấn phím bất kì để tiếp tục\n\t\t");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 4:
                        Console.Clear();
                        hienThi();
                        Console.WriteLine("\t\tSửa thông tin môn học");
                        string id2;
                        do
                        {
                            Console.Write("\t\tNhập mã môn học cần sửa thông tin: ");
                            id2 = Console.ReadLine();
                            if (mhBLL.maMonHopLe1(id2) == true) Console.WriteLine("\t\tMã môn học không tồn tại,nhập lại");
                        } while (mhBLL.maMonHopLe1(id2) == true);
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
                            Console.Write("\n\t\tNhập mã môn học cần xóa thông tin: ");
                            id3 = Console.ReadLine();
                            if (mhBLL.maMonHopLe1(id3) == true) Console.WriteLine("\t\tMã môn học không tồn tại,nhập lại");
                           
                        } while (mhBLL.maMonHopLe1(id3) == true);
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
