using System;
using System.Collections.Generic;

namespace SneakerC2C.Models
{
    public partial class HangSanPham
    {
        public HangSanPham()
        {
            SanPham = new HashSet<SanPham>();
        }

        public Guid Id { get; set; }
        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public string TinhTrang { get; set; }

        public ICollection<SanPham> SanPham { get; set; }
    }
}
