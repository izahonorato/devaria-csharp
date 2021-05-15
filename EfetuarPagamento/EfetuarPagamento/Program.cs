using EfetuarPagamento.Classes;
using EfetuarPagamento.Enums;
using System;


namespace EfetuarPagamento
{
    class Program
    {
        static void Main(string[] produtos)
        {
            if(produtos.Length == 0)
            {
                Console.WriteLine("Nenhum produto foi listado para compra");
                return;
            }

            Console.WriteLine("Favor informar a forma de pagamento (Boleto, Pix, CartaoCredito ou Transferencia)");
            var formaPagamentoDesejada = Console.ReadLine();

            if(string.IsNullOrEmpty(formaPagamentoDesejada) ||string.IsNullOrWhiteSpace(formaPagamentoDesejada)
                || (TipoPagamentoEnum.Boleto.ToString() != formaPagamentoDesejada 
                && TipoPagamentoEnum.Pix.ToString() != formaPagamentoDesejada
                && TipoPagamentoEnum.CartaoCredito.ToString() != formaPagamentoDesejada
                && TipoPagamentoEnum.Transferencia.ToString() != formaPagamentoDesejada))
            {
                Console.WriteLine($"A forma de pagamento {formaPagamentoDesejada} não é válida! ");
                return;
            }

            FormaPagamento formaPagamento;
            if (TipoPagamentoEnum.Boleto.ToString() == formaPagamentoDesejada)
            {
                formaPagamento = new FormaPagamentoBoleto();
            }else if(TipoPagamentoEnum.Pix.ToString() == formaPagamentoDesejada)
            {
                formaPagamento = new FormaPagamentoPix();
            }else if(TipoPagamentoEnum.CartaoCredito.ToString() == formaPagamentoDesejada)
            {
                formaPagamento = new FormaPagamentoCartaoCredito();
            }else if(TipoPagamentoEnum.Transferencia.ToString() == formaPagamentoDesejada)
            {
                formaPagamento = new FormaPagamentoTransferencia();
            }
            else
            {
                Console.WriteLine($"A forma de pagamento: {formaPagamentoDesejada} não é válida!");
                return;
            }

            if(formaPagamento != null)
            {
                formaPagamento.EfetuarPagamento();
            }

        }
    }
}
