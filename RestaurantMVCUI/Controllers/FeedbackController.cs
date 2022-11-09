using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using RestaurantEntity;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace RestaurantMVCUI.Controllers
{
    public class FeedbackController : Controller
    {
        private IConfiguration _configuration;
        public FeedbackController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Feedback> feedbackresult = null;
            using (HttpClient client = new HttpClient())
            {
                string endPoint = _configuration["WebApiBaseUrl"] + "Feedback/GetFeedback";
                using (var response = await client.GetAsync(endPoint))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        feedbackresult = JsonConvert.DeserializeObject<IEnumerable<Feedback>>(result);
                    }
                }
            }
            return View(feedbackresult);
        }
        public IActionResult Feedback()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Feedback(Feedback feedback)
        {
            ViewBag.status = "";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(feedback), Encoding.UTF8, "application/json");
                string endPoint = _configuration["WebApiBaseUrl"] + "Feedback/AddFeedback";


                using (var response = await client.PostAsync(endPoint, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Ok";
                        ViewBag.message = "feedback saved sucessfully!!";
                    }
                    else
                    {
                        ViewBag.status = "Error";
                        ViewBag.message = "Wrong entries!";
                    }
                }
            }
            return View();
        }

    }
}
