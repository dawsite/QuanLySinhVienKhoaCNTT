using System;
using System.Collections.Generic;
using System.Text;
using QuanLySinhVien.Utilities;
using QuanLySinhVien.DataAccessLayer;
using QuanLySinhVien.BusinessLayer;

namespace QuanLySinhVien.Utilities
{
    public class Invalid
    {
       
        public static bool chiChuaSo(string value)
        {
            try
            {
                char[] chars = value.ToCharArray();
                foreach (char c in chars)
                {
                    if (!char.IsNumber(c))
                        return false;
                }
                return true;
            }
            catch (Exception ex) { return false; }
        }

        public static void ClearLastLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.BufferWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }

       

    }
}
