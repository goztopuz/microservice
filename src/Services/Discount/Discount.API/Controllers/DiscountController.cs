﻿using Discount.API.Entities;
using Discount.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Discount.API.Controllers
{

    [ApiController]
    [Route("api/v1/[controller]")]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountRepository _repository;

        public DiscountController(IDiscountRepository repository)
        {
            _repository = repository;
        }
        [HttpGet("{productName}", Name = "GetDiscount")]
        [ProducesResponseType(typeof(Coupon), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<Coupon>> GetDiscount(string productName)
        {
            Coupon cp = new Coupon();
            cp.Id = 1;
            cp.ProductName = "IPhone X";
            cp.Description = "IPhone X Description";
            cp.Amount = 150;

            return Ok(cp);

       //   var coupon = await _repository.GetDiscount(productName);
          //  return Ok(coupon);


            
        }

        [HttpPost]
        [ProducesResponseType(typeof(Coupon), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<Coupon>> CreateDiscount([FromBody]Coupon coupon)
        {
          //  await _repository.CreateDiscount(coupon);
            return CreatedAtRoute("GetDiscount", new  { productName = coupon.ProductName }, coupon);

        }

        [HttpPut]
        [ProducesResponseType(typeof(Coupon), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<Coupon>> UpdateDiscount([FromBody] Coupon coupon)
        {
            return Ok(true);
         //   return Ok(await _repository.UpdateDiscount(coupon));
        }

        [HttpDelete("{productName}", Name = "DeleteDiscount")]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<bool>> DeleteDiscount(string productName)
        {
            return Ok(true);
          //  return Ok(await _repository.DeleteDiscount(productName));
        }

    }
}
