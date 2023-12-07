using TesteV2.Domain;
using TesteV2.Domain.Enum;
using TesteV2.Services;
using TesteV2.Services.Interfaces;

IEmpresaService empresaService = new EmpresaService();

Tarefa01();
Tarefa02();
Tarefa03();
Tarefa04();
Tarefa05();
Tarefa06();

Console.ReadLine();
return;

void Tarefa01()
{
    //Tarefa 01: Ao utilizar o serviço EmpresaService para registrar quatro empresas, foi observado que o método Adicionar permite a inclusão de CNPJs duplicados na lista.
    //Como posso modificar este método para impedir a inserção de CNPJs repetidos?
    empresaService.Adicionar(new Empresa("Empresa BB", "00.000.000/0001-91", TipoSituacao.Ativo, 1000000));
    empresaService.Adicionar(new Empresa("Empresa Alpha", "12.345.678/0001-99", TipoSituacao.Ativo, 1000000));
    empresaService.Adicionar(new Empresa("Empresa Beta", "98.765.432/0001-88", TipoSituacao.Inativo, 500000));
    empresaService.Adicionar(new Empresa("Empresa Gama", "00.000.000/0001-91", TipoSituacao.Inativo, 500000));
    
    Console.WriteLine("Resultado tarefa 01:");
    empresaService.ImprimirInformacoes();
}

void Tarefa02()
{
    //Tarefa 02-A: Utilizar o serviço EmpresaService para para localizar e obter informações da empresa cujo CNPJ é 12.345.678/0001-99.
    Console.WriteLine("Resultado tarefa 02:");

    //Tarefa 02-B:Imprimir o nome da empresa encontrada.
    Console.WriteLine(Environment.NewLine);
}

void Tarefa03()
{
    //Tarefa 03: Utilizar o serviço EmpresaService para alterar o status da empresa com CNPJ 12.345.678/0001-99 para 'Inativo'.
    Console.WriteLine("Resultado tarefa 03:");
    empresaService.ImprimirInformacoes();
}

void Tarefa04()
{
    //Tarefa 04: Listar e exibir em tela todas as empresas com status 'Inativo'.
    Console.WriteLine("Resultado tarefa 04:");
}

void Tarefa05()
{
    //Tarefa 05: Utilizar o serviço EmpresaService para remover a empresa com CNPJ 98.765.432/0001-88.
    Console.WriteLine("Resultado tarefa 05:");
    empresaService.ImprimirInformacoes();
}

void Tarefa06()
{
    //Tarefa 06: A exibição do faturamento anual está sem o formato de moeda.
    //Qual seria a melhor maneira de incorporar o método FormatarMoeda da classe Util (localizada na pasta 'Utils') ao método ImprimirInformacoes?"
    Console.WriteLine("Resultado tarefa 06:");
    empresaService.ImprimirInformacoes();
}