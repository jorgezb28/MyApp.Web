using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApp.UI.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace MyApp.UI.Controllers
{
    public class MembersController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly string _baseUrl;

        public MembersController(IConfiguration configuration, IHttpClientFactory httpClientFactory)
        {
            _configuration = configuration;
            _httpClientFactory = httpClientFactory;
            _baseUrl = _configuration["BaseApiUrl"];
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var client = _httpClientFactory.CreateClient();
                client.BaseAddress = new Uri(_baseUrl);

                HttpResponseMessage response = await client.GetAsync("api/Members/get-all");

                if (response.IsSuccessStatusCode)
                {
                    var memberListSerialized = response.Content.ReadAsStringAsync().Result;
                    var memberList = JsonConvert.DeserializeObject<List<MemberModel>>(memberListSerialized);

                    return View(memberList);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return NotFound();
        }

        public ActionResult AddMember()
        {
            return View();
        }

        public ActionResult EditMember()
        {
            return View();
        }

        public ActionResult ViewDetails()
        {
            return View();
        }

    }
}
