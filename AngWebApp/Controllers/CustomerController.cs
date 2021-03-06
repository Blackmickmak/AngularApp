﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngWebApp.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AngWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        // GET: api/values
        [HttpGet]
        public List<Customers> Get()
        {
            return new Customers().GetCustomers();
        }
    }
}
