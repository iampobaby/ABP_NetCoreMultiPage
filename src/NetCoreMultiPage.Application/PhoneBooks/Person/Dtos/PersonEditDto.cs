﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using NetCoreMultiPage.PhoneBooks.Persons;
using NetCoreMultiPage.PhoneBooks.PhoneNumber.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NetCoreMultiPage.PhoneBooks.Persons.Dtos
{
    [AutoMapTo(typeof(Person))]
    public class PersonEditDto
    {

        public int? Id { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// 邮箱地址
        /// </summary >
        [EmailAddress]
        [MaxLength(80)]
        public string EmailAddress { get; set; }
        /// <summary>
        /// 地址信息
        /// </summary>
        [MaxLength(200)]
        public string Address { get; set; }


        public List<PhoneNumberEditDto> PhoneNumbers { get; set; }



    }
}
