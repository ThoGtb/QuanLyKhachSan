﻿using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_DSPhong
    {
        public DAO_DSPhong phongDAO = new DAO_DSPhong();

        public List<Phong> Xem()
        {
            return phongDAO.Xem();
        }
        public bool themPhong(string maPhong, string maLoaiPhong, string soPhong, string tinhTrang)
        {
            return phongDAO.themPhong(maPhong, maLoaiPhong, soPhong, tinhTrang);
        }
        public bool xoaPhong(string maPhong)
        {
            return phongDAO.xoaPhong(maPhong);
        }
        public bool suaPhong(string maPhong, string maLoaiPhong, string soPhong, string tinhTrang)
        {
            return phongDAO.suaPhong(maPhong, maLoaiPhong, soPhong, tinhTrang);
        }
        public double LayGiaTienTheoMaPhong(string maPhong)
        {
            if (string.IsNullOrWhiteSpace(maPhong))
            {
                throw new ArgumentException("Mã phòng không được để trống.");
            }
            return phongDAO.LayGiaTienTheoMaPhong(maPhong);
        }
    }
}
