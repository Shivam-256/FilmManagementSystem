using AspNetCore_MVC_FMS.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AspNetCore_MVC_FMS.Controllers
{
    public class FilmController2 : Controller
    {
        public IActionResult Search(IFormCollection fc)
        {

            IEnumerable<FilmVM> fmList = null;
            string title = fc["txtTitle"];
            using (HttpClient client = new HttpClient())
            {
                Uri uri = new Uri("https://localhost:44320/api/filmsControler2/" + title);
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
            Uri uri = new Uri("https://localhost:44320/api/filmsController2");
            var result = client.GetAsync(uri).Result;
            if (result.IsSuccessStatusCode)
            {
                Task<string> data = result.Content.ReadAsStringAsync();
                fmList = JsonConvert.DeserializeObject<IEnumerable<FilmVM>>(data.Result);
            }
            return View(fmList);
        }
    }
}
