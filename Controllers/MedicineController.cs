using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OnlineMedicineStore.Controllers
{
    public class MedicineController : Controller
    {
        public IActionResult Store()
        {
            return View();
        }
    }
}