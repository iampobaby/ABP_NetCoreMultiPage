using Abp.AutoMapper;
using NetCoreMultiPage.PhoneBooks.PhoneNumbers;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreMultiPage.PhoneBooks.PhoneNumber.Dtos
{
    [AutoMapFrom(typeof(NetCoreMultiPage.PhoneBooks.PhoneNumbers.PhoneNumber))]
    public class PhoneNumberListDto
    {
        /// <summary>
        /// 电话号码
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// 电话类型
        /// </summary>
        public PhoneNumberType PhoneNumberType { get; set; }


    }
}
