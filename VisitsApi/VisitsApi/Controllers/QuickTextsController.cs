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
    public class QuickTextsController : ApiController
    {
        private VisitModelContainer db = new VisitModelContainer();

        // GET: api/QuickTexts
        public IQueryable<QuickText> GetQuickTexts()
        {
            return db.QuickTexts;
        }

        // GET: api/QuickTexts/5
        [ResponseType(typeof(QuickText))]
        public async Task<IHttpActionResult> GetQuickText(int id)
        {
            QuickText quickText = await db.QuickTexts.FindAsync(id);
            if (quickText == null)
            {
                return NotFound();
            }

            return Ok(quickText);
        }

        // PUT: api/QuickTexts/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutQuickText(int id, QuickText quickText)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != quickText.Id)
            {
                return BadRequest();
            }

            db.Entry(quickText).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuickTextExists(id))
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

        // POST: api/QuickTexts
        [ResponseType(typeof(QuickText))]
        public async Task<IHttpActionResult> PostQuickText(QuickText quickText)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.QuickTexts.Add(quickText);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = quickText.Id }, quickText);
        }

        // DELETE: api/QuickTexts/5
        [ResponseType(typeof(QuickText))]
        public async Task<IHttpActionResult> DeleteQuickText(int id)
        {
            QuickText quickText = await db.QuickTexts.FindAsync(id);
            if (quickText == null)
            {
                return NotFound();
            }

            db.QuickTexts.Remove(quickText);
            await db.SaveChangesAsync();

            return Ok(quickText);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool QuickTextExists(int id)
        {
            return db.QuickTexts.Count(e => e.Id == id) > 0;
        }
    }
}