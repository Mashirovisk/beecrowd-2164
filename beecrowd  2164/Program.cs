using System.Security.Cryptography.X509Certificates;

int n = int.Parse(Console.ReadLine());

while (n < 0 || n >= 50)
{
    Console.WriteLine("Digite um número válido: ");
     n = int.Parse(Console.ReadLine());
}


double x = (1 + Math.Sqrt(5)) /2;

double y = (1 - Math.Sqrt(5)) /2;

double conta = (Math.Pow(x,n) - Math.Pow(y,n)) / Math.Sqrt(5);

int resultado = (int)Math.Round(conta);

Console.WriteLine(resultado);