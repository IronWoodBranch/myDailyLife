using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet.Ability.Docking.caloriesApp.Dto;
using dotnet.Domain.CaloriesInfo;
using JetBrains.Annotations;
using Youshow.Ace.Ability;
using Youshow.Ace.Domain.Models;
using Youshow.Ace.Domain.Repository;

namespace dotnet.Ability.caloriesApp
{
    public class CaloriesServicer : AbilityServicer,ICaloriesServicer
    {
        public IRepository<CaloriesOfFood> caloriesRepo {get;set;}
        public bool addFood(FoodCaloriesDto addFoodCaloriesDto)
        {
            var cal = ModelMapper.Map<FoodCaloriesDto,CaloriesOfFood>(addFoodCaloriesDto);
            try{
                caloriesRepo.InsertAsync(cal);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public FoodCaloriesDto getSingleFoodCaloriesById(int id)
        {
            var result =  caloriesRepo.Get(t=>t.Id==id);
            var cal =ModelMapper.Map<CaloriesOfFood,FoodCaloriesDto>(result);
            return cal;

        }

        //先实现功能，这有待优化，因为前端必须把食物的id传过来
        public FoodCaloriesDto updateFoodCaloriesById(FoodCaloriesDto updateDto,int id)
        {
            //把前端的dto转过来，好像
            var EntitiyAfterUpdate = ModelMapper.Map<FoodCaloriesDto,CaloriesOfFood>(updateDto);
            //通过前端的id，用ef去取要改的对象
            var QueryResult = caloriesRepo.Get(id);
            QueryResult.FoodName=EntitiyAfterUpdate.FoodName;
            QueryResult.Calories=EntitiyAfterUpdate.Calories;

            //改好后update回去，返回新的对象
            caloriesRepo.Update(QueryResult);

            return getSingleFoodCaloriesById(EntitiyAfterUpdate.Id);

        }

        public bool deleteFoodCaloriesById(int id)
        {
            try
            {
                caloriesRepo.Delete(p=>p.Id==id);
                return true;
            }
            catch (System.Exception)
            {
                return false;        
                throw;
            }
        
        }
    }
}