using Abp.AutoMapper;
using NetCoreMultiPage.PhoneBooks.PhoneNumbers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NetCoreMultiPage.PhoneBooks.PhoneNumber.Dtos
{
    [AutoMapTo(typeof(NetCoreMultiPage.PhoneBooks.PhoneNumbers.PhoneNumber))]
    public class PhoneNumberEditDto
    {
        /// <summary>
        /// 电话号码
        /// </summary>
        [Required]
        [MaxLength(NetCoreMultiPageConsts.MaxPhoneNumberLength)]
        public string Number { get; set; }
        /// <summary>
        /// 电话类型
        /// </summary>
        public PhoneNumberType PhoneType { get; set; }
    }
}
