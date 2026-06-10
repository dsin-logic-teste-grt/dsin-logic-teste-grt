using DsinLogicTesteGrt.Questoes;

var questoes = new Dictionary<string, (string Titulo, Action Executar)>
{
    ["1"]  = ("Cálculo de Salário Líquido",           Questao01.Executar),
    ["2"]  = ("Validação de Valores A, B, C e D",     Questao02.Executar),
    ["3"]  = ("Decomposição em Notas",                Questao03.Executar),
    ["4"]  = ("Equação AX + BX + C = 1",             Questao04.Executar),
    ["5"]  = ("Identificação de Placa Mercosul",      Questao05.Executar),
    ["6"]  = ("Sequência com Classificação de 1 a N", Questao06.Executar),
    ["7"]  = ("Título Formatado e Centralizado",      Questao07.Executar),
    ["8"]  = ("Matriz Caracol",                       Questao08.Executar),
    ["12"] = ("Programe um Pato",                     Questao12.Executar),
};

while (true)
{
    Console.Clear();
    Console.WriteLine("╔══════════════════════════════════════════════╗");
    Console.WriteLine("║         TESTE DSIN — Gabriel Trindade        ║");
    Console.WriteLine("║         Desenvolvedor de Software Sênior      ║");
    Console.WriteLine("╚══════════════════════════════════════════════╝");
    Console.WriteLine();

    foreach (var (key, (titulo, _)) in questoes)
        Console.WriteLine($"  [{key,2}] {titulo}");

    Console.WriteLine();
    Console.WriteLine("   [0]  Sair");
    Console.WriteLine();
    Console.Write("Escolha uma questão: ");

    var entrada = Console.ReadLine()?.Trim();

    if (entrada == "0" || entrada == null) break;

    if (!questoes.TryGetValue(entrada, out var questao))
    {
        Console.WriteLine("\nQuestão não encontrada. Pressione qualquer tecla...");
        Console.ReadKey();
        continue;
    }

    Console.Clear();
    Console.WriteLine($"══ Questão {entrada}: {questao.Titulo} ══");
    Console.WriteLine();

    questao.Executar();

    Console.WriteLine();
    Console.Write("Pressione qualquer tecla para voltar ao menu...");
    Console.ReadKey();
}
