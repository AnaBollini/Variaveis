
// String para aramazenar texto

// Atalho de comentário: Ctrl + K + C
string nome = "Ana Clara Bollini";

// Tipo de variável para valores inteiros: 1,2 e etc
int idade = 16;

// Tipo de variável para valores decimais; 1.5, 2.5 e etc
float altura = 1.60f;
double preco = 17.5;
decimal saldo = 1000.50m;

// Tipo de variável para valores lógicos: true ou false
bool estudante = true;

// Tipo de variável para valores únicos: 'A', 'B' e etc
char genero = 'F';

// Tipo de variável para valores constantes: PI = 3.14
const double pi = 3.14;

// Forma 1
Console.WriteLine(nome);

// Forma 2 - Interpolação de strings
Console.WriteLine($"A {nome} tem {idade} anos");

// Forma 3 - Concatenação de strings
Console.WriteLine("A " + nome + " tem " + idade + " anos.");

// Utilizando \n para pular uma linha
// Semelhante ao <br> do HTML que já utilizamos
Console.WriteLine($"\n O valor de pi é: {pi}");




