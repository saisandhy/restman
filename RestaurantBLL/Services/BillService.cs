using RestaurantDAL.Repost;
using RestaurantEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantBLL.Services
{
    public class BillService
    {
        IBillRepost _billRepost;
        public BillService(IBillRepost billRepost)
        {
            _billRepost = billRepost;
        }   

        public void AddBill(Bill bill)
        {
            _billRepost.AddBill(bill);
        }
        //update bill
        public void UpdateBill(Bill bill)
        {
            _billRepost.UpdateBill(bill);
        }
        //delete bill
        public void DeleteBill(int Id)
        {
            _billRepost.DeleteBill(Id);
        }
        //get bill by id
        public Bill  GetBillById(int billId)
        {
             return _billRepost.GetBillById(billId);
        }
        //get bills
        public IEnumerable<Bill> GetBill()
        {
            return _billRepost.GetBills();
        }
    }
}
