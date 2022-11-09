using Microsoft.EntityFrameworkCore;
using RestaurantEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantDAL.Repost
{
    public class BillRepost:IBillRepost
    {
        RestaurantDbContext _billdbContext;

        public BillRepost(RestaurantDbContext billdbContext)
        {
            _billdbContext = billdbContext;
        }
        public void AddBill(Bill bill)
        {
            _billdbContext.tbl_Bill.Add(bill);
            _billdbContext.SaveChanges();
        }

        public void DeleteBill(int BillId)
        {
            var bill = _billdbContext.tbl_Bill.Find(BillId);
            _billdbContext.tbl_Bill.Remove(bill);
            _billdbContext.SaveChanges();
        }

        public Bill GetBillById(int Id)
        {
            return _billdbContext.tbl_Bill.Find(Id);
        }

        public IEnumerable<Bill> GetBills()
        {
            return _billdbContext.tbl_Bill.ToList();
        }

        public void UpdateBill(Bill bill)
        {
            _billdbContext.Entry(bill).State = EntityState.Modified;
            _billdbContext.SaveChanges();
        }
    }
   
}
