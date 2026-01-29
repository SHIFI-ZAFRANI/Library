using AutoMapper;
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
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryServices _categoryServices;
        private readonly IMapper _mapper;
        public CategoryController(ICategoryServices categoryServices,IMapper mapper)
        {
            _categoryServices = categoryServices;
            _mapper = mapper;
        }
        // GET: api/<CategoryController>
        [HttpGet]
        public async Task< ActionResult> Get()
        {
            var categorys =await _categoryServices.GetCategoryAsync();
            return Ok(_mapper.Map<List<CategoryDTO>>(categorys));
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public async Task< ActionResult> Get(int id)
        {
            var e =await _categoryServices.GetCategoryByIdAsync(id);
            if (e != null)
            {
                var stu = _mapper.Map<CategoryDTO>(e);
                return Ok(e);
            }
            return NotFound();
        }

        // POST api/<CategoryController>
        [HttpPost]
        public async Task< ActionResult> Post([FromBody] CategoryPostModel value)
        {
            var e=_categoryServices.GetCategoryByIdAsync(value.idCategory);
            if (e != null)
            {
                var category = _mapper.Map<Category>(value);
                var s =await _categoryServices.PostCategoryAsync(category);
                return Ok();
            }
         
            return Conflict();
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Category value)
        {
            var index=await _categoryServices.GetCategoryByIdAsync(id);
            if (index != null)
            {
                return BadRequest();
            }
           await _categoryServices.putCategoryAsync(index);
           return Ok();
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public async Task< ActionResult> Delete(int id)
        {
            var p =await _categoryServices.GetCategoryByIdAsync(id);
            if (p == null)
            {
                return BadRequest();
            }
          await  _categoryServices.deleteCategoryAsync(id);
            return Ok();
        }
    }
}
