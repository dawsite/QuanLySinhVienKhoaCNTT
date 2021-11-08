using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySinhVien.Utilities
{
    public class Menu
    {
        #region Giao diện bắt đầu
        static public void GiaoDienBatDau()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Menu Chính";
            Console.CursorVisible = true; //con trỏ có thể chia sẻ
            Console.WriteLine();
            Console.WriteLine("\t\t╔═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║                                                                                                                               ║");
            Console.WriteLine("\t\t║                                            TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT HƯNG YÊN                                           ║");
            Console.WriteLine("\t\t║                                                    KHOA CÔNG NGHỆ THÔNG TIN                                                   ║");
            Console.WriteLine("\t\t║                                                                                                                               ║");
            Console.WriteLine("\t\t║                                                                                                                               ║");
            Console.WriteLine("\t\t║                                                                                                                               ║");
            Console.WriteLine("\t\t║                                                                                                                               ║");
            Console.WriteLine("\t\t║                    ********   *********     *******   ********** *********   ********  **********       ***                   ║");
            Console.WriteLine("\t\t║                    ***    **  ***    ***   ***   ***       ***    ***       ***           ***          *****                  ║");
            Console.WriteLine("\t\t║                    ***    *** ***    ***  ***     ***      ***    ***       ***           ***            ***                  ║");
            Console.WriteLine("\t\t║                    *********  *********   ***     ***      ***    ********* ***           ***            ***                  ║");
            Console.WriteLine("\t\t║                    ***        ***    ***  ***     ***      ***    ***       ***           ***            ***                  ║");
            Console.WriteLine("\t\t║                    ***        ***     ***  ***   ***      ***     ***       ***           ***            ***                  ║");
            Console.WriteLine("\t\t║                    ***        ***      ***  *******   ******     *********   ********     ***          *******                ║");
            Console.WriteLine("\t\t║                                                                                                                               ║");
            Console.WriteLine("\t\t║                                                                                                                               ║");
            Console.WriteLine("\t\t║                   ╔════════════════════════════════════════════════════════════════════════════════════════╗                  ║");
            Console.WriteLine("\t\t║                   ║   CHÀO MỪNG BẠN ĐẾN VỚI ỨNG DỤNG QUẢN LÝ SINH VIÊN KHOA CNTT TRƯỜNG ĐH SPKT HƯNG YÊN   ║                  ║");
            Console.WriteLine("\t\t║                   ╚════════════════════════════════════════════════════════════════════════════════════════╝                  ║");
            Console.WriteLine("\t\t║                                                                                                                               ║");
            Console.WriteLine("\t\t║                                                                                                                               ║");
            Console.WriteLine("\t\t║                                                                                                                               ║");
            Console.WriteLine("\t\t║                                              Giáo Viên Hướng dẫn: TRỊNH THỊ NHỊ                                               ║");
            Console.WriteLine("\t\t║                                              Sinh Viên thực hiện: LUYỆN HẢI ĐĂNG                                              ║");
            Console.WriteLine("\t\t║                                              Lớp                : 125201                                                      ║");
            Console.WriteLine("\t\t║                                              Mã sinh viên       : 12520063                                                    ║");
            Console.WriteLine("\t\t║                                                                                                                               ║");
            Console.WriteLine("\t\t║                                                                                                                               ║");
            Console.WriteLine("\t\t║                                                                                                                               ║");
            Console.WriteLine("\t\t║                                                                                                                               ║");
            Console.WriteLine("\t\t║                                                                                                                               ║");
            Console.WriteLine("\t\t║                                                                                                                               ║");
            Console.WriteLine("\t\t║                                                                                                                               ║");
            Console.WriteLine("\t\t║                                                                                                                               ║");
            Console.WriteLine("\t\t║                                                                                                                               ║");
            Console.WriteLine("\t\t║                                                        Hưng Yên 2021                                                          ║");
            Console.WriteLine("\t\t╚═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine("\t\t                                              Nhấn ENTER để vào menu chính!!!                                                    ");
            Console.ReadKey();
        }
        #endregion

        #region Menu
        static public void MenuQL()
        {
            Console.Title = "Chương Trình Quản Lý Sinh Viên Khoa CNTT Trường ĐH SPKT Hưng Yên - Luyện Hải Đăng";
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t\t╔═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("\t\t║                                                                                                                               ║");
            Console.WriteLine("\t\t║                                                                                                                               ║");
            Console.WriteLine("\t\t║                                                                                                                               ║");
            Console.Write("\t\t║                        ");
            Console.Write("                                 ▐▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▌                                                   ");
            Console.WriteLine("║");
            Console.Write("\t\t║                        ");
            Console.Write("                                 ▐       MENU      ▌                                                   ");
            Console.WriteLine("║");
            Console.Write("\t\t║                        ");
            Console.Write("                                 ▐▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▌                                                   ");
            Console.WriteLine("║");
            Console.WriteLine("\t\t║                                                                                                                               ║");
            Console.WriteLine("\t\t║                                                                                                                               ║");
            Console.WriteLine("\t\t║                                                                                                                               ║");
            Console.WriteLine("\t\t║                                                                                                                               ║");
            Console.WriteLine("\t\t║                                                                                                                               ║");
            Console.WriteLine("\t\t║                                                  ╔══════════════════════════════╗                                             ║");
            Console.WriteLine("\t\t║                                                  ║     1.Quản Lý Lớp Học        ║                                             ║");
            Console.WriteLine("\t\t║                                                  ╚══════════════════════════════╝                                             ║");
            Console.WriteLine("\t\t║                                                  ╔══════════════════════════════╗                                             ║");
            Console.WriteLine("\t\t║                                                  ║     2.Quản lý Sinh Viên      ║                                             ║");
            Console.WriteLine("\t\t║                                                  ╚══════════════════════════════╝                                             ║");
            Console.WriteLine("\t\t║                                                  ╔══════════════════════════════╗                                             ║");
            Console.WriteLine("\t\t║                                                  ║     3.Quản Lý Giáo Viên      ║                                             ║");
            Console.WriteLine("\t\t║                                                  ╚══════════════════════════════╝                                             ║");
            Console.WriteLine("\t\t║                                                  ╔══════════════════════════════╗                                             ║");
            Console.WriteLine("\t\t║                                                  ║     4.Quản Lý Môn Học        ║                                             ║");
            Console.WriteLine("\t\t║                                                  ╚══════════════════════════════╝                                             ║");
            Console.WriteLine("\t\t║                                                  ╔══════════════════════════════╗                                             ║");
            Console.WriteLine("\t\t║                                                  ║     5.Quản Lý Điểm Số        ║                                             ║");
            Console.WriteLine("\t\t║                                                  ╚══════════════════════════════╝                                             ║");
            Console.WriteLine("\t\t║                                                  ╔══════════════════════════════╗                                             ║");
            Console.WriteLine("\t\t║                                                  ║     6.Tiện Ích               ║                                             ║");
            Console.WriteLine("\t\t║                                                  ╚══════════════════════════════╝                                             ║");
            Console.WriteLine("\t\t║                                                  ╔══════════════════════════════╗                                             ║");
            Console.WriteLine("\t\t║                                                  ║     7.Exit                   ║                                             ║");
            Console.WriteLine("\t\t║                                                  ╚══════════════════════════════╝                                             ║");
            Console.WriteLine("\t\t║                                                                                                                               ║");
            Console.WriteLine("\t\t║                                                                                                                               ║");
            Console.WriteLine("\t\t║                                                                                                                               ║");
            Console.WriteLine("\t\t║                                                                                                                               ║");
            Console.WriteLine("\t\t║                                                                                                                               ║");
            Console.WriteLine("\t\t╚═══════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
        }
        #endregion

    }
}
