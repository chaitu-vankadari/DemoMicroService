﻿namespace CatalogService.Database
{
    public class Products
    {
        public int Id { get; set; }

        public string Name { get; set; }=string.Empty;
        public string Description { get; set; }= string.Empty;
        public decimal UnitPrice { get; set;}
    }
}
