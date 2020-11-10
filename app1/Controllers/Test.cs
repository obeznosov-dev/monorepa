using Microsoft.AspNetCore.Mvc;

namespace TestApp.Controllers
{
    public class TestResponse
    {
        public string Result { set; get; }
    }
    
    public class Test : Controller
    {
        [HttpGet("api/test")]
        public IActionResult Index()
        {
            return Json(new TestResponse
            {
                Result = "OK"
            });
        }
    }
}