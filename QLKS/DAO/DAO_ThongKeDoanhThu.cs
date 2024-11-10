using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{   
    public class DAO_ThongKeDoanhThu
    {
        
        private static DAO_ThongKeDoanhThu instance;
        public static DAO_ThongKeDoanhThu Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAO_ThongKeDoanhThu();
                }
                return instance;
            }
        }
        private DAO_ThongKeDoanhThu() { }

        public class ThongKeKhachHangDTO
        {
            public string tenKH { get; set; }
            public DateTime ngaynhanphong { get; set; }
            public DateTime ngaytraphong { get; set; }
            public float giamoidem { get; set; }
            public int soluong { get; set; }
            public float tonggia { get; set; }
            public string phuongthucthanhtoan { get; set; }
            public string tenloaiphong { get; set; }
        }

        public List<ThongKeKhachHangDTO> ThongKeKhachHang(string tungay, string denngay)
        {
            using (DBQuanLyKhachSanDataContext db = new DBQuanLyKhachSanDataContext(ThayDoiChuoi.GetConnectionString()))
            {
                List<ThongKeKhachHangDTO> lst = new List<ThongKeKhachHangDTO> ();

                var thongkekh = (from kh in db.KhachHangs
                                 join ctdp in db.ChiTietDatPhongs on kh.MaKhachHang equals ctdp.MaKhachHang
                                 join lp in db.LoaiPhongs on ctdp.MaLoaiPhong equals lp.MaLoaiPhong
                                 where ctdp.NgayNhanPhong >= DateTime.Parse(tungay) && ctdp.NgayTraPhong <= DateTime.Parse(denngay)
                                 select new
                                 {
                                     kh.TenKhachHang,
                                     ctdp.NgayNhanPhong,
                                     ctdp.NgayTraPhong,
                                     ctdp.GiaMoiDem,
                                     ctdp.SoLuongPhong,
                                     ctdp.TongGia,
                                     ctdp.PhuongThucThanhToan,
                                     lp.TenLoaiPhong,
                                 }).ToList();
                foreach (var item in thongkekh)
                {
                    ThongKeKhachHangDTO kh = new ThongKeKhachHangDTO();
                    kh.tenKH = item.TenKhachHang;
                    kh.ngaynhanphong = (DateTime)item.NgayNhanPhong;
                    kh.ngaytraphong = (DateTime)item.NgayNhanPhong;
                    kh.giamoidem = (float)item.GiaMoiDem;
                    kh.soluong = (int)item.SoLuongPhong;
                    kh.tonggia = (float)item.TongGia;
                    kh.phuongthucthanhtoan = item.PhuongThucThanhToan;
                    kh.tenloaiphong = item.TenLoaiPhong;
                    lst.Add(kh);
                }
                return lst;
            }
        }
    }
}
