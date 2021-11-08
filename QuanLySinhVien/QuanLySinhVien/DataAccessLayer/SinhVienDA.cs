using System;
using System.Collections.Generic;
using System.Text;
using QuanLySinhVien.Entities;
using System.IO;
using QuanLySinhVien.DataAccessLayer.Interface;

namespace QuanLySinhVien.DataAccessLayer
{
    class SinhVienDA : IQuanLyDA<SinhVien>
    {
        #region Đường dẫn tệp
        private string FileData = "SinhVien.txt";
        #endregion

        #region Đọc dữ liệu từ tệp
        public List<SinhVien> layData()
        {
            if (!File.Exists(FileData))
                File.Create(FileData).Close();
            List<SinhVien> List = new List<SinhVien>();
            StreamReader Reader = File.OpenText(FileData);
            string s = Reader.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('|');
                    SinhVien sv = new SinhVien(a[0],a[1],a[2],a[3],a[4],a[5],a[6]);
                    List.Add(sv);
                }
                s = Reader.ReadLine();
            }
            Reader.Close();
            return List;
        }
        #endregion

        #region Thêm dữ liệu vào tệp
        public void themData(SinhVien sv)
        {
            StreamWriter Fwrite = File.AppendText(FileData);
            Fwrite.WriteLine();
            Fwrite.Write(sv.MaSinhVien + "|" + sv.HoTen + "|" + sv.GioiTinh+"|"+sv.DiaChi+"|"+sv.NgaySinh+"|"+sv.SDT+"|"+sv.MaLop);
            Fwrite.Close();
        }
        #endregion

        #region Cập nhật dữ liệu tệp
        public void suaData(List<SinhVien> list)
        {
            StreamWriter Fwrite = File.CreateText(FileData);
            for (int i = 0; i < list.Count; ++i)
            {
                Fwrite.WriteLine(list[i].MaSinhVien + "|" + list[i].HoTen + "|" + list[i].GioiTinh + "|" + list[i].DiaChi + "|" + list[i].NgaySinh + "|" + list[i].SDT + "|" + list[i].MaLop);
            }
            Fwrite.Close();
        }
        #endregion
    }
}
