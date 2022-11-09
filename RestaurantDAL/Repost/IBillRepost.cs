using RestaurantEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantDAL.Repost
{
    public interface IBillRepost
    {
        void AddBill(Bill bill);
        void UpdateBill(Bill bill);
        void DeleteBill(int Id);
        Bill GetBillById(int Id);
        IEnumerable<Bill> GetBills();

    }
}
