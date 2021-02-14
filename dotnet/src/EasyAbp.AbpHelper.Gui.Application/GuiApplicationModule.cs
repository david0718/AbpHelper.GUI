﻿using EasyAbp.AbpHelper.Core;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Cli;
using Volo.Abp.Modularity;

namespace EasyAbp.AbpHelper.Gui
{
    [DependsOn(
        typeof(AbpCliCoreModule),
        typeof(AbpHelperCoreModule),
        typeof(GuiApplicationContractsModule)
    )]
    public class GuiApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClient();
        }
    }
}
