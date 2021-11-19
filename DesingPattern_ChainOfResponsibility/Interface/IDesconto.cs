using DesingPattern_ChainOfResponsibility.Dominio;

namespace DesingPattern_ChainOfResponsibility.Interface
{
    public interface IDesconto
    {
        double Desconta(Orcamento orcamento);
        IDesconto Proximo { get; set; }
    }
}
