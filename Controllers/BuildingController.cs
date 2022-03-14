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


        /// <summary>
        /// The administrator can visualize the list with all buildings
        /// </summary>
        /// <returns>List of all Buildings</returns>
        [HttpGet]
        public async Task<ActionResult<List<BuildingModel>>> Get()
        {
           
            return Ok(await apiDbContext.BuildingModels.ToListAsync());
        }


        /// <summary>
        /// Search for a building by name
        /// </summary>
        /// <param name="name">String with the building's name</param>
        /// <returns>The specified building</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<BuildingModel>> GetOneBuildingByName(string name)
        {
            var building =await apiDbContext.BuildingModels.FindAsync(name);
            if(building == null)
            {
                return NotFound("Building not found");
            }
           
            return Ok(building);

        }

        /// <summary>
        /// The administrator can add another building to the list
        /// </summary>
        /// <param name="building">BuildingModel object</param>
        /// <returns>List with all old and new buildings</returns>
        [HttpPost]
        public async Task<ActionResult<List<BuildingModel>>> AddBuilding(BuildingModel building)
        {
            apiDbContext.BuildingModels.Add(building);
            await apiDbContext.SaveChangesAsync();
            return Ok(await apiDbContext.BuildingModels.ToListAsync());

        }

        /// <summary>
        /// Update building proprieties
        /// </summary>
        /// <param name="request">A buildingModel object</param>
        /// <returns>List with all buildings including the updated one</returns>
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

        /// <summary>
        /// The administrator can delete a building if it's offices are free
        /// TODO: Add check if offices are free.
        /// </summary>
        /// <param name="buildingname">String containing the building name</param>
        /// <returns>List with the remaining buildings</returns>
        [HttpDelete("{name}")]
        public async Task<ActionResult<List<BuildingModel>>> DeleteOneBuildingByID(string buildingname)
        {
            var dbBuilding = await apiDbContext.BuildingModels.FindAsync(buildingname);
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
