﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace FlightTickets.Controllers
{
    public class HomeController : AppController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}