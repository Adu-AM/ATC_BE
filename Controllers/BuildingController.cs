using ATC_BE.Models;
using ATC_BE.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ATC_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingController : ControllerBase
    {
        private readonly ApiDbContext apiDbContext;

        public BuildingController(ApiDbContext apiDbContext)
        {
            this.apiDbContext = apiDbContext;
        }
        [HttpGet]
        public async Task<ActionResult<List<BuildingModel>>> Get()
        {
           

            return Ok(await apiDbContext.BuildingModels.ToListAsync());

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BuildingModel>> GetOneBuildingByID(int id)
        {
            var building =await apiDbContext.BuildingModels.FindAsync(id);
            if(building == null)
            {
                return NotFound("Building not found");
            }
           
            return Ok(building);

        }

        [HttpPost]
        public async Task<ActionResult<List<BuildingModel>>> AddBuilding(BuildingModel building)
        {
            apiDbContext.BuildingModels.Add(building);
            await apiDbContext.SaveChangesAsync();
            return Ok(await apiDbContext.BuildingModels.ToListAsync());

        }
        [HttpPut]
        public async Task<ActionResult<List<BuildingModel>>> UpdateBuilding(BuildingModel request)
        {
            var dbBuilding = await apiDbContext.BuildingModels.FindAsync(request.BuildingId);
            if (dbBuilding == null)
            {
                return NotFound("Building not found");
            }

            dbBuilding.Name = request.Name;
            dbBuilding.FloorCount = request.FloorCount;
            dbBuilding.BuildingAddress = request.BuildingAddress;

            await apiDbContext.SaveChangesAsync();

            return Ok(await apiDbContext.BuildingModels.ToListAsync());

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<BuildingModel>>> DeleteOneBuildingByID(int id)
        {
            var dbBuilding = await apiDbContext.BuildingModels.FindAsync(id);
            if (dbBuilding == null)
            {
                return NotFound("Building not found");
            }
            apiDbContext.BuildingModels.Remove(dbBuilding);
            await apiDbContext.SaveChangesAsync();

            return Ok(await apiDbContext.BuildingModels.ToListAsync());

        }

    }
}
