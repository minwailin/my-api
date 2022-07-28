
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_api.Data.Models;
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
    public class PublisherController : ControllerBase
    {
        private readonly PublisherService _publisherService;

        public PublisherController(PublisherService publisherService)
        {
            _publisherService = publisherService;
        }

        [HttpPost("add-publisher")]
        public  IActionResult CreatePublisher([FromBody] PublisherVM publishervm)
        {
            _publisherService.AddPublisher(publishervm);
            return Ok();
        }

        [HttpGet("get-AuthorById/{id}")]
        public IActionResult GetPublisherById(int id)
        {
            var publisher = _publisherService.getPublisherById(id);
            return Ok(publisher);
        }

        [HttpDelete("delete-publisher/{id}")]
        public IActionResult DeletePublisher(int id)
        {
            _publisherService.DeletePublisher(id);
            return Ok();
        }
    }
}
