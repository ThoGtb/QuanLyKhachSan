using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DAO_DatPhong
    {
        private static DAO_DatPhong instance;
        public static DAO_DatPhong Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAO_DatPhong();
                }
                return instance;
            }
        }
        private DAO_DatPhong() { }

        public List<ChiTietDatPhong> Xem()
        {
            List<ChiTietDatPhong> data = new List<ChiTietDatPhong>();
            using (DBQuanLyKhachSanDataContext db = new DBQuanLyKhachSanDataContext(ThayDoiChuoi.GetConnectionString()))
            {
                var datphong = (from dv in db.ChiTietDatPhongs
                              select new
                              {
                                  dv.MaChiTietDatPhong,
                                  dv.MaDatPhong,
                                  dv.MaKhachHang,
                                  dv.MaPhong,
                                  dv.MaLoaiPhong,
                                  dv.TinhTrang,
                                  dv.GiaMoiDem,
                                  dv.SoLuongPhong,
                                  dv.TongGia,
                                  dv.PhuongThucThanhToan,
                                  dv.NgayNhanPhong,
                                  dv.NgayTraPhong
                              }).ToList();

                foreach (var item in datphong)
                {
                    ChiTietDatPhong datp = new ChiTietDatPhong();
                    datp.MaChiTietDatPhong = item.MaChiTietDatPhong;
                    datp.MaDatPhong = item.MaDatPhong;
                    datp.MaKhachHang = item.MaKhachHang;
                    datp.MaPhong = item.MaPhong;
                    datp.MaLoaiPhong = item.MaLoaiPhong;
                    datp.TinhTrang = item.TinhTrang;
                    datp.GiaMoiDem = item.GiaMoiDem;    
                    datp.SoLuongPhong = item.SoLuongPhong;
                    datp.TongGia = item.TongGia;    
                    datp.PhuongThucThanhToan = item.PhuongThucThanhToan;
                    datp.NgayNhanPhong = item.NgayNhanPhong;
                    datp.NgayTraPhong = item.NgayTraPhong;

                    data.Add(datp);
                }
            }
            return data;
           
        }
        public List<DatPhong> XemDatPhong()
        {

            List<DatPhong> data = new List<DatPhong>();
            using (DBQuanLyKhachSanDataContext db = new DBQuanLyKhachSanDataContext(ThayDoiChuoi.GetConnectionString()))
            {
                var datphong = (from dv in db.DatPhongs
                                select new
                                {
                                 
                                    dv.MaDatPhong,
                                    dv.MaKhachHang,
                                   
                                }).ToList();

                foreach (var item in datphong)
                {
                    DatPhong datp = new DatPhong();
                  
                    datp.MaDatPhong = item.MaDatPhong;
                    datp.MaKhachHang = item.MaKhachHang;
                

                    data.Add(datp);
                }
            }
            return data;

        }
        public void LoadComBoBoxDatPhong(ComboBox cb)
        {
            Dictionary<string, string> dp = new Dictionary<string, string>();
            using (DBQuanLyKhachSanDataContext db = new DBQuanLyKhachSanDataContext(ThayDoiChuoi.GetConnectionString()))
            {
                var maDPhong = from ma in db.DatPhongs
                               select (
                                   ma.MaDatPhong);

                foreach (var item in maDPhong)
                {
                    dp.Add(item, item);
                }

                cb.DataSource = new BindingSource(dp, null);
                cb.DisplayMember = "Value";
                cb.ValueMember = "Key";
            }
        }
        public void LoadComBoBoxKhachHang(ComboBox cb)
        {
            Dictionary<string, string> dp = new Dictionary<string, string>();
            using (DBQuanLyKhachSanDataContext db = new DBQuanLyKhachSanDataContext(ThayDoiChuoi.GetConnectionString()))
            {
                var maKH = from ma in db.KhachHangs
                           select new
                           {
                               ma.MaKhachHang,
                               ma.TenKhachHang
                           };
                                 

                foreach (var item in maKH)
                {
                    dp.Add(item.MaKhachHang, item.TenKhachHang);
                }

                cb.DataSource = new BindingSource(dp, null);
                cb.DisplayMember = "Value";
                cb.ValueMember = "Key";
            }
        }
        public void LoadDGVFormDatPhong( TextBox maDatPhong, ComboBox maKH, DataGridView data)
        {
            using (DBQuanLyKhachSanDataContext db = new DBQuanLyKhachSanDataContext(ThayDoiChuoi.GetConnectionString()))
            {
                var rowIndex = data.SelectedCells[0].RowIndex;
                var row = data.Rows[rowIndex];
                  maDatPhong.Text = row.Cells[0].Value.ToString().Trim();
                maKH.SelectedValue = row.Cells[1].Value.ToString().Trim();
             
             
            }
        }
        public void ThemDP(DatPhong dv)
        {
            try
            {
                // Kiểm tra mã khách hàng đã tồn tại hay chưa
                if (CheckMaSDDVExists(dv.MaDatPhong))
                {
                    MessageBox.Show("Mã su dung vu đã tồn tại. Vui lòng nhập mã khác.");
                    return; // Không thực hiện thêm nếu mã đã tồn tại
                }

                using (DBQuanLyKhachSanDataContext db = new DBQuanLyKhachSanDataContext(ThayDoiChuoi.GetConnectionString()))
                {

                    db.DatPhongs.InsertOnSubmit(dv);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm thành công");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Thêm vào bị lỗi ");
            }
        }
        public void XoaDatPhong(string maDP)
        {
            using (DBQuanLyKhachSanDataContext db = new DBQuanLyKhachSanDataContext(ThayDoiChuoi.GetConnectionString()))
            {
                var ma = db.DatPhongs.FirstOrDefault(a => a.MaDatPhong == maDP);
                if (ma != null)
                {
                    db.DatPhongs.DeleteOnSubmit(ma);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
        }

        public bool SuaDatPhong(DatPhong maDPP)
        {
            using (DBQuanLyKhachSanDataContext db = new DBQuanLyKhachSanDataContext(ThayDoiChuoi.GetConnectionString()))
            {
                var maSDDV = db.DatPhongs.SingleOrDefault(a => a.MaDatPhong == maDPP.MaDatPhong);
                if (maSDDV != null)
                {

                    
                    maSDDV.MaDatPhong = maDPP.MaDatPhong;
                    maSDDV.MaKhachHang = maDPP.MaKhachHang;
                    db.SubmitChanges();
                    MessageBox.Show("Sửa thành công");
                    return true;
                }
                return false;
            }
        }
        public bool CheckMaSDDVExists(string maDP)
        {
            using (var context = new DBQuanLyKhachSanDataContext(ThayDoiChuoi.GetConnectionString())) // Giả sử đây là context của Entity Framework
            {
                // Sử dụng LINQ để kiểm tra trùng mã
                return context.DatPhongs.Any(dv => dv.MaDatPhong == maDP);
            }
        }
        public string GetCustomerNameByBookingId(string maDatPhong)
        {
            using (DBQuanLyKhachSanDataContext db = new DBQuanLyKhachSanDataContext(ThayDoiChuoi.GetConnectionString()))
            {
                var customer = (from dp in db.DatPhongs
                                join kh in db.KhachHangs on dp.MaKhachHang equals kh.MaKhachHang
                                where dp.MaDatPhong == maDatPhong
                                select kh.TenKhachHang).FirstOrDefault();
                return customer ?? "Not Found";
            }
        }




        public void LoadComBoBoxLoaiPhong(ComboBox cb)
        {
            Dictionary<string, string> dp = new Dictionary<string, string>();
            using (DBQuanLyKhachSanDataContext db = new DBQuanLyKhachSanDataContext(ThayDoiChuoi.GetConnectionString()))
            {
                var maKH = from ma in db.LoaiPhongs
                           select new
                           {
                               ma.MaLoaiPhong,
                               ma.TenLoaiPhong
                           };


                foreach (var item in maKH)
                {
                    dp.Add(item.MaLoaiPhong, item.TenLoaiPhong);
                }

                cb.DataSource = new BindingSource(dp, null);
                cb.DisplayMember = "Value";
                cb.ValueMember = "Key";
            }

        }

        public void LoadComBoBoxPhong(ComboBox cb)
        {
            Dictionary<string, string> dp = new Dictionary<string, string>();
            using (DBQuanLyKhachSanDataContext db = new DBQuanLyKhachSanDataContext(ThayDoiChuoi.GetConnectionString()))
            {
                var maDPhong = from ma in db.Phongs
                               select (
                                   ma.MaPhong);

                foreach (var item in maDPhong)
                {
                    dp.Add(item, item);
                }

                cb.DataSource = new BindingSource(dp, null);
                cb.DisplayMember = "Value";
                cb.ValueMember = "Key";
            }
        }

        public (string TenLoaiPhong, string TinhTrang) GetRoomInfoById(string maPhong)
        {
            using (DBQuanLyKhachSanDataContext db = new DBQuanLyKhachSanDataContext(ThayDoiChuoi.GetConnectionString()))
            {
                var result = (from dp in db.ChiTietDatPhongs
                              join kh in db.Phongs on dp.MaPhong equals kh.MaPhong
                              join loai in db.LoaiPhongs on kh.MaLoaiPhong equals loai.MaLoaiPhong // Corrected dp.MaLoaiPhong to kh.MaLoaiPhong
                              where dp.MaPhong == maPhong
                              select new { loai.TenLoaiPhong, kh.TinhTrang }).FirstOrDefault();

                return result != null ? (result.TenLoaiPhong, result.TinhTrang) : (null, null);
            }
        }

        public void ThemChiTietDatPhong(ChiTietDatPhong chiTiet)
        {
            try
            {
                using (DBQuanLyKhachSanDataContext db = new DBQuanLyKhachSanDataContext(ThayDoiChuoi.GetConnectionString()))
                {
                    // Thêm chi tiết đặt phòng vào cơ sở dữ liệu
                    db.ChiTietDatPhongs.InsertOnSubmit(chiTiet);
                    db.SubmitChanges();
                    MessageBox.Show("Thêm chi tiết đặt phòng thành công");
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Thêm chi tiết đặt phòng bị lỗi: " );
            }
        }

    }
}
