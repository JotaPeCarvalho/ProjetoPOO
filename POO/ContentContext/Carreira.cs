using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.ContentContext
{
    public class Carreira : Content
    {
        public Carreira(string titulo, string url) :base(titulo, url)
        {
             Items = new List<CarreiraItem>();
        }
        public IList<CarreiraItem> Items { get; set; }
        public int TotalCursos  => Items.Count;
    }

}
