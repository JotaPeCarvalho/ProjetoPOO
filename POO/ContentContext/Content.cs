using POO.NotificationContext;
using POO.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.ContentContext
{
    public abstract class Content : Base
    {
        public Content(string titulo, string url)
        {
            Titulo = titulo;
            Url = url;
        }
        public string Titulo { get; set; }
        public string Url { get; set; }
    }
}
