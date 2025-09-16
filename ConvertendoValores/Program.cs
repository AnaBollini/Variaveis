// Variáveis sem valor inicial
string nome;
int idade;
char sexo;
double salario;


Console.WriteLine("Digite seu nome:");
nome = Console.ReadLine();

// Convertendo o valor que foi digitado para o tipo Int16 (int)
Console.WriteLine("Digite sua idade:");
idade = Convert.ToInt16(Console.ReadLine());

// Convertendo o valor que foi digitado para o tipo Char
Console.WriteLine("Qual é o seu sexo: M ou F");
sexo = Convert.ToChar(Console.ReadLine().ToUpper());

// Convertendo o valor que foi digitado para o tipo Double
Console.WriteLine("Digite seu salário:");
salario = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"O seu nome é {nome}, você tem {idade} anos, seu sexo é {sexo}, e seu salário é: R${salario},00");



