using System;
using System.Collections.Generic;
using System.Text;
using quanly.lopdulieu;
using quanlythuvien.Data;
using System.Data;

namespace quanly.DoiTuong
{
    public class TheLoai
    {
        public string MaTheLoai { get; set; }
        public string TenTheLoai { get; set; }
        public TheLoai() { }
        public TheLoai(string maTheLoai, string tenLoai)
        {
            this.MaTheLoai = maTheLoai;
            this.TenTheLoai = tenLoai;
        }
        public bool TaoMoi()
        {
            string query = "insert into TheLoai values ('" + MaTheLoai + "',N'" + TenTheLoai + "')";
            if (DataProvider.ExecuteNonQuery(query) == 1) return true; else return false;
        }
        public bool CapNhat()
        {
            string query = "update TheLoai set loai = N'" + TenTheLoai + "' where MaTheLoai='" + MaTheLoai + "'";
            if (DataProvider.ExecuteNonQuery(query) == 1) return true; else return false;
        }
        public static List<TheLoai> GetDanhSachTheLoai()
        {
            DataTable dtTheLoai = DataProvider.ExecuteQuery("select * from TheLoai");
            List<TheLoai> list = new List<TheLoai>();
            foreach (DataRow dr in dtTheLoai.Rows)
            {
                TheLoai item = new TheLoai(dr["MaTheLoai"].ToString(), dr["TenTheLoai"].ToString());
                list.Add(item);
            }
            return list;
        }
    }
}
