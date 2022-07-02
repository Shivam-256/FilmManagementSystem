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
    public class CategoryController2 : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<CategoryVM> cgyList = null;

            HttpClient client = new HttpClient();

            string token = Request.Cookies["jwttoken"];

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            Uri uri = new Uri("https://localhost:44320/api/categories");

            var result = client.GetAsync(uri).Result;

            if (result.IsSuccessStatusCode)

            {

                Task<string> data = result.Content.ReadAsStringAsync();

                cgyList = JsonConvert.DeserializeObject<IEnumerable<CategoryVM>>(data.Result);

            }

            return View(cgyList);
        }
    }
}
