using AutoMapper;
using library.Controllers;
using library.Core.Models;
using library.Models;
using Library.Core.DTO;
using Library.Core.Services;
using Library.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userServices;
        private readonly IMapper _mapper;
        public UserController(IUserServices userServices,IMapper mapper)
        {
            _userServices = userServices;
            _mapper = mapper;
        }
        // GET: api/<UserController>
        [HttpGet]
        public async Task< ActionResult> Get()
        {
            var students =await _userServices.GetUsersAsync();
            return Ok(_mapper.Map<List<UserDTO>>(students));
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public async Task< ActionResult> Get(int id)
        {
            var e =await _userServices.GetUserByIdAsync(id);
            if (e != null)
            {
                return Ok(e);
            }
            return NotFound();
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task< ActionResult> Post([FromBody] UserPostModel value)
        {
            var e = _userServices.GetUserByIdAsync(value.password);
            if (e != null)
            {
                var student = _mapper.Map<User>(value);
                var s =await _userServices.PostUserAsync(student);
                return Ok(s);
               
            }
          

           return Conflict();


        }


        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] User value)
        {
            var u =await _userServices.GetUserByIdAsync(id);
            if (u != null)
            {
                return BadRequest();
            }
            await _userServices.PutUserAsync(u);
            return Ok();    

           
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task< ActionResult> Delete(int id)
        {
            var p = _userServices.GetUserByIdAsync(id);
            if (p == null)
            {
                return BadRequest();
            }
          await  _userServices.DeleteUserAsync(id);
            return Ok(p);
        }
    }
}




