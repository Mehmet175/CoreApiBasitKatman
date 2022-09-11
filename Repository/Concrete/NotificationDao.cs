using DenemeApi.EF;
using DenemeApi.Models;
using DenemeApi.Repository.Abstract;
using DenemeApi.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DenemeApi.Repository.Concrete
{
    public class NotificationDao : EfEntityRepositoryBase<TblNotification>, INotificationDao
    {
        PVSCADA2022Context context;

        public NotificationDao()
        {
            context = new PVSCADA2022Context();
        }

        public ClientMessage AddNotification(TblNotification notification)
        {
            try
            {
                context.TblNotifications.Add(notification);
                context.SaveChanges();
                return new ClientMessage()
                {
                    Message = null,
                    Status = true,
                };
            }
            catch (Exception e)
            {
                return new ClientMessage()
                {
                    Message = e.Message,
                    Status = false,
                };
            }
        }
    }
}
