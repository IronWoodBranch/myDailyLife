using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet.Ability.Docking.dairyApp;
using dotnet.Domain.DairyInfo;
using Youshow.Ace.Ability;
using Youshow.Ace.Domain.Repository;

namespace dotnet.Ability.dairyApp
{
    public class DairyServicer : AbilityServicer, IDairyServicer
    {
        public IRepository<MyDiary> diaryRepo{get;set;}
        public bool AddDairy(string dairyText)
        {
            MyDiary diary=new MyDiary();
            diary.diary=dairyText;
            diary.diaryTime=DateTime.Now;
            diaryRepo.InsertAsync(diary);
            return true;
        }
    }
}