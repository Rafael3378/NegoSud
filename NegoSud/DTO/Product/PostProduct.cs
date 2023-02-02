using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NegoSud.Server.DTO
{
	public class PostProduct
	{
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

        public int SupplierId { get; set; }
    }
}

