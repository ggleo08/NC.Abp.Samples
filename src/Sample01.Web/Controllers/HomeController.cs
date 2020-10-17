using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc;

namespace Sample01.Web.Controllers
{
    public class HomeController : AbpController
    {
        public IActionResult Index()
        {
            return Ok("Hellp ABP!");
        }
    }
}
