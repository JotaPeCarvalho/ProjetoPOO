using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.NotificationContext
{
    public sealed class Notification
    {
        public Notification()
        {

        }
        public Notification(string propriedade, string menssagem)
        {
            Propriedade = propriedade;
            Menssagem = menssagem;
        }
        public string Propriedade { get; set; }
        public string Menssagem { get; set; }

    }
}
