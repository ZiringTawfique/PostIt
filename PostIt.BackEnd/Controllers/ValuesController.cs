﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace PostIt.BackEnd.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        IUseCases _useCases; 

        public ValuesController(IUseCases useCases)
        {
            _useCases = useCases;

        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Post AdPost)
        {
            _useCases.SetPost(AdPost);

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
