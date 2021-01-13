using DataModel;
using DataModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BikeStore.Controllers
{
    public class ValuesController : ApiController
    {
        private IBrandModel _model;

        public ValuesController(IBrandModel model)
        {
            this._model = model;
        }
        // GET api/values

        [Route("api/values")]
        public IHttpActionResult Get()
        {
            
            return Ok(_model.GetAllBrands());
        }


    }
}
