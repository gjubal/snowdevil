using System;
using Microsoft.AspNetCore.Mvc;
using snowdevil.Models;

namespace snowdevil.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository productRepository;

        public ProductController(IProductRepository repository)
        {
            productRepository = repository;
        }

        public ViewResult List() => View(productRepository.Products);
    }
}
