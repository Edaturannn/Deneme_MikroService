﻿using System;
using MongoDB.Bson.Serialization.Attributes;
using MultiShop.Catalog.Entities;

namespace MultiShop.Catalog.Dtos.ProductDetailDtos
{
	public class CreateProductDetailDto
	{
        public string ProductDescription { get; set; }
        public string ProductInfo { get; set; }

        public string ProductId { get; set; }

        public Product Product { get; set; }
    }
}

