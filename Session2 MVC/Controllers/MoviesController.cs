using Microsoft.AspNetCore.Mvc;
using Session2_MVC.Model;

namespace Session2_MVC.Controllers
{
    public class MoviesController : Controller
    {

        //action public (non static function)
        //public string Test()
        //{
        //    return "default";
        //}
        //public string GetMovies(string id)
        //{

        //    return $"Id:{id}";
        //}

        [HttpGet]
        [ActionName("Hamada")]
        public IActionResult GetMovies(string id,string name,Movies movies)
        {
            //ContentResult result = new ContentResult();
            //result.Content =$"Id:{id}";
            //result.ContentType = "text/html";
            ////result.ContentType= "object/pdf";
            //return result;
            return Content($"Id:{id}", "object/pdf");
           
        }
        //Action parameter Binding
        //1-Form
        //2-segment
        //3-Querystring-Query Params
        //3-File
        //public RedirectToActionResult Test( string id)
        //{
        //    RedirectToActionResult result = new RedirectToActionResult("GetMovies", "Movies", new { id = id });
        //    return result;
        //}

        public ActionResult Test(int? id)
        {
            if (id is null) {
                //RedirectResult result = new RedirectResult("https://www.youtube.com/");
                //return result;
                return Redirect("https://www.youtube.com/");
            
            
            } else {
                //RedirectToActionResult result = new RedirectToActionResult("GetMovies", "Movies", new { id = id });
                //return result;
                return RedirectToAction("GetMovies", "Movies", new { id = id });
            }
       
        }

        //public RedirectResult Test1(int? id)
        //{

        //    RedirectResult result;
        //    if (id == 1)
        //    {
        //        result = new RedirectResult("https://www.google.com/");
        //    }
        //    else { 

        //            result= new RedirectResult("https://www.youtube.com/");
        //    }
        //    return result;
        //}
    }
}
