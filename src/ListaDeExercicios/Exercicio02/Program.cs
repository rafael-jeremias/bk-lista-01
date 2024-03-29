namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Converter a temperatura de graus Fahrenheit para graus Celsius.
            Exemplo de entrada: Temperatura em Fahrenheit = 68
            Fórmula: Celsius = (Fahrenheit - 32) * 5 / 9
            Exemplo de saída: A temperatura em Celsius é 20 °C
            */
            
            Console.Write("Digite a temperatura em Fahrenheit: ");

            double fahrenheit = double.Parse(Console.ReadLine()); 
            
            double celsius = (fahrenheit - 32) * 5 / 9;
                        
            Console.WriteLine("Temperatura em Celsius: {0}", celsius + "°C");
            Console.ReadKey();
        }
    }
}
