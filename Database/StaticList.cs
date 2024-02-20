﻿using DynamicTechShop.Model;

namespace DynamicTechShop.Database;

public static class StaticList
{

	public static List<ProductModel> Productes { get; set; } = new()
	{
		new ProductModel
		{
			Id = 1,
			Name = "iPhone 13",
			Category = "Smartphone",
			Description = "The iPhone 13 features a new dual-camera system and brighter display.",
			ImageUrl = "images/iphone13.png",
			Price = 799.00
		},
		new ProductModel
		{
			Id = 2,
			Name = "Samsung Galaxy S21",
			Category = "Smartphone",
			Description = "High-end smartphone with an advanced camera setup and sleekdesign.",
			ImageUrl = "images/galaxys21.png",
			Price = 699.00
		},

		new ProductModel
		{
			Id = 3,
			Name = "MacBook Air",
			Category = "Laptop",
			Description = "Lightweight and powerful laptop with M1 chip for incredibleperformance.",
			ImageUrl = "images/macbookair.png",
			Price = 999.00
		},

		new ProductModel
		{
			Id = 4,
			Name = "Sony WH-1000XM4",
			Category = "Headphones",
			Description = "Industry-leading noise canceling headphones with exceptionalsound quality.",
			ImageUrl = "images/sonywh1000xm4.png",
			Price = 349.99
		},

		new ProductModel
		{
			Id = 5,
			Name = "Logitech MX Master 3",
			Category = "Accessories",
			Description = "Advanced wireless mouse designed for precision and comfort.",
			ImageUrl = "images/logitechmxmaster3.png",
			Price = 99.99
		},

		new ProductModel
		{
			Id = 6,
			Name = "Dell XPS 15",
			Category = "Laptop",
			Description = "Powerful laptop with stunning 4K display and exceptional build quality.",
			ImageUrl = "images/dellxps15.png",
			Price = 1250.00
		},

		new ProductModel
		{
			Id = 7,
			Name = "Google Pixel 5",
			Category = "Smartphone",
			Description = "The ultimate 5G Google phone with an ultra-wide lens and all- day battery.",
			ImageUrl = "images/googlepixel5.png",
			Price = 699.00
		},

		new ProductModel
		{
			Id = 8,
			Name = "iPad Pro",
			Category = "Tablet",
			Description = "Most advanced iPad with breakthrough M1 performance and stunning 12.9 - inch Liquid Retina XDR display.",
			ImageUrl = "images/ipadpro.png",
			Price = 1099.00
		},

		new ProductModel
		{
			Id = 9,
			Name = "Apple Watch Series 6",
			Category = "Wearable",
			Description = "The future of health on your wrist with blood oxygen and ECGapps.",
			ImageUrl = "images/applewatchs6.png",
			Price = 399.00
		},

		new ProductModel
		{
			Id = 10,
			Name = "Bose QuietComfort Earbuds",
			Category = "Headphones",
			Description = "World-class noise cancelling earbuds with high-fidelity audio and comfortable fit.",
			ImageUrl = "images/boseearbuds.png",
			Price = 279.00
		},

		new ProductModel
		{
			Id = 11,
			Name = "Nvidia GeForce RTX 3080",
			Category = "Graphics Card",
			Description = "The ultimate play with 10GB GDDR6X memory and next-gen ray tracing.",
			ImageUrl = "images/nvidiartx3080.png",
			Price = 699.99
		},

		new ProductModel
		{
			Id = 12,
			Name = "Razer DeathAdder V2",
			Category = "Accessories",
			Description = "Ergonomic gaming mouse with best-in-class ergonomics and high - precision 20K DPI optical sensor.",
			ImageUrl = "images/razerdeathadderv2.png",
			Price = 69.99
		}
	};
};