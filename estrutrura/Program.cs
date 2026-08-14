void crescente(int nI, int nF)
{
    if(nI <= nF)
    {
        Console.WriteLine(nI);
        crescente(nI + 1, nF);
    }
}

void decrescente(int nI, int nF)
{
    if(nI >= nF)
    {
        Console.WriteLine(nI);
        decrescente(nI - 1, nF);
    }
}

void impares(int nI, int nF)
{
    if(nI <= nF)
    {
        if(nI % 2 != 0)

            Console.WriteLine(nI);
            nI = nI+ 1;
        impares(nI + 1, nF);
    }
}

string op = "1";
while (op != "3")
{
    Console.WriteLine("MENU:");
    Console.WriteLine("1 - Função sem vetor");
    Console.WriteLine("2 - Função com vetor");
    Console.WriteLine("3 - Sair");
    Console.Write("Escolha uma opção: ");
    op = Console.ReadLine();
    if (op == "1")
    {
        int nI, nF;
        Console.Write("Digite o número inicial: ");
        nI = int.Parse(Console.ReadLine());
        Console.Write("Digite o número final: ");
        nF = int.Parse(Console.ReadLine());
        Console.WriteLine("Menu 2");
            
            Console.WriteLine("1- Números em ordem crescente:");
            Console.WriteLine("2- Números em ordem decrescente:");
            Console.WriteLine("3- Números ímpares:");
            Console.WriteLine("4- Somatorio");
            Console.Write("Escolha uma opção: ");
            string op2 = Console.ReadLine();
            if (op2 == "1")
            {
                crescente(nI, nF);
            }
            else if (op2 == "2")
            {
                decrescente(nI, nF);
            }
            else if (op2 == "3")
            {
                impares(nI, nF);
            }
            else if (op2 == "4")
            {
                // Implementar somatório
            }
    }
    else if (op == "2")
    {
        // Função com vetor (a ser implementada)
    }
}