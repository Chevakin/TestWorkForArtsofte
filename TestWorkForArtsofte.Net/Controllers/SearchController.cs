using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace TestWorkForArtsofte.Net.Controllers
{
    [Route("api/search")]
    public class SearchController : Controller
    {
        private readonly IEnumerable<string> _names = new string[]
        {
            "Анастасия",
            "Мария",
            "София",
            "Вероника",
            "Виктория",
            "Артем",
            "Александр",
            "Максим",
            "Дмитрий",
            "Матвей",
        };

        [Route("names")]
        [HttpGet]
        public JsonResult GetNames(string term)
        {
            return Json(_names
                .Where(n => n.Contains(term, System.StringComparison.OrdinalIgnoreCase))
                .ToArray());
        }
    }
}
