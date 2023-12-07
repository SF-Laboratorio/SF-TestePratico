using System.Text;
using TesteV2.Domain;
using TesteV2.Domain.Enum;
using TesteV2.Services.Interfaces;
using TesteV2.Utils;

namespace TesteV2.Services;

public class EmpresaService : IEmpresaService
{
    private readonly List<Empresa> empresas = new();
    
    public void Adicionar(Empresa empresa)
    {
        empresas.Add(empresa);

        Util.GerarLogOperacao();
    }
    
    public Empresa? BuscarPorCnpj(string cnpj)
    {
        return empresas.FirstOrDefault(e => e.Cnpj == cnpj);
    }

    public void Atualizar(string cnpj, TipoSituacao novaSituacao)
    {
        var empresa = BuscarPorCnpj(cnpj);

        if (empresa == null)
        {
            return;
        }

        empresa.Situacao = novaSituacao;
        Util.GerarLogOperacao();
    }

    public void Remover(string cnpj)
    {
        var empresa = BuscarPorCnpj(cnpj);

        if (empresa != null)
        {
            empresas.Remove(empresa);
        }
        Util.GerarLogOperacao();
    }

    public IEnumerable<Empresa> ListarEmpresas()
    {
        return empresas;
    }

    public void ImprimirInformacoes()
    {
        var builder = new StringBuilder();
        foreach (var empresa in empresas)
        {
            ImprimirRegistro(builder, empresa);
        }
        Console.WriteLine(builder.ToString());
    }

    public void ImprimirInformacoes(List<Empresa> pEmpresas)
    {
        var builder = new StringBuilder();
        foreach (var empresa in pEmpresas)
        {
            ImprimirRegistro(builder, empresa);
        }
        Console.WriteLine(builder.ToString());
    }

    private static void ImprimirRegistro(StringBuilder builder, Empresa empresa)
    {
        builder.AppendLine(
            $"Nome: {empresa.Nome}, " +
            $"CNPJ: {empresa.Cnpj}, " +
            $"Situação: {empresa.Situacao}, " +
            $"Faturamento Anual: {empresa.FaturamentoAnual}");
    }
}