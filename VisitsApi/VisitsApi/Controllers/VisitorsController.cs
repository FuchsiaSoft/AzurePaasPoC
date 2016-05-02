using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using VisitsApi.Models;

namespace VisitsApi.Controllers
{
    public class VisitorsController : ApiController
    {
        private VisitModelContainer db = new VisitModelContainer();

        // GET: api/Visitors
        public IQueryable<Visitor> GetVisitors()
        {
            return db.Visitors;
        }

        // GET: api/Visitors/5
        [ResponseType(typeof(Visitor))]
        public async Task<IHttpActionResult> GetVisitor(int id)
        {
            Visitor visitor = await db.Visitors.FindAsync(id);
            if (visitor == null)
            {
                return NotFound();
            }

            return Ok(visitor);
        }

        // PUT: api/Visitors/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutVisitor(int id, Visitor visitor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != visitor.Id)
            {
                return BadRequest();
            }

            db.Entry(visitor).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VisitorExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Visitors
        [ResponseType(typeof(Visitor))]
        public async Task<IHttpActionResult> PostVisitor(Visitor visitor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Visitors.Add(visitor);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = visitor.Id }, visitor);
        }

        // DELETE: api/Visitors/5
        [ResponseType(typeof(Visitor))]
        public async Task<IHttpActionResult> DeleteVisitor(int id)
        {
            Visitor visitor = await db.Visitors.FindAsync(id);
            if (visitor == null)
            {
                return NotFound();
            }

            db.Visitors.Remove(visitor);
            await db.SaveChangesAsync();

            return Ok(visitor);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VisitorExists(int id)
        {
            return db.Visitors.Count(e => e.Id == id) > 0;
        }
    }
}