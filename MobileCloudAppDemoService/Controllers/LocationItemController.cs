﻿using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using MobileCloudAppDemoService.DataObjects;
using MobileCloudAppDemoService.Models;

namespace MobileCloudAppDemoService.Controllers
{
    public class LocationItemController : TableController<LocationItem>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            MobileCloudAppDemoContext context = new MobileCloudAppDemoContext();
            DomainManager = new EntityDomainManager<LocationItem>(context, Request);
        }

        // GET tables/TodoItem
        public IQueryable<LocationItem> GetAllLocationItems()
        {
            return Query();
        }

        // GET tables/TodoItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<LocationItem> GetLocationItem(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/TodoItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<LocationItem> PatchLocationItem(string id, Delta<LocationItem> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/TodoItem
        public async Task<IHttpActionResult> PostLocationItem(LocationItem item)
        {
            LocationItem current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/TodoItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteLocationItem(string id)
        {
            return DeleteAsync(id);
        }
    }
}