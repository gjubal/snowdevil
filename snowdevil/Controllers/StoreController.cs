using Microsoft.AspNetCore.Mvc;
using snowdevil.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace snowdevil.Controllers
{
    public class StoreController : Controller
    {
        public ViewResult Index(string title, string text)
        {
            return View(new StoreViewModel
            {
                Title = title,
                Text = text
            });
        }

        public ViewResult ShippingIndex(string title, string text)
        {
            return View(new StoreViewModel
            {
                Title = title,
                Text = text
            });
        }
    }
}
