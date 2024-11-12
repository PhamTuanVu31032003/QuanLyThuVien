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
            string sql = "SELECT Sach.MaSach,Sach.TenSach, Sach.NhaXuatBan, Sach.NamXuatBan, Sach.TheLoai, Sach.SoLuong, Sach.SoLuongConLai, Sach.Gia, TacGia.MaTacGia, TacGia.TenTacGia " +
                "FROM Sach INNER JOIN TacGia ON Sach.MaTacGia = TacGia.MaTacGia";
            return kn.Readdata(sql);
        }
        // them sach
        public void Createbook(string Masach, string Tensach, string Matg, string Nhaxb, int Namxb, string theloai, int Soluong, int soluongconlai, string gia)
        {
            string sql = "INSERT INTO Sach (MaSach, TenSach, NhaXuatBan, NamXuatBan, TheLoai, SoLuong, SoLuongConLai, Gia, MaTacGia) " +
            "VALUES (@MaSach, @TenSach, @NhaXuatBan, @NamXuatBan, @TheLoai, @SoLuong, @SoLuongConLai, @Gia, @MaTacGia);";
            // truyen vao cac tham so 
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@MaSach", Masach),
                new SqlParameter("@TenSach", Tensach),
                new SqlParameter("@MaTacGia", Matg),
                new SqlParameter("@NhaXuatBan", Nhaxb),
                new SqlParameter("@NamXuatBan", Namxb),
                new SqlParameter("@TheLoai", theloai),
                new SqlParameter("@SoLuong", Soluong),
                new SqlParameter("@SoLuongConLai", soluongconlai),
                new SqlParameter("@Gia",gia)
            };
            kn.CUD(sql, sp);
        }
        public void Updatebook(string Masach, string Tensach, string Matg, string Nhaxb, int Namxb, string theloai, int Soluong, int soluongconlai, string gia)
        {
            string sql = "UPDATE Sach SET TenSach = @TenSach, NhaXuatBan = @NhaXuatBan, NamXuatBan = @NamXuatBan, TheLoai = @TheLoai, SoLuong = @SoLuong, SoLuongConLai = @SoLuongConLai, Gia = @Gia " +
            "WHERE MaSach = @MaSach;"; // truyen vao cac tham so 
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@MaSach", Masach),
                new SqlParameter("@TenSach", Tensach),
                new SqlParameter("@MaTacGia", Matg),
                new SqlParameter("@NhaXuatBan", Nhaxb),
                new SqlParameter("@NamXuatBan", Namxb),
                new SqlParameter("@TheLoai", theloai),
                new SqlParameter("@SoLuong", Soluong),
                new SqlParameter("@SoLuongConLai", soluongconlai),
                new SqlParameter("@Gia",gia)
            };
            kn.CUD(sql, sp);
        }
        public void Deletebook(string Masach, string Tensach, string Matg, string Nhaxb, int Namxb, string theloai, int Soluong, int soluongconlai, string gia)
        {
            string sql = "DELETE FROM Sach WHERE MaSach = @MaSach; "; // truyen vao cac tham so
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
