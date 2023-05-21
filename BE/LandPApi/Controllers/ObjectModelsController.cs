using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LandPApi.Data;
using LandPApi.Models;
using NuGet.Protocol;
using Newtonsoft.Json;

namespace LandPApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ObjectModelsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ObjectModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/ObjectModels
        [HttpGet]
        public async Task<IActionResult> GetObjectModels()
        {
          if (_context.ObjectModels == null)
          {
              return NotFound();
          }
          //var address = await _context.ObjectModels.SingleOrDefaultAsync();

            //return Ok((address.demo));
            return Ok(_context.ObjectModels.ToList());
        }

        // GET: api/ObjectModels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ObjectModel>> GetObjectModel(int id)
        {
          if (_context.ObjectModels == null)
          {
              return NotFound();
          }
            var objectModel = await _context.ObjectModels.FindAsync(id);

            if (objectModel == null)
            {
                return NotFound();
            }

            return objectModel;
        }

        // PUT: api/ObjectModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutObjectModel(int id, ObjectModel objectModel)
        {
            if (id != objectModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(objectModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ObjectModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ObjectModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ObjectModel>> PostObjectModel()
        {
          if (_context.ObjectModels == null)
          {
              return Problem("Entity set 'ApplicationDbContext.ObjectModels'  is null.");
          }
            _context.ObjectModels.Add(new ObjectModel
            {
                demo = new Address
                {
                    CustomerId = Guid.NewGuid().ToString(),
                    District = "hello"
                }.ToJson(),
            });
            await _context.SaveChangesAsync();
            return Ok();
            //return CreatedAtAction("GetObjectModel", new { id = objectModel.Id }, objectModel);
        }

        // DELETE: api/ObjectModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteObjectModel(int id)
        {
            if (_context.ObjectModels == null)
            {
                return NotFound();
            }
            var objectModel = await _context.ObjectModels.FindAsync(id);
            if (objectModel == null)
            {
                return NotFound();
            }

            _context.ObjectModels.Remove(objectModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ObjectModelExists(int id)
        {
            return (_context.ObjectModels?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
