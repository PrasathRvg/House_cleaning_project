using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using housecleaningApi.Models;
using housecleaningmvc.Helper;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace housecleaningmvc.Controllers
{
    public class UserController : Controller
    {
        UserHelper _api = new UserHelper();
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
            var temp = new RoomCost();
            ViewData["amount"] = temp.CostPerSqft;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Adduser(UserTbl userdata)
        {
            //List<RoomCost> roomdetails = new List<RoomCost>();
            //roomdetails.Add(new RoomCost() { RoomId = 1, RoomNameSqft = "livingroom", CostPerSqft = 50 });
            //roomdetails.Add(new RoomCost() { RoomId = 2, RoomNameSqft = "Bedroom", CostPerSqft = 60 });
            HttpClient cli = _api.Initial();
            string authornew = JsonConvert.SerializeObject(userdata);
            StringContent content = new StringContent(authornew, Encoding.UTF8, "application/json");
            HttpResponseMessage response = cli.PostAsync(cli.BaseAddress + "api/UserTbls", content).Result;
            HttpResponseMessage response1 = cli.GetAsync(cli.BaseAddress + "api/RoomCosts").Result;
            var name = new RoomCost();


            if (response.IsSuccessStatusCode)
            {
                
                ViewData["costsqft"] = name.CostPerSqft;
                return RedirectToAction("Index");

            }
            
            return View();
        }
    }
}

