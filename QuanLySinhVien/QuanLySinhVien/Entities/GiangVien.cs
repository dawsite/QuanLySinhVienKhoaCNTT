using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySinhVien.Entities
{
    //Khai báo các thông tin liên quan đến giảng viên
    public class GiangVien
    {
        #region Các thành phần dữ liệu
        private string maGiangVien;
        private string hoTen;
        private string gioiTinh;
        private string diaChi;
        private string ngaySinh;
        private string sdt;
        #endregion

        #region Các thuộc tính
        public string MaGiangVien
        {
            get { return maGiangVien; }
            set
            {
                if(value!="")
                {
                    maGiangVien = value;
                }
            }
        }
        public string HoTen
        {
            get { return hoTen; }
            set
            {
                if (value != "")
                {
                    hoTen = value;
                }
            }
        }
        public string GioiTinh
        {
            get { return gioiTinh; }
            set
            {
                if (value != "")
                {
                    gioiTinh = value;
                }
            }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set
            {
                if (value != "")
                {
                    diaChi = value;
                }
            }
        }
        public string NgaySinh
        {
            get { return ngaySinh; }
            set
            {
                if (value != "")
                {
                    ngaySinh = value;
                }
            }
        }
        public string SDT
        {
            get { return sdt; }
            set
            {
                if (value != "")
                {
                    sdt = value;
                }
            }
        }
        #endregion

        #region Các thương thức  
        //Phương thức khởi tạo không tham số
        public GiangVien() { }
        //Phương thức thiết lập sao chép
        public GiangVien(GiangVien gv)
        {
            this.maGiangVien = gv.maGiangVien;
            this.hoTen = gv.hoTen;
            this.gioiTinh = gv.gioiTinh;
            this.diaChi = gv.diaChi;
            this.ngaySinh = gv.ngaySinh;
            this.sdt = gv.sdt;
        }
        //Phương thức khởi tạo có tham số
        public GiangVien(string magv, string hoten, string gioitinh, string diachi, string ngaysinh, string dt)
        {
            this.maGiangVien = magv;
            this.hoTen = hoten;
            this.gioiTinh = gioitinh;
            this.diaChi = diachi;
            this.ngaySinh = ngaysinh;
            this.sdt = dt;
        }
        
        #endregion
    }
}
