using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.NotificationContext
{
    public abstract class Notifable
    {
       public List<Notification> Notificacoes { get; set; }

        public Notifable()
        {
            Notificacoes = new List<Notification>();
        }
       public void AddNotification(Notification notification)
        {
            Notificacoes.Add(notification);
        }

        public void AddNotifications(IEnumerable<Notification> notifications)
        {
            Notificacoes.AddRange(notifications);
        }

        public bool IsInvalid => Notificacoes.Any(); //Se tiver alguma notificação é inválido, se não, é valido

    }
}
