using TesteV2.Domain;
using TesteV2.Domain.Enum;

namespace TesteV2.Services.Interfaces;

public interface IEmpresaService
{
    void Adicionar(Empresa empresa);

    Empresa? BuscarPorCnpj(string cnpj);

    void Atualizar(string cnpj, TipoSituacao novaSituacao);

    void Remover(string cnpj);

    IEnumerable<Empresa> ListarEmpresas();

    void ImprimirInformacoes();

    void ImprimirInformacoes(List<Empresa> empresas);
}