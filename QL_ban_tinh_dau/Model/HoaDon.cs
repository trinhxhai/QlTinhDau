using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_ban_tinh_dau.Model
{
    public class HoaDon
    {
        public int Id { get; set; }
        public string TenNhanVien { get; set; }
        public int NhanVienId { get; set; }
        public int KhachHangId { get; set; }
        public string TenKhachHang { get; set; }
    }
}
