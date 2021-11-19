using DesingPattern_ChainOfResponsibility.Dominio;
using DesingPattern_ChainOfResponsibility.Infraestrutura.Desconto;
using DesingPattern_ChainOfResponsibility.Interface;

namespace DesingPattern_ChainOfResponsibility.Servico
{
    public class CalculadorDeDesconto
    {
        public double Calcula(Orcamento orcamento)
        {
            IDesconto d1 = new DescontoPorCincoItens();
            IDesconto d2 = new DescontoPorMaisDeQuinhentosReais();
            IDesconto d3 = new DescontoPorVendaCasada();
            IDesconto d4 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = d4;

            return d1.Desconta(orcamento);
        }
    }
}
