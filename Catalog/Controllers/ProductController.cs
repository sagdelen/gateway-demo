using Catalog.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Catalog.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        [HttpGet]
        public List<Product> All()
        {
            return new List<Product>
            {
                new Product
                {
                    ProductId = Guid.Parse("ef29fc61-abcc-4ac1-9c8c-e5e17b266868"),
                    Name = "Azure Shirt"
                },
                new Product
                {
                    ProductId = Guid.Parse("618808a6-8466-4fd8-80da-e8651ec0c0e4"),
                    Name = "ASP.net Core Shirt"
                },
                new Product
                {
                    ProductId = Guid.Parse("dc2bd686-7eaf-44a3-9fdd-b3645fef9a02"),
                    Name = "Node JS Shirt"
                },
                new Product
                {
                    ProductId = Guid.Parse("d91d2019-e642-4b00-8b10-2bf07c383787"),
                    Name = "Spring Shirt"
                }
            };
        }
    }
}