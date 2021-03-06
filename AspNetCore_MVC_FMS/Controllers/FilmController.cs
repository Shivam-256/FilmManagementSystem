using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using AspNetCore_MVC_FMS.Models;
using System.Collections.Generic;

namespace AspNetCore_Mvc_FMS.Controllers
{
    public class FilmController : Controller
    {
        public IActionResult Search(IFormCollection fc)
        {

            IEnumerable<FilmVM> fmList = null;
            string title = fc["txtTitle"];
            using (HttpClient client = new HttpClient())
            {
                Uri uri = new Uri("https://localhost:44320/api/films/" + title);
                var result = client.GetAsync(uri).Result;
                if (result.IsSuccessStatusCode)
                {
                    Task<string> data = result.Content.ReadAsStringAsync();
                    fmList = JsonConvert.DeserializeObject<IEnumerable<FilmVM>>(data.Result);
                }
                return View("index", fmList);
            }
        }
        public IActionResult Index()
        {
            IEnumerable<FilmVM> fmList = null;
            HttpClient client = new HttpClient();
            string token = Request.Cookies["jwttoken"];
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            Uri uri = new Uri("https://localhost:44320/api/films");
            var result = client.GetAsync(uri).Result;

            if (result.IsSuccessStatusCode)
            {
                Task<string> data = result.Content.ReadAsStringAsync();
                fmList = JsonConvert.DeserializeObject<IEnumerable<FilmVM>>(data.Result);
                {
                    return View(fmList);
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

       //doubt
        public IActionResult Create()
        {
            TableDataVM tbList = null;
            HttpClient client = new HttpClient();
            string token = Request.Cookies["jwttoken"];
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            Uri uri = new Uri("https://localhost:44320/api/tabledatas");
            var result = client.GetAsync(uri).Result;
            if (result.IsSuccessStatusCode)
            {
                Task<string> data = result.Content.ReadAsStringAsync();
                tbList = JsonConvert.DeserializeObject<TableDataVM>(data.Result);
                //var actList = (ActorVM)(tbList.ActorVM);
                var actList = tbList.Actors;
                var cgyList = tbList.Categories;
                var lngList = tbList.Languages;
                //TempData["deptList"] = deptList;
                //TempData.Keep();
                SelectList sl = new SelectList(actList, "ActorId", "FirstName");
                SelectList sl1 = new SelectList(cgyList, "CategoryId", "Name"); 
                SelectList sl2 = new SelectList(lngList, "LanguageId", "Name");
                ViewBag.actList = sl;
                ViewBag.cgyList = sl1;
                ViewBag.lngList = sl2;
                return View();
            }
            else
            {
                return RedirectToAction("ErrorHandling","Home");
            }
        }

        [HttpPost]
        public IActionResult Create(TableDataVM tb)
        {
            HttpClient client = new HttpClient();

            string token = Request.Cookies["jwttoken"];
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            Uri uri = new Uri("https://localhost:44320/tabldatas");
            var result = client.PostAsJsonAsync(uri, tb).Result;
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

                Uri uri = new Uri("https://localhost:44320/films/" + id.ToString());
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
            FilmVM fm = null;
            using (HttpClient client = new HttpClient())
            {
                string token = Request.Cookies["jwttoken"];
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                Uri uri = new Uri("https://localhost:44320/api/films/" + id);
                var result = client.GetAsync(uri).Result;
                if (result.IsSuccessStatusCode)
                {
                    var data = result.Content.ReadAsStringAsync();
                    fm = JsonConvert.DeserializeObject<FilmVM>(data.Result);
                    return View(fm);
                }
                else
                {
                    TempData["message"] = result.ReasonPhrase;
                }
                return RedirectToAction("index");
            }
        }

        [HttpPost]
        public IActionResult Edit(FilmVM fm)
        {
            using (HttpClient client = new HttpClient())
            {
                string token = Request.Cookies["jwttoken"];
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                Uri uri = new Uri("https://localhost:44320/api/films/" + fm.FilmId.ToString());
                var result = client.PutAsJsonAsync(uri, fm).Result;
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