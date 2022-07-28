using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_api.Data.Services;
using my_api.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private AuthorService _authorService;

        public AuthorController(AuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpPost("add-author")]
        public IActionResult CreateAuthor([FromBody]AuthorVM authorVM)
        {     
            _authorService.Add(authorVM);
            return Ok();
        }

        [HttpGet("get-AuthorById/{id}")]
        public IActionResult GetAuthorById(int id)
        {
            var author = _authorService.GetAuthorWithBook(id);
            return Ok(author);
        }
    }
}
