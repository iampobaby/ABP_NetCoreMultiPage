using System;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using System.Dynamic; 
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Linq.Extensions;
using Abp.UI;
using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using NetCoreMultiPage.PhoneBooks.Dtos;
using NetCoreMultiPage.PhoneBooks.Persons;

namespace NetCoreMultiPage.PhoneBooks
{
    public  class PersonAppService : NetCoreMultiPageAppServiceBase, IPersonAppService
    {
        private readonly IRepository<Person> _personResitory;

        public PersonAppService(IRepository<Person> personResitory)
        {
            _personResitory = personResitory;
        }

        public async Task CreateOrUpdatePersonAsync(CreateOrUpdatePersonInput input)
        {
            if (input.PersonEditDto.Id.HasValue)
            {
                await UpdatePersonAsync(input.PersonEditDto);
            }
            else
            {
                await CreatePersonAsync(input.PersonEditDto);

            }
        }

        public async Task DeletePersonAsync(EntityDto input)
        {
            var entity = await _personResitory.GetAsync(input.Id);
            if (entity == null)
            {
                throw new UserFriendlyException("该联系人已经消失在数据库中,无法二次删除");
            }
            await _personResitory.DeleteAsync(input.Id);
        }

        public async Task<PagedResultDto<PersonListDto>> GetPagedPersonAsync(GetPersonInput input)
        {
            var query = _personResitory.GetAll();
            var personCount = await query.CountAsync();
            var person = await query.OrderBy(input.Sorting).PageBy(input).ToListAsync();
            var dtos = person.MapTo<List<PersonListDto>>();
            return new PagedResultDto<PersonListDto>(personCount, dtos);
        }

        public async Task<PersonListDto> GetPersonByldAsync(NullableIdDto input)
        {
            var person = await  _personResitory.GetAsync(input.Id.Value);
            return person.MapTo<PersonListDto>();
        }


        protected async Task UpdatePersonAsync(PersonEditDto input)
        {
            var entity = await _personResitory.GetAsync(input.Id.Value);


            await _personResitory.UpdateAsync(input.MapTo(entity));

        }
        protected async Task CreatePersonAsync(PersonEditDto input)
        {
           await _personResitory.InsertAsync(input.MapTo<Person>());
            //此处有一个警告 定义了async 但没有使用await
        }

    }
}
