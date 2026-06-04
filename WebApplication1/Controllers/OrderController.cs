using Microsoft.AspNetCore.Mvc;
using OrderTracking.Business.Interface;
using OrderTracking.Model.DTO;
using OrderTracking.Model.Enums;
using OrderTracking.Model.Exceptions;

namespace WebApplication1.Controllers
{
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _iorderService;
        public OrderController(IOrderService iorderService)
        {
            _iorderService = iorderService;
        }
        [HttpGet]
        [Route("GetAllCustomer")]
        public async Task<IActionResult> GetAll(OrderStatus? status, int page = 1, int pageSize = 10)
        {
            var result = await _iorderService.GetOrderList(status, page, pageSize);
            return Ok(result);
        }

        [HttpPatch]
        [Route("{id}/status")]
        public async Task <IActionResult> Update(int id, [FromBody] OrderUpdateDTO request)
        {
            try
            {
                await _iorderService.Update(id, request.status);

            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
            catch (InvalidOrderException ex)
            {
                return BadRequest(new
                {
                    message = ex.Message
                });
            }
            return NoContent();
        }
    }
}
