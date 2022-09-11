using DenemeApi.EF;
using DenemeApi.Models.Base;
using DenemeApi.Models.ComplexType;
using DenemeApi.Repository.Abstract;
using DenemeApi.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DenemeApi.Repository
{
    public class UserDao : EfEntityRepositoryBase<TblUser>, IUserDao
    {
        PVSCADA2022Context context;

        public UserDao()
        {
            context = new PVSCADA2022Context();
        }


        public BaseModel<IEnumerable<CtUser>> CtGetUser()
        {
            try
            {
                var data = (from user in context.TblUsers
                           from company in context.TblCompanies
                           where user.CompanyId == company.Id
                           select new CtUser()
                           {
                               CompanyId = company.Id,
                               CompanyName = company.Name,
                               UserId = user.Id,
                               UserName = user.Name,
                           }).ToList();
                return new BaseModel<IEnumerable<CtUser>>()
                {
                    Message = null,
                    Status = data.Count == 0 ? StatusEnum.empty : StatusEnum.success,
                    Data = data,
                };
            }
            catch (Exception e)
            {
                return new BaseModel<IEnumerable<CtUser>>()
                {
                    Message = e.Message,
                    Status = StatusEnum.error,
                    Data = null,
                };
            }
        }
    }
}
