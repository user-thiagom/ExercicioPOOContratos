using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOOContratos.Services
{
    public interface IServicoDePagamentoOnline
    {
        public double TaxaDePagamento(double quantia);
        public double Taxa(double quantia, int mes);
    }
}
