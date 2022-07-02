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

    public class CategoryController : Controller
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

        public IActionResult Create()

        {

            IEnumerable<CategoryVM> cgyList = null;

            HttpClient client = new HttpClient();

            Uri uri = new Uri("https://localhost:44320/api/categories");

            var result = client.GetAsync(uri).Result; if (result.IsSuccessStatusCode)

            {

                Task<string> data = result.Content.ReadAsStringAsync();

                cgyList = JsonConvert.DeserializeObject<IEnumerable<CategoryVM>>(data.Result);

                //TempData["deptList"] = deptList;

                //TempData.Keep();

                SelectList sl = new SelectList(cgyList, "CategoryId", "Name");

                ViewBag.deptList = sl;

            }

            return View();

        }
        [HttpPost]

        public IActionResult Create(CategoryVM cgy)

        {

            HttpClient client = new HttpClient(); string token = Request.Cookies["jwttoken"];

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

            Uri uri = new Uri("https://localhost:44320/api/categories");

            var result = client.PostAsJsonAsync(uri, cgy).Result;

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

                Uri uri = new Uri("https://localhost:44320/api/languagess/" + id.ToString());

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

            CategoryVM cgy = null;

            using (HttpClient client = new HttpClient())

            {

                string token = Request.Cookies["jwttoken"];

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token); 

                Uri uri = new Uri("https://localhost:44376/api/employees/" + id);

                var result = client.GetAsync(uri).Result;

                if (result.IsSuccessStatusCode)

                {

                    Task<string> data = result.Content.ReadAsStringAsync();

                    cgy = JsonConvert.DeserializeObject<CategoryVM>(data.Result);

                    return View(cgy);

                }

                else

                {

                    TempData["message"] = result.ReasonPhrase;

                }

                return RedirectToAction("index");

            }

        }
        [HttpPost]

        public IActionResult Edit(CategoryVM cgy)

        {

            using (HttpClient client = new HttpClient())

            {
               string token = Request.Cookies["jwttoken"];

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token); 
                Uri uri = new Uri("https://localhost:44320/api/categories/" + cgy.CategoryId.ToString());
                var result = client.PutAsJsonAsync(uri, cgy).Result;
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