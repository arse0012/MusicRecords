using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MusicRecords.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordsController : ControllerBase
    {
        private List<record> recordList = new List<record>()
        {
            new record("hello", "Steven Wilson", 95, "1997"),
            new record("abc", "Jackson  Five", 234, "1988")
        };

        


        // GET: api/Records

        [HttpGet]
        public IEnumerable<record> Get()
        {
            return recordList;
        }

        // GET: api/Records/5
        [HttpGet("{id}", Name = "Get")]
        public record Get(int id)
        {
            return recordList.Find(i => i.Id == id);
        }

        // POST: api/Records
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Records/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
