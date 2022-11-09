using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantBLL.Services;
using RestaurantEntity;
using System.Collections.Generic;

namespace RestaurantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillController : ControllerBase
    {
        private BillService _BillService;
        public BillController(BillService billService)
        {
            _BillService = billService;
        }
        [HttpGet("GetBills")]

        public IEnumerable<Bill> GetBills()
        {
            return _BillService.GetBill();
        }
        [HttpPost("AddBills")]
        public IActionResult AddBill([FromBody] Bill bill)
        {
            _BillService.AddBill(bill);
            return Ok("bill created successfully!!");
        }
        [HttpDelete("DeleteBills")]
        public IActionResult DeleteBill(int id)
        {
            _BillService.DeleteBill(id);
            return Ok("bill deleted Successfully!!");
        }
        [HttpPut("UpdateBill")]
        public IActionResult UpdateBooking([FromBody] Bill bill)
        {
            _BillService.UpdateBill(bill);
            return Ok("bill updated succesfully!!");
        }
        [HttpGet("GetBillById")]
        public Bill GetBillById(int Id)
        {
            return _BillService.GetBillById(Id);
        }
    }
}
