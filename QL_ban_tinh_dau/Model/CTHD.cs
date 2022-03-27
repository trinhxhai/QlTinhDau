using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_ban_tinh_dau.Model
{
    public class CTHD
    {
        public int HoaDonId { get; set; }
        public int SanPhamId { get; set; }
        public double SoLuong { get; set; }
        public double KhuyenMai { get; set; }
        public double ThanhTien { get; set; }
        public string TenSanPham { get; set; }
        public double GiaBan { get; set; }
    }
}
