using System;
using System.Collections.Generic;
using System.Text;
using QuanLySinhVien.Entities;

namespace QuanLySinhVien.DataAccessLayer.Interface
{
    public interface IQuanLyDA<T>
    {
        List<T> layData();

        void themData(T myObject);

        void suaData(List<T> myListObject);
    }
}
