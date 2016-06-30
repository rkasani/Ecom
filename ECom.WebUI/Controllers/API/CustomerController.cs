namespace ECom.WebUI.Controllers.API
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using ECom.Abstraction.Repository;
    using ECom.Dto;
    using Newtonsoft.Json;
    


    public class CustomerController : ApiController
    {
        private EComUnitOfWork _uow = new EComUnitOfWork();
        // GET api/<controller>
        public IEnumerable<CustomerDTO> GetAll()

        {
            var custList = _uow.CustomerRepository.AllIncluding(x => x.Addresses);
            return custList.Select(p => new CustomerDTO
            {
                CustomerID = p.CustomerID,
                FirstName = p.FirstName,
                LastName = p.LastName,
                Address = p.Addresses.ToList()
            }).ToList();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            ECom.DataModel.EcomContext context = new DataModel.EcomContext();
            
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}