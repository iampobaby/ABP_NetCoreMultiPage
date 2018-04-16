using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using NetCoreMultiPage.PhoneBooks.Persons;
using NetCoreMultiPage.PhoneBooks.PhoneNumber.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreMultiPage.PhoneBooks.Dtos
{
    [AutoMapFrom(typeof(Person))]
    public class PersonListDto : FullAuditedEntityDto
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 邮箱地址
        /// </summary >
        public string EmailAddress { get; set; }
        /// <summary>
        /// 地址信息
        /// </summary>
        public string Address { get; set; }

        public List<PhoneNumberListDto> PhoneNumbers { get; set; }

    }
}
