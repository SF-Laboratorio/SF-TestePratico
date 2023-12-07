namespace TesteV2.Utils;

public static class Util
{
    public static void GerarLogOperacao()
    {
        //Log de operação gerado com sucesso!
    }

    private static string FormatarMoeda(decimal valor)
    {
        var resultado = valor.ToString("C", new System.Globalization.CultureInfo("pt-BR"));

        return resultado;
    }
}