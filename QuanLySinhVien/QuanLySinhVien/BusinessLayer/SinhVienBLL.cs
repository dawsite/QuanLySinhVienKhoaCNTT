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
    public class SinhVienBLL : IQuanLyBLL<SinhVien>
    {
        private IQuanLyDA<SinhVien> svDA = new SinhVienDA();

        #region Lấy danh sách các đối tượng
        public List<SinhVien> layDS()
        {
            return svDA.layData();
        }
        #endregion

        #region Thêm đối tượng vào danh sách
        public void themDS(SinhVien sv)
        {
            if (sv.MaSinhVien !="")
            {
                svDA.themData(sv);
            }
            else
                throw new Exception("Dữ liệu lỗi");
        }
        #endregion

        #region Sửa thông tin đối tượng trong danh sách
        public void suaDS(string id, SinhVien sinhvien)
        {
            //Đọc toàn bộ tập lớn về
            List<SinhVien> sv = layDS();
            //Sửa trên DS và ghi đè vào tệp
            sv[viTri(id)] = sinhvien;
            svDA.suaData(sv);//Sửa ds ghi lại tệp
        }
        #endregion

        #region Xóa đối tượng khỏi danh sách
        public void xoaDS(string id)
        {
            List<SinhVien> list = svDA.layData();
            list.RemoveAt(viTri(id));
            svDA.suaData(list);
        }
        #endregion

        #region Tìm vị trí của đối tượng trong danh sách
        public int viTri(string id)
        {
            List<SinhVien> list = svDA.layData();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].MaSinhVien == id)
                    return i;
            }
            return -1;
        }
        #endregion

        #region Lấy danh sách mã sinh viên
        public List<string> layDSMaSinhVien()
        {
            List<string> list = new List<string>();
            foreach (SinhVien ttin in svDA.layData())
            {
                list.Add(ttin.MaSinhVien);
            }
            return list;
        }
        #endregion

        #region Kiểm tra tính hợp lệ đầu vào
        public bool maSinhVienHopLe(string id)
        {
            List<string> list = layDSMaSinhVien();
            if (list.Contains(id) == false && id !="")
            {
                return true;
            }
            else return false;
        }

        public bool chuoiSinhVienHopLe(string tensvhoacdiachi)
        {
            if (tensvhoacdiachi != "" && tensvhoacdiachi.Length < 30)
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
            if (sdt != "" && sdt.Length < 11 && Invalid.chiChuaSo(sdt)==true)
            {
                return true;
            }
            else return false;
        }

        public bool maLopHopLe1(string malop)
        {
            LopHocBLL lhBLL = new LopHocBLL();
            List<string> list = lhBLL.layDSMaLop();
            if (list.Contains(malop) == false && malop != "")
            {
                return true;
            }
            else return false;
        }

        public int siSoSinhVienLop(string id)
        {
   
            int dem = 0;
            foreach (SinhVien ttin in svDA.layData())
            {
                if(ttin.MaLop==id)
                {
                    dem++;
                }
            }
            return dem;

        }
        #endregion
    }
}
