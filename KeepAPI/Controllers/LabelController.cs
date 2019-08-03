using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KeepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LabelController : ControllerBase
    {
        private readonly ILabelService labelService;
        public LabelController(ILabelService service)
        {
            labelService = service;
        }
        // GET: api/Label
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(labelService.GetLabels());
        }

        // GET: api/Label/5
        [HttpGet("{id}")]
        public IActionResult GetLabelById(int id)
        {
            try
            {
                return Ok(labelService.GetLabelById(id));
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        // POST: api/Label
        [HttpPost]
        public IActionResult Post([FromBody] Label label)
        {
            try
            {
                return Ok(labelService.AddLabel(label));
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }

        }

        // PUT: api/Label/5
        [HttpPut]
        public IActionResult Put([FromBody] Label label)
        {
            try
            {
                return Ok(labelService.UpdateLabel(label));
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                return Ok(labelService.DeleteLabel(id));
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}
