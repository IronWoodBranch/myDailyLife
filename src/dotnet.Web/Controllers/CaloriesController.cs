using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet.Ability.Docking.caloriesApp.Dto;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class CaloriesController : ControllerBase
    {
        public ICaloriesServicer caloriesServicer { get; set; }

        [HttpPost]
        public bool AddFoodAndCalories(FoodCaloriesDto addFoodCaloriesDto)
        {
            return caloriesServicer.addFood(addFoodCaloriesDto);
        }

        [HttpGet]
        public FoodCaloriesDto GetSingleFoodAndCaloriesById(int id)
        {
            return caloriesServicer.getSingleFoodCaloriesById(id);
        }

        [HttpPut]
        public FoodCaloriesDto UpdateFoodCaloriesById(FoodCaloriesDto updatedto,int id)
        {
            return caloriesServicer.updateFoodCaloriesById(updatedto,id);
        }

        [HttpDelete]
        public bool DeleteFoodCaloriesById(int id )
        {
            return caloriesServicer.deleteFoodCaloriesById(id);
        }
    }
}