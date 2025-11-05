using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookControlle : ControllerBase
    {
        private readonly IDataContext _Context;
        public BookControlle(IDataContext context)
        {
            _Context = context;
        }
        // GET: api/<BookControlle>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _Context.Books;
        }

        // GET api/<BookControlle>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var e = _Context.Books.Find(x => x.id == id);
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
            var e = _Context.Books.Find(x => x.id == value.id);
            if (e != null)
            {
                return Conflict(); // BadRequest
            }
            _Context.Books.Add(value);
            return Ok(value);
        }

        // PUT api/<BookControlle>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Book value)
        {
            var index=_Context.Books.FindIndex(x => x.id==id);
            _Context.Books[index].nameBook = value.nameBook;
        }

        // DELETE api/<BookControlle>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var e = _Context.Books.Find(x => x.id == id);
            _Context.Books.Remove(e);
        }
    }
}
