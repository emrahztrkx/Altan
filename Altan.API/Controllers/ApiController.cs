using Microsoft.AspNetCore.Mvc;

namespace Altan.API.Controllers
{
   
    [ApiController]
    [Route("[controller]/[action]")]
    public class ApiController : ControllerBase
    {
        // current user or something else

        [NonAction]
        public ResponseBase<T> Response<T>(T obj)
            where T : class, new()
        {
            var model = new ResponseBase<T>(obj);

            return model;
        }
        
        [NonAction]
        public ResponseBase Response()
        {
            return new ResponseBase();
        }
    }
}