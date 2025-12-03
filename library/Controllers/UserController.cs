using library.Core.Models;
using Library.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userServices;
        public UserController(IUserServices _userServices)
        {
            _userServices = _userServices;
        }
        // GET: api/<UserController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_userServices.GetUsers());
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var e = _userServices.GetUserById(id);
            if (e != null)
            {
                return Ok(e);
            }
            return NotFound();
        }

        // POST api/<UserController>
        [HttpPost]
        public ActionResult Post([FromBody] User value)
        {
            var e = _userServices.GetUserById(value.password);
            if (e != null)
            {
                return Conflict();
            }
            e = _userServices.PostUser(value);
           return Ok(e);


        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User value)
        {
            var index = _userServices.GetUsers().FindIndex(x=>x.password == id);
            _userServices.GetUsers()[index].password=value.password;
            _userServices.GetUsers()[index].email=value.email;
            _userServices.GetUsers()[index].phone=value.phone;
            _userServices.GetUsers()[index].name=value.name;
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var p = _userServices.GetUserById(id);
            if (p != null)
            {
                return Conflict();
            }
            _userServices.DeleteUser(id);
            return Ok(p);
        }
    }
}