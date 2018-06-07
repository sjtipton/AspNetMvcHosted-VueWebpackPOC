using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AspNetMvcHosted_VueWebpackPOC.Controllers
{
    public class TodosController : ApiController
    {
        // GET api/FakeTodos
        [Route("~/api/FakeTodos")]
        public IHttpActionResult GetFakeTodos()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data", "todos.json");

            var result = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new ByteArrayContent(File.ReadAllBytes(path))
            };

            return ResponseMessage(result);
        }
    }
}