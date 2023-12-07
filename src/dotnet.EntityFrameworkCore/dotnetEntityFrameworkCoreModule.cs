using Microsoft.Extensions.DependencyInjection;
using dotnet.Domain;
using Youshow.Ace.EntityFrameworkCore;
using Youshow.Ace.Modularity;

namespace dotnet.EntityFrameworkCore;
[RelyOn(
    typeof(AceEntityFrameworkCoreModule),
    typeof(dotnetDomainModule)
)]
public class dotnetEntityFrameworkCoreModule : AceModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAceDbContext<dotnetDbContext>(opt=>
        {
            opt.AddDefaultRepositories(true);
        });
        Configure<AceDbContextOptions>(opt=>{
            opt.UseSqlServer();
        });
    }
}
