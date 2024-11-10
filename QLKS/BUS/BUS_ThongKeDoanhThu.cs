using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_ThongKeDoanhThu
    {
        private static BUS_ThongKeDoanhThu instance;
        public static BUS_ThongKeDoanhThu Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BUS_ThongKeDoanhThu();
                }
                return instance;
            }
        }
        private BUS_ThongKeDoanhThu() { }
        public void ThongKeKhachHang(DataGridView data, string tungay, string denngay)
        {
            data.DataSource = DAO_ThongKeDoanhThu.Instance.ThongKeKhachHang(tungay, denngay);
        }

    }
}
