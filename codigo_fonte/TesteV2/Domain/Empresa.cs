using TesteV2.Domain.Enum;

namespace TesteV2.Domain;
public class Empresa
{
    public string Nome { get; set; }

    public string Cnpj { get; set; }

    public TipoSituacao Situacao { get; set; }

    public decimal FaturamentoAnual { get; set; }

    public Empresa(string nome, string cnpj, TipoSituacao situacao, decimal faturamentoAnual)
    {
        Nome = nome;
        Cnpj = cnpj;
        Situacao = situacao;
        FaturamentoAnual = faturamentoAnual;
    }
}