using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Youshow.Ace.EntityFrameworkCore;
using Youshow.Ace.EntityFrameworkCore.SqlServer;

namespace dotnet.EntityFrameworkCore
{
    public class dotnetDesignTimeFactory : AceSqlServerDesignTimeDbContextFactory<dotnetDbContext>
{
    public override AceDesignTimeDbContextOptions Options => new()
    {
        StartupProjectPath = @"../dotnet.Web" //appsetting.json所在目录
    };
}
}
