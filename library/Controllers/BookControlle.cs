using AutoMapper;
using library.Core.Models;
using library.Models;
using Library.Core.DTO;
using Library.Core.Services;
using Library.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookControlle : ControllerBase
    {
        private readonly IBookServices _bookService;
        private readonly IMapper _mapper;
        public BookControlle(IBookServices context,IMapper mapper)
        {
            _bookService = context;
            _mapper = mapper;

        }
        // GET: api/<BookControlle>
        [HttpGet]
        public async Task< ActionResult> Get()
        {
            var books=await _bookService.GetBooksAsync();
            return Ok(_mapper.Map<List<BookDTO>>(books));
        }

        // GET api/<BookControlle>/5
        [HttpGet("{id}")]
        public async Task< ActionResult> Get(int id)
        {
            var e =await _bookService.GetBookByIdAsync( id);
            if (e != null)
            {
                var book= _mapper.Map< BookDTO >(e);
                return Ok(book);
            }
            return NotFound();
        }

        // POST api/<BookControlle>
        [HttpPost]
        public async Task< ActionResult> Post([FromBody] BookPostModel value)
        {
            var book1 = _bookService.GetBookByIdAsync(value.Id);
            if (book1 == null)
            {
                var book = _mapper.Map<Book>(value);
                var e =await _bookService.PostBookAsync(book);
                return Ok(e);

            }
            return Conflict();  
        }

        // PUT api/<BookControlle>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Book value)
        {
            var index=await _bookService.GetBookByIdAsync(value.Id);
            if (index == null)
            {
                return BadRequest();

            }
            await _bookService.PutBookAsync( value);
            return Ok();    

        }

        // DELETE api/<BookControlle>/5
        [HttpDelete("{id}")]
        public async Task< ActionResult >Delete(int id)
        {
            var e =await _bookService.GetBookByIdAsync(id);
            if (e == null)
            {
                return BadRequest();
            }
           await _bookService.DeleteBookAsync(id);
            return Ok(e);
        }
    }
}
