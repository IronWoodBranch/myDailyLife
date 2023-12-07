using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Youshow.Ace.Domain.Models;

namespace dotnet.Domain.CaloriesInfo
{
    public class CaloriesOfFood : BaseModel<int>
    {
        [Comment("食物名")]
        public string FoodName { get; set; }

        [Comment("每100克多少热量")]
        public decimal Calories{get;set;}
    }
}