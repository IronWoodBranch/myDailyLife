using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Youshow.Ace.Ability.Services;

namespace dotnet.Ability.Docking.caloriesApp.Dto
{
    public interface ICaloriesServicer : IAbilityServicer
    {
        public bool addFood(FoodCaloriesDto FoodCaloriesDto);

        public FoodCaloriesDto getSingleFoodCaloriesById(int id);

        public FoodCaloriesDto updateFoodCaloriesById(FoodCaloriesDto updateDto,int id);

        public bool deleteFoodCaloriesById(int id);
    }
}