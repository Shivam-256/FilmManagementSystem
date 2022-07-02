using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using AspNetCore_MVC_FMS.Models;

namespace AspNetCore_Mvc_Demo.Controllers
{
    public class ActorController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<ActorVM> actList = null;
            HttpClient client = new HttpClient();
            string token = Request.Cookies["jwttoken"];
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            Uri uri = new Uri("https://localhost:44320/api/actors");
            var result = client.GetAsync(uri).Result;
            if (result.IsSuccessStatusCode)
            {
                Task<string> data = result.Content.ReadAsStringAsync();
                actList = JsonConvert.DeserializeObject<IEnumerable<ActorVM>>(data.Result);
            }
            return View(actList);
        }
        public IActionResult Create()
        {
            IEnumerable<ActorVM> actList = null;
            HttpClient client = new HttpClient();
            Uri uri = new Uri("https://localhost:44320/api/actors");
            var result = client.GetAsync(uri).Result;

            if (result.IsSuccessStatusCode)
            {
                Task<string> data = result.Content.ReadAsStringAsync();
                actList = JsonConvert.DeserializeObject<IEnumerable<ActorVM>>(data.Result);
                //TempData["deptList"] = deptList;
                //TempData.Keep();
                SelectList sl = new SelectList(actList, "ActorId", "FirstName","LastName");
                ViewBag.actList = sl;
            }
            return View();
        }

        [HttpPost]
        public IActionResult Create(ActorVM act)
        {
            HttpClient client = new HttpClient();

            string token = Request.Cookies["jwttoken"];
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            Uri uri = new Uri("https://localhost:44320/api/actors");
            var result = client.PostAsJsonAsync(uri, act).Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("index");
            }
            else
            {
                ModelState.AddModelError("", result.ReasonPhrase);
            }
            return View();
        }
        public IActionResult Delete(int id)
        {

            using (HttpClient client = new HttpClient())
            {
                string token = Request.Cookies["jwttoken"];
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                Uri uri = new Uri("https://localhost:44320/api/actors/" + id.ToString());
                var result = client.DeleteAsync(uri).Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("index");
                }
                else
                {
                    TempData["message"] = result.ReasonPhrase;
                }
                return RedirectToAction("index");
            }
        }

        public IActionResult Edit(int id)
        {
            ActorVM act = null;
            using (HttpClient client = new HttpClient())
            {
                string token = Request.Cookies["jwttoken"];
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                Uri uri = new Uri("https://localhost:44320/api/actor/" + id);
                var result = client.GetAsync(uri).Result;
                if (result.IsSuccessStatusCode)
                {
                    Task<string> data = result.Content.ReadAsStringAsync();
                    act = JsonConvert.DeserializeObject<ActorVM>(data.Result);
                    return View(act);
                }
                else
                {
                    TempData["message"] = result.ReasonPhrase;
                }
                return RedirectToAction("index");
            }
        }

        [HttpPost]
        public IActionResult Edit(ActorVM act)
        {
            using (HttpClient client = new HttpClient())
            {
                string token = Request.Cookies["jwttoken"];
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                Uri uri = new Uri("https://localhost:44320/api/actor/" + act.ActorId.ToString());
                var result = client.PutAsJsonAsync(uri, act).Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("index");
                }
                else
                {
                    ModelState.AddModelError("", result.ReasonPhrase);
                }
                return View();
            }
        }
    }
}