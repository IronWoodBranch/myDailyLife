using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Youshow.Ace.Domain.Models;

namespace dotnet.Domain.DairyInfo
{
    public class MyDiary :BaseModel<int>
    {
        [Comment("日记正文")]
        public string diary { get; set; }

        public DateTime diaryTime { get; set; }
    }
}