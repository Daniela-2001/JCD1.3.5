namespace JCD1._3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número de linhas ");

            int linhas = Convert.ToInt32(Console.ReadLine());

            string arvore = "*";

            int i = 1;

            do

            {
                Console.WriteLine(new String('*', i )); // Aqui o i vai multiplicar o valor do caractere (a quantidade de * corresponde com o número da linha)
                i++; // Aqui ele sempre somará mais 1
            }while (i < linhas);
        }
    }
}