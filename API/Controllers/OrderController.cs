using ApplicationCore.Entities;
using ApplicationCore.IRepositories;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepositoryAsync _order;
        public OrderController(OrderRepositoryAsync orderRepositoryAsync)
        {
            _order = orderRepositoryAsync;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
        {
            return Ok(await _order.GetAllAsync());
        }

        [HttpPost]
        public async Task<IActionResult> SaveTheNewOrder(Order order)
        {
            return Ok(await _order.InsertAsync(order));
        }

        [HttpGet]
        public async Task<IActionResult> GetOrderByCustomerId(int id)
        {
            return Ok(await _order.GetByIdAsync(id));
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteTheOrder(int id)
        {
            return Ok(await _order.DeleteAsync(id));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTheOrder(Order order)
        {
            return Ok(await _order.UpdateAsync(order));
        }



    }
}
