using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using dotnet.Ability.Docking;
using dotnet.Ability.Docking.paymentApp.Dto;
using dotnet.Domain.PaymentInfo;
using Youshow.Ace.Ability;
using Youshow.Ace.Domain.Repository;

namespace dotnet.Ability.paymentApp
{
    public class PaymentServicer : AbilityServicer, IPaymentServicer
    {
        public IRepository<singlePayment> paymentRepo{get;set;}
        public async Task<bool> addSinglePayment(AddSinglePaymentDto addDto)
        {
            try
            {
                var payment = ModelMapper.Map<AddSinglePaymentDto,singlePayment>(addDto);
                payment.theTime = DateTime.Now;
                paymentRepo.InsertAsync(payment);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
            
        }
    }
}