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
    public class ServiceUsersController : ApiController
    {
        private VisitModelContainer db = new VisitModelContainer();

        // GET: api/ServiceUsers
        public IQueryable<ServiceUser> GetServiceUsers()
        {
            return db.ServiceUsers;
        }

        // GET: api/ServiceUsers/5
        [ResponseType(typeof(ServiceUser))]
        public async Task<IHttpActionResult> GetServiceUser(int id)
        {
            ServiceUser serviceUser = await db.ServiceUsers.FindAsync(id);
            if (serviceUser == null)
            {
                return NotFound();
            }

            return Ok(serviceUser);
        }

        // PUT: api/ServiceUsers/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutServiceUser(int id, ServiceUser serviceUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != serviceUser.Id)
            {
                return BadRequest();
            }

            db.Entry(serviceUser).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ServiceUserExists(id))
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

        // POST: api/ServiceUsers
        [ResponseType(typeof(ServiceUser))]
        public async Task<IHttpActionResult> PostServiceUser(ServiceUser serviceUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ServiceUsers.Add(serviceUser);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = serviceUser.Id }, serviceUser);
        }

        // DELETE: api/ServiceUsers/5
        [ResponseType(typeof(ServiceUser))]
        public async Task<IHttpActionResult> DeleteServiceUser(int id)
        {
            ServiceUser serviceUser = await db.ServiceUsers.FindAsync(id);
            if (serviceUser == null)
            {
                return NotFound();
            }

            db.ServiceUsers.Remove(serviceUser);
            await db.SaveChangesAsync();

            return Ok(serviceUser);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ServiceUserExists(int id)
        {
            return db.ServiceUsers.Count(e => e.Id == id) > 0;
        }
    }
}