using Decola_Tech_2024.Models; // colar o namespace para o programa reconhecer a classe

/*
→ A diferença entre uma lista e array são os métodos
→ uma lista é como se fosse uma extensão de um array
→ na lista você não precisa se preocupar em gerenciar a capacidade

// LISTAS
//criando uma lista sem determinar a capacidade máxima
List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("RS");

Console.WriteLine($"Itens da minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Add("SC");

Console.WriteLine($"Itens da minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

listaString.Remove("BA"); // serve para remover e reordenar

Console.WriteLine($"Itens da minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");

// PERCORRENDO A LISTA COM O FOR
//                                count = length
for(int contador = 0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Posição Nº {contador} - {listaString[contador]}");
}

// PERCORRENDO A LISTA COM FOREACH
foreach(string item in listaString)
{
    Console.WriteLine($"{item}");
}
*/


/*
// ARRAYS
// O array nasce e morre com uma capacidade fixa, apesar de poder redimensioná-lo com o resize

int[] arrayInteiros = new int[4];
//int[] arrayInteiros = {72, 64, 50, 1};
//int[] arrayInteiros = new int[]{72, 64, 50, 1};

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
arrayInteiros[3] = 1;

// Resize: cria uma cópia do array antigo com um novo array
//          referência arrayInteiros             4 * 2
Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

// Copy: copia o array antigo e coloca ele em uma nova variável 
int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// se precisa do valor do contador = FOR; se NÃO precisa do valor do contador = FOREACH
Console.WriteLine("PERCORRENDO O ARRAY COM FOR");
for(int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição nº {contador} - {arrayInteiros[contador]}");
}

Console.WriteLine("PERCORRENDO O ARRAY COM FOREACH");
int contadorForeach = 0;
foreach(int valor in arrayInteiros)
{
    Console.WriteLine($"Posição nº {contadorForeach} - {valor}");
    contadorForeach++;
}
*/


/*
// MENU INTERATIVO
string opcao
bool exibirMenu = true;

while(exibirMenu)
{   
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastras cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;
        case "2":
            Console.WriteLine("Busca de cliente");
            break;
        case "3":
            Console.WriteLine("Apagar cliente");
            break;
        case "4":
            Console.WriteLine("Encerrar");
            exibirMenu = false; // dessa forma sai do menu, mas continua executando o código abaixo
            // Environment.Exit(0);  // encerra o programa e não executa mais nada abaixo
            break;
        default:
            Console.WriteLine("Opção inválida.");
            continue;
    }
}
*/


/*
//ESTRUTURA DE REPETIÇÃO DO WHILE
// no WHILE verifica primeiro a condição e faz o loop,
// no DO WHILE executa pelo menos uma vez o código,
// independente da condição

int soma = 0, numero = 0;

do
{
    Console.WriteLine("Digite um número [0 para parar]");
    numero = Convert.ToInt32(Console.ReadLine());
    soma += numero;
} while(numero != 0);

Console.WriteLine($"Soma total dos números digitados: {soma}");
*/


/*
// ESTRUTURA DE REPETIÇÃO WHILE
int numero = 5;
int contador = 0;

while (contador <= 10)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
    contador++;
    if (contador == 5)
        break;
}
*/


/*
// ESTRUTURA DE REPETIÇÃO FOR
int numero = 5;

for (int contador = 0; contador <= 10; contador++)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
}
*/


/*
// INCREMENTO E DECREMENTO
int numeroIncremento = 10;

Console.WriteLine(numeroIncremento);
Console.WriteLine("Incrementando o 10");
numeroIncremento++;
Console.WriteLine(numeroIncremento);

int numeroDecremento = 20;
Console.WriteLine("Decrementando o 20");
numeroDecremento--;
Console.WriteLine(numeroDecremento);
*/


/*
// UTILIZANDO A CLASSE CALCULADORA
Calculadora calculadora = new Calculadora();

calculadora.Somar(10, 30);
calculadora.Subtrair(10, 50);
calculadora.Multiplicar(15, 45);
calculadora.Dividir(2, 2);
calculadora.Potencia(3, 3);
calculadora.Seno(30);
calculadora.Coseno(30);
calculadora.Tangente(30);
calculadora.RaizQuadrada(9);
*/


/*
// OPERADOR NOT !
// negar uma operação
bool choveu = false;
bool estaTarde = false;

if (!choveu && !estaTarde) // se NÃO choveu / se NÃO está tarde
{
    Console.WriteLine("Vou pedalar.");
}
else
{
    Console.WriteLine("Vou pedalar outro dia.");
}
*/


/*
// OPERADOR AND &&
// executa apenas se TODAS as condições forem verdadeiras
bool possuiPresencaMinima = true;
double media = 7.5;

if (possuiPresencaMinima && media >= 7)
{
    Console.WriteLine("Aprovado!");
}
else
{
    Console.WriteLine("Reprovado!");
}
*/


/*
// OPERADOR OR ||
// executa se ao menos uma condição é verdadeira
bool ehMaiorDeIdade = true;
bool possuiAutorizacaoDoResponsavel = false;

if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
{
    Console.WriteLine("Entrada liberada!");
}
else
{
    Console.WriteLine("Entrada não liberada!");
}
*/


/*
// SWITCH CASE
// se você tem muitos else if, considere usar o switch
Console.WriteLine("Digite uma letra: ");
string letra = Console.ReadLine();

// verificando se é vogal com o SWITCH
switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vogal");
        break;
    default:
        Console.WriteLine("Não é uma vogal");
        break;
}

// verificando se é vogal com o IF (|| = pipe)
// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal");
// }
*/


/*
// OPERADOR CONDICIONAL IF e IF ANINHADO
int quantidadeEmEstoque = 3;
int quantidadeCompra = 0;
bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

if (quantidadeCompra == 0)
{
    Console.WriteLine("Venda inválida.");
}
else if (possivelVenda)
{
    Console.WriteLine("Venda realizada.");
}
else
{
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
}
*/


/* // CONVERTENDO DE MANEIRA SEGURA
// o TryParse já espera um erro, então não para o programa na metade
string a = "15-";
// int b = 0;

int.TryParse(a, out int b); // cria uma nova variável(int b) e sai como padrão o número 0
Console.WriteLine(b);
*/


/* // ORDEM DOS OPERADORES
double a = 4 / 2 + 2;  // res = 4 obedece a ordem matemática
// passar a prioridade entre parênteses, ex: 4 / (2 + 2)
Console.WriteLine(a);
*/


/* // CAST IMPLÍCITO
int a = 5;
double b = a;

long c = long.MaxValue;  // valor máximo de um long

// um inteiro cabe no double e no long, então implicitamente ele faz essa conversão
// já um long e double podem ter valores que o int não suporta, então não converte

int d = int.MaxValue; // valor máximo de um inteiro
long e = d;

Console.WriteLine(c);
*/


/* // TO STRING
int inteiro = 5;
string a = inteiro.ToString();  // todo tipo pode ser convertido para string

Console.WriteLine(a);
*/


/* // Cast/Casting  - converte um dado para outro tipo
int a = Convert.ToInt32("5");
int b = int.Parse("5");
// int c = Convert.ToInt32(null); // usar o convert com null, pois com o Parse dá erro e encerra o programa

Console.WriteLine(a);
Console.WriteLine(b);
*/


/* // OPERADORES
int a = 10;
int b = 20;
int c = a + b;
c += 5;  // c = c + 5;

Console.WriteLine(c);
*/


/* // DATETIME
DateTime dataAtual = DateTime.Now.AddDays(5); // adiciona 5 dias na data atual
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));  // imprime apenas a data e o horário, sem os segundos
*/


/* // VARIÁVEIS
string apresentacao = "Olá, seja bem vindo";

int quantidade = 1;
Console.WriteLine("Valor da variável quantidade: " + quantidade);

quantidade = 10;  // mudando o valor da variável
Console.WriteLine("Valor da variável quantidade: " + quantidade);

double altura = 1.80;
decimal preco = 1.80M;
bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variável quantidade: " + quantidade);
Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
Console.WriteLine("Valor da variável preço: " + preco);
Console.WriteLine("Valor da variável condição: " + condicao);
*/


/*  // CLASSE
Pessoa pessoa = new Pessoa();

pessoa.Nome = "Michele";
pessoa.Idade = 29;
pessoa.Apresentar();
*/
