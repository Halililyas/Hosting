﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concreate
{
	public class Category
	{
		public int CategoryId { get; set; }
		public string PaketAdı { get; set; }
		public ICollection<Product> Products { get; set; }
	}
}
