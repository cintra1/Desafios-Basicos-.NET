//Abaixo segue um exemplo de código que você pode ou não utilizar
using System;

class minhaClasse
{

    static void Main(string[] args)
    {

        int tamanhoLista = int.Parse(Console.ReadLine());

        int[] listaNum = new int[tamanhoLista];

        string[] n      = Console.ReadLine().Split(' ');

        int contador = 0;
        foreach(string item in n){
            listaNum[contador] = Convert.ToInt32(item);
            contador++;
        }

        int multiplo2 = 0;
        int multiplo3 = 0;
        int multiplo4 = 0;
        int multiplo5 = 0;
        
        //TODO: Complete os espaços em branco com uma possível solução para o desafio
        for (int iContador = 0; iContador < tamanhoLista; iContador++)
        {
            if ((listaNum[iContador] % 2) == 0) multiplo2++;
            if ((listaNum[iContador] % 3) == 0) multiplo3++;
            if ((listaNum[iContador] % 4) == 0) multiplo4++;
            if ((listaNum[iContador] % 5) == 0) multiplo5++;
        }

        Console.WriteLine("{0} Multiplo(s) de 2", multiplo2);
        Console.WriteLine("{0} Multiplo(s) de 3", multiplo3);
        Console.WriteLine("{0} Multiplo(s) de 4", multiplo4);
        Console.WriteLine("{0} Multiplo(s) de 5", multiplo5);

    }
}