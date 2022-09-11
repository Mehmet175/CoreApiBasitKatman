using DenemeApi.EF;
using DenemeApi.Models.Base;
using DenemeApi.Models.ComplexType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DenemeApi.Repository.Abstract
{
    interface IUserDao : IEntityRepository<TblUser>
    {
        public BaseModel<IEnumerable<CtUser>> CtGetUser();
    }
}
