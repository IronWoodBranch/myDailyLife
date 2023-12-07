using dotnet.EntityFrameworkCore;
using dotnet.Ability.Docking;
using Youshow.Ace.Ability;
using Youshow.Ace.AutoMapper;
using Youshow.Ace.Modularity;
using Youshow.Ace.Logger;
using Microsoft.Extensions.DependencyInjection;

namespace dotnet.Ability;
[RelyOn(
    typeof(AceAbilityModule),
    typeof(AceAutoMapperModule),
    typeof(AceLoggerModule),
    typeof(dotnetAbilityDockingModule),
    typeof(dotnetEntityFrameworkCoreModule)
)]
public class dotnetAbilityModule : AceModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        var services = context.Services;
        services.AddAceLogger(
            opt=>opt.UseFile()
                    .UseElasticSearch(false)
        );
    }
}
