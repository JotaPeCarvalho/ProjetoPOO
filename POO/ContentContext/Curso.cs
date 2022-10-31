using POO.ContentContext.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.ContentContext
{
    public class Curso : Content
    {
        public Curso(string titulo, string url) : base(titulo, url)
        {
            Modulos = new List<Modulo>();
        }

       public string Tag { get; set; }
       public IList<Modulo> Modulos { get; set; }
       public int DurationInMinutes { get; set; }
       public EContentLevel Nivel { get; set; }

    }

}
