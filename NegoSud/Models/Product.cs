using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NegoSud.Server.Models
{
	public class Product
	{
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Ref { get; set; }

        public string UnitPrice { get; set; }

        public string PackPrice { get; set; }

        public string CreationDate { get; set; }

        public string UpdateDate { get; set; }

        public string Millesime { get; set; }

        public string Stock { get; set; }

        public string StockTreshold { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        [ForeignKey("SupplierId")]
        public int SupplierId { get; set; }

        public Supplier Supplier { get; set; }

        public List<OrderProduct> Orders { get; set; }

    }
}

