using POO.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.ContentContext
{
    public class CarreiraItem : Base
    {
        public CarreiraItem(int order, string titulo, string descricao, Curso curso)
        {
            if (curso == null)
                AddNotification(new NotificationContext.Notification("Course", "Curso inválido"));
            Order = order;
            Titulo = titulo;
            Descricao = descricao;
            Curso = curso;
        }

        public int Order { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public Curso Curso { get; set; }
    }
}
