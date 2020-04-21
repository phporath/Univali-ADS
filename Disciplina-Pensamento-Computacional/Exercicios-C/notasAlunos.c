#include <stdio.h>
#include <stdlib.h>

int main(void)
{
    float notas[50];
    int nuAlunos;

    do
    {
        printf("Quantidade de alunos na sala: \n");
        scanf("%i", &nuAlunos);
    }
    while (nuAlunos < 1 || nuAlunos > 50);

    int i;
    float somaNota = 0;

    for (i = 1; i <= nuAlunos; i++)
    {
        printf("Nota do aluno %i: \n",i);
        scanf("%f", &notas[i]);
        somaNota = somaNota + notas[i];
    }

    float media =  somaNota / (float)nuAlunos;

    printf("Média das notas dos alunos: %.2f\n", media);
}






