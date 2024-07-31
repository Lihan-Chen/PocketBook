using Microsoft.AspNetCore.Mvc;
using PocketBook.Core.IConfiguration;
using PocketBook.Models;

namespace PocketBook.Controllers
{
        [ApiController]
        [Route("[controller]")]
        public class AllEventController : ControllerBase
        {
            private readonly ILogger<UserController> _logger;

            private readonly IUnitOfWork _unitOfWork;

            public AllEventController(
                ILogger<UserController> logger,
                IUnitOfWork unitOfWork
            )
            {
                _logger = logger;
                _unitOfWork = unitOfWork;
            }


            [HttpGet]
            public async Task<IActionResult> Get()
            {
                var AllEvents = await _unitOfWork.AllEvents.GetAllAsync();
                return Ok(AllEvents);
            }

            [HttpGet("{id}")]
            public async Task<IActionResult> GetItem(int facilNo, int logTypeNo, string eventID, int eventID_RevNo)
            {
                var item = await _unitOfWork.AllEvents.GetByIdAsync(facilNo, logTypeNo, eventID, eventID_RevNo);

                if (item == null)
                    return NotFound();

                return Ok(item);
            }
            [HttpPost]
            public async Task<IActionResult> CreateAllEvent(AllEvent AllEvent)
            {
                if (ModelState.IsValid)
                {
                    // AllEvent.Id = Random.Shared.Next(1, 200);

                    await _unitOfWork.AllEvents.AddAsync(AllEvent);
                    await _unitOfWork.CompleteAsync();

                    return CreatedAtAction("Getitem", new { AllEvent.FacilNo, AllEvent.LogTypeNo, AllEvent.EventID, AllEvent.EventID_RevNo }, AllEvent);
                }

                //return BadRequest();
                return new JsonResult("Something went wrong") { StatusCode = 500 };
            }

            //[HttpPut("{id}")]
            //public async Task<IActionResult> UpdateItem(Guid id, AllEvent allEvent)
            //{
            //    if (id != user.Id)
            //        return BadRequest();

            //    await _unitOfWork.AllEvents.UpsertAsync(allEvent);
            //    await _unitOfWork.CompleteAsync();

            //    // Following up the REST standart on update we need to return NoContent
            //    return NoContent();
            //}

            //[HttpDelete("{id}")]
            //public async Task<IActionResult> DeleteItem(Guid id)
            //{
            //    var item = await _unitOfWork.Users.GetByIdAsync(id);

            //    if (item == null)
            //        return BadRequest();

            //    await _unitOfWork.Users.DeleteAsync(id);
            //    await _unitOfWork.CompleteAsync();

            //    return Ok(item);
            //}
        }
}

