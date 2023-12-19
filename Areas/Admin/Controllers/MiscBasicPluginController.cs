using Grand.Business.Core.Interfaces.Common.Configuration;
using Grand.Business.Core.Utilities.Common.Security;
using Grand.Web.Common.Controllers;
using Grand.Web.Common.Filters;
using Grand.Web.Common.Security.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Misc.BasicPlugin.Areas.Admin.Controllers
{
    [AuthorizeAdmin]
    [Area("Admin")]
    [PermissionAuthorize(PermissionSystemName.Plugins)]
    public class MiscBasicPluginController : BasePluginController
    {
        private readonly ISettingService _settingService;

        public MiscBasicPluginController(ISettingService settingService)
        {
            _settingService = settingService;
        }


        public IActionResult Configure()
        {
            var settings = _settingService.GetAllSettings();

            return View(settings);
        }
    }
}
