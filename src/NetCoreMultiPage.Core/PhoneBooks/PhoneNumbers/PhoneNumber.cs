using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using NetCoreMultiPage.PhoneBooks.Persons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NetCoreMultiPage.PhoneBooks.PhoneNumbers
{
    public class PhoneNumber:Entity<long>,IHasCreationTime
    {
        
        /// <summary>
        /// 电话号码
        /// </summary>
        [MaxLength(12)]
        public string Number { get; set; }
        /// <summary>
        /// 电话类型
        /// </summary>
        public PhoneNumberType PhoneType { get; set; }
        public int PersonID { get; set; }

        public Person Person { get; set; }
        public DateTime CreationTime { get; set; }


    }
}
