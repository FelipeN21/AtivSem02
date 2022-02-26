using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivSem02
{
    internal class InjDep
    {
        
        
        public static void Main(string[] args)
        {
            TransferenciasBancarias Teste = new TransferenciasBancarias(new BancosDaTransferencias.Banco01(),new BancosDaTransferencias.Banco02());
            Teste.Transferir(50);
            Console.ReadKey();
        }
       
    }
}
