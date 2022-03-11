using ATC_BE.Data;
using ATC_BE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ATC_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficeController : ControllerBase
    {
        private readonly ApiDbContext apiDbContext;

        public OfficeController(ApiDbContext apiDbContext)
        {
            this.apiDbContext = apiDbContext;
        }
        [HttpGet]
        public async Task<ActionResult<List<OfficeModel>>> Get()
        {


            return Ok(await apiDbContext.OfficeModels.ToListAsync());

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OfficeModel>> GetOneOfficeByID(int id)
        {
            var office = await apiDbContext.OfficeModels.FindAsync(id);
            if (office == null)
            {
                return NotFound("Office not found");
            }

            return Ok(office);

        }

        [HttpPost]
        public async Task<ActionResult<List<OfficeModel>>> AddOffice(OfficeModel Office)
        {
            apiDbContext.OfficeModels.Add(Office);
            await apiDbContext.SaveChangesAsync();
            return Ok(await apiDbContext.OfficeModels.ToListAsync());

        }
        [HttpPut]
        public async Task<ActionResult<List<OfficeModel>>> UpdateOffice(OfficeModel request)
        {
            var dbOffice = await apiDbContext.OfficeModels.FindAsync(request.OfficeId);
            if (dbOffice == null)
            {
                return NotFound("Office not found");
            }

            dbOffice.OfficeId = request.OfficeId;
            dbOffice.BuildingName = request.BuildingName;
            dbOffice.TotalDeskCount = request.TotalDeskCount;
            dbOffice.UsableDeskCount = request.UsableDeskCount;
            dbOffice.OfficeAdmin = request.OfficeAdmin;
            dbOffice.Width = request.Width;
            dbOffice.Length = request.Length;

            await apiDbContext.SaveChangesAsync();

            return Ok(await apiDbContext.OfficeModels.ToListAsync());

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<OfficeModel>>> DeleteOneOfficeByID(int id)
        {
            var dbOffice = await apiDbContext.OfficeModels.FindAsync(id);
            if (dbOffice == null)
            {
                return NotFound("Office not found");
            }
            apiDbContext.OfficeModels.Remove(dbOffice);
            await apiDbContext.SaveChangesAsync();

            return Ok(await apiDbContext.OfficeModels.ToListAsync());

        }

    }
}

