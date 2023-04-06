using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_NhaSach.DAL;
using QL_NhaSach.DTO;
namespace QL_NhaSach.BLL
{
    class NhanVienBLL
    {
         NhanVienDAL dal;
         public NhanVienBLL()
        {
            dal = new NhanVienDAL();
        }
         public bool Insert(NhanVien a, TaiKhoan b, ChucVu_NhanVien c)
        {
            return dal.Insert(a, b, c);
        }
         public List<NhanVien> Thongtinnhanvien(string tendn)
         {
             return dal.Thongtinnhanvien(tendn);
         }
         public bool kiemtra_sdt(string sdt)
         {
             return dal.kiemtra_sdt(sdt);
         }
         public bool update_mk(string sdt, string mk)
         {
             return dal.update_mk(sdt, mk);
         }
         public bool update_Reset_mk(string manv)
         {
             return dal.update_Reset_mk(manv);
         }
         public bool kiemtra_MaNV(string manv)
         {
             return dal.kiemtra_MaNV(manv);
         }
    }
}
