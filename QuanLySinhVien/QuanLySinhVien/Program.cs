using System;
using QuanLySinhVien.PresentationLayer;
using System.IO;
using System.Text;
using QuanLySinhVien.Utilities;

namespace QuanLySinhVien
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            Console.SetCursorPosition(Console.CursorTop, Console.CursorLeft);
            Console.SetWindowPosition(Console.CursorLeft, Console.CursorTop);

            //Em chưa viết Interface của GUI nên ms khai báo từng cái ntn
            LopHocGUI lh = new LopHocGUI();
            SinhVienGUI sv = new SinhVienGUI();
            GiaoVienGUI gv = new GiaoVienGUI();
            MonHocGUI mh = new MonHocGUI();
            DiemSoGUI ds = new DiemSoGUI();

            Menu.GiaoDienBatDau();
            do
            {
                
                int check = 0;
                while (check == 0)
                {
                    Menu.MenuQL();
                    Console.WriteLine("");
                    Console.WriteLine("");
                    string tm = "";
                    do
                    {
                        Console.Write("\t\tNhập chức năng: ");
                        tm = Console.ReadLine();
                    } while (tm != "1" && tm != "2" && tm != "3" && tm != "4" && tm != "5" && tm != "0");
                    Console.Clear();
                    switch (int.Parse(tm))
                    {
                        case 1:
                            {
                                lh.Menu();
                                break;
                            }
                        case 2:
                            {
                                sv.Menu();
                                break;
                            }
                        case 3:
                            {
                                gv.Menu();
                                break;
                            }
                        case 4:
                                mh.Menu();
                                break;
                        case 5:
                                Console.WriteLine("Đối tượng điểm số vẫn đang code!!");
                                break;
                        case 0:
                            check = 1;
                            Console.WriteLine("Bấm bất kì để trở lại Menu quản lý");
                            Menu.MenuQL();
                            break;
                        default:

                            Console.WriteLine("Sai cú pháp!");
                            break;
                    }
                }
            } while (true);
        }
    }
}
