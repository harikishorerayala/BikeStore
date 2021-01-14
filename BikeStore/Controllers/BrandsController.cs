using DataModel.Interfaces;
using DataTransfers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BikeStore.Controllers
{
    [Authorize]
    public class BrandsController : ApiController
    {
        private IBrandModel _model;

        public BrandsController(IBrandModel model)
        {
            this._model = model;
        }

        
        [HttpGet]
        [Route("api/brands/getallbrands")]
        public IHttpActionResult GetAllBrands()
        {
            return Ok(_model.GetAllBrands());
        }

        [HttpGet]
        [Route("api/brands/getbrand/{id}")]
        public IHttpActionResult GetBrandInfo(int id) {
            return Ok(_model.GetBrandInfo(id));
        }

        [HttpPost]
        [Route("api/brands/addbrand")]
        public IHttpActionResult AddBrand(Brands brand)
        {
            return Ok(_model.AddBrand(brand));
        }

        [HttpPut]
        [Route("api/brands/updatebrand")]
        public IHttpActionResult EditBrand(Brands brand)
        {
            return Ok(_model.UpdateBrand(brand));
        }

        [HttpDelete]
        [Route("api/brands/deletebrand/{id}")]
        public IHttpActionResult DeleteBrand(int id)
        {
            return Ok(_model.DeleteBrand(id));
        }


    }
}