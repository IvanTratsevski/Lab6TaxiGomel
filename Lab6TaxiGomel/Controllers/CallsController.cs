using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Lab6TaxiGomel.Data;
using Lab6TaxiGomel.Models;

namespace Lab6TaxiGomel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CallsController : ControllerBase
    {
        private readonly TaxiGomelContext _context;

        public CallsController(TaxiGomelContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Call> Get()
        {
            var data = _context.Calls
                                .Include(e => e.Car)
                                .Include(e => e.Dispatcher)
                                .Include(e => e.Rate)
                .ToList();
            return data;
        }

        [HttpGet("{callId}")]
        public IActionResult Get(int callId)
        {
            Call call = _context.Calls.FirstOrDefault(e => e.CallId == callId);
            if (call == null)
                return NotFound();

            return new ObjectResult(call);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Call call)
        {
            if (call == null)
            {
                return BadRequest();
            }

            _context.Calls.Add(call);
            _context.SaveChanges();
            return Ok(call);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Call call)
        {
            if (call == null)
            {
                return BadRequest();
            }

            if (!_context.Calls.Any(e => e.CallId == call.CallId))
            {
                return NotFound();
            }

            _context.Update(call);
            _context.SaveChanges();
            return Ok(call);
        }

        [HttpDelete("{callId}")]
        public IActionResult Delete(int callId)
        {
            Call call = _context.Calls.FirstOrDefault(e => e.CallId == callId);
            if (call == null)
            {
                return NotFound();
            }

            _context.Calls.Remove(call);
            _context.SaveChanges();
            return Ok(call);
        }
    }
}
