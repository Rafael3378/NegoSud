using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NegoSud.Server.DTO
{
	public class PostProduct
	{
        public string Name { get; set; } 

        public string Ref { get; set; } 

        public int UnitPrice { get; set; }

        public int PackPrice { get; set; }

        public int CreationDate { get; set; }

        public int UpdateDate { get; set; }

        public string Millesime { get; set; } 

        public int Stock { get; set; }

        public int StockTreshold { get; set; }

        public int CategoryId { get; set; }

        public int SupplierId { get; set; }
    }
}

