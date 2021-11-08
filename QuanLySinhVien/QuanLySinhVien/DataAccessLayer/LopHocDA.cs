using System;
using System.Collections.Generic;
using System.Text;
using QuanLySinhVien.Entities;
using System.IO;
using QuanLySinhVien.DataAccessLayer.Interface;

namespace QuanLySinhVien.DataAccessLayer
{
    class LopHocDA : IQuanLyDA<LopHoc>
    {
        #region Đường dẫn tệp
        private string FileData = "LopHoc.txt";
        #endregion
         
        #region Đọc dữ liệu từ tệp
        public List<LopHoc> layData()
        {
            if (!File.Exists(FileData))
                File.Create(FileData).Close();
            List<LopHoc> List = new List<LopHoc>();
            StreamReader Reader = File.OpenText(FileData);
            string s = Reader.ReadLine();
            while(s!=null)
            {
                if(s!="")
                {
                    string[] a = s.Split('|');
                    LopHoc lh = new LopHoc(a[0], a[1], a[2]);
                    List.Add(lh);
                }
                s = Reader.ReadLine();
            }
            Reader.Close();
            return List;
        }
        #endregion

        #region Thêm dữ liệu vào tệp
        public void themData(LopHoc lh)
        {
            StreamWriter Fwrite = File.AppendText(FileData);
            Fwrite.WriteLine();
            Fwrite.Write(lh.MaLop + "|" + lh.TenLop + "|" + lh.ChuyenNganh);
            Fwrite.Close();
        }
        #endregion

        #region Cập nhật dữ liệu tệp
        public void suaData(List<LopHoc> list)
        {
            StreamWriter Fwrite = File.CreateText(FileData);
            for(int i =0;i < list.Count;++i)
            {
                Fwrite.WriteLine(list[i].MaLop + "|" + list[i].TenLop + "|" + list[i].ChuyenNganh);
            }
            Fwrite.Close();
        }
        #endregion
    }
}
