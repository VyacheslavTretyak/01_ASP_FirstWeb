﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace FivePages.Controllers
{
    public class FirstPageController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}