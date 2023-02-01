using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NegoSud.Server.Models
{
	public class Product
	{
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Ref { get; set; } = string.Empty;

        public int UnitPrice { get; set; }

        public int PackPrice { get; set; }

        public int CreationDate { get; set; }

        public int UpdateDate { get; set; }

        public string Millesime { get; set; } = string.Empty;

        public int Stock { get; set; }

        public int StockTreshold { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [ForeignKey("SupplierId")]
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        public List<OrderProduct> Orders { get; set; }

    }
}

