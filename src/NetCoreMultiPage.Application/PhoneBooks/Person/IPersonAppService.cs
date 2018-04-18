using Abp.Application.Services;
using Abp.Application.Services.Dto;
using NetCoreMultiPage.PhoneBooks.Persons;
using NetCoreMultiPage.PhoneBooks.Persons.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreMultiPage.PhoneBooks
{
   public interface IPersonAppService:IApplicationService
    {
        /// <summary>
        /// 获取人的相关信息,支持分页
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<PersonListDto>> GetPagedPersonAsync(GetPersonInput input);

        /// <summary>
        /// 根据ID获取相关用户的信息
        /// </summary>
        /// <returns></returns>
        Task<PersonListDto> GetPersonByldAsync(NullableIdDto input);

        /// <summary>
        /// 增加或更改联系人信息
        /// </summary>
        /// <returns></returns>
        Task CreateOrUpdatePersonAsync(CreateOrUpdatePersonInput input);

        /// <summary>
        /// 删除用户联系人信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task DeletePersonAsync(EntityDto input);

        /// <summary>
        /// 通过ID获取联系人 再进行编辑
        /// </summary>
        /// <returns></returns>
        Task<GetPersonForEditOutput> GetPersonForEditAsync(NullableIdDto input);
    }
}
