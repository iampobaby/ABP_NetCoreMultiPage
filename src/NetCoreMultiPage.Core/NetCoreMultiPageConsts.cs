namespace NetCoreMultiPage
{
    public class NetCoreMultiPageConsts
    {
        public const string LocalizationSourceName = "NetCoreMultiPage";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = false;//多租户使用或不使用
        //change the true to false
        //多租户 非多租户
        //相应的实现代码在: D:\Data_source\NetCoreMultiPage\3.6.0\aspnet-core\src\NetCoreMultiPage.Core\NetCoreMultiPageCoreModule.cs
        /// <summary>
        /// 名字最大长度
        /// </summary>
        public const int MaxNameLength = 50;
        /// <summary>
        /// 邮箱最大长度
        /// </summary>
        public const int MaxEmailAddressLength = 80;
        /// <summary>
        /// 地址最大长度
        /// </summary>
        public const int MaxAddressLength = 100;
        /// <summary>
        /// 手机号码最大长度
        /// </summary>
        public const int MaxPhoneNumberLength = 11;
        /// <summary>
        /// Default page size for paged requests.
        /// </summary>
        public const int DefaultPageSize = 10;
        /// <summary>
        /// Maximum allowed page size for paged requests.
        /// </summary>
        public const int MaxPageSize = 1000;

    }
}
