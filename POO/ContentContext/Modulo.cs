using POO.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.ContentContext
{
    public class Modulo : Base
    {
        public Modulo()
        {
            Aulas = new List<Aula>();
        }
        public int Ordem { get; set; }
        public string Titulo { get; set; }

        public IList<Aula> Aulas { get; set; }

    }
}
