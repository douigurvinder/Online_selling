using Microsoft.AspNetCore.Mvc;
using Online_selling.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Online_selling.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class GController:ControllerBase
    {
        private readonly ApplicationDBContext context;
        public GController(ApplicationDBContext context)
        {
            this.context = context;
        }
        [HttpPost]
        public async Task<ActionResult<int>>Post(Class1 genre)
        {
            context.Add(genre);
            await context.SaveChangesAsync();
            return genre.ID;
        }
    }
}
