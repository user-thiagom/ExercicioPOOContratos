using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOOContratos.Services
{
    public class PaypalService : IServicoDePagamentoOnline
    {
        public double Taxa(double quantia, int mes)
        {
            return ((quantia * 0.01) * mes) + quantia;
        }

        public double TaxaDePagamento(double quantia)
        {
            return quantia * 1.02;
        }
    }
}
