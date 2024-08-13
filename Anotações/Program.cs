using System;

Tipos de variáveis que usamos:

----------------------------------------------------------------------------------------------------------------------------

String: Variáveis de texto

Int: Variável de números inteiros

Float: Variável de números decimais
----------------------------------------------------------------------------------------------------------------------------
Tipos de escreva:

Console.Write: Escreva na mesma linha

Console.WriteLine: Escreva e pule uma linha
----------------------------------------------------------------------------------------------------------------------------

Tipos de leia:

Console.Readline: Leia uma linha de inserção de dados

Console.Read: Leia até Enter

Console.ReadKey: Leia uma tecla
----------------------------------------------------------------------------------------------------------------------------
int.Parse é um metodo usado para converter uma string que representa um número inteiro em um valor do tipo int
Se a string passada para int.Parse contiver uma representação válida de um número inteiro, a conversão será bem-sucedida
----------------------------------------------------------------------------------------------------------------------------
Casos:

if: é usado para executar um bloco de código caso uma condição seja verdadeira

EXEMPLO IF
int x = 10;
if (x > 5)
{
    Console.WriteLine("x é maior que 5");
}
----------------------------------------------------------------------------------------------------------------------------
else if: else if permite verificar varias condições em sequência

EXEMPLO ELSE IF
int x = 10;
if (x > 15)
{
    Console.WriteLine("x é maior que 15");
}
else if (x > 5)
{
    Console.WriteLine("x é maior que 5, mas menor ou igual a 15");
}
----------------------------------------------------------------------------------------------------------------------------
else: é usada para definir um blooco de código a ser executado caso todas as outras condições sejam falsas

EXEMPLO ELSE
int x = 2;
if (x > 5)
{
    Console.WriteLine("x é maior que 5");
}
else
{
    Console.WriteLine("x é menor ou igual a 5");
}
----------------------------------------------------------------------------------------------------------------------------
switch: é usada para selecionar um bloco de código para ser executado entre várias alternativas, baseado no valor da expressão

EXEMPLO SWITCH

int day = 3;
switch (day)
{
    case 1:
        Console.WriteLine("Domingo");
        break;
    case 2:
        Console.WriteLine("Segunda-feira");
        break;
    case 3:
        Console.WriteLine("Terça-feira");
        break;
    default:
        Console.WriteLine("Outro dia");
        break;
}


----------------------------------------------------------------------------------------------------------------------------
for: é usada para repetir um bloco de código um número expecifico de vezes

EXEMPLO FOR
for (int i = 0; i < 5; i++)
    {
        Console.WriteLine("i = " + i);
    }

----------------------------------------------------------------------------------------------------------------------------

Try -catch: É usada pra lidar com exceções em tempo de execução, o código que pode gerar um erro é colocado dentro do bloco try e o bloco catch é usado para coletar e lidar com a exceção

EXEMPLO TRY-CATCH

try
{
    int[] numbers = { 1, 2, 3 };
Console.WriteLine(numbers[5]);
}
catch (IndexOutOfRangeException e)
{
    Console.WriteLine("Erro: " + e.Message);
}

