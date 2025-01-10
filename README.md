# Tabuleiro de Xadrez - Projeto C#

Este projeto implementa um **tabuleiro de xadrez** em C# com peças e regras básicas de movimentação. O código simula o funcionamento de um jogo de xadrez, permitindo representar o tabuleiro e as peças, além de verificar movimentos válidos.

## Funcionalidades

- Representação de um **tabuleiro de xadrez 8x8**.
- Movimentação das **peças** (Rei, Rainha, Torre, Bispo, Cavalo, Peão).
- Verificação de **movimentos válidos** para cada peça.
- Simulação de **jogadas** entre dois jogadores.
- Possibilidade de verificar **Xeque e Xeque-mate**.
- Interface de **linha de comando** para interação.

## Tecnologias Utilizadas

- **Linguagem:** C#
- **Plataforma:** .NET Core ou .NET Framework
- **Bibliotecas:** Nenhuma biblioteca externa foi utilizada, o código foi escrito de maneira simples e direta.

## Estrutura do Projeto

O projeto é composto pelos seguintes componentes principais:

- **Tabuleiro.cs**: Representação do tabuleiro de xadrez e suas regras.
- **Peca.cs**: Classe base para as peças de xadrez (Rei, Rainha, etc.).
- **Jogador.cs**: Define os jogadores e suas ações durante o jogo.
- **Jogo.cs**: Controla o fluxo do jogo, alternando as jogadas entre os jogadores.
- **Main.cs**: Ponto de entrada do programa (interface de linha de comando para interação com o usuário).

## Como Rodar o Projeto

### Pré-requisitos

Certifique-se de ter o **.NET Core SDK** ou **.NET Framework** instalado em sua máquina.

Você pode baixar a versão mais recente do .NET no [site oficial](https://dotnet.microsoft.com/download).

### Executando o Projeto

1. Clone este repositório para sua máquina local:

   ```bash
   git clone https://github.com/FelipeQ-CODE/xadrez-console.git
