using BusinnesLayer.Abtrack;
using DataAccessLayer.Abtrack;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Concrete
{
    public class NotificationManager : INotificationService
    {
        INotificationDal notificationDal;

        public NotificationManager(INotificationDal notificationDal)
        {
            this.notificationDal = notificationDal;
        }

        public Notification GetById(int id)
        {
           return notificationDal.GetById(id);
        }

        public List<Notification> GetList()
        {
            return notificationDal.GetListAll();
        }

        public void TAdd(Notification t)
        {
            notificationDal.Insert(t);
        }

        public void TDelete(Notification t)
        {
           notificationDal.Delete(t);
        }

        public void TUpdate(Notification t)
        {
            notificationDal.Update(t);
        }
    }
}
