﻿using System.Threading.Tasks;
using EasyAbp.AbpHelper.Gui.AbpCli.New;
using EasyAbp.AbpHelper.Gui.AbpCli.New.Dtos;
using EasyAbp.AbpHelper.Gui.ModuleManagement.Explorer;
using EasyAbp.AbpHelper.Gui.ModuleManagement.Explorer.dtos;
using EasyAbp.AbpHelper.Gui.ModuleManagement.Installer.Dtos;
using EasyAbp.AbpHelper.Gui.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace EasyAbp.AbpHelper.Gui.Controllers.ModuleManagement
{
    [RemoteService]
    [Route("/api/abp-helper/module-management/explorer")]
    public class ModuleManagementExplorerController : GuiController, IModuleManagementExplorerAppService
    {
        private readonly IModuleManagementExplorerAppService _service;

        public ModuleManagementExplorerController(IModuleManagementExplorerAppService service)
        {
            _service = service;
        }
        
        [HttpGet]
        [Route("module-group")]
        public virtual Task<ListResultDto<ModuleGroupDto>> GetModuleGroupListAsync()
        {
            return _service.GetModuleGroupListAsync();
        }
    }
}