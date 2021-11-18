using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using housecleaning2Api.Models;
using housecleaning2MVC.Helper;
using housecleaning2MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace housecleaning2MVC.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<Controller> _logger;
        private readonly housecleaning1Context _context;
        public UserController(ILogger<HomeController> logger, housecleaning1Context context)
        {
            _logger = logger;
            _context = context;
        }
        userHelper _api = new userHelper();
        public async Task<IActionResult> Index() //list of details//
        {
            List<UserTbl> UserDatas = new List<UserTbl>();
            HttpClient cli = _api.Initial(); //response msg as a result
            HttpResponseMessage result = await cli.GetAsync("api/UserTbls");
            if (result.IsSuccessStatusCode)
            {
                var res = result.Content.ReadAsStringAsync().Result;
                UserDatas = JsonConvert.DeserializeObject<List<UserTbl>>(res);

            }
            return View(UserDatas);

        }
        public ActionResult Adduser()
        {
            ViewBag.cost = new SelectList(_context.Roomcosts, "RoomId", "CostPerSqft").ToList();
            for(var i=0; i<ViewBag.cost.Count;i++)
            {
                ViewBag.lc =ViewBag.cost[i];
            }
            //ViewBag.roomname = new SelectList(_context.Roomcosts, "RoomId", "RoomNameSqft").ToList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Adduser(UserTbl userdata)
        {

            HttpClient cli = _api.Initial();
            string authornew = JsonConvert.SerializeObject(userdata);
            StringContent content = new StringContent(authornew, Encoding.UTF8, "application/json");
            HttpResponseMessage response = cli.PostAsync(cli.BaseAddress + "api/UserTbls", content).Result;
            HttpResponseMessage response1 = cli.GetAsync(cli.BaseAddress + "api/RoomCosts").Result;


            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");

            }

            return View();
        }
    }
}
