#include <stdio.h>
#include <stdlib.h>
#include <time.h>

int ptoJogador=0, ptoCPU=0;

main()
{
    ppt(); // Pedra-Papel-Tesoura
    //char nome[100];
    //printf ("Qual o nome do jogador?\n"); //depois colcar de limpar a tela
    //scanf ("%s", nome);

}
int ppt()
{
    int opcJogador, opcCPU;
    
    printf (" _____________________________\n");
    printf ("|                             |\n");
    printf ("| Jogo de Pedra-Papel-Tesoura |\n");
    printf ("|_____________________________| \n");
    
    printf ("%d Jogador X CPU %d\n", ptoJogador, ptoCPU);
    printf ("                    \n");
    printf ("0. Pedra\n");
    printf ("1. Papel\n");
    printf ("2. Tesoura\n");
    printf ("3. Sair\n");
    scanf ("%d", &opcJogador);
    if (opcJogador < 0 || opcJogador >=3) //verifica se o valor inserido é válido
    {
        exit(0);
    }
    srand(time(NULL)); //responsável por alimentar a "rand"
    opcCPU = rand() % 3; //gera um numero aleatorio que é aplicado MOD de 3  
    switch(opcCPU)
    {
        case 0:
            printf ("CPU -> Pedra\n");
            printf (" \n");
        break;
        case 1:
            printf ("CPU -> Papel\n");
            printf (" \n");
        break;
        case 2:
            printf ("CPU -> Tesoura\n");
            printf (" \n");
        break;
    }

    if ((opcJogador == 0 && opcCPU==2) || (opcJogador == 1 && opcCPU == 0) || (opcJogador == 2 && opcCPU == 1)) //verifica se o jogador venceu
        {
            printf("Voce venceu!\n");
            printf (" \n");
            ptoJogador++;
            ppt();
        }
    if (opcJogador == opcCPU) //verifica se houve empate
        {
            printf ("Empate!\n");
            printf (" \n");
            ppt();
        }
    else
        {
            printf ("CPU venceu!\n");
            printf (" \n");
            ptoCPU++;
            ppt();

        }
        return 0;
}
