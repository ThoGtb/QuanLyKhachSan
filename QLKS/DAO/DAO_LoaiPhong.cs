﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DAO_LoaiPhong
    {
        public DBQuanLyKhachSanDataContext db = new DBQuanLyKhachSanDataContext(ThayDoiChuoi.GetConnectionString());

        public List<LoaiPhong> Xem()
        {
            List<LoaiPhong> data = new List<LoaiPhong>();
            using (DBQuanLyKhachSanDataContext db = new DBQuanLyKhachSanDataContext(ThayDoiChuoi.GetConnectionString()))
            {
                var loaiphong = (from lp in db.LoaiPhongs
                                 select new
                                 {
                                     lp.MaLoaiPhong,
                                     lp.TenLoaiPhong,
                                     lp.Gia
                                 }).ToList();

                foreach (var item in loaiphong)
                {
                    LoaiPhong lpItem = new LoaiPhong();
                    lpItem.MaLoaiPhong = item.MaLoaiPhong;
                    lpItem.TenLoaiPhong = item.TenLoaiPhong;
                    lpItem.Gia = item.Gia;

                    data.Add(lpItem);
                }
            }
            return data;
        }
        public bool ThemLoaiPhong(string maLoaiPhong, string tenLoaiPhong, float gia)
        {
            using (DBQuanLyKhachSanDataContext db = new DBQuanLyKhachSanDataContext(ThayDoiChuoi.GetConnectionString()))
            {
                try
                {
                    if (db.LoaiPhongs.Any(lp => lp.MaLoaiPhong == maLoaiPhong))
                    {
                        return false;
                    }

                    LoaiPhong loaiPhong = new LoaiPhong();
                    loaiPhong.MaLoaiPhong = maLoaiPhong;
                    loaiPhong.TenLoaiPhong = tenLoaiPhong;
                    loaiPhong.Gia = gia;

                    db.LoaiPhongs.InsertOnSubmit(loaiPhong);
                    db.SubmitChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool SuaLoaiPhong(string maLoaiPhong, string tenLoaiPhong, float gia)
        {
            using (DBQuanLyKhachSanDataContext db = new DBQuanLyKhachSanDataContext(ThayDoiChuoi.GetConnectionString()))
            {
                try
                {
                    LoaiPhong loaiPhong = db.LoaiPhongs.SingleOrDefault(lp => lp.MaLoaiPhong == maLoaiPhong);
                    if (loaiPhong != null)
                    {
                        loaiPhong.TenLoaiPhong = tenLoaiPhong;
                        loaiPhong.Gia = gia;
                        db.SubmitChanges();
                        return true;
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public bool XoaLoaiPhong(string maLoaiPhong)
        {
            using (DBQuanLyKhachSanDataContext db = new DBQuanLyKhachSanDataContext(ThayDoiChuoi.GetConnectionString()))
            {
                try
                {
                    LoaiPhong loaiPhong = db.LoaiPhongs.SingleOrDefault(lp => lp.MaLoaiPhong == maLoaiPhong);

                    if (loaiPhong != null)
                    {
                        db.LoaiPhongs.DeleteOnSubmit(loaiPhong);
                        db.SubmitChanges();
                        return true;
                    }
                    return false;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
