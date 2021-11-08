using System;
using System.Collections.Generic;
using System.Text;
using QuanLySinhVien.Entities;

namespace QuanLySinhVien.BusinessLayer.Interface
{
    public interface IQuanLyBLL<T>
    {
        List<T> layDS();
        //void themDS(T myObject);
        //void suaDS(string id, T myObject);
        //void xoaDS(string id);
    }
}
