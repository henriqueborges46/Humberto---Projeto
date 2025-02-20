// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string[,] tabuleiro = new string[3, 3];
bool fimDeJogo = false;
//matriz
//3x3
//armazenar X ,O ou vazio
string jogadorO = "O";
string jogadorX = "X";
int linha, coluna;
string jogador_atual = jogadorX;
while (!fimDeJogo)
{
    Console.WriteLine("Jogador atual: " + jogador_atual);
    Console.WriteLine("Digite a linha:");
    linha = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite a coluna:");
    coluna = Convert.ToInt32(Console.ReadLine());


    if (tabuleiro[linha, coluna] == null)
    {
        tabuleiro[linha, coluna] = jogador_atual;
        if (jogador_atual == jogadorX)
        {
            jogador_atual = jogadorO;
        }
        else
        {
            jogador_atual = jogadorX;
        }

    }
    else
    {
        Console.WriteLine("Posição está ocupada");
    }
    ImprimirTabuleiro();
}

    void ImprimirTabuleiro()
    {
        for (int linhaTabuleiro = 0; linhaTabuleiro < 3; linhaTabuleiro++)
        {
            for (int colunaTabuleiro = 0; colunaTabuleiro < 3; colunaTabuleiro++)
            {
                Console.Write(" " + tabuleiro[linhaTabuleiro,colunaTabuleiro] + " ");
            }
            Console.WriteLine();

        }
    }

