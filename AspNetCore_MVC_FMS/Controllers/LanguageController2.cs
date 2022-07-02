using AspNetCore_MVC_FMS.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace AspNetCore_MVC_FMS.Controllers
{
    public class LanguageController2 : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<LanguageVM> lngList = null;
            HttpClient client = new HttpClient();
            Uri uri = new Uri("https://localhost:44320/api/languages");
            var result = client.GetAsync(uri).Result;
            if (result.IsSuccessStatusCode)
            {
                Task<string> data = result.Content.ReadAsStringAsync();
                lngList = JsonConvert.DeserializeObject<IEnumerable<LanguageVM>>(data.Result);
            }
            return View(lngList);
        }
    }
}
