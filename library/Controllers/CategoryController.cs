using library.Core.Models;
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
        public CategoryController(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }
        // GET: api/<CategoryController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_categoryServices.GetCategory());
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var e = _categoryServices.GetCategoryById(id);
            if (e != null)
            {
                return Ok(e);
            }
            return NotFound();
        }

        // POST api/<CategoryController>
        [HttpPost]
        public ActionResult Post([FromBody] Category value)
        {
            var e=_categoryServices.GetCategoryById(value.idCategory);
            if (e != null)
            {
                return Conflict();
            }
            e = _categoryServices.PostCategory(value);
            return Ok(e);
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Category value)
        {
            var index=_categoryServices.GetCategory().FindIndex(x=>x.idCategory==id);
            _categoryServices.GetCategory()[index].idCategory=value.idCategory;
            _categoryServices.GetCategory()[index].nameCategory=value.nameCategory;
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var p = _categoryServices.GetCategoryById(id);
            if (p != null)
            {
                return Conflict();
            }
            _categoryServices.deleteCategory(id);
            return Ok(p);
        }
    }
}
