using System;
using System.Collections.Generic;
using System.Text;
using QuanLySinhVien.DataAccessLayer;
using QuanLySinhVien.Entities;
using QuanLySinhVien.BusinessLayer.Interface;
using QuanLySinhVien.DataAccessLayer.Interface;
namespace QuanLySinhVien.BusinessLayer
{
    public class MonHocBLL : IQuanLyBLL<MonHoc>
    {
        private IQuanLyDA<MonHoc> mhDA = new MonHocDA();

        #region Lấy danh sách các đối tượng
        public List<MonHoc> layDS()
        {
            return mhDA.layData();
        }
        #endregion

        #region Thêm đối tượng vào danh sách
        public void themDS(MonHoc mh)
        {
            if (mh.MaMonHoc!="")
            {
                mhDA.themData(mh);
            }
            else
                throw new Exception("Dữ liệu lỗi");
        }
        #endregion

        #region Tìm vị trí của đối tượng trong danh sách
        public int viTri(string id)
        {
            List<MonHoc> list = mhDA.layData();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].MaMonHoc == id)
                    return i;
            }
            return -1;
        }
        #endregion

        #region Sửa thông tin đối tượng trong danh sách
        public void suaDS(string id, MonHoc monhoc)
        {
            //Đọc toàn bộ tập lớn về
            List<MonHoc> mh = layDS();
            //Sửa trên DS và ghi đè vào tệp

            mh[viTri(id)] = monhoc;
            mhDA.suaData(mh);//Sửa ds ghi lại tệp
        }
        #endregion

        #region Xóa đối tượng khỏi danh sách
        public void xoaDS(string id)
        {
            List<MonHoc> list = mhDA.layData();
            list.RemoveAt(viTri(id));
            mhDA.suaData(list);
        }
        #endregion

        #region Lấy danh sách mã môn
        public List<string> layDSMaMon()
        {
            List<string> list = new List<string>();
            foreach (MonHoc ttin in mhDA.layData())
            {
                list.Add(ttin.MaMonHoc);
            }
            return list;
        }
        #endregion

        #region Kiểm tra tính hợp lệ dữ liệu đầu vào
        public bool maMonHopLe(string id)
        {
            List<string> list = layDSMaMon();
            if (id != "" && id.Length<30)
            {
                return true;
            }
            else return false;
        }

        public bool maMonHopLe1(string id)
        {
            List<string> list = layDSMaMon();
            if (list.Contains(id) == false && id != "")
            {
                return true;
            }
            else return false;
        }

        

        public bool chuoiMonHopLe(string tenmon)
        {
            if (tenmon != "" && tenmon.Length < 30)
            {
                return true;
            }
            else return false;
        }

        public bool soTinChiHopLe(int sotc)
        {
            if (sotc<10&&sotc>0)
            {
                return true;
            }
            else return false;
        }
        
        public bool maGiaoVienHopLe(string id)
        {
            GiangVienBLL gvBLL = new GiangVienBLL();
            List<string> list = gvBLL.layDSMaGiangVien();
            if (list.Contains(id) == false && id != "")
            {
                return true;
            }
            else return false;

        }
        public bool maGiaoVienHopLe(string mamon,string magv)
        {
            bool check = true;
            for(int i=0;i<mhDA.layData().Count;i++)
            {
                if(mhDA.layData()[i].MaMonHoc==mamon&&mhDA.layData()[i].MaGiangVien==magv)
                {
                    return false; 
                }
            }
            return check;
        }

        public MonHoc timMonHoc(string id)
        {
            MonHoc x = new MonHoc();
            List<MonHoc> list = mhDA.layData();
            foreach (MonHoc mh in list)
            {
                if (mh.MaMonHoc == id)
                {
                    x = mh;
                }
            }
            return x;
        }
        #endregion

    }
}

