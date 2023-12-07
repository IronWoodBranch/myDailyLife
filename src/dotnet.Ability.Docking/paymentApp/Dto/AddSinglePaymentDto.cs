using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet.Ability.Docking.paymentApp.Dto
{
    public class AddSinglePaymentDto
    {
    public decimal Amount { get; set; } 

    public string remark{get;set;}

    public DateTime theTime{get;set;}
    }
}