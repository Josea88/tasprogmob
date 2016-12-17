using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinClientApp.Models
{
   public class BarangKategori
    {
        public string KodeBarang { get; set; }
        public int KategoriId { get; set; }
        public string NamaKategori { get; set; }
        public int IdJenisMotor { get; set; }
        public string Nama { get; set; }
        public int Stok { get; set; }
        public string HargaBeli { get; set; }
        public string HargaJual { get; set; }
        public DateTime TanggalBeli { get; set; }
    }
}
