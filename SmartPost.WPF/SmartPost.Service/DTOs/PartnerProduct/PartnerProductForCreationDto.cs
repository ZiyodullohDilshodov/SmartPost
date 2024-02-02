﻿using SmartPost.Domain.Entities.Brands;
using SmartPost.Domain.Entities.Categories;
using SmartPost.Domain.Entities.Partners;

namespace SmartPost.Service.DTOs.PartnerProduct;

public record PartnerProductForCreationDto
{
    public long PartnerId { get; set; }
    public long BrandId { get; set; }
    public long CategoryId { get; set; }
    public string ProductName { get; set; }
    public string PCode { get; set; }
    public string BarCode { get; set; }
    public decimal Quantity { get; set; }
    public decimal Price { get; set; }
    public decimal TotalPrice { get; set; }
    public string Status { get; set; }
    public decimal Paid { get; set; }
    public decimal Debt { get; set; }
}