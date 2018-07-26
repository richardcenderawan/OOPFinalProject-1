using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptLibrary
{
    public class PenjualanDetail
    {
        public Member NomorMember { get; set; }
        public string NoTransaksi { get; set; }
        public Makanan KodeMakanan { get; set; }
        public Penjualan Jumlah { get; set; }
        public double TotalHarga { get; set; }
        public double diskon { get; set; }
    }
}
