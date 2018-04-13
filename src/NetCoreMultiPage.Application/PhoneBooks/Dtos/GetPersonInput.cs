using Abp.Runtime.Validation;
using NetCoreMultiPage.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreMultiPage.PhoneBooks.Dtos
{
    class GetPersonInput : PagedAndSortedInputDto, IShouldNormalize
    {

        //ViewModel=dto=>model
        //dto=>model
       public string FilterText { get; set; }
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }
    }
}
