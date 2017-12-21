using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thickener.API.Controllers
{
    [Route("api/[controller]")]
    public class ThickenerController
    {
        [HttpPost]
        public string Thicken(string thinString)
        {
            return thinString.Thicken();
        }
    }
}
