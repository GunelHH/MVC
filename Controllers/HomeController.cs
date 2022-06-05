using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MVCHome_Work.Models;

namespace MVCHome_Work.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            List<Slider> sliders = new List<Slider>
            {
                new Slider
                {
                    Id=1,
                    Image="1.jpg",
                    Title="New Collection!",
                    Subtitle="Top Selling))",
                    Url="https://www.google.com"
                } ,
                new Slider
                {
                    Id=2,
                    Image="2.jpg",
                    Title="Top Collection m",
                    Subtitle="tp slng",
                    Url="https://www.youtube.com"
                }
            };

            return View(sliders);
        }
         public IActionResult Shop()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult Blog_detail()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
         public IActionResult ProductDetail()
        {
            return View();
        }

    }
}
