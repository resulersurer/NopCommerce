using Nop.Services.Localization;
using Nop.Services.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResulPlugin.Widgets.SwiperSlider
{
    internal class SwiperSliderPlugin : BasePlugin
    {
        #region Fields
        private readonly ILocalizationService _localizationService;
        #endregion
        #region Ctor
        public SwiperSliderPlugin(LocalizationService localizationService)
        {
            _localizationService = localizationService;
        }
        #endregion

        #region Methods

        public override Task InstallAsync() => _localizationService.AddOrUpdateLocaleResourceAsync("ResulPlugin.Widgets.SwiperSlider.test", "test");

        public override Task UninstallAsync()
        {
            return base.UninstallAsync();
        }

        public override Task PreparePluginToUninstallAsync() => _localizationService.DeleteLocaleResourcesAsync("ResulPlugin.Widgets.SwiperSlider.test");

        public override string GetConfigurationPageUrl()
        {
            return base.GetConfigurationPageUrl();
        }
        #endregion
    }
}

