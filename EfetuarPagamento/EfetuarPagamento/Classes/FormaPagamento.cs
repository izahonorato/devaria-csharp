using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfetuarPagamento.Classes
{
    class FormaPagamento
    {
        public virtual void EfetuarPagamento()
        {
            Console.WriteLine("Pagamento efetuado");
        }
    }

    class FormaPagamentoBoleto : FormaPagamento
    {
        public override void EfetuarPagamento()
        {
            Console.WriteLine("Pagamento efetuado com Boleto");
        }
    }

    class FormaPagamentoPix : FormaPagamento
    {
        public override void EfetuarPagamento()
        {
            Console.WriteLine("Pagamento efetuado com Pix");
        }
    }

    class FormaPagamentoCartaoCredito : FormaPagamento
    {
        public override void EfetuarPagamento()
        {
            Console.WriteLine("Pagamento efetuado com Cartão de crédito");
        }
    }

    class FormaPagamentoTransferencia : FormaPagamento
    {
        public override void EfetuarPagamento()
        {
            Console.WriteLine("Pagamento efetuado com Transferência");
        }
    }
}
