using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MABrandProject.Models;
using MABrandProject.Data;


namespace MABrandProject.Controllers
{
    public class BrandController : ApiController
    {

        private BrandRepository _ourBrandRepository;

        public BrandController()
        {
            _ourBrandRepository = new BrandRepository();
        }

        // GET: api/Brand
        [Route("BrandData")]
        [HttpGet]
        public List<BrandData> Get()
        {
            return _ourBrandRepository.GetClassification();
        }

        //// GET: api/Brand/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Brand
        //[Route("Customers")]
        //[HttpPost]
        //public bool Post([FormData]BrandData ourBrand)
        //{
        //    //return true;
        //    return _ourBrandRepository.InsertCustomer(ourBrand);
        //}

        //// PUT: api/Brand/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Brand/5
        //public void Delete(int id)
        //{
        //}
    }
}
