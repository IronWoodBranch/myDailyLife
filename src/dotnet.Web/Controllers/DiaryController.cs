using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet.Ability.Docking.dairyApp;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class DiaryController : ControllerBase
    {
        public IDairyServicer diaryServicer { get; set; }
        [HttpPost]
        public bool AddNewDiary(string diaryText)
        {
           return  diaryServicer.AddDairy(diaryText);
        }
    }
}