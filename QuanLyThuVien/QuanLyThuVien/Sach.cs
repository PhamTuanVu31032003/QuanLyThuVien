using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    internal class Sach
    {
        Ketnoi kn;
        public Sach()
        {
            kn = new Ketnoi();
        }
        // lay du lieu bang book
        public DataTable Getallbook()
        {
            string sql = "SELECT * FROM Sach";
            return kn.Readdata(sql);
        }
        // them sach
        public void Createbook(string Masach, string Tensach,string Matg, string Tentg, string Nhaxb, int Namxb,string theloai, int Soluong,int soluongconlai)
        {
            string sql = "INSERT INTO Sach (MaSach,TenSach,MaTacGia,TenTacGia,NhaXuatBan,NamXuatBan,TheLoai,SoLuong,SoLuongConLai) VALUES (@MaSach, @TenSach,@MaTacGia,@TenTacGia,@NhaXuatBan,@NamXuatBan,@TheLoai,@SoLuong,@SoLuongConLai)"; // truyen vao cac tham so 
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@MaSach", Masach),
                new SqlParameter("@TenSach", Tensach),
                new SqlParameter("@MaTacGia", Matg),
                new SqlParameter("@TenTacGia", Tentg),
                new SqlParameter("@NhaXuatBan", Nhaxb),
                new SqlParameter("@NamXuatBan", Namxb),
                new SqlParameter("@TheLoai", theloai),
                new SqlParameter("@SoLuong", Soluong),
                new SqlParameter("@SoLuongConLai", soluongconlai)
            };
            kn.CUD(sql, sp);
        }
        public void Updatebook(string Masach, string Tensach, string Matg, string Tentg, string Nhaxb, int Namxb, string theloai, int Soluong, int soluongconlai)
        {
            string sql = "UPDATE Sach SET TenSach = @TenSach, MaTacGia = @MaTacGia, TenTacGia = @TenTacGia, NhaXuatBan = @NhaXuatBan, NamXuatBan=@NamXuatBan,Theloai = @TheLoai,SoLuong=@SoLuong, SoLuongConLai = @SoLuongConLai WHERE MaSach = @MaSach"; // truyen vao cac tham so 
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@MaSach", Masach),
                new SqlParameter("@TenSach", Tensach),
                new SqlParameter("@MaTacGia", Matg),
                new SqlParameter("@TenTacGia", Tentg),
                new SqlParameter("@NhaXuatBan", Nhaxb),
                new SqlParameter("@NamXuatBan", Namxb),
                new SqlParameter("@TheLoai", theloai),
                new SqlParameter("@SoLuong", Soluong),
                new SqlParameter("@SoLuongConLai", soluongconlai)
            };
            kn.CUD(sql, sp);
        }
        public void Deletebook(string Masach, string Tensach, string Matg, string Tentg, string Nhaxb, int Namxb, string theloai, int Soluong, int soluongconlai)
        {
            string sql = "DELETE FROM Sach WHERE MaSach = @MaSach"; // truyen vao cac tham so 
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@MaSach", Masach)
            };
            kn.CUD(sql, sp);
        }
        public DataTable Searchmabook(string Masach)
        {
            string sql = "SELECT * FROM Sach Where MaSach = @MaSach";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@MaSach", Masach)
            };
            return kn.Readdata(sql, sp);
        }
        public DataTable Searchtenbook(string Tensach)
        {
            string sql = "SELECT * FROM Sach Where TenSach = @TenSach";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@tensach", Tensach)
            };
            return kn.Readdata(sql, sp);
        }
    }
}
