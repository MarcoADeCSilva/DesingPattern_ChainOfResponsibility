using DesingPattern_ChainOfResponsibility.Dominio;
using DesingPattern_ChainOfResponsibility.Interface;

namespace DesingPattern_ChainOfResponsibility.Infraestrutura.Desconto
{
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            return 0;
        }
    }
}
