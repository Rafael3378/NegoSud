using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NegoSud.Server.DTO.Order
{
	public class OrderDto
	{
        public int Id { get; set; }

        public string CreationDate { get; set; } = string.Empty;

        public string State { get; set; } = string.Empty;

        public string Quantity { get; set; } = string.Empty;

        public int Archived { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public List<ProductDto> Products { get; set; }
    }
}

