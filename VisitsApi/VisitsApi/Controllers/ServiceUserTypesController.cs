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
    public class ServiceUserTypesController : ApiController
    {
        private VisitModelContainer db = new VisitModelContainer();

        // GET: api/ServiceUserTypes
        public IQueryable<ServiceUserType> GetServiceUserTypes()
        {
            return db.ServiceUserTypes;
        }

        // GET: api/ServiceUserTypes/5
        [ResponseType(typeof(ServiceUserType))]
        public async Task<IHttpActionResult> GetServiceUserType(int id)
        {
            ServiceUserType serviceUserType = await db.ServiceUserTypes.FindAsync(id);
            if (serviceUserType == null)
            {
                return NotFound();
            }

            return Ok(serviceUserType);
        }

        // PUT: api/ServiceUserTypes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutServiceUserType(int id, ServiceUserType serviceUserType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != serviceUserType.Id)
            {
                return BadRequest();
            }

            db.Entry(serviceUserType).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ServiceUserTypeExists(id))
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

        // POST: api/ServiceUserTypes
        [ResponseType(typeof(ServiceUserType))]
        public async Task<IHttpActionResult> PostServiceUserType(ServiceUserType serviceUserType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ServiceUserTypes.Add(serviceUserType);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = serviceUserType.Id }, serviceUserType);
        }

        // DELETE: api/ServiceUserTypes/5
        [ResponseType(typeof(ServiceUserType))]
        public async Task<IHttpActionResult> DeleteServiceUserType(int id)
        {
            ServiceUserType serviceUserType = await db.ServiceUserTypes.FindAsync(id);
            if (serviceUserType == null)
            {
                return NotFound();
            }

            db.ServiceUserTypes.Remove(serviceUserType);
            await db.SaveChangesAsync();

            return Ok(serviceUserType);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ServiceUserTypeExists(int id)
        {
            return db.ServiceUserTypes.Count(e => e.Id == id) > 0;
        }
    }
}