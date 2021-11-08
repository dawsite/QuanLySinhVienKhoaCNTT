using System;
using System.Collections.Generic;
using System.Text;
using QuanLySinhVien.DataAccessLayer;
using QuanLySinhVien.Entities;
using QuanLySinhVien.BusinessLayer.Interface;
using QuanLySinhVien.DataAccessLayer.Interface;

namespace QuanLySinhVien.BusinessLayer
{
    public class DiemSoBLL : IQuanLyBLL<DiemSo>
    {
        private IQuanLyDA<DiemSo> dsDA = new DiemSoDA();

        #region Lấy danh sách các đối tượng
        public List<DiemSo> layDS()
        {
            return dsDA.layData();
        }
        #endregion

        #region Thêm đối tượng vào danh sách
        public void themDS(DiemSo ds)
        {
            if (ds.MaSinhVien>0)
            {
                dsDA.themData(ds);
            }
            else
                throw new Exception("Dữ liệu lỗi");
        }
        #endregion

        #region Tìm vị trí của đối tượng trong danh sách
        public int viTri(int id)
        {
            List<DiemSo> list = dsDA.layData();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].MaSinhVien == id)
                    return i;
            }
            return -1;
        }
        #endregion

        #region Sửa thông tin đối tượng trong danh sách
        public void suaDS(int id, DiemSo diemso)
        {
            //Đọc toàn bộ tập lớn về
            List<DiemSo> ds = layDS();
            //Sửa trên DS và ghi đè vào tệp

            ds[viTri(id)] = diemso;
            dsDA.suaData(ds);//Sửa ds ghi lại tệp
        }
        #endregion

        #region Xóa đối tượng khỏi danh sách
        public void xoaDS(int id)
        {
            List<DiemSo> list = dsDA.layData();
            list.RemoveAt(viTri(id));
            dsDA.suaData(list);
        }
        #endregion
    }
}
