using DenemeApi.EF;
using DenemeApi.Repository.Abstract;
using DenemeApi.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DenemeApi.Repository
{
    public class CompanyDao :  EfEntityRepositoryBase<TblCompany>, ICompanyDao
    {
        
    }
}
