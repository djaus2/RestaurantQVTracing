using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using Newtonsoft.Json;

namespace BlazorRestaurantQRCode.Data
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableTracesController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public TableTracesController(ApplicationDBContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var athletes =  await _context.TableTraces.ToListAsync();
            return Ok(athletes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var dev = await _context.TableTraces.FirstOrDefaultAsync(a => a.Id == id);
            return Ok(dev);
        }

        [HttpPost]
        public async Task<IActionResult> Post(TableTrace tableTrace)
        {
            _context.Add(tableTrace);
            await _context.SaveChangesAsync();
            return Ok(tableTrace.Id);
        }


        //[HttpPost]
        //public async Task<IActionResult> Post(Object trace)
        //{
        //    var json = trace.ToString();
        //    TableTrace tableTrace = JsonConvert.DeserializeObject<TableTrace>(json);
        //    _context.Add(tableTrace);
        //    await _context.SaveChangesAsync();
        //    return Ok(tableTrace.Id);
        //}
        [HttpPut]
        public async Task<IActionResult> Put(TableTrace tableTrace)
        {
            _context.Entry(tableTrace).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var dev = new TableTrace { Id = id };
            _context.Remove(dev);
            await _context.SaveChangesAsync();
            return NoContent();
        }


    }
}
