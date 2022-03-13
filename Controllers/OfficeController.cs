﻿using ATC_BE.Data;
using ATC_BE.Helpers;
using ATC_BE.Models;
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
        [Route("get-offices")]
        public async Task<ActionResult<List<OfficeModel>>> Get()
        {


            return Ok(await apiDbContext.OfficeModels.ToListAsync());

        }

        [HttpGet]
        [Route("get-office-by-id{id}")]
        public async Task<ActionResult<OfficeModel>> GetOneOfficeByID(int id)
        {
            var office = await apiDbContext.OfficeModels.FindAsync(id);
            if (office == null)
            {
                return NotFound("Office not found");
            }

            return Ok(office);

        }
        [HttpGet]
        [Route("get-offices-by-building-id{id}")]
        public async Task<ActionResult<List<OfficeModel>>> GetOneOfficesByBuildingId(int id)
        {
            var offices = await apiDbContext.OfficeModels
                .Where(c=> c.Building_Id == id).ToListAsync();
            if (offices == null)
            {
                return NotFound("Office not found");
            }

            return Ok(offices);

        }

        [HttpPost]
        [Route("add-office")]
        public async Task<ActionResult<List<OfficeModel>>> AddOffice(AddOfficeDto request)
        {
            var building = await apiDbContext.BuildingModels
                .Where(c => c.Name == request.BuildingName).ToListAsync();
       
            if (building == null)
                return NotFound();

            var newOffice = new OfficeModel()
            {
                OfficeId = request.OfficeId,
                BuildingName = request.BuildingName,
                Building_Id = building[0].BuildingId,
                Floor = request.Floor,
                TotalDeskCount = request.TotalDeskCount,
                UsableDeskCount = request.UsableDeskCount,
                OfficeAdmin = request.OfficeAdmin,
                Width = request.Width,
                Length = request.Length,

            };

            apiDbContext.OfficeModels.Add(newOffice);
            await apiDbContext.SaveChangesAsync();

            return Ok(await apiDbContext.OfficeModels.ToListAsync());

        }
        [HttpPut]
        [Route("update-office")]
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

        [HttpDelete]
        [Route("delete-office-by-id{id}")]
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

