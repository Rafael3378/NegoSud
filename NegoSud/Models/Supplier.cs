using System;

namespace NegoSud.Server.Models
{
	public class Supplier
	{
        public int Id { get; set; }

        public string Name { get; set; }

        public string Siret { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string City { get; set; }

        public string ZipCode { get; set; }

        public string Street { get; set; }

        public List<Product> Products { get; set; }
    }
}

