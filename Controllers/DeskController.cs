using ATC_BE.Data;
using ATC_BE.Helpers;
using ATC_BE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ATC_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeskController : ControllerBase
    {
      
        private readonly ApiDbContext apiDbContext;

        public DeskController(ApiDbContext apiDbContext)
        {
            this.apiDbContext = apiDbContext;
        }
        /*[HttpGet]
        [Route("get-offices")]
        public async Task<ActionResult<List<DeskModel>>> Get()
        {


            return Ok(await apiDbContext.DeskModels.ToListAsync());

        }

        [HttpGet]
        [Route("get-office-by-id{id}")]
        public async Task<ActionResult<DeskModel>> GetOneDeskByID(int id)
        {
            var office = await apiDbContext.DeskModels.FindAsync(id);
            if (office == null)
            {
                return NotFound("Desk not found");
            }

            return Ok(office);

        }
        /*[HttpGet]
        [Route("get-offices-by-building-id{id}")]
        public async Task<ActionResult<List<DeskModel>>> GetOneDesksByBuildingId(int id)
        {
            var offices = await apiDbContext.DeskModels
                .Where(c => c.BuildingId == id).ToListAsync();
            if (offices == null)
            {
                return NotFound("Desk not found");
            }

            return Ok(offices);

        }

        [HttpPost]
        [Route("add-office")]
        public async Task<ActionResult<List<DeskModel>>> AddDesk(AddDeskDto request)
        {
            var building = await apiDbContext.BuildingModels
                .Where(c => c.Name == request.BuildingName).ToListAsync();

            if (building == null)
                return NotFound();

            var newDesk = new DeskModel()
            {
                DeskId = request.DeskId,
                BuildingName = request.BuildingName,
                BuildingId = building[0].BuildingId,
                Floor = request.Floor,
                TotalDeskCount = request.TotalDeskCount,
                UsableDeskCount = request.UsableDeskCount,
                DeskAdmin = request.DeskAdmin,
                Width = request.Width,
                Length = request.Length,

            };

            apiDbContext.DeskModels.Add(newDesk);
            await apiDbContext.SaveChangesAsync();

            return Ok(await apiDbContext.DeskModels.ToListAsync());

        }
        
        [HttpPut]
        [Route("update-office")]
        public async Task<ActionResult<List<DeskModel>>> UpdateDesk(DeskModel request)
        {
            var dbDesk = await apiDbContext.DeskModels.FindAsync(request.DeskId);
            if (dbDesk == null)
            {
                return NotFound("Desk not found");
            }

            dbDesk.DeskId = request.DeskId;
            dbDesk.Width = request.Width;
            dbDesk.Length = request.Length;

            await apiDbContext.SaveChangesAsync();

            return Ok(await apiDbContext.DeskModels.ToListAsync());

        }

        [HttpDelete]
        [Route("delete-office-by-id{id}")]
        public async Task<ActionResult<List<DeskModel>>> DeleteOneDeskByID(int id)
        {
            var dbDesk = await apiDbContext.DeskModels.FindAsync(id);
            if (dbDesk == null)
            {
                return NotFound("Desk not found");
            }
            apiDbContext.DeskModels.Remove(dbDesk);
            await apiDbContext.SaveChangesAsync();

            return Ok(await apiDbContext.DeskModels.ToListAsync());

        }
        */
    }
}

