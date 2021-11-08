using System;
using System.Collections.Generic;
using System.Text;
using QuanLySinhVien.DataAccessLayer;
using QuanLySinhVien.Entities;
using QuanLySinhVien.BusinessLayer.Interface;
using QuanLySinhVien.DataAccessLayer.Interface;
using QuanLySinhVien.Utilities;

namespace QuanLySinhVien.BusinessLayer
{
    public class GiangVienBLL:IQuanLyBLL<GiangVien>
    {
        private IQuanLyDA<GiangVien> gvDA = new GiangVienDA();

        #region Lấy danh sách các đối tượng
        public List<GiangVien> layDS()
        {
            return gvDA.layData();
        }
        #endregion

        #region Thêm đối tượng vào danh sách
        public void themDS(GiangVien gv)
        {
            if (gv.MaGiangVien!="")
            {
                gvDA.themData(gv);
            }
            else
                throw new Exception("Dữ liệu lỗi");
        }
        #endregion

        #region Tìm vị trí của đối tượng trong danh sách
        public int viTri(string id)
        {
            List<GiangVien> list = gvDA.layData();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].MaGiangVien == id)
                    return i;
            }
            return -1;
        }
        #endregion

        #region Sửa thông tin đối tượng trong danh sách
        public void suaDS(string id, GiangVien giaovien)
        {
            //Đọc toàn bộ tập lớn về
            List<GiangVien> gv = layDS();
            //Sửa trên DS và ghi đè vào tệp

            gv[viTri(id)] = giaovien;
            gvDA.suaData(gv);//Sửa ds ghi lại tệp
        }
        #endregion

        #region Xóa đối tượng khỏi danh sách
        public void xoaDS(string id)
        {
            List<GiangVien> list = gvDA.layData();
            list.RemoveAt(viTri(id));
            gvDA.suaData(list);
        }
        #endregion


        #region Lấy danh sách mã giảng viên
        public List<string> layDSMaGiangVien()
        {
            List<string> list = new List<string>();
            foreach (GiangVien ttin in gvDA.layData())
            {
                list.Add(ttin.MaGiangVien);
            }
            return list;
        }
        #endregion


        #region Kiểm tra tính hợp lệ đầu vào


        public bool maGiangVienHopLe(string id)
        {
            List<string> list = layDSMaGiangVien();
            if (list.Contains(id) == false && id != "")
            {
                return true;
            }
            else return false;
        }


        public bool chuoiGiangVienHopLe(string tengvhoacdiachi)
        {
            if (tengvhoacdiachi != "" && tengvhoacdiachi.Length < 30)
            {
                return true;
            }
            else return false;
        }


        public bool gioiTinhHopLe(string gt)
        {
            List<string> list = new List<string>();
            list.Add("nam");
            list.Add("nữ");
            if (list.Contains(gt.ToLower()) == true)
            {
                return true;
            }
            else return false;
        }


        public bool namSinhHopLe(string namsinh)
        {
            if (namsinh != "" && namsinh.Length < 30)
            {
                return true;
            }
            else return false;
        }


        public bool sdtHopLe(string sdt)
        {
            if (sdt != "" && sdt.Length < 11 && Invalid.chiChuaSo(sdt) == true)
            {
                return true;
            }
            else return false;
        }
        #endregion
    }
}
