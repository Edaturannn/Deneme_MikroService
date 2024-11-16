using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Discount.Dtos;
using MultiShop.Discount.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MultiShop.Discount.Controllers
{
    [Route("api/[controller]")]
    public class DiscountsController : Controller
    {
        private readonly IDiscountService _discountService;
        public DiscountsController(IDiscountService discountService)
        {
            _discountService = discountService;
        }
        [HttpGet]
        public async Task<IActionResult> ListDiscount()
        {
            var values = await _discountService.GetAllCouponAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateDiscount(CreateCouponDto createCouponDto)
        {
            await _discountService.CreateCouponAsync(createCouponDto);
            return Ok("Başarılı Bir Şekilde Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateDiscount(UpdateCouponDto updateCouponDto)
        {
            await _discountService.UpdateCouponAsync(updateCouponDto);
            return Ok("Başarılı Bir Şekilde Güncellendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIDDiscount(int id)
        {
            var values = await _discountService.GetByIdCouponDtoAsync(id);
            return Ok(values);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDiscount(int id)
        {
            await _discountService.DeleteCouponAsync(id);
            return Ok("Başaralı Bir Şekilde Silindi");
        }
    }
}

