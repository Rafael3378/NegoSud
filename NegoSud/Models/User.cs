﻿using System;
namespace NegoSud.Server.Models
{
	public class User
	{
        public int Id { get; set; }

        public string Login { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string FirstName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public string ZipCode { get; set; } = string.Empty;

        public string Street { get; set; } = string.Empty;

        public string Role { get; set; } = string.Empty;

        public List<Order> Orders { get; set; }
	}
}

