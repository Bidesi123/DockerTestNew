using Core.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpPost("CreateOrder")]
        public IActionResult Create(Order order)
        {
            return Ok($"Order created successfully on {order.OrderId}");
        }
    }
}
