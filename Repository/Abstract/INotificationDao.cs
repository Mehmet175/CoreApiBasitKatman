using DenemeApi.EF;
using DenemeApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DenemeApi.Repository.Abstract
{
    public interface INotificationDao : IEntityRepository<TblNotification>
    {
        public ClientMessage AddNotification(TblNotification notification);
    }
}
