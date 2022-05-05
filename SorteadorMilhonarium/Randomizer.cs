using SorteadorMilhonarium;
Console.SetWindowSize(105, 40);
Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Black;
Console.Clear();
Console.Title = "S.I.M - Sorteador Inteligente Milhonarium 0.5.1"; // Nome do Programa

#region Variaveis 
Random dado = new Random();
int numeroSorteado = dado.Next(1, 11);

int primeiroNumP1 = 0;
int segundoNumP1 = 0;
int terceiroNumP1 = 0;

int primeiroNumP2 = 0;
int segundoNumP2 = 0;
int terceiroNumP2 = 0;

int primeiroNumP3 = 0;
int segundoNumP3 = 0;
int terceiroNumP3 = 0;

int primeiroNumP4 = 0;
int segundoNumP4 = 0;
int terceiroNumP4 = 0;

int primeiroNumP5 = 0;
int segundoNumP5 = 0;
int terceiroNumP5 = 0;
//----------------------------------Variaveis dos Vencedores-------------------------------//
int numeroWinP1 = 0;
int numeroWinP2 = 0;
int numeroWinP3 = 0;
int numeroWinP4 = 0;
int numeroWinP5 = 0;

//--------------------------------------Variaveis Pessoas----------------------------------//              
int numDeVencedores = 0;
int valorDoPremio = 1_000_000; // Valor do Sorteio 
double premioConsolo = 0.1 * valorDoPremio;
int bonusPar = 500;
int bonus7 = 700_000;
int bonus100 = 100;
bool par = numeroSorteado % 2 == 0;
int anoAtual = DateTime.Today.Year; // Ano atual
int qualificados = 0;

#endregion Variaveis

#region Cadastro dos Participantes 
Console.WriteLine("\t\t\t\t\t Cadastro dos Participantes" + "\n");

Console.WriteLine(" Digite o nome completo do Primeiro participante");
string nome1 = Console.ReadLine();
Console.WriteLine($"Digite o Ano de nascimento de {nome1}");
int idade1 = (anoAtual - int.Parse(Console.ReadLine()));
bool status1 = (idade1 >= 18);
if (status1 == false)
{
    Console.WriteLine($" {nome1} não esta Qualificado(a) para participar do Sorteio");
    Thread.Sleep(4000);
}
else if (status1)
{
    Console.WriteLine($" Peça a {nome1} para informar 3 numeros inteiros entre 1 a 10");
    primeiroNumP1 = int.Parse(Console.ReadLine());
    segundoNumP1 = int.Parse(Console.ReadLine());
    terceiroNumP1 = int.Parse(Console.ReadLine());
}
Console.Clear();

Console.WriteLine(" Digite o nome completo do Segundo participante");
string nome2 = Console.ReadLine();
Console.WriteLine($" Digite o Ano de nascimento de {nome2}");
int idade2 = (anoAtual - int.Parse(Console.ReadLine()));
bool status2 = (idade2 >= 18);
if (status2 == false)
{
    Console.WriteLine($" {nome2} não esta Qualificado(a) para participar do Sorteio");
    Thread.Sleep(3000);
}
else if (status2)
{
    Console.WriteLine($" Peça a {nome2} para informar 3 numeros inteiros entre 1 a 10");
    primeiroNumP2 = int.Parse(Console.ReadLine());
    segundoNumP2 = int.Parse(Console.ReadLine());
    terceiroNumP2 = int.Parse(Console.ReadLine());
}
Console.Clear();

Console.WriteLine(" Digite o nome completo do Terceiro participante");
string nome3 = Console.ReadLine();
Console.WriteLine($" Digite o Ano de nascimento de {nome3}");
int idade3 = (anoAtual - int.Parse(Console.ReadLine()));
bool status3 = (idade3 >= 18);
if (status3 == false)
{
    Console.WriteLine($" {nome3} não esta Qualificado(a) para participar do Sorteio");
    Thread.Sleep(3000);
}
else if (status3)
{
    Console.WriteLine($" Peça a {nome3} para informar 3 numeros inteiros entre 1 a 10");
    primeiroNumP3 = int.Parse(Console.ReadLine());
    segundoNumP3 = int.Parse(Console.ReadLine());
    terceiroNumP3 = int.Parse(Console.ReadLine());
}
Console.Clear();

Console.WriteLine(" Digite o nome completo do Quarto participante");
string nome4 = Console.ReadLine();
Console.WriteLine($" Digite o Ano de nascimento de {nome4}");
int idade4 = (anoAtual - int.Parse(Console.ReadLine()));
bool status4 = (idade4 >= 18);
if (status4 == false)
{
    Console.WriteLine($" {nome4} não esta Qualificado(a) para participar do Sorteio");
    Thread.Sleep(3000);
}
else if (status4)
{
    Console.WriteLine($" Peça a {nome4} para informar 3 numeros inteiros entre 1 a 10");
    primeiroNumP4 = int.Parse(Console.ReadLine());
    segundoNumP4 = int.Parse(Console.ReadLine());
    terceiroNumP4 = int.Parse(Console.ReadLine());
}
Console.Clear();

Console.WriteLine(" Digite o nome completo do Quinto participante");
string nome5 = Console.ReadLine();
Console.WriteLine($" Digite o Ano de nascimento de {nome5}");
int idade5 = (anoAtual - int.Parse(Console.ReadLine()));
bool status5 = (idade5 >= 18);
if (status5 == false)
{
    Console.WriteLine($" {nome5} não esta Qualificado(a) para participar do Sorteio");
    Thread.Sleep(3000);
}
else if (status5)
{
    Console.WriteLine($" Peça a {nome5} para informar 3 numeros inteiros entre 1 a 10");
    primeiroNumP5 = int.Parse(Console.ReadLine());
    segundoNumP5 = int.Parse(Console.ReadLine());
    terceiroNumP5 = int.Parse(Console.ReadLine());
}
Console.Clear();

#endregion Cadastro dos Participantes

#region Dado (random) 
Console.Write("Preparando Dado.");
Thread.Sleep(1000);
Console.Write(".");
Thread.Sleep(1000);
Console.Write(".");
Thread.Sleep(1000);
Console.Write(".");
Thread.Sleep(700);
Console.Clear();
Console.Write("Iniciando Sorteio..");
Console.Write(".");
Thread.Sleep(1000);
Console.Write(".");
Thread.Sleep(1000);
Console.WriteLine(".");
Thread.Sleep(1000);
Console.WriteLine($" O numero Sorteado foi: {numeroSorteado}\n");
#endregion 

#region Junção dos Numeros
if (numeroSorteado == primeiroNumP1 || numeroSorteado == segundoNumP1 || numeroSorteado == terceiroNumP1)
{
    Console.WriteLine($" {nome1} Acertou o numero sorteado {numeroSorteado}\n");
    numeroWinP1 = numeroSorteado;

}

if (numeroSorteado == primeiroNumP2 || numeroSorteado == segundoNumP2 || numeroSorteado == terceiroNumP2)
{
    Console.WriteLine($" {nome2} Acertou o numero sorteado {numeroSorteado}\n");
    numeroWinP2 = numeroSorteado;

}

if (numeroSorteado == primeiroNumP3 || numeroSorteado == segundoNumP3 || numeroSorteado == terceiroNumP3)
{
    Console.WriteLine($" {nome3} Acertou o numero sorteado {numeroSorteado} \n");
    numeroWinP3 = numeroSorteado;

}

if (numeroSorteado == primeiroNumP4 || numeroSorteado == segundoNumP4 || numeroSorteado == terceiroNumP4)
{
    Console.WriteLine($" {nome4} Acertou o numero sorteado {numeroSorteado} \n");
    numeroWinP4 = numeroSorteado;

}

if (numeroSorteado == primeiroNumP5 || numeroSorteado == segundoNumP5 || numeroSorteado == terceiroNumP5)
{
    Console.WriteLine($" {nome5} Acertou o numero sorteado {numeroSorteado}\n");
    numeroWinP5 = numeroSorteado;

}
#endregion Junção dos Numeros

#region Contagem dos Ganhadores
if (numeroWinP1 > 0)
{
    numDeVencedores++;
}
if (numeroWinP2 > 0)
{
    numDeVencedores++;
}
if (numeroWinP3 > 0)
{
    numDeVencedores++;
}
if (numeroWinP4 > 0)
{
    numDeVencedores++;
}
if (numeroWinP5 > 0)
{
    numDeVencedores++;
}
#endregion Contagem dos Ganhadores

#region Contagem dos Qualificados

if (status1 = true)
    qualificados++;
if (status2 = true)
    qualificados++;
if (status3 = true)
    qualificados++;
if (status4 = true)
    qualificados++;
if (status5 = true)
    qualificados++;

#endregion Contagem Qualificados

#region Premiação
if (numDeVencedores == 5)
{
    #region Variaveis 5 Wins bonus 100
    int valorDoPremioDivididoPara5 = valorDoPremio / 5;

    int totalBonus100_1 = (valorDoPremioDivididoPara5 + bonus100 * idade1);
    int totalBonus100_2 = (valorDoPremioDivididoPara5 + bonus100 * idade2);
    int totalBonus100_3 = (valorDoPremioDivididoPara5 + bonus100 * idade3);
    int totalBonus100_4 = (valorDoPremioDivididoPara5 + bonus100 * idade4);
    int totalBonus100_5 = (valorDoPremioDivididoPara5 + bonus100 * idade5);
    #endregion

    Console.WriteLine(" Todos acertaram o numero sorteado\n" +
                      " O valor do premio será Dividido igualmente entre os participantes.\n" +
                      " E cada um receberá um bônus de R$ 100,00 por cada ano da idade");

    if (par)
    {
        #region Variaveis 5 Wins numero Par
        int totalBonusPar_bonus100_5 = (valorDoPremioDivididoPara5 + bonusPar + bonus100 * idade5);
        int totalBonusPar_bonus100_4 = (valorDoPremioDivididoPara5 + bonusPar + bonus100 * idade4);
        int totalBonusPar_bonus100_3 = (valorDoPremioDivididoPara5 + bonusPar + bonus100 * idade3);
        int totalBonusPar_bonus100_2 = (valorDoPremioDivididoPara5 + bonusPar + bonus100 * idade2);
        int totalBonusPar_bonus100_1 = (valorDoPremioDivididoPara5 + bonusPar + bonus100 * idade1);
        #endregion

        Console.WriteLine(" Como o numero sorteado foi um numero Par\n" +
            " Os participantes vencedores receberão o valor de R$ 500,00 a mais cada um!");
        Console.WriteLine($" {nome1} recebera = {totalBonusPar_bonus100_1.ToString("R$ 000,000.00")} \n");
        Console.WriteLine($" {nome2} recebera = {totalBonusPar_bonus100_2.ToString("R$ 000,000.00")} \n");
        Console.WriteLine($" {nome3} recebera = {totalBonusPar_bonus100_3.ToString("R$ 000,000.00")} \n");
        Console.WriteLine($" {nome4} recebera = {totalBonusPar_bonus100_4.ToString("R$ 000,000.00")} \n");
        Console.WriteLine($" {nome5} recebera = {totalBonusPar_bonus100_5.ToString("R$ 000,000.00")} \n");

        Thread.Sleep(7000);
        Console.WriteLine(" Aperte Qualquer Tecla para Finalizar");
        Console.ReadKey();

    }
    else
    {
        Console.WriteLine($" {nome1} recebera: {totalBonus100_1.ToString("R$ 000,000.00")}");
        Console.WriteLine($" {nome2} recebera: {totalBonus100_2.ToString("R$ 000,000.00")}");
        Console.WriteLine($" {nome3} recebera: {totalBonus100_3.ToString("R$ 000,000.00")}");
        Console.WriteLine($" {nome4} recebera: {totalBonus100_4.ToString("R$ 000,000.00")}");
        Console.WriteLine($" {nome5} recebera: {totalBonus100_5.ToString("R$ 000,000.00")}");

        Thread.Sleep(7000);
        Console.WriteLine(" Aperte Qualquer Tecla para Finalizar");
        Console.ReadKey();
    }
}

else if (numDeVencedores == 4)
{
    #region Variaveis 4 Wins bonus 100
    int valorDoPremioDivididoPara4 = valorDoPremio / 4;

    int totalBonus100_1 = (valorDoPremioDivididoPara4 + bonus100 * idade1);
    int totalBonus100_2 = (valorDoPremioDivididoPara4 + bonus100 * idade2);
    int totalBonus100_3 = (valorDoPremioDivididoPara4 + bonus100 * idade3);
    int totalBonus100_4 = (valorDoPremioDivididoPara4 + bonus100 * idade4);
    int totalBonus100_5 = (valorDoPremioDivididoPara4 + bonus100 * idade5);
    #endregion

    Console.WriteLine(" Os 4 Participantes Acertaram o numero Sorteado \n");
    Console.WriteLine(" O valor do premio será Dividido igualmente entre os participantes Vencedores. \n" +
                      " E cada um receberá um bônus de R$ 100,00 por cada ano da idade \n");

    if (par)
    {
        #region Variaveis 4 Wins numero Par
        int totalBonusPar_bonus100_5 = (valorDoPremioDivididoPara4 + bonusPar + bonus100 * idade5);
        int totalBonusPar_bonus100_4 = (valorDoPremioDivididoPara4 + bonusPar + bonus100 * idade4);
        int totalBonusPar_bonus100_3 = (valorDoPremioDivididoPara4 + bonusPar + bonus100 * idade3);
        int totalBonusPar_bonus100_2 = (valorDoPremioDivididoPara4 + bonusPar + bonus100 * idade2);
        int totalBonusPar_bonus100_1 = (valorDoPremioDivididoPara4 + bonusPar + bonus100 * idade1);
        #endregion

        Console.WriteLine(" Como o numero sorteado foi um numero Par\n" +
            " Os participantes vencedores receberão o valor de R$ 500,00 a mais cada um! \n");
        if (numeroWinP1 > 0)
            Console.WriteLine($" {nome1} recebera = {totalBonusPar_bonus100_1.ToString("R$ 000,000.00")} \n");
        if (numeroWinP2 > 0)
            Console.WriteLine($" {nome2} recebera = {totalBonusPar_bonus100_2.ToString("R$ 000,000.00")} \n");
        if (numeroWinP3 > 0)
            Console.WriteLine($" {nome3} recebera = {totalBonusPar_bonus100_3.ToString("R$ 000,000.00")} \n");
        if (numeroWinP4 > 0)
            Console.WriteLine($" {nome4} recebera = {totalBonusPar_bonus100_4.ToString("R$ 000,000.00")} \n");
        if (numeroWinP5 > 0)
            Console.WriteLine($" {nome5} recebera = {totalBonusPar_bonus100_5.ToString("R$ 000,000.00")} \n");

        Thread.Sleep(8000);
        Console.WriteLine(" Aperte Qualquer Tecla para Finalizar");
        Console.ReadKey();

    }
    else
    {
        if (numeroWinP1 > 0)
            Console.WriteLine($" {nome1} recebera: {totalBonus100_1.ToString("R$ 000,000.00")}");
        if (numeroWinP2 > 0)
            Console.WriteLine($" {nome2} recebera: {totalBonus100_2.ToString("R$ 000,000.00")}");
        if (numeroWinP3 > 0)
            Console.WriteLine($" {nome3} recebera: {totalBonus100_3.ToString("R$ 000,000.00")}");
        if (numeroWinP4 > 0)
            Console.WriteLine($" {nome4} recebera: {totalBonus100_4.ToString("R$ 000,000.00")}");
        if (numeroWinP5 > 0)
            Console.WriteLine($" {nome5} recebera: {totalBonus100_5.ToString("R$ 000,000.00")}");

        Thread.Sleep(7000);
        Console.WriteLine(" Aperte Qualquer Tecla para Finalizar");
        Console.ReadKey();
    }
}

else if (numDeVencedores == 3)
{
    #region Variaveis 3 Wins bonus 100
    int valorDoPremioDivididoPara3 = valorDoPremio / 3;

    int totalBonus100_1 = (valorDoPremioDivididoPara3 + bonus100 * idade1);
    int totalBonus100_2 = (valorDoPremioDivididoPara3 + bonus100 * idade2);
    int totalBonus100_3 = (valorDoPremioDivididoPara3 + bonus100 * idade3);
    int totalBonus100_4 = (valorDoPremioDivididoPara3 + bonus100 * idade4);
    int totalBonus100_5 = (valorDoPremioDivididoPara3 + bonus100 * idade5);
    #endregion

    Console.WriteLine(" Os 3 Participantes Acertaram o numero Sorteado \n");
    Console.WriteLine(" O valor do premio será Dividido igualmente entre os participantes Vencedores. \n" +
                      " E cada um receberá um bônus de R$ 100,00 por cada ano da idade \n");

    if (par)
    {
        #region Variaveis 4 Wins numero Par
        int totalBonusPar_bonus100_5 = (valorDoPremioDivididoPara3 + bonusPar + bonus100 * idade5);
        int totalBonusPar_bonus100_4 = (valorDoPremioDivididoPara3 + bonusPar + bonus100 * idade4);
        int totalBonusPar_bonus100_3 = (valorDoPremioDivididoPara3 + bonusPar + bonus100 * idade3);
        int totalBonusPar_bonus100_2 = (valorDoPremioDivididoPara3 + bonusPar + bonus100 * idade2);
        int totalBonusPar_bonus100_1 = (valorDoPremioDivididoPara3 + bonusPar + bonus100 * idade1);
        #endregion

        Console.WriteLine(" Como o numero sorteado foi um numero Par\n" +
            " Os participantes vencedores receberão o valor de R$ 500,00 a mais cada um! \n");
        if (numeroWinP1 > 0)
            Console.WriteLine($" {nome1} recebera = {totalBonusPar_bonus100_1.ToString("R$ 000,000.00")} \n");
        if (numeroWinP2 > 0)
            Console.WriteLine($" {nome2} recebera = {totalBonusPar_bonus100_2.ToString("R$ 000,000.00")} \n");
        if (numeroWinP3 > 0)
            Console.WriteLine($" {nome3} recebera = {totalBonusPar_bonus100_3.ToString("R$ 000,000.00")} \n");
        if (numeroWinP4 > 0)
            Console.WriteLine($" {nome4} recebera = {totalBonusPar_bonus100_4.ToString("R$ 000,000.00")} \n");
        if (numeroWinP5 > 0)
            Console.WriteLine($" {nome5} recebera = {totalBonusPar_bonus100_5.ToString("R$ 000,000.00")} \n");

        Thread.Sleep(8000);
        Console.WriteLine(" Aperte Qualquer Tecla para Finalizar");
        Console.ReadKey();

    }
    else
    {
        if (numeroWinP1 > 0)
            Console.WriteLine($" {nome1} recebera: {totalBonus100_1.ToString("R$ 000,000.00")}");
        if (numeroWinP2 > 0)
            Console.WriteLine($" {nome2} recebera: {totalBonus100_2.ToString("R$ 000,000.00")}");
        if (numeroWinP3 > 0)
            Console.WriteLine($" {nome3} recebera: {totalBonus100_3.ToString("R$ 000,000.00")}");
        if (numeroWinP4 > 0)
            Console.WriteLine($" {nome4} recebera: {totalBonus100_4.ToString("R$ 000,000.00")}");
        if (numeroWinP5 > 0)
            Console.WriteLine($" {nome5} recebera: {totalBonus100_5.ToString("R$ 000,000.00")}");

        Thread.Sleep(7000);
        Console.WriteLine(" Aperte Qualquer Tecla para Finalizar");
        Console.ReadKey();
    }
}

else if (numDeVencedores == 2)
{
    #region Variaveis 2 Wins bonus 100
    int valorDoPremioDivididoPara2 = valorDoPremio / 2;

    int totalBonus100_1 = (valorDoPremioDivididoPara2 + bonus100 * idade1);
    int totalBonus100_2 = (valorDoPremioDivididoPara2 + bonus100 * idade2);
    int totalBonus100_3 = (valorDoPremioDivididoPara2 + bonus100 * idade3);
    int totalBonus100_4 = (valorDoPremioDivididoPara2 + bonus100 * idade4);
    int totalBonus100_5 = (valorDoPremioDivididoPara2 + bonus100 * idade5);
    #endregion

    Console.WriteLine(" Os 2 Participantes Acertaram o numero Sorteado \n");
    Console.WriteLine(" O valor do premio será Dividido igualmente entre os participantes Vencedores. \n" +
                      " E cada um receberá um bônus de R$ 100,00 por cada ano da idade \n");

    if (par)
    {
        #region Variaveis 2 Wins numero Par
        int totalBonusPar_bonus100_5 = (valorDoPremioDivididoPara2 + bonusPar + bonus100 * idade5);
        int totalBonusPar_bonus100_4 = (valorDoPremioDivididoPara2 + bonusPar + bonus100 * idade4);
        int totalBonusPar_bonus100_3 = (valorDoPremioDivididoPara2 + bonusPar + bonus100 * idade3);
        int totalBonusPar_bonus100_2 = (valorDoPremioDivididoPara2 + bonusPar + bonus100 * idade2);
        int totalBonusPar_bonus100_1 = (valorDoPremioDivididoPara2 + bonusPar + bonus100 * idade1);
        #endregion

        Console.WriteLine(" Como o numero sorteado foi um numero Par\n" +
            " Os participantes vencedores receberão o valor de R$ 500,00 a mais cada um! \n");
        if (numeroWinP1 > 0)
            Console.WriteLine($" {nome1} recebera = {totalBonusPar_bonus100_1.ToString("R$ 000,000.00")} \n");
        if (numeroWinP2 > 0)
            Console.WriteLine($" {nome2} recebera = {totalBonusPar_bonus100_2.ToString("R$ 000,000.00")} \n");
        if (numeroWinP3 > 0)
            Console.WriteLine($" {nome3} recebera = {totalBonusPar_bonus100_3.ToString("R$ 000,000.00")} \n");
        if (numeroWinP4 > 0)
            Console.WriteLine($" {nome4} recebera = {totalBonusPar_bonus100_4.ToString("R$ 000,000.00")} \n");
        if (numeroWinP5 > 0)
            Console.WriteLine($" {nome5} recebera = {totalBonusPar_bonus100_5.ToString("R$ 000,000.00")} \n");

        Thread.Sleep(8000);
        Console.WriteLine("Aperte Qualquer Tecla para Finalizar");
        Console.ReadKey();

    }
    else
    {
        if (numeroWinP1 > 0)
            Console.WriteLine($" {nome1} recebera: {totalBonus100_1.ToString("R$ 000,000.00")} \n");
        if (numeroWinP2 > 0)
            Console.WriteLine($" {nome2} recebera: {totalBonus100_2.ToString("R$ 000,000.00")} \n");
        if (numeroWinP3 > 0)
            Console.WriteLine($" {nome3} recebera: {totalBonus100_3.ToString("R$ 000,000.00")} \n");
        if (numeroWinP4 > 0)
            Console.WriteLine($" {nome4} recebera: {totalBonus100_4.ToString("R$ 000,000.00")} \n");
        if (numeroWinP5 > 0)
            Console.WriteLine($" {nome5} recebera: {totalBonus100_5.ToString("R$ 000,000.00")} \n");

        Thread.Sleep(7000);
        Console.WriteLine(" Aperte Qualquer Tecla para Finalizar");
        Console.ReadKey();
    }
}

else if (numDeVencedores == 1)
{
    if (par)
    {
        #region Variaveis 1 Wins numero Par
        int totalBonusPar = (valorDoPremio + bonusPar);

        #endregion

        Console.WriteLine(" Como o numero sorteado foi um numero Par\n" +
            " O(a) vencedor(a) recebera o valor de R$ 500,00 a mais! \n");
        if (numeroWinP1 > 0)
            Console.WriteLine($" O(a) grande Vencedor(a) Foi {nome1} com {idade1} anos de Idade\n" +
                              $" {nome1} recebera: {totalBonusPar.ToString("R$ 000,000.00")} \n");
        if (numeroWinP2 > 0)
            Console.WriteLine($" O(a) grande Vencedor(a) Foi {nome2} com {idade2} anos de Idade\n" +
                              $" {nome2} recebera: {totalBonusPar.ToString("R$ 000,000.00")} \n");
        if (numeroWinP3 > 0)
            Console.WriteLine($" O(a) grande Vencedor(a) Foi {nome3} com {idade3} anos de Idade\n" +
                              $" {nome3} recebera: {totalBonusPar.ToString("R$ 000,000.00")} \n");
        if (numeroWinP4 > 0)
            Console.WriteLine($" O(a) grande Vencedor(a) Foi {nome4} com {idade4} anos de Idade\n" +
                              $" {nome4} recebera: {totalBonusPar.ToString("R$ 000,000.00")} \n");
        if (numeroWinP5 > 0)
            Console.WriteLine($" O(a) grande Vencedor(a) Foi {nome5} com {idade5} anos de Idade\n" +
                              $" {nome5} recebera: {totalBonusPar.ToString("R$ 000,000.00")} \n");

        Thread.Sleep(8000);
        Console.WriteLine(" Aperte Qualquer Tecla para Finalizar");
        Console.ReadKey();

    }
    else if (numeroSorteado == 7)
    {
        #region Variaveis 1 Win numero 7
        int totalBonus7 = (valorDoPremio + bonus7);

        #endregion

        Console.WriteLine(" Como o numero sorteado foi o numero 7\n" +
            " O(a) vencedor(a) recebera o valor de R$ 700.000,00 a mais! \n");
        if (numeroWinP1 > 0)
            Console.WriteLine($" O(a) grande Vencedor(a) Foi {nome1} com {idade1} anos de Idade\n" +
                              $" {nome1} recebera: {totalBonus7.ToString("R$ 000,000.00")} \n");
        if (numeroWinP2 > 0)
            Console.WriteLine($" O(a) grande Vencedor(a) Foi {nome2} com {idade2} anos de Idade\n" +
                              $" {nome2} recebera: {totalBonus7.ToString("R$ 000,000.00")} \n");
        if (numeroWinP3 > 0)
            Console.WriteLine($" O(a) grande Vencedor(a) Foi {nome3} com {idade3} anos de Idade\n" +
                              $" {nome3} recebera: {totalBonus7.ToString("R$ 000,000.00")} \n");
        if (numeroWinP4 > 0)
            Console.WriteLine($" O(a) grande Vencedor(a) Foi {nome4} com {idade4} anos de Idade\n" +
                              $" {nome4} recebera: {totalBonus7.ToString("R$ 000,000.00")} \n");
        if (numeroWinP5 > 0)
            Console.WriteLine($" O(a) grande Vencedor(a) Foi {nome5} com {idade5} anos de Idade\n" +
                              $" {nome5} recebera: {totalBonus7.ToString("R$ 000,000.00")} \n");

        Thread.Sleep(8000);
        Console.WriteLine(" Aperte Qualquer Tecla para Finalizar");
        Console.ReadKey();
    }
    else
    {
        if (numeroWinP1 > 0)
            Console.WriteLine($" O(a) grande Vencedor(a) Foi {nome1} com {idade1} anos de Idade\n" +
                              $" {nome1} recebera: {valorDoPremio.ToString("R$ 0,000,000.00")} \n");
        if (numeroWinP2 > 0)
            Console.WriteLine($" O(a) grande Vencedor(a) Foi {nome2} com {idade2} anos de Idade\n" +
                              $" {nome2} recebera: {valorDoPremio.ToString("R$ 0,000,000.00")} \n");
        if (numeroWinP3 > 0)
            Console.WriteLine($" O(a) grande Vencedor(a) Foi {nome3} com {idade3} anos de Idade\n" +
                              $" {nome3} recebera: {valorDoPremio.ToString("R$ 0,000,000.00")} \n");
        if (numeroWinP4 > 0)
            Console.WriteLine($" O(a) grande Vencedor(a) Foi {nome4} com {idade4} anos de Idade\n" +
                              $" {nome4} recebera: {valorDoPremio.ToString("R$ 0,000,000.00")} \n");
        if (numeroWinP5 > 0)
            Console.WriteLine($" O(a) grande Vencedor(a) Foi {nome5} com {idade5} anos de Idade\n" +
                              $" {nome5} recebera: {valorDoPremio.ToString("R$ 0,000,000.00")} \n");

        Thread.Sleep(7000);
        Console.WriteLine(" Aperte Qualquer Tecla para Finalizar");
        Console.ReadKey();
    }
}

else if (numDeVencedores == 0)
{
    if (status1 == false && status2 == false && status3 == false && status4 == false && status5 == false)
    {
        Console.WriteLine(" Todos os participantes estão Desqualificados para Participar do Sorteio");

        Thread.Sleep(8000);
        Console.WriteLine(" Aperte Qualquer Tecla para Finalizar");
        Console.ReadKey();
    }
    else
    {
        MsgFail.ngmAcertou();

        Console.WriteLine("Nenhum dos participante acertou. Então, 10% do premio sera dividido igualmente entre Cada participante QUALIFICADO");
        double dezPorCentoDividido = (premioConsolo / qualificados);
        if (status1)
            Console.WriteLine($"{nome1} com {idade1} anos de idade recebera: {dezPorCentoDividido.ToString("000,000.00")} ");
        if (status2)
            Console.WriteLine($"{nome2} com {idade2} anos de idade recebera: {dezPorCentoDividido.ToString("000,000.00")} ");
        if (status3)
            Console.WriteLine($"{nome3} com {idade3} anos de idade recebera: {dezPorCentoDividido.ToString("000,000.00")} ");
        if (status4)
            Console.WriteLine($"{nome4} com {idade4} anos de idade recebera: {dezPorCentoDividido.ToString("000,000.00")} ");
        if (status5)
            Console.WriteLine($"{nome5} com {idade5} anos de idade recebera: {dezPorCentoDividido.ToString("000,000.00")} ");

        Console.ReadKey();
    }
}

#endregion Premiação