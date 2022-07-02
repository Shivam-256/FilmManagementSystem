using AspNetCore_Mvc_FMS.Models;
using AspNetCore_MVC_FMS.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
namespace AspNetCore_Mvc_FMS.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            IEnumerable<RoleVM> roleList = null;
            HttpClient client = new HttpClient();
            Uri uri = new Uri("https://localhost:44320/api/roles");
            var result = client.GetAsync(uri).Result;
            if (result.IsSuccessStatusCode)
            {
                Task<string> data = result.Content.ReadAsStringAsync();
                roleList = JsonConvert.DeserializeObject<IEnumerable<RoleVM>>(data.Result);
                SelectList sl = new SelectList(roleList, "RoleId", "RoleName");
                ViewBag.roleList = sl;
            }
            return View();
        }
        [HttpPost]
        public IActionResult Register(RegisterVM user)
        {
            HttpClient client = new HttpClient();
            //string token = Request.Cookies["jwttoken"];
            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            Uri uri = new Uri("https://localhost:44320/api/users");
            var result = client.PostAsJsonAsync(uri, user).Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("index", "home");
            }
            else
            {
                ModelState.AddModelError("", result.ReasonPhrase);
            }
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginVM login, int RoleId)
        {
            MyJwtToken jwttoken;
            using (HttpClient client = new HttpClient())
            {
                Uri uri = new Uri("https://localhost:44320/api/users/" + login.UserName + "/" + login.Password);
                var result = client.GetAsync(uri).Result;
                if (result.IsSuccessStatusCode)
                {
                    Task<string> data = result.Content.ReadAsStringAsync();
                    jwttoken = JsonConvert.DeserializeObject<MyJwtToken>(data.Result);
                    Response.Cookies.Append("jwttoken", jwttoken.Token);
                    //HttpContext.Session.SetString("token", jwttoken.Token);
                    Response.Cookies.Append("username", login.UserName);
                    ViewBag.message = jwttoken.Token;
                }
                else
                {
                    ViewBag.message = result.ReasonPhrase;
                }
                if(RoleId == 1)
                {
                    return RedirectToAction("index", "film");
                }
               else
                {
                    return RedirectToAction("index", "filmController2");
                }
            }

        }
        public IActionResult Logout()
        {
            HttpContext.Response.Cookies.Delete("username");
            return RedirectToAction("login");
        }
    }
}
