using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_ban_tinh_dau.Model
{
    public class BCTK_KhachHang
    {
        public int IdKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public int TongSoLuongDaBan { get; set; }
        public int TongThanhTien { get; set; }
    }
}
