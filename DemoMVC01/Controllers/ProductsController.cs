using Microsoft.AspNetCore.Mvc;

namespace DemoMVC01.Controllers
{
    public class ProductsController : Controller
    {
        #region Actions
        //[HttpGet] //By default method GET
        //BaseUrl/Products/Test
        //public string Test()
        //{
        //    return $"Hello from test";
        //}

        // Response
        // [Status code , Content type [default text/palin] , Content ]
        //[HttpGet]
        //public IActionResult Test()
        //{
        //    ContentResult result = new ContentResult();
        //    //result.ContentType = "text/html";
        //    result.Content = $"Hello from test </br> Bye";
        //    result.StatusCode = StatusCodes.Status200OK;
        //    return result;

        //        //return Content(content: $"Hello from test </br> Bye", contentType: "text/html");

        //}

        //Master action
        //BaseUrl/Products
        //BaseUrl/Products/Index
        //[HttpGet]
        //public IActionResult Index()
        //{
        //    return View();
        //}

        //BaseUrl/Products/GetProducts
        //[HttpGet]
        //public IActionResult GetProducts()
        //{
        //    var products = new List<Product>()
        //    {
        //        new Product() {Id = 1 , Name = "Mobile"},
        //        new Product() {Id = 2 , Name = "Tablet"},
        //    };
        //    return Json(products);
        //}

        //[NonAction]
        //public IActionResult Test()
        //{
        //    return View();
        //}

        //BaseUrl/Products/GetProductById/10
        //public IActionResult GetProductById (int id)
        //{
        //    if (id < 0)
        //        return BadRequest();
        //    else if (id == 0)
        //        //return RedirectToAction("GetProducts");
        //        return RedirectToAction(nameof(GetProducts));
        //    else if (id < 10)
        //        return NotFound();
        //    else
        //        return Json(new Product() { Id = id, Name = "Laptop" });
        //}

        //BaseUrl/Products/RedirectAction
        //[HttpGet]
        //public IActionResult RedirectAction()
        //{
        //    return Redirect("https://docs.google.com/presentation/d/1TPKT3Esh3c8jtX1FJAifaLxjL2NlzjKM/edit?slide=id.p10#slide=id.p10");
        //}

        //BaseUrl/Products/FileAction
        //[HttpGet]
        //public IActionResult FileAction()
        //{
        //    byte[] fileBytes = System.IO.File.ReadAllBytes("wwwroot/files/PdfSample.pdf");
        //    return File(fileBytes, "application/pdf", "Group01.pdf");
        //}
        #endregion

        #region Routing
        //BaseUrl/Controller/Action/Segment
        //Segment --> Static segement  , variable segement , mixed segement
        //BaseUrl/Products/Test/Ten
        //BaseUrl/Products/Test/{Num} 
        //BaseUrl/Products/Test/X{Num}

        //Param --> segement , query param 
        //BaseUrl/Products/Test?num=10

        //BaseUrl/Products/TestRouting
        //[HttpGet("Products/Test01")]
        //public IActionResult TestRouting()
        //{
        //    return Json($"Hello from testrouting");
        //}

        //BaseUrl/Products/TestRouting/10
        //[HttpGet("TestingRoute/Test{id:int}")]
        //public IActionResult TestRouting(int id)
        //{
        //    return Json($"Hello with id : {id}");
        //}

        //BaseUrl/Products/TestRouting/10?name=Mariam
        //public IActionResult TestRouting (int id , string name)
        //{
        //    return Json($"Hello from TestRouting : id = {id} , name = {name}");
        //}

        //BaseUrl/json
        //[HttpGet("json")]
        //public IActionResult JsonAction()
        //{
        //    return Json("Hello from json action");
        //}

        ////BaseUrl/ProductCode/10
        //[HttpGet("ProductCode/{code:int}")]
        //public IActionResult GetProductByCode(int code)
        //{
        //    return Json(new Product() { Id = code, Name = "Mobile" });
        //}
        #endregion

        #region Model binding
        //Action --> Params [Simple data , Complex data [user defined data type] , collection]
        //[HttpGet]
        ////BaseUrl/Products/GetById
        //public IActionResult GetById([FromQuery]int id ,[FromQuery(Name = "id2")] int anotherId)
        //{
        //    return Json(new {id = id , anotherId = anotherId});
        //}

        //Complex data
        //BaseUrl/Products/Search
        //[HttpGet]
        //public IActionResult Search(ProductFilter filter)
        //{
        //    return Content("Search completed");
        //}

        //Collection
        //BaseUrl/Products/GetByIds
        //[HttpGet]
        //public IActionResult GetByIds(int[] ids)
        //{
        //    return Json(new
        //    {
        //        ids
        //    });
        //}
        #endregion
    }
}
