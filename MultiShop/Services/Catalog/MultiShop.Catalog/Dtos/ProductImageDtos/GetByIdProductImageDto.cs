using System;
using MongoDB.Bson.Serialization.Attributes;
using MultiShop.Catalog.Entities;

namespace MultiShop.Catalog.Dtos.ProductImageDtos
{
	public class GetByIdProductImageDto
	{
        public string ProductImageID { get; set; }
        public string Images1 { get; set; }
        public string Images2 { get; set; }
        public string Images3 { get; set; }

        public string ProductId { get; set; }

        public Product Product { get; set; }
    }
}

