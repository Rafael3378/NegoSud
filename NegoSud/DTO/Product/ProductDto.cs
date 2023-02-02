using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NegoSud.Server.DTO
{
	public class ProductDto
	{
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

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public int OrderProductId { get; set; }

        public OrderProduct OrderProduct { get; set; }

        public int SupplierId { get; set; }

        public Supplier Supplier { get; set; }

    }
}

