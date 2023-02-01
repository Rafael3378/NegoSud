﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NegoSud.Server.Models
{
	public class Order
	{
        [Key]
        public int Id { get; set; }

        public string CreationDate { get; set; } = string.Empty;

        public string State { get; set; } = string.Empty;

        public string Quantity { get; set; } = string.Empty;

        public int Archived { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public User User { get; set; }

        public List<OrderProduct> Products { get; set; }
    }
}

