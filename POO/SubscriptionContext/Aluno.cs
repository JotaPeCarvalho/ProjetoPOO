using POO.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.SubscriptionContext
{
    public class Aluno : Base
    {
        public Aluno()
        {
            Assinaturas = new List<Assinatura>();
        }

        public string Nome { get; set; }
        public string Email { get; set; }
        public Usuario Usuario { get; set; }
        public IList<Assinatura> Assinaturas { get; set; }

        public void CriarAssinatura(Assinatura assinatura)
        {
            if (EPremium)
            {
                AddNotification(new NotificationContext.Notification("Premium", "O aluno já tem assinatura ativa"));
                return; //return pra ele sair da função
            }
            Assinaturas.Add(assinatura);
        }

        public bool EPremium => Assinaturas.Any(x => !x.EstaInativo);
    }
}
