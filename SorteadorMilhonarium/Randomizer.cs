using SorteadorMilhonarium;
using System.Globalization;

Console.SetWindowSize(105, 40);
Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Black;
Console.Clear();
Console.Title = "S.I.M - Sorteador Inteligente Milhonarium 0.5.1"; // Nome do Programa

#region Variaveis 
int[] numerosP1 = new int[3];

int[] numerosP2 = new int[3];

int[] numerosP3 = new int[3];

int[] numerosP4 = new int[3];

int[] numerosP5 = new int[3];

int numDeQualificados = 0;
int numDeVencedores = 0;

int valorDoPremio = 1_000_000; // Valor do Sorteio 

int bonusPar = 500;
int bonus7 = 700_000;
int bonus100 = 100;

var cultura = CultureInfo.CreateSpecificCulture("pt-BR");
int anoAtual = DateTime.Today.Year; // Ano atual

#endregion Variaveis

#region Cadastro dos Participantes 

#region 1º
Console.WriteLine(" Digite o nome completo do Primeiro participante");
string nome1 = Console.ReadLine();
Console.WriteLine($"Digite o Ano de nascimento de {nome1}");
int idade1 = (anoAtual - int.Parse(Console.ReadLine()));
bool status1 = (idade1 >= 18);
if (status1)
{
    Console.WriteLine($" Peça a {nome1} para informar 3 numeros inteiros entre 1 a 10");
    for (int index = 0; index < 3; index++)
        numerosP1[index] = int.Parse(Console.ReadLine());
}
else
{
    Console.WriteLine($" {nome1} não esta Qualificado(a) para participar do Sorteio");
    Thread.Sleep(4000);
}
Console.Clear();
#endregion 1º 

#region 2º
Console.WriteLine(" Digite o nome completo do Segundo participante");
string nome2 = Console.ReadLine();
Console.WriteLine($" Digite o Ano de nascimento de {nome2}");
int idade2 = (anoAtual - int.Parse(Console.ReadLine()));
bool status2 = (idade2 >= 18);
if (status2)
{
    Console.WriteLine($" Peça a {nome2} para informar 3 numeros inteiros entre 1 a 10");
    var index = 0;
    while (index < 3)
    {
        numerosP2[index] = int.Parse(Console.ReadLine());
        index++;
    }
}
else
{
    Console.WriteLine($" {nome2} não esta Qualificado(a) para participar do Sorteio");
    Thread.Sleep(3000);
}
Console.Clear();
#endregion 2º

#region 3º
Console.WriteLine(" Digite o nome completo do Terceiro participante");
string nome3 = Console.ReadLine();
Console.WriteLine($" Digite o Ano de nascimento de {nome3}");
int idade3 = (anoAtual - int.Parse(Console.ReadLine()));
bool status3 = (idade3 >= 18);
if (status3)
{
    Console.WriteLine($" Peça a {nome3} para informar 3 numeros inteiros entre 1 a 10");
    for (int index = 0; index < 3; index++)
        numerosP3[index] = int.Parse(Console.ReadLine());
}
else
{
    Console.WriteLine($" {nome3} não esta Qualificado(a) para participar do Sorteio");
    Thread.Sleep(3000);
}
Console.Clear();
#endregion 3º

#region 4º
Console.WriteLine(" Digite o nome completo do Quarto participante");
string nome4 = Console.ReadLine();
Console.WriteLine($" Digite o Ano de nascimento de {nome4}");
int idade4 = (anoAtual - int.Parse(Console.ReadLine()));
bool status4 = (idade4 >= 18);
if (status4)
{
    Console.WriteLine($" Peça a {nome4} para informar 3 numeros inteiros entre 1 a 10");
    for (int index = 0; index < 3; index++)
        numerosP4[index] = int.Parse(Console.ReadLine());
}
else
{
    Console.WriteLine($" {nome4} não esta Qualificado(a) para participar do Sorteio");
    Thread.Sleep(3000);
}
Console.Clear();
#endregion 4º

#region 5º
Console.WriteLine(" Digite o nome completo do Quinto participante");
string nome5 = Console.ReadLine();
Console.WriteLine($" Digite o Ano de nascimento de {nome5}");
int idade5 = (anoAtual - int.Parse(Console.ReadLine()));
bool status5 = (idade5 >= 18);
if (status5)
{
    Console.WriteLine($" Peça a {nome5} para informar 3 numeros inteiros entre 1 a 10");
    for (int index = 0; index < 3; index++)
         numerosP5[index] = int.Parse(Console.ReadLine());
}
else
{
    Console.WriteLine($" {nome5} não esta Qualificado(a) para participar do Sorteio");
    Thread.Sleep(3000);
}
Console.Clear();
#endregion 5º

#endregion Cadastro dos Participantes

#region Dado (random) 

Random dado = new Random();
int numeroSorteado = 7; //dado.Next(1, 10);
bool par = numeroSorteado % 2 == 0;

Console.WriteLine($" O numero Sorteado foi: {numeroSorteado}\n");

#endregion 

#region Junção dos Numeros
if (numerosP1.Contains(numeroSorteado))
{
    Console.WriteLine($"{nome1} Acertou o numero sorteado {numeroSorteado}\n");
    numDeVencedores++;
}

if (numerosP2.Contains(numeroSorteado))
{
    Console.WriteLine($"{nome2} Acertou o numero sorteado {numeroSorteado}\n");
    numDeVencedores++;
}

if (numerosP3.Contains(numeroSorteado))
{
    Console.WriteLine($"{nome3} Acertou o numero sorteado {numeroSorteado}\n");
    numDeVencedores++;
}

if (numerosP4.Contains(numeroSorteado))
{
    Console.WriteLine($"{nome4} Acertou o numero sorteado {numeroSorteado}\n");
    numDeVencedores++;
}

if (numerosP5.Contains(numeroSorteado))
{
    Console.WriteLine($"{nome5} Acertou o numero sorteado {numeroSorteado}\n");
    numDeVencedores++;
}
#endregion Junção dos Numeros

#region Contagem dos Qualificados
if (status1)
    numDeQualificados++;
if (status2)
    numDeQualificados++;
if (status3)
    numDeQualificados++;
if (status4)
    numDeQualificados++;
if (status5)
    numDeQualificados++;

#endregion Contagem dos Qualificados

#region Premiação
switch (numDeVencedores)
{
    case > 1:
        {
            int valorDoPremioDividido = valorDoPremio / numDeVencedores;


            Console.WriteLine($" {numDeVencedores} Pessoas acertaram o numero sorteado\n" +
                              " O valor do premio será Dividido igualmente entre os participantes.\n" +
                              " E cada um receberá um bônus de R$ 100,00 por cada ano da idade");

            if (par)
            {

                Console.WriteLine(" Como o numero sorteado foi um numero Par\n" +
                    " Os participantes vencedores receberão o valor de R$ 500,00 a mais cada um!");

                if (numerosP1.Contains(numeroSorteado))
                    Console.WriteLine($" {nome1} com {idade1} anos de idade recebera = {(valorDoPremioDividido + bonusPar + (bonus100 * idade1)).ToString("C", cultura)} \n");

                if (numerosP2.Contains(numeroSorteado))
                    Console.WriteLine($" {nome2} com {idade2} anos de idade recebera = {(valorDoPremioDividido + bonusPar + (bonus100 * idade2)).ToString("C", cultura)}\n");

                if (numerosP3.Contains(numeroSorteado))
                    Console.WriteLine($" {nome3} com {idade3} anos de idade recebera = {(valorDoPremioDividido + bonusPar + (bonus100 * idade3)).ToString("C", cultura)} \n");

                if (numerosP4.Contains(numeroSorteado))
                    Console.WriteLine($" {nome4} com {idade4} anos de idade recebera = {(valorDoPremioDividido + bonusPar + (bonus100 * idade4)).ToString("C", cultura)} \n");

                if (numerosP5.Contains(numeroSorteado))
                    Console.WriteLine($" {nome5} com {idade5} anos de idade recebera = {(valorDoPremioDividido + bonusPar + (bonus100 * idade5)).ToString("C", cultura)} \n");

                Thread.Sleep(7000);
                Console.WriteLine(" Aperte Qualquer Tecla para Finalizar");
                Console.ReadKey();

            }
            else
            {
                if (numerosP1.Contains(numeroSorteado))
                    Console.WriteLine($" {nome1} com {idade1} anos de idade recebera: {(valorDoPremioDividido + (bonus100 * idade1)).ToString("C", cultura)}");

                if (numerosP2.Contains(numeroSorteado))
                    Console.WriteLine($" {nome2} com {idade2} anos de idade recebera: {(valorDoPremioDividido + (bonus100 * idade2)).ToString("C", cultura)}");

                if (numerosP3.Contains(numeroSorteado))
                    Console.WriteLine($" {nome3} com {idade3} anos de idade recebera: {(valorDoPremioDividido + (bonus100 * idade3)).ToString("C", cultura)}");

                if (numerosP4.Contains(numeroSorteado))
                    Console.WriteLine($" {nome4} com {idade4} anos de idade recebera: {(valorDoPremioDividido + (bonus100 * idade4)).ToString("C", cultura)}");

                if (numerosP5.Contains(numeroSorteado))
                    Console.WriteLine($" {nome5} com {idade5} anos de idade recebera: {(valorDoPremioDividido + (bonus100 * idade5)).ToString("C", cultura)}");

                Thread.Sleep(7000);
                Console.WriteLine(" Aperte Qualquer Tecla para Finalizar");
                Console.ReadKey();
            }
            break;
        }
    case 1:
        {
            if (par)
            {
                int totalBonusPar = (valorDoPremio + bonusPar);

                Console.WriteLine(" Como o numero sorteado foi um numero Par\n" +
                    " O(a) vencedor(a) recebera o valor de R$ 500,00 a mais! \n");

                if (numerosP1.Contains(numeroSorteado))
                    Console.WriteLine($" O(a) grande Vencedor(a) Foi {nome1} com {idade1} anos de Idade\n" +
                                      $" {nome1} recebera: {totalBonusPar.ToString("C", cultura)} \n");
                if (numerosP2.Contains(numeroSorteado))
                    Console.WriteLine($" O(a) grande Vencedor(a) Foi {nome2} com {idade2} anos de Idade\n" +
                                      $" {nome2} recebera: {totalBonusPar.ToString("C", cultura)} \n");
                if (numerosP3.Contains(numeroSorteado))
                    Console.WriteLine($" O(a) grande Vencedor(a) Foi {nome3} com {idade3} anos de Idade\n" +
                                      $" {nome3} recebera: {totalBonusPar.ToString("C", cultura)} \n");
                if (numerosP4.Contains(numeroSorteado))
                    Console.WriteLine($" O(a) grande Vencedor(a) Foi {nome4} com {idade4} anos de Idade\n" +
                                      $" {nome4} recebera: {totalBonusPar.ToString("C", cultura)} \n");
                if (numerosP5.Contains(numeroSorteado))
                    Console.WriteLine($" O(a) grande Vencedor(a) Foi {nome5} com {idade5} anos de Idade\n" +
                                      $" {nome5} recebera: {totalBonusPar.ToString("C", cultura)} \n");

                Thread.Sleep(8000);
                Console.WriteLine(" Aperte Qualquer Tecla para Finalizar");
                Console.ReadKey();

            }
            else if (numeroSorteado == 7)
            {
                int totalBonus7 = (valorDoPremio + bonus7);

                Console.WriteLine(" Como o numero sorteado foi o numero 7\n" +
                    " O(a) vencedor(a) recebera o valor de R$ 700.000,00 a mais! \n");

                if (numerosP1.Contains(numeroSorteado))
                    Console.WriteLine($" O(a) grande Vencedor(a) Foi {nome1} com {idade1} anos de Idade\n" +
                                      $" {nome1} recebera: {totalBonus7.ToString("C", cultura)} \n");
                if (numerosP2.Contains(numeroSorteado))
                    Console.WriteLine($" O(a) grande Vencedor(a) Foi {nome2} com {idade2} anos de Idade\n" +
                                      $" {nome2} recebera: {totalBonus7.ToString("C", cultura)} \n");
                if (numerosP3.Contains(numeroSorteado))
                    Console.WriteLine($" O(a) grande Vencedor(a) Foi {nome3} com {idade3} anos de Idade\n" +
                                      $" {nome3} recebera: {totalBonus7.ToString("C", cultura)} \n");
                if (numerosP4.Contains(numeroSorteado))
                    Console.WriteLine($" O(a) grande Vencedor(a) Foi {nome4} com {idade4} anos de Idade\n" +
                                      $" {nome4} recebera: {totalBonus7.ToString("C", cultura)} \n");
                if (numerosP5.Contains(numeroSorteado))
                    Console.WriteLine($" O(a) grande Vencedor(a) Foi {nome5} com {idade5} anos de Idade\n" +
                                      $" {nome5} recebera: {totalBonus7.ToString("C", cultura)} \n");

                Thread.Sleep(8000);
                Console.WriteLine(" Aperte Qualquer Tecla para Finalizar");
                Console.ReadKey();
            }
            else
            {
                if (numerosP1.Contains(numeroSorteado))
                    Console.WriteLine($" O(a) grande Vencedor(a) Foi {nome1} com {idade1} anos de Idade\n" +
                                      $" {nome1} recebera: {valorDoPremio.ToString("C", cultura)} \n");
                if (numerosP2.Contains(numeroSorteado))
                    Console.WriteLine($" O(a) grande Vencedor(a) Foi {nome2} com {idade2} anos de Idade\n" +
                                      $" {nome2} recebera: {valorDoPremio.ToString("C", cultura)} \n");
                if (numerosP3.Contains(numeroSorteado))
                    Console.WriteLine($" O(a) grande Vencedor(a) Foi {nome3} com {idade3} anos de Idade\n" +
                                      $" {nome3} recebera: {valorDoPremio.ToString("C", cultura)} \n");
                if (numerosP4.Contains(numeroSorteado))
                    Console.WriteLine($" O(a) grande Vencedor(a) Foi {nome4} com {idade4} anos de Idade\n" +
                                      $" {nome4} recebera: {valorDoPremio.ToString("C", cultura)} \n");
                if (numerosP5.Contains(numeroSorteado))
                    Console.WriteLine($" O(a) grande Vencedor(a) Foi {nome5} com {idade5} anos de Idade\n" +
                                      $" {nome5} recebera: {valorDoPremio.ToString("C", cultura)} \n");

                Thread.Sleep(7000);
                Console.WriteLine(" Aperte Qualquer Tecla para Finalizar");
                Console.ReadKey();
            }
            break;
        }
    default:
        {
            if (numDeQualificados == 0)
            {
                Console.WriteLine(" Todos os participantes estão Desqualificados para Participar do Sorteio\n");

                Thread.Sleep(8000);
                Console.WriteLine(" Aperte Qualquer Tecla para Finalizar");
                Console.ReadKey();
            }
            else
            {
                int premioConsolo = (100000 / numDeQualificados);
                MsgFail.ngmAcertou();

                Console.WriteLine("10% do valor de R$ 1.000.000,00 será dividido igualmente entre os Participantes \n" +
                                  "Qualificados como prêmio de Participação\n");

                if (status1)
                    Console.WriteLine($"{nome1} com {idade1} anos de idade recebera: {premioConsolo.ToString("C", cultura)} \n");
                if (status2)
                    Console.WriteLine($"{nome2} com {idade2} anos de idade recebera: {premioConsolo.ToString("C", cultura)} \n");
                if (status3)
                    Console.WriteLine($"{nome3} com {idade3} anos de idade recebera: {premioConsolo.ToString("C", cultura)} \n");
                if (status4)
                    Console.WriteLine($"{nome4} com {idade4} anos de idade recebera: {premioConsolo.ToString("C", cultura)} \n");
                if (status5)
                    Console.WriteLine($"{nome5} com {idade5} anos de idade recebera: {premioConsolo.ToString("C", cultura)} \n");

                Console.ReadKey();
            }
            break;
        }
}

#endregion Premiação