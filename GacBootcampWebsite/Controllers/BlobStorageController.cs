﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GacBootcampWebsite.Controllers
{
    public class BlobStorageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}