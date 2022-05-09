using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestBll;

namespace TestApi.Controllers
{
    public class DataController : ApiController
    {

        [Route("data")]
        [HttpGet]
        public IHttpActionResult GetAllData()
        {
            var issues = DataManager.GetIssues();
            if (issues == null)
            {
                return NotFound();
            }
            return Ok(issues);
        }


        [Route("data/search/{textSearch}")]
        [HttpGet]
        [AllowAnonymous]
        public IHttpActionResult GetIssueBySearch([FromUri] string textSearch)
        {
            var issue= DataManager.GetIssueBySearch(textSearch);
            if (issue == null)
            {
                return NotFound();
            }
            return Ok(issue);
        }

        //public IHttpActionResult GetProduct(int id)
        //{
        //    var issues = DataManager.FirstOrDefault((p) => p.Id == id);
        //    if (product == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(product);
        //}
    }
}
