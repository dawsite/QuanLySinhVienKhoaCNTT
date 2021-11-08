using System;
using System.Collections.Generic;
using System.Text;
using QuanLySinhVien.Entities;
using System.IO;
using QuanLySinhVien.DataAccessLayer.Interface;
namespace QuanLySinhVien.DataAccessLayer
{
    public class DiemSoDA : IQuanLyDA<DiemSo>
    {
        #region Đường dẫn tệp
        private string FileData = "DiemSo.txt";
        #endregion

        #region Đọc dữ liệu từ tệp
        public List<DiemSo> layData()
        {
            if (!File.Exists(FileData))
                File.Create(FileData).Close();
            List<DiemSo> List = new List<DiemSo>();
            StreamReader Reader = File.OpenText(FileData);
            string s = Reader.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('|');
                    DiemSo ds = new DiemSo(int.Parse(a[0]), int.Parse(a[1]), int.Parse(a[2]), double.Parse(a[3]), double.Parse(a[4]));
                    List.Add(ds);
                }
                s = Reader.ReadLine();
            }
            Reader.Close();
            return List;
        }
        #endregion

        #region Thêm dữ liệu vào tệp
        public void themData(DiemSo ds)
        {
            StreamWriter Fwrite = File.AppendText(FileData);
            Fwrite.WriteLine();
            Fwrite.Write(ds.MaLop + "|" + ds.MaMonHoc + "|" + ds.MaSinhVien+"|"+ ds.DiemQuaTrinh +"|"+ds.DiemKTHP);
            Fwrite.Close();
        }
        #endregion

        #region Cập nhật dữ liệu tệp
        public void suaData(List<DiemSo> list)
        {
            StreamWriter Fwrite = File.CreateText(FileData);
            for (int i = 0; i < list.Count; ++i)
            {
                Fwrite.WriteLine(list[i].MaLop + "|" + list[i].MaMonHoc + "|" + list[i].MaSinhVien+"|"+list[i].DiemQuaTrinh+"|"+list[i].DiemKTHP);
            }
            Fwrite.Close();
        }
        #endregion
    }
}
