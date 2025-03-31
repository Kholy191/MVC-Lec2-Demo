using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class MoviesController : Controller
    {
        //Action - Public Non static method inside controller
        public IActionResult GetMovie(int id, string name)
        {
            if (id == 0)
            {
                return new BadRequestResult();
            }

            ContentResult result = new ContentResult();
            result.Content = $"Id = {id} Name = {name}";

            result.ContentType = "text/html";

            return result;
        }


        public string index()
        {
            return "GetAllMovies";
        }

        public ActionResult Hamada()
        {
            var Result = RedirectToAction(actionName: "Index");
            return Result;
        }

        public ActionResult ToRoute()
        {
            var Result = RedirectToRoute("default", new { controller = "Movies", action = "GetMovie", id = 5 });
            return Result;
        }
    }
}
