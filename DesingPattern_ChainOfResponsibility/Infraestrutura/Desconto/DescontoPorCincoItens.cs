using DesingPattern_ChainOfResponsibility.Dominio;
using DesingPattern_ChainOfResponsibility.Interface;

namespace DesingPattern_ChainOfResponsibility.Infraestrutura.Desconto
{
    public class DescontoPorCincoItens : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
                return orcamento.Valor * 0.1;
            else
                return Proximo.Desconta(orcamento);
        }
    }
}
