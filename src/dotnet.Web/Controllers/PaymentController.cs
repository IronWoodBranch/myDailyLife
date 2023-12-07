using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet.Ability.Docking;
using dotnet.Ability.Docking.paymentApp.Dto;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class PaymentController : ControllerBase
    {
        public IPaymentServicer paymentServicer { get; set; }

        [HttpPost]
        public async Task<bool> addPayment(AddSinglePaymentDto addSinglePaymentDto)
        {
            return await paymentServicer.addSinglePayment(addSinglePaymentDto);

        }
    }
}