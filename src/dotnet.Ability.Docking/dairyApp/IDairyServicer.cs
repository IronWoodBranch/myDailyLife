using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Youshow.Ace.Ability.Services;

namespace dotnet.Ability.Docking.dairyApp
{
    public interface IDairyServicer : IAbilityServicer
    {
        public bool AddDairy(string dairyText);
    }
}