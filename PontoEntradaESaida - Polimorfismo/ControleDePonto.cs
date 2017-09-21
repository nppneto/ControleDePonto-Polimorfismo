using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontoEntradaESaida___Polimorfismo
{
    class ControleDePonto
    {
        public void RegistraEntrada(Funcionario f)
        {
            DateTime agora = DateTime.Now;
            string horario = string.Format("{0:d/MM/yyyy HH:mm:ss}", agora);

            Console.WriteLine("DATA ENTRADA: " + horario);
            Console.WriteLine("FUNCIONÁRIO: " + f.Codigo);
        }

        public void RegistraSaida(Funcionario f)
        {
            DateTime agora = DateTime.Now;
            string horario = string.Format("{0:d/MM/yyyy HH:mm:ss}", agora);

            Console.WriteLine("\nDATA SAÍDA: " + horario);
            Console.WriteLine("FUNCIONÁRIO: " + f.Codigo);
            Console.WriteLine("-------------------------------------------");
        }
    }
}
