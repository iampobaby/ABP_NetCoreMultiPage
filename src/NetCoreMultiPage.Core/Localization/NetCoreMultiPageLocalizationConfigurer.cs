using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace NetCoreMultiPage.Localization
{
    public static class NetCoreMultiPageLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(NetCoreMultiPageConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(NetCoreMultiPageLocalizationConfigurer).GetAssembly(),
                        "NetCoreMultiPage.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
