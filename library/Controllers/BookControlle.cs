using library.Core.Models;
using Library.Core.Services;
using Library.Service;
using Microsoft.AspNetCore.Mvc;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookControlle : ControllerBase
    {
        private readonly IBookServices _bookService;
        public BookControlle(IBookServices context)
        {
            _bookService = context;
        }
        // GET: api/<BookControlle>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_bookService.GetBooks());
        }

        // GET api/<BookControlle>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var e = _bookService.GetBookById( id);
            if (e != null)
            {
                return Ok(e);
            }
            return NotFound();
        }

        // POST api/<BookControlle>
        [HttpPost]
        public ActionResult Post([FromBody] Book value)
        {
            var e = _bookService.GetBookById(value.Id);
            if (e != null)
            {
                return Conflict(); 
            }
            e=_bookService.PostBook(value);
            return Ok(e);
        }

        // PUT api/<BookControlle>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Book value)
        {
            var index=_bookService.GetBooks().FindIndex(x => x.Id==id);
            _bookService.GetBooks()[index].Id=value.Id;
            _bookService.GetBooks()[index].nameBook=value.nameBook;
        }

        // DELETE api/<BookControlle>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var e = _bookService.GetBookById(id);
            if (e != null)
            {
                return Conflict();
            }
            _bookService.DeleteBook(id);
            return Ok(e);
        }
    }
}
