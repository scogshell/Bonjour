using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Bonjour.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var text = "<form method='post'>" +
                "<input name='name' type='text'/>" +
                "<select name='language'>" +
                "<option value='spanish'>spanish</option>" +
                "<option value='french'>french</option>" +
                "<option value='english'>english</option>" +
                "<option value='german'>german</option>" +
                "</select>" +
                "<button>greet</button>" +
                "</form>";
            return Content(text, "text/html");
        }

        [HttpPost]
        public IActionResult Index(string name, string language)
        {
            var text = CreateMessage(name, language);
            return Content(text, "text/html");
        }

        public static string CreateMessage(string name, string language)
        {
            string greeting = null;
            switch(language)
            {
                case "spanish":
                    greeting = "Hola";
                    break;
                case "german":
                    greeting = "Hallo";
                    break;
                case "french":
                    greeting = "Bonjour";
                    break;
                default:
                    greeting = "Hello";
                    break;
            }

            return greeting + " " + name;
        }
    }
}