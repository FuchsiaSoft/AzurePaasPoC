﻿using System;
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
    public class VisitsController : ApiController
    {
        private VisitModelContainer db = new VisitModelContainer();

        // GET: api/Visits
        public IQueryable<Visit> GetVisits()
        {
            return db.Visits;
        }

        // GET: api/Visits/5
        [ResponseType(typeof(Visit))]
        public async Task<IHttpActionResult> GetVisit(int id)
        {
            Visit visit = await db.Visits.FindAsync(id);
            if (visit == null)
            {
                return NotFound();
            }

            return Ok(visit);
        }

        // PUT: api/Visits/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutVisit(int id, Visit visit)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != visit.Id)
            {
                return BadRequest();
            }

            db.Entry(visit).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VisitExists(id))
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

        // POST: api/Visits
        [ResponseType(typeof(Visit))]
        public async Task<IHttpActionResult> PostVisit(Visit visit)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Visits.Add(visit);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = visit.Id }, visit);
        }

        // DELETE: api/Visits/5
        [ResponseType(typeof(Visit))]
        public async Task<IHttpActionResult> DeleteVisit(int id)
        {
            Visit visit = await db.Visits.FindAsync(id);
            if (visit == null)
            {
                return NotFound();
            }

            db.Visits.Remove(visit);
            await db.SaveChangesAsync();

            return Ok(visit);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VisitExists(int id)
        {
            return db.Visits.Count(e => e.Id == id) > 0;
        }
    }
}