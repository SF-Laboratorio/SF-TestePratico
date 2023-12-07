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
    // Tarefa 01 - Quando invoco o serviço EmpresaService para adicionar quatro empresas, o programa deixa incluir CNPJ repetido.
    // Qual seria a solução para não permitir inserção de CNPJ repetido?
    empresaService.Adicionar(new Empresa("Empresa BB", "00.000.000/0001-91", TipoSituacao.Ativo, 1000000));
    empresaService.Adicionar(new Empresa("Empresa Alpha", "12.345.678/0001-99", TipoSituacao.Ativo, 1000000));
    empresaService.Adicionar(new Empresa("Empresa Beta", "98.765.432/0001-88", TipoSituacao.Inativo, 500000));
    empresaService.Adicionar(new Empresa("Empresa Gama", "00.000.000/0001-91", TipoSituacao.Inativo, 500000));

    Console.WriteLine("Resultado tarefa 01:");
    empresaService.ImprimirInformacoes();
}

void Tarefa02()
{
    // Tarefa 02 - Chamar o serviço EmpresaService e buscar a empresa com CNPJ 12.345.678/0001-99.
    var empresa = empresaService.BuscarPorCnpj("12.345.678/0001-99");

    Console.WriteLine("Resultado tarefa 02:");
    //Imprimir o nome da empresa encontrada.
    Console.WriteLine($"Empresa encontrada: {empresa?.Nome}");
    Console.WriteLine(Environment.NewLine);
}

void Tarefa03()
{
    // Tarefa 03 - Chamar o serviço EmpresaService e atualizar a empresa com CNPJ 12.345.678/0001-99 para a situação Inativo.
    empresaService.Atualizar("12.345.678/0001-99", TipoSituacao.Inativo);
    
    Console.WriteLine("Resultado tarefa 03:");
    //Listar todas as empresas INATIVAS.
    empresaService.ImprimirInformacoes();
}

void Tarefa04()
{
    // Tarefa 04 - Listar todas as empresas INATIVAS e imprimir na tela.
    var empresasInivativas = empresaService.ListarEmpresas().Where(e => e.Situacao == TipoSituacao.Inativo).ToList();

    Console.WriteLine("Resultado tarefa 04:");
    empresaService.ImprimirInformacoes(empresasInivativas);
}

void Tarefa05()
{
    // Tarefa 05 - Chamar o serviço EmpresaService e remover a empresa com CNPJ 98.765.432/0001-88.
    empresaService.Remover("98.765.432/0001-88");

    Console.WriteLine("Resultado tarefa 05:");
    empresaService.ImprimirInformacoes();
}

void Tarefa06()
{
    //Tarefa 06 - A impressão do faturamento anual está sem formato de moeda.
    //Como você faria para utilizar o método FormatarMoeda da classe Util para imprimir o faturamento anual?

    Console.WriteLine("Resultado tarefa 06:");
    empresaService.ImprimirInformacoes();
}