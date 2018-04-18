

using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreMultiPage.PhoneBooks.Persons.Dtos
{
    public class CreateOrUpdatePersonInput
    {    /// <summary>
         /// 通过ID获取联系人 再进行编辑
         /// </summary>
        public PersonEditDto PersonEditDto { get; set; }

    }
}
