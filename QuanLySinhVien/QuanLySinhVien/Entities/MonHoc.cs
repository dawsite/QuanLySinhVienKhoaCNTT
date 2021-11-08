using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLySinhVien.Entities
{
    //Khai báo các thông tin liên quan đến môn học
    public class MonHoc
    {
        #region Các thành phần dữ liệu
        private string maMonHoc;
        private string tenMonHoc;
        private int soTC;
        private string maGiangVien;
        #endregion

        #region Các thuộc tính
        public string MaMonHoc
        {
            get { return maMonHoc; }
            set
            {
                if (value!="")
                {
                    maMonHoc = value;
                }
            }
        }
        public string TenMonHoc
        {
            get { return tenMonHoc; }
            set
            {
                if (value != "")
                {
                    tenMonHoc = value;
                }
            }
        }
        public int SoTC
        {
            get { return soTC; }
            set
            {
                if (value >0 )
                {
                    soTC = value;
                }
            }
        }
        public string MaGiangVien
        {
            get { return maGiangVien; }
            set
            {
                if (value !="")
                {
                    maGiangVien = value;
                }
            }
        }
        #endregion

        #region Các thương thức  
        //Phương thức khởi tạo không tham số
        public MonHoc() { }
        //Phương thức thiết lập sao chép
        public MonHoc(MonHoc mh)
        {
            this.MaMonHoc = mh.maMonHoc;
            this.tenMonHoc = mh.tenMonHoc;
            this.soTC = mh.soTC;
            this.maGiangVien = mh.maGiangVien;
        }
        //Phương thức khởi tạo có tham số
        public MonHoc(string mamh, string tenmh, int sotc, string magv)
        {
            this.maMonHoc = mamh;
            this.tenMonHoc = tenmh;
            this.soTC = sotc;
            this.MaGiangVien = magv;
        }
        #endregion
    }
}
