using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QL_NhaSach.DAL.ql_SachTableAdapters;
using QL_NhaSach.DTO;
using System.Data;
namespace QL_NhaSach.DAL
{
    class NhanVienDAL
    {
        NHANVIENTableAdapter nv;
        DataConnect con;
        public NhanVienDAL()
        {
            nv = new NHANVIENTableAdapter();
            con = new DataConnect();
        }
        
        public bool Insert(NhanVien a, TaiKhoan tk, ChucVu_NhanVien b)
        {
            try
            {
                     TaiKhoanDAL taikhoan;
                    ChucVu_NhanVienDAL chucvu;
                    taikhoan = new TaiKhoanDAL();
                    chucvu = new ChucVu_NhanVienDAL();
                    bool kqTaiKhoan = taikhoan.Insert(tk);
                    if (!kqTaiKhoan)
                        return false;
                int i = (int)nv.ktraKhoa_NhanVien(a.MANV);
                if(i==0)
                {
                    nv.Insert(a.MANV, a.TENTAIKHOAN, a.HOTEN, a.NGAYSINH, a.SDT,a.DIACHI);
                    chucvu.Insert(b);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        public List<NhanVien> Thongtinnhanvien(string tendn)
        {
             DataTable dt = nv.ThongTin_Nhanvien_TenDN(tendn);
             List<NhanVien> k = con.ListTable<NhanVien>(dt);
            return k;
        }
     public bool kiemtra_sdt(string sdt)
        {
            try
            {
                
                int kq = (int)nv.KtraKhoaSDT(sdt);
                if (kq<0)
                    return false;
                return true;
            }
            catch
            {
                return false;
            }
        }
     public bool update_mk(string sdt, string mk)
     {
         try
         {

             int kq = (int)nv.UpdateQuery_MatKhau(mk,sdt);
             if (kq < 0)
                 return false;
             return true;
         }
         catch
         {
             return false;
         }
     }
     public bool update_Reset_mk(string manv)
     {
         try
         {

             int kq = (int)nv.update_Reset_mk(manv);
             if (kq < 0)
                 return false;
             return true;
         }
         catch
         {
             return false;
         }
     }
     public bool kiemtra_MaNV(string manv)
     {
         try
         {

             int kq = (int)nv.ktraKhoa_NhanVien(manv);
             if (kq < 0)
                 return false;
             return true;
         }
         catch
         {
             return false;
         }
     }
    }   
}
