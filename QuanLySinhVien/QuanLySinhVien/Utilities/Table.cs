using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySinhVien.Utilities
{
    public class Table
    {
        protected int tableWidth;


        public Table(int width)
        {
            this.tableWidth = width;
        }

        public void PrintLine()
        {
            Console.Write("\t\t");
            Console.WriteLine(new string('═', tableWidth+1));
        }

        public void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "\t\t║";

            foreach (string column in columns)
            {
                row += AlignLeft(column, width) + "║";
            }
            Console.WriteLine(row);
        }


        public void PrintTitle(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "\t\t║";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "║";
            }

            Console.WriteLine(row);
        }

        public string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }

        public string AlignLeft(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text + new string(' ', width - text.Length);
            }
        }


    }
}
