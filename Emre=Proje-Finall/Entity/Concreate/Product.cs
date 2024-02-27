using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concreate
{
	public class Product
	{
		public int ProductId { get; set; }
		public string UrunAdı { get; set; }
		public int UrunFiyat { get; set; }
		public string RamAlanı { get; set; }
		public string HafızaAlanı { get; set; }
		public string YedeklemeZamanı { get; set; }
		public string Koruması { get; set; }
		public string Erişim { get; set; }
		public string TeknikDestek { get; set; }

		/// Urun Kategory İle İliş ki 
		public int CategoryId { get; set; }
		public Category Category { get; set; }
	}
}
