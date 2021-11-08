using System;
using System.Collections.Generic;
using System.Text;
using QuanLySinhVien.Entities;
using System.IO;
using QuanLySinhVien.DataAccessLayer.Interface;

namespace QuanLySinhVien.DataAccessLayer
{
    class GiangVienDA : IQuanLyDA<GiangVien>
    {
        #region Đường dẫn tệp
        private string FileData = "GiangVien.txt";
        #endregion

        #region Đọc dữ liệu từ tệp
        public List<GiangVien> layData()
        {
            if (!File.Exists(FileData))
                File.Create(FileData).Close();
            List<GiangVien> List = new List<GiangVien>();
            StreamReader Reader = File.OpenText(FileData);
            string s = Reader.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('|');
                    GiangVien gv = new GiangVien(a[0], a[1], a[2], a[3], a[4],a[5]);
                    List.Add(gv);
                }
                s = Reader.ReadLine();
            }
            Reader.Close();
            return List;
        }
        #endregion

        #region Thêm dữ liệu vào tệp
        public void themData(GiangVien gv)
        {
            StreamWriter Fwrite = File.AppendText(FileData);
            Fwrite.WriteLine();
            Fwrite.Write(gv.MaGiangVien + "|" + gv.HoTen + "|" + gv.GioiTinh + "|" + gv.DiaChi + "|" + gv.NgaySinh + "|" + gv.SDT);
            Fwrite.Close();
        }
        #endregion

        #region Cập nhật dữ liệu tệp
        public void suaData(List<GiangVien> list)
        {
            StreamWriter Fwrite = File.CreateText(FileData);
            for (int i = 0; i < list.Count; ++i)
            {
                Fwrite.WriteLine(list[i].MaGiangVien + "|" + list[i].HoTen + "|" + list[i].GioiTinh + "|" + list[i].DiaChi + "|" + list[i].NgaySinh + "|" + list[i].SDT);
            }
            Fwrite.Close();
        }
        #endregion
    }
}
