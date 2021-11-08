using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySinhVien.Entities
{
    //Khai báo các thông tin liên quan đến điểm số
    public class DiemSo
    {
        #region Các thành phần dữ liệu
        private int maLop;
        private int maMonHoc;
        private int maSinhVien;
        private double diemQuaTrinh;
        private double diemKTHP;
        #endregion

        #region Các thuộc tính
        public int MaLop
        {
            get { return maLop; }
            set
            {
                if (value > 0)
                {
                    maLop = value;
                }
            }
        }
        public int MaMonHoc
        {
            get { return maMonHoc; }
            set
            {
                if (value>0)
                {
                    maMonHoc = value;
                }
            }
        }
        public int MaSinhVien
        {
            get { return maSinhVien; }
            set
            {
                if (value>0)
                {
                    maSinhVien = value;
                }
            }
        }
        public double DiemQuaTrinh
        {
            get { return diemQuaTrinh; }
            set
            {
                if (value > 0)
                {
                    diemQuaTrinh = value;
                }
            }
        }
        public double DiemKTHP
        {
            get { return diemKTHP; }
            set
            {
                if (value > 0)
                {
                    diemKTHP = value;
                }
            }
        }
        #endregion

        #region Các thương thức  
        //Phương thức khởi tạo không tham số
        public DiemSo() { }
        //Phương thức thiết lập sao chép
        public DiemSo(DiemSo ds)
        {
            this.maLop = ds.maLop;
            this.maMonHoc = ds.maMonHoc;
            this.maSinhVien = ds.maSinhVien;
            this.diemQuaTrinh = ds.diemQuaTrinh;
            this.diemKTHP = ds.diemKTHP;
        }
        //Phương thức khởi tạo có tham số
        public DiemSo(int malop, int mamh, int masv, double diemqt, double diemkthp)
        {
            this.maLop = malop;
            this.maMonHoc = mamh;
            this.MaSinhVien = masv;
            this.diemQuaTrinh = diemqt;
            this.diemKTHP = diemkthp;
        }
        #endregion
    }
}
