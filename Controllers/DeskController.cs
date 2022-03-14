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
            var desks = await apiDbContext.DeskModels.ToListAsync();

            if(desks.Count == 0)
                return NotFound();  

            return Ok(desks);

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
        [Route("get-desk-by-user-email{email}")]
        public async Task<ActionResult<List<DeskModel>>> GetOneDesksByUserEmail(string email)
        {
           var desk = await apiDbContext.DeskModels
                .Where(x=> x.UserEmail == email).ToListAsync();

            if (desk.Count == 0)
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
            var office = await apiDbContext.OfficeModels.FindAsync(request.OfficeId);

            if (office == null)
            {
                return NotFound("Office not found");
            }

            var newDesk = new DeskModel()
            {
                Vacancy = request.Vacancy,  
                Width = request.Width, 
                Length = request.Length,
                UserEmail = request.UserEmail,
                OfficeId = office.OfficeId,
            };

            if (newDesk.Vacancy == Data.Enums.DeskStatus.Occupied)
            {
                if (newDesk.UserEmail == null)
                    return BadRequest("Email not given");
            }
            else
            {
                if (newDesk.UserEmail != null)
                    return BadRequest("why u giv email");
            }

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

            dbDesk.Width = request.Width;
            dbDesk.Length = request.Length;
            dbDesk.UserEmail = request.UserEmail;
            dbDesk.OfficeId = request.OfficeId;
            dbDesk.Vacancy = request.Vacancy;

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

