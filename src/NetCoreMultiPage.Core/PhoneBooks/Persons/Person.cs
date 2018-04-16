using Abp.Domain.Entities.Auditing;
using NetCoreMultiPage.PhoneBooks.PhoneNumbers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NetCoreMultiPage.PhoneBooks.Persons
{
    public class Person : FullAuditedEntity
    {

        /// <summary>
        /// 姓名
        /// </summary>
        [Required]
        [MaxLength(NetCoreMultiPageConsts.MaxNameLength)]
        public string Name { get; set; }

        /// <summary>
        /// 邮箱地址
        /// </summary >
        [EmailAddress]
        [MaxLength(NetCoreMultiPageConsts.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
        /// <summary>
        /// 地址信息
        /// </summary>
        [MaxLength(NetCoreMultiPageConsts.MaxAddressLength)]
        public string Address { get; set; }

        /// <summary>
        /// 手机号码信息
        /// </summary>
        public ICollection<PhoneNumber> PhoneNumbers { get; set; }

    }
}
