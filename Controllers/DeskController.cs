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
        [HttpGet]
        [Route("get-desks")]
        public async Task<ActionResult<List<DeskModel>>> Get()
        {


            return Ok(await apiDbContext.DeskModels.ToListAsync());

        }

        [HttpGet]
        [Route("get-desk-by-id{id}")]
        public async Task<ActionResult<DeskModel>> GetOneDeskByID(int id)
        {
            var office = await apiDbContext.DeskModels.FindAsync(id);
            if (office == null)
            {
                return NotFound("Desk not found");
            }

            return Ok(office);

        }
     
        [HttpGet]
        [Route("get-desk-by-user-id{email}")]
        public async Task<ActionResult<List<DeskModel>>> GetOneDesksByUserEmail(string email)
        {
            var desk = await apiDbContext.DeskModels.FindAsync(email);

            if (desk == null)
            {
                return NotFound("Desk not found");
            }

            return Ok(desk);
        }
        
        [HttpPost]
        [Route("add-desk")]
        public async Task<ActionResult<List<DeskModel>>> AddDesk(AddDeskDto request)
        {

            var user = await apiDbContext.UserDetails
                .Where(c => c.Email == request.UserEmail).ToListAsync();

            if (user == null)
                return NotFound();

            var newDesk = new DeskModel()
            {
                Vacancy = request.Vacancy,  
                Width = request.Width, 
                Length = request.Length,
                UserEmail = request.UserEmail,
            };

            apiDbContext.DeskModels.Add(newDesk);
            await apiDbContext.SaveChangesAsync();

            return Ok(await apiDbContext.DeskModels.ToListAsync());

        }

        [HttpPut]
        [Route("update-desk")]
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
        [Route("delete-desk-by-id{id}")]
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
    }
}

