namespace DsinLogicTesteGrt.Questoes;

public static class Questao01
{
    // Calcule o salário líquido em função de horas/dia, preço/hora e dias trabalhados.
    // Desconto de 3% sobre o salário bruto.
    public static void Executar()
    {
        const float desconto = 0.03f;

        float horas = LerFloat("Insira a quantidade de horas trabalhadas por dia: ", min: 0.1f);
        int dias    = LerInt("Insira a quantidade de dias trabalhados: ", min: 1);
        float valor_hora = LerFloat("Insira o valor da sua hora: ", min: 0.01f);

        float salario_bruto   = horas * dias * valor_hora;
        float salario_liquido = salario_bruto - (salario_bruto * desconto);

        System.Console.WriteLine($"Seu salário é de R$ {salario_liquido:F2}");
    }

    private static float LerFloat(string mensagem, float min)
    {
        while (true)
        {
            System.Console.Write(mensagem);
            if (float.TryParse(Console.ReadLine()?.Trim(), out float valor) && valor >= min)
                return valor;
            System.Console.WriteLine($"  Valor inválido. Informe um número maior que {min:F2}.");
        }
    }

    private static int LerInt(string mensagem, int min)
    {
        while (true)
        {
            System.Console.Write(mensagem);
            if (int.TryParse(Console.ReadLine()?.Trim(), out int valor) && valor >= min)
                return valor;
            System.Console.WriteLine($"  Valor inválido. Informe um número inteiro maior ou igual a {min}.");
        }
    }
}
