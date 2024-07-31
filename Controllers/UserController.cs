using Microsoft.AspNetCore.Mvc;
using PocketBook.Core.IConfiguration;
using PocketBook.Models;

namespace PocketBook.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        private readonly IUnitOfWork _unitOfWork;


        public UserController(
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
            var users = await _unitOfWork.Users.GetAllAsync();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetItem(int id)
        {
            var item = await _unitOfWork.Users.GetByIdAsync(id);

            if (item == null)
                return NotFound();

            return Ok(item);
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser(User user)
        {
            if (ModelState.IsValid)
            {
                //user.Id = Guid.NewGuid();
                user.Id = Random.Shared.Next(1, 999);
                await _unitOfWork.Users.AddAsync(user);
                await _unitOfWork.CompleteAsync();

                return CreatedAtAction("Getitem", new {user.Id}, user);
            }

            //return BadRequest();
            return new JsonResult("Something went wrong") { StatusCode = 500};
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateItem(int id, User user)
        {
            if (id != user.Id)
                return BadRequest();

            await _unitOfWork.Users.UpsertAsync(user);
            await _unitOfWork.CompleteAsync();

            // Following up the REST standart on update we need to return NoContent
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(int id)
        {
            var item = await _unitOfWork.Users.GetByIdAsync(id);

            if (item == null)
                return BadRequest();

            await _unitOfWork.Users.DeleteAsync(id);
            await _unitOfWork.CompleteAsync();

            return Ok(item);
        }
    }
}
