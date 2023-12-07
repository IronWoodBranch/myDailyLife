using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet.Ability.Docking.paymentApp.Dto;
using Youshow.Ace.Ability.Services;

namespace dotnet.Ability.Docking
{
    public interface IPaymentServicer : IAbilityServicer
    {
        Task<bool> addSinglePayment(AddSinglePaymentDto addDto);
    }
}