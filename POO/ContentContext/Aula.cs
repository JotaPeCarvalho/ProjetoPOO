using POO.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.ContentContext
{
    public class Aula : Base
    {
        public int Ordem { get; set; }
        public string Titulo { get; set; }
        public int DurationInMinutes { get; set; }
    }
}
