namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. Calcular o volume de uma caixa retangular.
                - Exemplo de entrada: Altura = 5, Largura = 3, Comprimento = 2
                - Fórmula: Volume = Altura * Largura * Comprimento
                - Exemplo de saída: O volume da caixa é 30 unidades cúbicas.*/

            double altura, largura, comprimento;

            Console.WriteLine("Calcule o volume da caixa!");

            Console.WriteLine("Digite a altura da caixa:");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a largura da caixa:");
            largura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o comprimento da caixa:");
            comprimento = Convert.ToDouble(Console.ReadLine());

            var volumeDaCaixa = altura * largura * comprimento;

            Console.WriteLine($"O volume da caixa é {volumeDaCaixa}");
            Console.ReadLine();

        }
    }
}
