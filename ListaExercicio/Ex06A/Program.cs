// PASSOS PARA RESOLVER O EXERCICIO
//1- CRIAR UM VERTOR DE 1000 POSIÇOES
//2- PREENCHER O VETOR COM VALORES ALEATORIOS
//3- IMPRIMIR O VETOR NA TELA
//4- Ordenar o vetor com o Bubble Sort

//Criar um vetor de valores inteiros
int[] vetor = new int[100];

//Gerar um valor randômico
Random r = new Random();

//Preencher o vetor com valores aleatórios
for (int i = 0; i < vetor.Length; i++)
{
    vetor[i] = r.Next(1000);
}



//Ordenar o vetor com o Bubble Sort
for (int i = 0; i < vetor.Length - 1; i++)
{
    //trocar valores
    if (vetor[i] > vetor [i + 1])
    {
        int aux = vetor [i];
        vetor[i] = vetor [i+1];
        vetor[i + 1] = aux;
    }
}

Console.WriteLine ("\n");
//Imprimir o vetor com valores aleatórios ordenados
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
} 
