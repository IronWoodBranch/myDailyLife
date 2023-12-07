using AutoMapper;
using dotnet.Ability.Docking.caloriesApp.Dto;
using dotnet.Ability.Docking.paymentApp.Dto;
using dotnet.Domain.CaloriesInfo;
using dotnet.Domain.PaymentInfo;

namespace dotnetSystem.Ability
{
    public class dotnetPrifile : Profile
    {
        public dotnetPrifile()
        {
            CreateMap<AddSinglePaymentDto,singlePayment>();
            CreateMap<FoodCaloriesDto,CaloriesOfFood>();
            CreateMap<CaloriesOfFood,FoodCaloriesDto>();
        }
    }
}
