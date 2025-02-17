Console.WriteLine("Cálculo IMC");
Console.WriteLine("Digite seu Nome:");
string nome = Console.ReadLine();
Console.WriteLine("Digite seu Peso:");
double peso =Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite seu Altura:");
double altura = Convert.ToDouble(Console.ReadLine());

double imc = peso / Math.Pow(altura,2);

Console.WriteLine($"{nome} o seu IMC é de {imc}");

if  (imc > 30)
{
    Console.WriteLine("Você é Obesoooooooo");
}
else if (imc < 18.5)
{
    Console.WriteLine("Baixo peso");
}
else if (imc >= 18.5 &&  imc <= 24.9)
{
    Console.WriteLine("Peso normal");
}
else if (imc >=25 && imc <=29.9)
{
    Console.WriteLine("excesso de peso");
}

Console.ReadKey();