﻿using System;
using System.Collections.Generic;
using System.Xml;
using Microsoft.AspNetCore.Mvc;
using PagedList;
using WebApplication3.Models;
using WebApplication3.DataContext;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication3.Controllers
{
    public class FoundController : Controller
    {
        GetDBtoAPI getDB = new GetDBtoAPI();

        // GET: /<controller>/
        public IActionResult Index()
        {
            getDB.GetSeoul(DateTime.Now);
            getDB.GetPolice(DateTime.Now, DateTime.Now, 1000);

            return View();
        }
        public IActionResult Detail()
        {
            return View();
        }
    }
}
