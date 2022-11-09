using Microsoft.EntityFrameworkCore;
using RestaurantEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantDAL.Repost
{
    public class FeedbackRepost : IFeedbackRepost
    {
        RestaurantDbContext _feedbackdbContext;
        public FeedbackRepost(RestaurantDbContext feedbackdbContext)
        {
            _feedbackdbContext = feedbackdbContext;
        }

        public void AddFeedback(Feedback feedback)
        {
            _feedbackdbContext.tbl_Feedback.Add(feedback);
            _feedbackdbContext.SaveChanges();
        }

        public void DeleteFeedback(int Id)
        {
            var feedback = _feedbackdbContext.tbl_Feedback.Find(Id);
            _feedbackdbContext.tbl_Feedback.Remove(feedback);
            _feedbackdbContext.SaveChanges();
        }

        public Feedback GetFeedbackById(int Id)
        {
            return _feedbackdbContext.tbl_Feedback.Find(Id);
        }

        public IEnumerable<Feedback> GetFeedbacks()
        {
          return _feedbackdbContext.tbl_Feedback.ToList();
        }

        public void UpdateFeedback(Feedback feedback)
        {
            _feedbackdbContext.Entry(feedback).State = EntityState.Modified;
            _feedbackdbContext.SaveChanges();
        }
    }
}
