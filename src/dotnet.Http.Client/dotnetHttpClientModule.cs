using dotnet.Ability.Docking;
using Microsoft.Extensions.DependencyInjection;
using Youshow.Ace.Http.Client;
using Youshow.Ace.Modularity;

namespace dotnet.Http.Client;
[RelyOn(
        typeof(AceHttpClientModule)
)]
public class dotnetHttpClientModule : AceModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAceHttpClient(opt =>
        {
           opt.AddRemoteModule<dotnetAbilityDockingModule>("Default");
        });
    }

}
