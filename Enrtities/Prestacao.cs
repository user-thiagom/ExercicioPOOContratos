using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOOContratos.Enrtities
{
    public class Prestacao
    {
        public DateTime DataVencimento { get; set; }
        public double Valor { get; set; }

        public Prestacao(DateTime dataVencimento, double valor)
        {
            DataVencimento = dataVencimento;
            Valor = valor;
        }

        public override string ToString()
        {
            return $"{DataVencimento} - {Valor}";
        }
    }
}
