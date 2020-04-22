#include <stdio.h>
#include <stdlib.h>
#include <cs50.h> // para poder usar get_int

int main(void)
{
    int matriz [5] [5];
    int menor, menorI, menorJ, maior;
    printf("Digite os elementos da matriz\n");
    for (int i = 0; i < 5; i++) // matriz é de ordem 5
        for (int j = 0 ; j < 5; j++)
        {             
            matriz[i][j] = get_int("Elemento [%d] [%d] = ", i, j); // alimenta a matriz com base nos valores []
            if (i == 0 && j == 0)
            {
                menor = matriz[0][0]; // atribui o menor valor ao primeiro elemento da matriz
            }
            if (matriz[i][j]<menor) // o valor é alterado se na varredura for encontrado um valor menor
            {
                menor = matriz[i][j];
                menorI = i; // menorI e menorJ definem a coordenada do menor número dessa matriz
                menorJ = j;
            }
        }    
    //printf("Menor numero: [%d] na linha %i\n", menor, menorI);        
    for (j = 0 ; j < 5; j++) // procura o maior valor na linha do menor valor da matriz
    {
        if (j == 0)
        {
            maior = matriz[menorI][0]; // menorI fixa a iteração apenas na linha onde se encontra o menor valor da matriz
        }

        if (matriz[menorI][j]>maior)
        {
            maior = matriz[menorI][j]; // define o valor do MINMAX
        }
    }    
    printf("\n\n******************* Saida de Dados ********************* \n\n");
    printf("Elementos da Matriz 5x5\n");
    printf("  \n");  
    for ( i=0; i<5; i++){
        for ( j=0; j<5; j++)
        {
            printf ("%d ",matriz[i][j]); // imprime o matriz lida
        }
            printf("\n");
    }
    printf("  \n");
    printf("Valor do elemento MINMAX dessa matriz: [%d]\n", maior); // imprime o valor do MINMAX
    getch();
    return(0);
}
