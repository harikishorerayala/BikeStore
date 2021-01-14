using DataModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BikeStore.Controllers
{

    public class BrandsController : ApiController
    {
        private IBrandModel _model;

        public BrandsController(IBrandModel model)
        {
            this._model = model;
        }

        [Authorize]
        [HttpGet]
        [Route("api/brands/getallbrands")]
        public IHttpActionResult Get()
        {
            return Ok(_model.GetAllBrands());
        }

    }
}