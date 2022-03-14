using ATC_BE.Models;
using ATC_BE.Data;
using ATC_BE.Dtos;
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
        [Route("get-buildings")]
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
        
        [HttpGet]
        [Route("get-building-by-name{name}")]
        public async Task<ActionResult<BuildingModel>> GetOneBuildingByName(string name)
        {
            var building =await apiDbContext.BuildingModels
                .Where( x => x.Name == name).ToListAsync();
            if(building.Count == 0)
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
        [Route("add-buildings")]
        public async Task<ActionResult<List<BuildingModel>>> AddBuilding(BuildingDto building)
        {
            var newBuilding = new BuildingModel()
            {
                Name = building.Name,
                FloorCount = building.FloorCount,
                BuildingAddress = building.BuildingAddress,
            };
            apiDbContext.BuildingModels.Add(newBuilding);
            await apiDbContext.SaveChangesAsync();
            return Ok(await apiDbContext.BuildingModels.ToListAsync());

        }

        /// <summary>
        /// Update building proprieties
        /// </summary>
        /// <param name="request">A buildingModel object</param>
        /// <returns>List with all buildings including the updated one</returns>
        [HttpPut]
        [Route("update-buildings")]
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
        /// <returns>List with the remaining buildings</returns
        [HttpDelete]
        [Route("delete-building{name}")]
        public async Task<ActionResult<List<BuildingModel>>> DeleteOneBuildingByID(string name)
        {
            try
            {
                var dbBuilding = await apiDbContext.BuildingModels.Where(x => x.Name == name).ToListAsync();
                if (dbBuilding == null)
                {
                    return NotFound("Building not found");
                }
                apiDbContext.BuildingModels.Remove(dbBuilding.ElementAt(0));

                await apiDbContext.SaveChangesAsync();

                return Ok(await apiDbContext.BuildingModels.ToListAsync());
            }
            catch (Exception)
            {

                return NotFound("Building not found");
            }
           

            
           

        }

    }
}
