using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantBLL.Services;
using RestaurantEntity;
using System.Collections.Generic;

namespace RestaurantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        private FeedbackService _feedbackService;
        public FeedbackController(FeedbackService feedbackService)
        {
            _feedbackService = feedbackService;
        }
        [HttpGet("GetFeedback")]
        public IEnumerable<Feedback> GetFeedbacks()
        {
            return _feedbackService.GetFeedbacks();
        }
        [HttpPost("AddFeedback")]
        public IActionResult AddFeedback([FromBody] Feedback feedback)
        {
            _feedbackService.AddFeedback(feedback);
            return Ok("feedback created successfully!!");
        }
        [HttpDelete("DeleteFeedback")]
        public IActionResult DeleteFeedback(int Id)
        {
            _feedbackService.DeleteFeedback(Id);
            return Ok("feedback deleted Successfully!!");
        }
        [HttpPut("UpdateFeedback")]
        public IActionResult UpdateFeedback([FromBody] Feedback feedback)
        {
            _feedbackService.UpdateFeedback(feedback);
            return Ok("feedback updated succesfully!!");
        }

        [HttpGet("GetFeedbackById")]
        public Feedback GetFeedbackById(int Id)
        {
            return _feedbackService.GetFeedbackById(Id);
        }
    }
}
