﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var book = new Book
            {
                Title ="Oni is Great",
                Author ="Oni"
            };

            return View(book);
        }
    }
}