//Atividade 1
using System.Globalization;

Console.Write("Digite o nome do seu personagem!");
Console.WriteLine();
string nome = Console.ReadLine();
Console.Write("Olá " + nome + ", sua jornada de 100 horas no mundo de C# começou. Boa Sorte!");
Console.WriteLine();
Console.WriteLine();

//Atividade 2
Console.Write("Escreva a pontuação da sua primeira missão aqui!");
Console.WriteLine();
int pontuacao = Convert.ToInt32(Console.ReadLine());
Console.Write("Escreva a pontuação da sua segunda missão aqui!");
Console.WriteLine();
int pontuacao2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Sua pontuação total nas missões é: ");
Console.Write(pontuacao + pontuacao2);
Console.WriteLine();
Console.WriteLine();

//Atividade 3
Console.Write("Defina o preço das poções:");
Console.WriteLine();
double precopocao = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
Console.Write("Quantas poções irá comprar?");
Console.WriteLine();
double qntpocao = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
Console.Write("O valor total das poções é: " + precopocao * qntpocao + " PO");
Console.WriteLine();
Console.WriteLine();

//Atividade 4
Console.WriteLine("Conversor de Coordenadas.");
int pixel = 64;
Console.WriteLine("Digite a medida");
int coor = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"A medida de pixels é: " + coor * pixel);
Console.WriteLine();

//Atividade 5
Console.WriteLine("Cálculo de XP");
Console.WriteLine("XP da partida 1!");
double p1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("XP da partida 2!");
double p2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("XP da partida 3!");
double p3 = Convert.ToInt32(Console.ReadLine());
double media = (p1 + p2 + p3) / 3;
Console.WriteLine("A média de XP obtido nas últimas 3 partidas é: " + media);
Console.WriteLine();
Console.WriteLine();

//Atividade 6
Console.WriteLine("Conversor de medidas de temperatura.");
Console.WriteLine("Temperatura em Celsius.");
double C = Convert.ToInt32(Console.ReadLine());
double F = (C * 1.8) + 32;
Console.WriteLine("O valor da temperatura e, Fahrenheit é: " + F);
Console.WriteLine();
Console.WriteLine();

//Atividade 7
Console.WriteLine("Catálogo de Skins.");
int id = Convert.ToInt32(Console.ReadLine());

int antecessor = id - 1;
int sucessor = id + 1;
Console.WriteLine("ID antecessor: " + antecessor);
Console.WriteLine("ID sucessor: " + sucessor);
Console.WriteLine();

//Atividade 8
Console.WriteLine("HP Atual");
double HPAtual = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("HP MaX");
double HPMAX = Convert.ToInt32(Console.ReadLine());
double PorcentagemHP = (HPAtual / HPMAX) * 100;
if (PorcentagemHP < 20)
{
    Console.WriteLine("ALERTA:Vida Crítica! Use uma poção");
}
else
{
    Console.WriteLine("HP Estável");
}
Console.WriteLine();

//Atividade 9
Console.WriteLine("Digite Sua idade!");
int idade = Convert.ToInt32(Console.ReadLine());

if (idade >= 18)
{
    Console.WriteLine("Acesso autorizado!");
}
else
{
    Console.WriteLine("Acesso não autorizado!");
}
Console.WriteLine();

//Atividade 10
Console.WriteLine("Contagem de eliminação Time Alpha");
int kda = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Contagem de eliminação Time Omega");
int kdo = Convert.ToInt32(Console.ReadLine());
if(kda > kdo)
{
    Console.WriteLine("Time alpha foi o campeão com " + kda + " eliminações.");
}
else if (kda < kdo)
{
    Console.WriteLine("Time Omega foi o campeão com " + kdo + " eliminações.");
}
else
{
    Console.WriteLine("Partida terminou em empate");
}
    Console.WriteLine();

//Atividade 11
Console.WriteLine("Digite o nome do personagem.");
string per1 = Console.ReadLine();
Random gerador = new Random();
int ID = gerador.Next(1, 999);
if (ID % 2 == 0)
{
    Console.WriteLine("Olá " + per1 + " seu id de jogador é:" + ID + " você agora pertence aos Magos do Alvorecer.");
}
else
{
    Console.WriteLine("Olá " + per1 + " seu id de jogador é: " + ID + " Você agora pertence aos Guerreiros da Noite.");
}
Console.WriteLine();

//Atividade 12
Console.WriteLine("Escreva o nome do jogador.");
string cheat = Console.ReadLine();
Console.WriteLine("Escreva o código de trapaça.");
int cheat2 = Convert.ToInt32(Console.ReadLine());
if(cheat == "godmode" && cheat2 == 666)
{
    Console.WriteLine("Trapaça Atividada: Modo Imortal Habilitado!");
}
else
{
    Console.WriteLine("Código Inválido!");
}
Console.WriteLine();

//Atividade 13
Console.WriteLine("Capacidade da mochila é 50.0KG!");
Console.WriteLine("--------------------------------");
double espada = 15;
double escudo = 12;
double armaduraLeve = 5;
double armaduraPesada = 35;
double pesoTotal = 0;
string resposta;
Console.WriteLine("Você possui espada? (sim/nao)");
resposta = Console.ReadLine().ToLower(); 
if (resposta == "sim")
{
    pesoTotal = pesoTotal + espada; 
}
Console.WriteLine("Você possui escudo? (sim/nao)");
resposta = Console.ReadLine().ToLower();
if (resposta == "sim")
{
    pesoTotal = pesoTotal + escudo;
}
Console.WriteLine("Você possui armadura leve? (sim/nao)");
resposta = Console.ReadLine().ToLower();
if (resposta == "sim")
{
    pesoTotal = pesoTotal + armaduraLeve; 
}
Console.WriteLine("Você possui armadura pesada? (sim/nao)");
resposta = Console.ReadLine().ToLower();
if (resposta == "sim")
{
    pesoTotal = pesoTotal + armaduraPesada; 
}
Console.WriteLine("--------------------------------");
Console.WriteLine("Peso total dos seus itens: " + pesoTotal + "KG");
if (pesoTotal > 50.0)
{
    Console.WriteLine("AVISO: Você ultrapassou o limite de 50KG! Está muito pesado.");
}
else
{
    Console.WriteLine("Sucesso: Os itens cabem na mochila com segurança!");
}
Console.WriteLine();

//Atividade 14
Console.WriteLine("Ranking competitivo");
Random rank = new Random();
int rankingAtual = 1000;
{
    for (int partida = 1; partida <= 10; partida++)
    {
        Console.WriteLine($"\n--- Partida{partida} de 10 ---");
        Console.WriteLine($"Pontuação atual: {rankingAtual} pontos");

        Console.WriteLine("O jogador venceu ou perdeu a partida? (ganhou/perdeu)");
        string resultado = Console.ReadLine().ToLower();
        int pontosAleatorios = rank.Next(10, 51);

        if (resultado == "ganhou")
        {
            rankingAtual = rankingAtual + pontosAleatorios;
            Console.WriteLine($"Vitória!Você ganhou {pontosAleatorios} pontos");
        }
        else if (resultado == "perdeu")
        {
            rankingAtual = rankingAtual - pontosAleatorios;
            Console.WriteLine($"Derrota... Você perdeu {pontosAleatorios} pontos.");
        }
        else
        {
            Console.WriteLine("Opção inválida! Pontuação não alterada nesta partida.");
        }

        Console.WriteLine("\n============================================");
        Console.WriteLine($"FIM DA PARTIDA! Pontuação Final: {rankingAtual} pontos.");

        if (rankingAtual < 1000)
        {
            Console.WriteLine("Sua classificação final: RANK BRONZE");
        }
        else if (rankingAtual >= 1000 && rankingAtual <= 2000)
        {
            Console.WriteLine("Sua classificação final: RANK PRATA");
        }
        else
        {
            Console.WriteLine("Sua classificação final: RANK OURO");
        }
    }
    Console.WriteLine();
}

//Atividade 15
Console.WriteLine("Spawner sequencial de inimigos");
for (int i = 1; i <= 50; i++)
{
    Console.WriteLine($"Inimigo #{i} gerado");
}
Console.WriteLine();

//Atividade 16
Console.WriteLine("--- 16. Eventos de Rounds Pares ---");
Console.WriteLine("O escudo do Boss será ativado nos seguintes rounds:");
for (int i = 2; i <= 100; i += 2)
{
    Console.WriteLine($"Round {i}");
}

//Atividade 17
Console.WriteLine("--- 17. Contagem Regressiva do Round ---");
for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}
Console.WriteLine("FIGHT! COMEÇOU O ROUND!");
Console.WriteLine();

//Atividade 18
Console.WriteLine("--- 18. Farm Semanal Acumulado ---");
int totalMoedas = 0;

for (int i = 1; i <= 7; i++)
{
    Console.Write($"Moedas farmadas no Dia {i}: ");
    totalMoedas += Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"\nMontante total arrecadado na semana: {totalMoedas} moedas.");
Console.WriteLine();

//Atividade 19
Console.WriteLine("--- 19. Multiplicador de Combo de Dano ---");
Console.Write("Qual o dano base do ataque do herói? ");
double danoBase = Convert.ToDouble(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{i}x Acertos | Dano Total: {danoBase * i}");
}

//Atividade 20
Console.WriteLine("--- 20. Quebrador de Baús (Tentativas) ---");
string senha = "";

while (senha != "ABRACADABRA")
{
    Console.Write("Tente adivinhar a palavra-chave do baú lendário: ");
    senha = Console.ReadLine();

    if (senha != "ABRACADABRA")
    {
        Console.WriteLine("Incorreto! O baú permanece trancado.\n");
    }
}
Console.WriteLine("Baú destrancado! Você encontrou itens lendários!");

//Atividade 21
Console.WriteLine("--- 21. Dungeon Customizável ---");
Console.Write("Quantas salas (N) a dungeon terá? ");
int nSalas = Convert.ToInt32(Console.ReadLine());

double somaDificuldade = 0;

for (int i = 1; i <= nSalas; i++)
{
    Console.Write($"Dificuldade da Sala {i} (1 a 100): ");
    somaDificuldade += Convert.ToDouble(Console.ReadLine());
}

double media1 = somaDificuldade / nSalas;
Console.WriteLine($"\nA média de dificuldade geral do mapa é: {media1}");

//Atividade 22
Console.WriteLine("--- 22. Simulador de Drop Rate (Loot Box) ---");
int lootComum = 0;
int lootRaro = 0;

for (int i = 1; i <= 10; i++)
{
    Console.Write($"Raridade da {i}ª caixa (0 a 100): ");
    int raridade = Convert.ToInt32(Console.ReadLine());

    if (raridade < 50)
    {
        lootComum++;
    }
    else
    {
        lootRaro++;
    }
}

Console.WriteLine("\n--- Balanço do Inventário ---");
Console.WriteLine($"Loot Comum: {lootComum}");
Console.WriteLine($"Loot Raro: {lootRaro}");
Console.WriteLine();

//Atividade 23
Console.WriteLine("--- 23. Recorde Absoluto de Pontos (High Score) ---");
int maiorPontuacao = 0;
int pontuacaoAtual = -1;

Console.WriteLine("Digite as pontuações dos jogadores. (Digite 0 para encerrar)");

while (pontuacaoAtual != 0)
{
    Console.Write("Pontuação: ");
    pontuacaoAtual = Convert.ToInt32(Console.ReadLine());

    if (pontuacaoAtual > maiorPontuacao)
    {
        maiorPontuacao = pontuacaoAtual;
    }
}
Console.WriteLine($"\nA Captação foi encerrada. Maior pontuação registrada: {maiorPontuacao}");
Console.WriteLine();

//Atividade 24
Console.WriteLine("--- 24. Gasto e Esvaziamento de Mana ---");
int mana = 1000;

while (mana > 0)
{
    Console.WriteLine($"Mana Atual: {mana}");
    Console.Write("Quanto de mana o feitiço custou? ");
    int gasto = Convert.ToInt32(Console.ReadLine());

    mana -= gasto; // Subtrai a mana gasta do total
}

Console.WriteLine("\nMana Esgotada! Recarregue.");
Console.WriteLine();

//Atividade 25

Console.WriteLine("--- 25. Painel MVP (Most Valuable Player) ---");
int totalAbatesCla = 0;
int maiorNumeroAbates = -1;
string nomeMVP = "";

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"\nJogador {i}:");
    Console.Write("Nome: ");
    string nome2 = Console.ReadLine();

    Console.Write("Número de Abates (Kills): ");
    int abates = Convert.ToInt32(Console.ReadLine());

    totalAbatesCla += abates;

    // Verifica se o jogador atual é o que mais matou até agora
    if (abates > maiorNumeroAbates)
    {
        maiorNumeroAbates = abates;
        nomeMVP = nome2;
    }
}
