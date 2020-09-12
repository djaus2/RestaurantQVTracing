using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using Newtonsoft.Json;

namespace TableTracewithQRCode.Data
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantsController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public RestaurantsController(ApplicationDBContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var list =  await _context.Restaurants.ToListAsync();
            return Ok(list);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var dev = await _context.Restaurants.FirstOrDefaultAsync(a => a.Id == id);
            return Ok(dev);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Restaurant Restaurant)
        {
            _context.Add(Restaurant);
            await _context.SaveChangesAsync();
            return Ok(Restaurant.Id);
        }


        //[HttpPost]
        //public async Task<IActionResult> Post(Object trace)
        //{
        //    var json = trace.ToString();
        //    Restaurant Restaurant = JsonConvert.DeserializeObject<Restaurant>(json);
        //    _context.Add(Restaurant);
        //    await _context.SaveChangesAsync();
        //    return Ok(Restaurant.Id);
        //}
        [HttpPut]
        public async Task<IActionResult> Put(Restaurant Restaurant)
        {
            _context.Entry(Restaurant).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var dev = new Restaurant { Id = id };
            _context.Remove(dev);
            await _context.SaveChangesAsync();
            return NoContent();
        }


    }
}
