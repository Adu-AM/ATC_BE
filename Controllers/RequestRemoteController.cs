#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ATC_BE.Data;
using ATC_BE.Models;
using ATC_BE.Data.Enums;

namespace ATC_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestRemoteController : ControllerBase
    {
        private readonly ApiDbContext _dbContext;

        public RequestRemoteController(ApiDbContext context)
        {
            _dbContext = context;
        }

        #region GET
        [HttpGet]
        [Route("get-requests-pending")]
        public async Task<ActionResult<IEnumerable<RequestRemoteModel>>> GetPendingRequests()
        {
            var requests = await _dbContext.RequestRemoteModels.Where(x => x.Status == RequestStatus.Pending).ToListAsync();
            if (requests.Count == 0)
                return NotFound("There are no pending requests");
            return requests;
        }

        [HttpGet]
        [Route("get-requests-all")]
        public async Task<ActionResult<IEnumerable<RequestRemoteModel>>> GetRequests()
        {
            var requests = await _dbContext.RequestRemoteModels.ToListAsync();
            if (requests.Count == 0)
                return NotFound("There are no pending requests");
            return requests;
        }

        [HttpGet]
        [Route("get-request-pending/{email}")]
        public async Task<ActionResult<RequestRemoteModel>> GetRequest(string email)
        {
            var request = await _dbContext.RequestRemoteModels.FirstOrDefaultAsync(x => x.UserEmail == email && x.Status == RequestStatus.Pending);
            if (request == null)
                return NotFound("A pending request doesn't exist");
            return request;
        }

        [HttpGet]
        [Route("get-request-all/{email}")]
        public async Task<ActionResult<IEnumerable<RequestRemoteModel>>> GetRequestsUser(string email)
        {
            var requests = await _dbContext.RequestRemoteModels.Where(x => x.UserEmail == email).ToListAsync();
            if (requests.Count == 0)
                return NotFound("There are no requests");
            return requests;
        }
        #endregion

        #region PUT
        [HttpPut]
        [Route("approve-request/{id}")]
        public async Task<IActionResult> ApproveRequest(int id)
        {
            var request = await _dbContext.RequestRemoteModels.FindAsync(id);
            if (request == null)
                return BadRequest("Request id doesn't exist");
            if (request.Status == RequestStatus.Approved)
                return BadRequest("Request is already approved");

            var user = await _dbContext.UserDetails.FindAsync(request.UserEmail);
            if (user == null)
                return BadRequest("User not found");

            // Updating the request
            request.Status = RequestStatus.Approved;

            user.RemotePercentage = request.RemotePercentage;

            _dbContext.UserDetails.Update(user);
            _dbContext.RequestRemoteModels.Update(request);
            await _dbContext.SaveChangesAsync();

            return Ok("The request has been approved");
        }

        [HttpPut]
        [Route("reject-request/{id}")]
        public async Task<IActionResult> RejectRequest(int id, string reason)
        {
            var request = await _dbContext.RequestRemoteModels.FindAsync(id);
            if (request == null)
                return BadRequest("Request id doesn't exist");
            if (request.Status == RequestStatus.Rejected)
                return BadRequest("Request is already rejected");

            // Updating the request
            request.Status = RequestStatus.Rejected;
            request.Reason = reason;

            _dbContext.RequestRemoteModels.Update(request);
            await _dbContext.SaveChangesAsync();

            return Ok("The request has been rejected");
        }
        #endregion 

        // POST: api/RequestRemote
        [HttpPost]
        [Route("add-request")]
        public async Task<ActionResult<RequestRemoteModel>> PostRequestRemoteModel(RequestRemoteModel request)
        {
            var user = await _dbContext.UserDetails.FindAsync(request.UserEmail);
            if (user == null)
                return BadRequest("User not found");
            if (user.RemotePercentage == 100)
                return BadRequest("User already working remote");

            var userRequests = await _dbContext.RequestRemoteModels.FirstOrDefaultAsync(x => x.Status == RequestStatus.Pending && x.UserEmail == request.UserEmail);
            if (userRequests != null)
                return BadRequest("Deja e una in pending");

            _dbContext.RequestRemoteModels.Add(request);
            await _dbContext.SaveChangesAsync();

            return Ok("Request has been created");
        }

    }
}
