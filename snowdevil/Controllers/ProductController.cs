using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using snowdevil.Models;
using snowdevil.Models.ViewModels;

namespace snowdevil.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository productsRepository;
        public int PageSize = 4;

        public ProductController(IProductRepository repository)
        {
            productsRepository = repository;
        }

        public ViewResult List(string category, int page = 1) => View(new ProductsListViewModel
        {
            Products = productsRepository.Products.Where(p => category == null || p.Category == category).OrderBy(p => p.ProductID).Skip((page - 1) * PageSize).Take(PageSize),
            PagingInfo = new PagingInfo
            {
                CurrentPage = page,
                ItemsPerPage = PageSize,
                TotalItems = category == null ? productsRepository.Products.Count() : productsRepository.Products.Where(e => e.Category == category).Count()
            },
            CurrentCategory = category
        });
    }
}
