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

namespace AspNetCore_Mvc_FMS.Controllers
{
    public class LanguageController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<LanguageVM> lngList = null;
            HttpClient client = new HttpClient();
            //string token = Request.Cookies["jwttoken"];
            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            Uri uri = new Uri("https://localhost:44320/api/languages");
            var result = client.GetAsync(uri).Result;

            if (result.IsSuccessStatusCode)
            {
                Task<string> data = result.Content.ReadAsStringAsync();
                lngList = JsonConvert.DeserializeObject<IEnumerable<LanguageVM>>(data.Result);
                {
                    return View(lngList);
                }
            }
            else
            {

                if (result.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                    ViewBag.message = "You are unauthorized, Error";
                else if (result.StatusCode == System.Net.HttpStatusCode.Forbidden)
                    ViewBag.message = "Forbidden, Error";
                else
                    ViewBag.message = "Unknown error, Contact Admin";
                {
                    return RedirectToAction("ErrorHandling", "Home");
                }
            }
        }
        public IActionResult Create()
        {
            IEnumerable<LanguageVM> lngList = null;
            HttpClient client = new HttpClient();
            Uri uri = new Uri("https://localhost:44320/api/languages");
            var result = client.GetAsync(uri).Result;

            if (result.IsSuccessStatusCode)
            {
                Task<string> data = result.Content.ReadAsStringAsync();
                lngList = JsonConvert.DeserializeObject<IEnumerable<LanguageVM>>(data.Result);
                //TempData["deptList"] = deptList;
                //TempData.Keep();
                SelectList sl = new SelectList(lngList, "LanguageId", "Name");
                ViewBag.deptList = sl;
            }
            return View();
        }

        [HttpPost]
        public IActionResult Create(LanguageVM lng)
        {
            HttpClient client = new HttpClient();
            string token = Request.Cookies["jwttoken"];
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            Uri uri = new Uri("https://localhost:44320/api/languages");
            var result = client.PostAsJsonAsync(uri, lng).Result;
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
                Uri uri = new Uri("https://localhost:44376/api/languages/" + id.ToString());
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
            LanguageVM lng = null;
            using (HttpClient client = new HttpClient())
            {
                string token = Request.Cookies["jwttoken"];
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
               Uri uri = new Uri("https://localhost:44320/api/languages/" + id);
                var result = client.GetAsync(uri).Result;
                if (result.IsSuccessStatusCode)
                {
                    Task<string> data = result.Content.ReadAsStringAsync();
                    lng = JsonConvert.DeserializeObject<LanguageVM>(data.Result);
                    return View(lng);
                }
                else
                {
                    TempData["message"] = result.ReasonPhrase;
                }
                return RedirectToAction("index");
            }
        }


        [HttpPost]
        public IActionResult Edit(LanguageVM lng)
        {
            using (HttpClient client = new HttpClient())
            {
                string token = Request.Cookies["jwttoken"];
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

               Uri uri = new Uri("https://localhost:44320/api/languages/" + lng.LanguageId.ToString());
                var result = client.PutAsJsonAsync(uri, lng).Result;
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