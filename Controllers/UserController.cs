using DenemeApi.EF;
using DenemeApi.Models.Base;
using DenemeApi.Models.ComplexType;
using DenemeApi.Repository;
using DenemeApi.Repository.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DenemeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserDao userDao = new UserDao();

       /* [HttpGet]
        public BaseModel<IEnumerable<TblUser>> GetAll()
        {
            return userDao.GetAll();
        }*/

        [HttpGet]
        public BaseModel<IEnumerable<CtUser>> CtGetAll()
        {
            return userDao.CtGetUser();
        }
    }
}
