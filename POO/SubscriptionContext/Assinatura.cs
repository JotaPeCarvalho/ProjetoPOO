using POO.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.SubscriptionContext
{
    public class Assinatura : Base
    {
        public Plano Plano { get; set; }    
        public DateTime? DataFinal { get; set; }
        public bool EstaInativo => DataFinal <= DateTime.Now; //Se a data final for maior(depois) que hoje, é true e ele está inativo
    }
}
