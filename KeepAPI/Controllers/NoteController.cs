using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace KeepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoteController : ControllerBase
    {
        private readonly IKeepService keepService;
        public NoteController(IKeepService service)
        {
            keepService = service;
        }
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(keepService.GetNotes());
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(keepService.GetNoteById(id));
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Note note)
        {
            try
            {
                return Created("api/note", keepService.AddNote(note));
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        // PUT api/values/5
        [HttpPut]
        public IActionResult Put([FromBody] Note note)
        {
            try
            {
                return Ok(keepService.UpdateNote(note));
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                return Ok(keepService.DeleteNote(id));
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
