using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySinhVien.Entities
{
    //Khai báo các thông tin liên quan đến sinh viên
    public class SinhVien
    {
        #region Các thành phần dữ liệu
        private string maSinhVien;
        private string hoTen;
        private string gioiTinh;
        private string diaChi;
        private string ngaySinh;
        private string sdt;
        private string maLop;
        #endregion

        #region Các thuộc tính
        public string MaSinhVien
        {
            get { return maSinhVien; }
            set
            {
                if (value !="")
                {
                    maSinhVien = value;
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
                if (value !="")
                {
                    sdt = value;
                }
            }
        }
        public string MaLop
        {
            get { return maLop; }
            set
            {
                if (value !="")
                {
                    maLop = value;
                }
            }
        }
        #endregion

        #region Các thương thức  
        //Phương thức khởi tạo không tham số
        public SinhVien() { }
        //Phương thức thiết lập sao chép
        public SinhVien(SinhVien sv)
        {
            this.maSinhVien = sv.maSinhVien;
            this.hoTen = sv.hoTen;
            this.gioiTinh = sv.gioiTinh;
            this.diaChi = sv.diaChi;
            this.ngaySinh = sv.ngaySinh;
            this.sdt = sv.sdt;
            this.maLop = sv.maLop;
        }
        //Phương thức khởi tạo có tham số
        public SinhVien(string masv, string hoten, string gioitinh, string diachi, string ngaysinh, string sdt,string malop)
        {
            this.maSinhVien = masv;
            this.hoTen = hoten;
            this.gioiTinh = gioitinh;
            this.diaChi = diachi;
            this.ngaySinh = ngaysinh;
            this.sdt = sdt;
            this.maLop = malop;
        }
        #endregion
    }
}
