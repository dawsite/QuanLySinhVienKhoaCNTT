using System;
using System.Collections.Generic;
using System.Text;
using QuanLySinhVien.DataAccessLayer;
using QuanLySinhVien.Entities;
using QuanLySinhVien.BusinessLayer.Interface;
using QuanLySinhVien.DataAccessLayer.Interface;

namespace QuanLySinhVien.BusinessLayer
{
    public class LopHocBLL : IQuanLyBLL<LopHoc>
    {
        private IQuanLyDA<LopHoc> lhDA = new LopHocDA();

        #region Lấy danh sách các đối tượng
        public List<LopHoc> layDS()
        {
            return lhDA.layData();
        }
        #endregion

        #region Thêm đối tượng vào danh sách
        public void themDS(LopHoc lh)
        {
            if (lh.MaLop !="" && lh.TenLop != ""&& lh.ChuyenNganh!="")
            {
                lhDA.themData(lh);
            }
            else
                throw new Exception("Dữ liệu lỗi");
        }
        #endregion

        #region Tìm vị trí của đối tượng trong danh sách
        public int viTri(string id)
        {
            List<LopHoc> list = lhDA.layData();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].MaLop == id)
                    return i;
            }
            return -1;
        }
        #endregion

        #region Sửa thông tin đối tượng trong danh sách
        public void suaDS(string id, LopHoc lop)
        {
            //Đọc toàn bộ tập lớn về
            List<LopHoc> lh = layDS();
            //Sửa trên DS và ghi đè vào tệp
            
            lh[viTri(id)] = lop;
            lhDA.suaData(lh);//Sửa ds ghi lại tệp
        }
        #endregion

        #region Xóa đối tượng khỏi danh sách
        public void xoaDS(string id)
        {
            List<LopHoc> list = lhDA.layData();
            list.RemoveAt(viTri(id));
            lhDA.suaData(list);
        }
        #endregion

        #region Lấy danh sách mã lớp
        public List<string> layDSMaLop()
        {
            List<string> list = new List<string>();
            foreach (LopHoc ttin in lhDA.layData())
            {
                list.Add(ttin.MaLop);
            }
            return list;
        }
        #endregion

        #region Kiểm tra tính hợp lệ dữ liệu đầu vào
        public bool maLopHopLe(string id)
        {
            List<string> list = layDSMaLop();
            if (list.Contains(id) == false && id !="")
            {
                return true;
            }
            else return false;
        }
        

        public bool tenLopHopLe(string tenlop)
        {
            if (tenlop != "" && tenlop.Length < 10)
            {
                return true;
            }
            else return false;
        }

        public List<string> danhSachChuyenNganh()
        {
            List<string> list = new List<string>();
            list.Add("công nghệ web");
            list.Add("công nghệ di động");
            list.Add("kiểm thử phần mềm");
            list.Add("mạng máy tính");
            list.Add("iot");
            list.Add("đồ họa");
            list.Add("khoa học dữ liệu");
            list.Add("xử lý ngôn ngữ");
            list.Add("nhận dạng hình ảnh");
            return list;
        }

        public bool chuyenNganhHopLe(string tennganh)
        {
            if (danhSachChuyenNganh().Contains(tennganh.ToLower()) == true)
            {
                return true;
            }
            else return false;
        }
        #endregion
    }
}
