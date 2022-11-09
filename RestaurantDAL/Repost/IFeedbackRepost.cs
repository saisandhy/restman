using RestaurantEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantDAL.Repost
{
    public interface IFeedbackRepost
    {

        void AddFeedback(Feedback feedback);
        void UpdateFeedback(Feedback feedback);
        void DeleteFeedback(int Id);
        Feedback GetFeedbackById(int Id);
        IEnumerable<Feedback> GetFeedbacks();
    }
}
