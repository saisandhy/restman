using RestaurantDAL.Repost;
using RestaurantEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantBLL.Services
{
    public class FeedbackService
    {
        IFeedbackRepost _feedbackRepost;

        public FeedbackService(IFeedbackRepost feedbackRepost)
        {
            _feedbackRepost = feedbackRepost;
        }
        public void AddFeedback(Feedback feedback)
        {
            _feedbackRepost.AddFeedback(feedback);
        }

        public void UpdateFeedback(Feedback feedback)
        {
            _feedbackRepost. UpdateFeedback(feedback);
        }
        public void DeleteFeedback(int Id) 
        { 
            _feedbackRepost.DeleteFeedback(Id);
        }
        public Feedback GetFeedbackById(int Id)
        {
            return _feedbackRepost.GetFeedbackById(Id);
        }
         public IEnumerable<Feedback> GetFeedbacks()
        {
            return _feedbackRepost.GetFeedbacks();
        }
    }
}
