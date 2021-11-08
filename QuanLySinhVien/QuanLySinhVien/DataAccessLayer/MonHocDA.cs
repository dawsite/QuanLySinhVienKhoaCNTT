using System;
using System.Collections.Generic;
using System.Text;
using QuanLySinhVien.Entities;
using System.IO;
using QuanLySinhVien.DataAccessLayer.Interface;

namespace QuanLySinhVien.DataAccessLayer
{
    class MonHocDA : IQuanLyDA<MonHoc>
    {
        #region Đường dẫn tệp
        private string FileData = "MonHoc.txt";
        #endregion

        #region Đọc dữ liệu từ tệp
        public List<MonHoc> layData()
        {
            if (!File.Exists(FileData))
                File.Create(FileData).Close();
            List<MonHoc> List = new List<MonHoc>();
            StreamReader Reader = File.OpenText(FileData);
            string s = Reader.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('|');
                    MonHoc mh = new MonHoc(a[0], a[1], int.Parse(a[2]), a[3]);
                    List.Add(mh);
                }
                s = Reader.ReadLine();
            }
            Reader.Close();
            return List;
        }
        #endregion

        #region Thêm dữ liệu vào tệp
        public void themData(MonHoc mh)
        {
            StreamWriter Fwrite = File.AppendText(FileData);
            Fwrite.WriteLine();
            Fwrite.Write(mh.MaMonHoc + "|" + mh.TenMonHoc + "|" + mh.SoTC + "|" + mh.MaGiangVien);
            Fwrite.Close();
        }
        #endregion

        #region Cập nhật dữ liệu tệp
        public void suaData(List<MonHoc> list)
        {
            StreamWriter Fwrite = File.CreateText(FileData);
            for (int i = 0; i < list.Count; ++i)
            {
                Fwrite.WriteLine(list[i].MaMonHoc + "|" + list[i].TenMonHoc + "|" + list[i].SoTC + "|" + list[i].MaGiangVien);
            }
            Fwrite.Close();
        }
        #endregion
    }
}
