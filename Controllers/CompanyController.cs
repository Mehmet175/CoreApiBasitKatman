using DenemeApi.EF;
using DenemeApi.Models.Base;
using DenemeApi.Repository.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DenemeApi.Repository
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        ICompanyDao companyDao = new CompanyDao();

        [HttpGet] 
        public BaseModel<IEnumerable<TblCompany>> GetAll()
        {
            return companyDao.GetAll();
        }

      
    }
}
