using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using housecleaning4Api.Models;
using housecleaning4Mvc.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace housecleaning4Mvc.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<Controller> _logger;
        private readonly housecleaning4Context _context;
        public UserController(ILogger<HomeController> logger, housecleaning4Context context)
        {
            _logger = logger;
            _context = context;
        }
        UserHelper _api = new UserHelper();

        public ActionResult homepage()
        {
            return View();
        }
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

        public async Task<IActionResult> Detailch()
        {
            List<UserTbl> cities = new List<UserTbl>();
            HttpClient cli = _api.Initial();
            HttpResponseMessage result = await cli.GetAsync("api/UserTbls/UserTbl/Chennai");
            if (result.IsSuccessStatusCode)
            {
                var res = result.Content.ReadAsStringAsync().Result;
                cities = JsonConvert.DeserializeObject<List<UserTbl>>(res);
            }
            return View(cities);
        }

        public async Task<IActionResult> DetailTvm()
        {
            List<UserTbl> cities = new List<UserTbl>();
            HttpClient cli = _api.Initial();
            HttpResponseMessage result = await cli.GetAsync("api/UserTbls/UserTbl/Tiruvannamalai");
            if (result.IsSuccessStatusCode)
            {
                var res = result.Content.ReadAsStringAsync().Result;
                cities = JsonConvert.DeserializeObject<List<UserTbl>>(res);
            }
            return View(cities);
        }

        public async Task<IActionResult> DetailKk()
        {
            List<UserTbl> cities = new List<UserTbl>();
            HttpClient cli = _api.Initial();
            HttpResponseMessage result = await cli.GetAsync("api/UserTbls/UserTbl/Kanyakumari");
            if (result.IsSuccessStatusCode)
            {
                var res = result.Content.ReadAsStringAsync().Result;
                cities = JsonConvert.DeserializeObject<List<UserTbl>>(res);
            }
            return View(cities);
        }



        public ActionResult Adduser()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Adduser(UserTbl userdata)
        {

            HttpClient cli = _api.Initial();
            string authornew = JsonConvert.SerializeObject(userdata);
            StringContent content = new StringContent(authornew, Encoding.UTF8, "application/json");
            HttpResponseMessage response = cli.PostAsync(cli.BaseAddress + "api/UserTbls", content).Result;


            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");

            }

            return View();
        }

        public JsonResult roomcost()
        {
            List<RoomCost> rcost = _context.RoomCosts.ToList<RoomCost>();
            return Json(new { data = rcost }, new Newtonsoft.Json.JsonSerializerSettings());
        }

        public JsonResult cities()
        {
            List<UserTbl>  cities= _context.UserTbls.ToList<UserTbl>();
            return Json(new { data = cities }, new Newtonsoft.Json.JsonSerializerSettings());
        }
    }
}
