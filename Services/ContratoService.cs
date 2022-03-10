using ExercicioPOOContratos.Enrtities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOOContratos.Services
{
    public class ContratoService
    {
        public IServicoDePagamentoOnline ServicoDePagamento { get; private set; }

        public ContratoService(IServicoDePagamentoOnline servicoDePagamento)
        {
            ServicoDePagamento = servicoDePagamento;
        }

        public void ProcessarContrato(Contrato contrato, int qtdMeses)
        {
            double valorBasicoDaParcela = (double) contrato.ValorTotal / 3;

            for (int i = 1; i <= qtdMeses; i++)
            {
                DateTime dataPrestacao = contrato.Data.AddMonths(i);
                double valorDaPrestacao = ServicoDePagamento.Taxa(valorBasicoDaParcela, i);
                valorDaPrestacao = ServicoDePagamento.TaxaDePagamento(valorDaPrestacao);
                contrato.Prestacoes.Add(new Prestacao(dataPrestacao, valorDaPrestacao));
            }
        }
    }
}
