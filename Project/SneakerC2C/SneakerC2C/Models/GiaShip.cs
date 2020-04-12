using System;
using System.Collections.Generic;

namespace SneakerC2C.Models
{
    public partial class GiaShip
    {
        public Guid Id { get; set; }
        public string Loai { get; set; }
        public double? Gia { get; set; }
        public DateTime? NgayCapNhat { get; set; }
    }
}
