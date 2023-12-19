using Grand.Business.Core.Extensions;
using Grand.Business.Core.Interfaces.Common.Localization;
using Grand.Infrastructure.Plugins;

namespace Misc.BasicPlugin
{
    public class MiscBasicPlugin : BasePlugin, IPlugin
    {
        private readonly ITranslationService _translationService;
        private readonly ILanguageService _languageService;

        public MiscBasicPlugin(ITranslationService translationService, ILanguageService languageService)
        {
            _translationService = translationService;
            _languageService = languageService;
        }

        public override string ConfigurationUrl()
        {
            return MiscBasicPluginDefaults.ConfigurationUrl;
        }

        public override async Task Install()
        {
            //locales
            await this.AddOrUpdatePluginTranslateResource(_translationService, _languageService, "Misc.BasicPlugin.FriendlyName", "Basic plugin structure");
            
            await base.Install();
        }

        public override async Task Uninstall()
        {
            //locales
            await this.DeletePluginTranslationResource(_translationService, _languageService, "Misc.BasicPlugin.FriendlyName");

            await base.Uninstall();
        }
    }
}
