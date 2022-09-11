using DenemeApi.EF;
using DenemeApi.Models;
using DenemeApi.Models.Base;
using DenemeApi.Repository.Abstract;
using DenemeApi.Repository.Concrete;
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
    public class NotificationController : ControllerBase
    {
        INotificationDao notificationDao = new NotificationDao();

        [HttpGet]
        public BaseModel<IEnumerable<TblNotification>> GetAll()
        {
            return notificationDao.GetAll();
        }



        [HttpPost] 
        public ClientMessage AddNotification([FromBody] TblNotification notification)
        {
            return notificationDao.AddNotification(notification);
        }
    }
}
