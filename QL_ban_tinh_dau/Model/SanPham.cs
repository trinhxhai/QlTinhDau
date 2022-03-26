using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_ban_tinh_dau.Model
{
    public class SanPham
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        
        public string TheTich { get; set; }

        public string Mota { get; set; }

        public int SoLuong { get; set; }

        public int GiaBan { get; set; }

        public int LoaiSanPhamId { get; set; }
    }
}
