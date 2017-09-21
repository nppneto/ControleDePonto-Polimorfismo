using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontoEntradaESaida___Polimorfismo
{
    class TestaEntradaESaida
    {
        static void Main(string[] args)
        {
            ControleDePonto cp = new ControleDePonto();

            Gerente g = new Gerente();
            g.Codigo = 123;

            Telefonista t = new Telefonista();
            t.Codigo = 456;

            cp.RegistraEntrada(g);
            cp.RegistraSaida(g);

            cp.RegistraEntrada(t);
            cp.RegistraSaida(t);

            Console.ReadKey();
        }
    }
}
