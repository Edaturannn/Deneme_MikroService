﻿using System;
using MultiShop.Catalog.Entities;

namespace MultiShop.Catalog.Dtos.ProductDetailDtos
{
	public class UpdateProductDetailDto
	{
        public string ProductDetailID { get; set; }
        public string ProductDescription { get; set; }
        public string ProductInfo { get; set; }

        public string ProductId { get; set; }

        public Product Product { get; set; }
    }
}

