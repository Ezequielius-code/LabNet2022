using Newtonsoft.Json;
using Practica.EF.WebAPI.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Practica.EF.WebAPI.Controllers
{
    public class SpellController : Controller
    {
        // GET: Spell
        public async Task<ActionResult> Index()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://fedeperin-harry-potter-api.herokuapp.com/hechizos");          
            List<SpellViewModel> spells = JsonConvert.DeserializeObject<List<SpellViewModel>>(json);

            return View(spells);
        }
    }
}