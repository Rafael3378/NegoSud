using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NegoSud.Server.DTO.Order
{
	public class PostOrder
	{
        public string CreationDate { get; set; } = string.Empty;

        public string State { get; set; } = string.Empty;

        public string Quantity { get; set; } = string.Empty;

        public int Archived { get; set; }

        public int UserId { get; set; }

        public List<int> Products { get; set; }
    }
}

