using System.Collections.Generic;
using System.Threading.Tasks;
using angular_dotnet_core.Controllers.Resources;
using angular_dotnet_core.Infrastructure;
using angular_dotnet_core.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace angular_dotnet_core.Controllers
{
    public class MakeController : Controller
    {
        private readonly ProjectDbContext context;
        private readonly IMapper mapper;
        public MakeController(ProjectDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet("api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes = await context.Makes.Include(m => m.Models).ToListAsync();
            return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}