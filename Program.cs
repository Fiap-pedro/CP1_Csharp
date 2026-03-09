double Somar(double num1, double num2)
{
    return num1 + num2;
}

double Subtrair(double num1, double num2)
{
    return num1 - num2;
}

double Multiplicar(double num1, double num2)
{
    return num1 * num2;
}

double Dividir(double num1, double num2)
{
    if (num2 == 0)
    {
        return -1;
    }

    return num1 / num2;
}

void Calculadora()
{
    Console.WriteLine("========== Calculadora - Soma, Subtração, Multiplicação e Divisão ==========");
    while (true)
    {
        Console.WriteLine("===============");
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Somar");
        Console.WriteLine("2 - Subtrair");
        Console.WriteLine("3 - Multiplicar");
        Console.WriteLine("4 - Dividir");
        Console.WriteLine("5 - Sair");
        Console.WriteLine("===============");
        int OpcaoEscolhida = int.Parse(Console.ReadLine());

        if (OpcaoEscolhida == 5)
        {
            Console.WriteLine("Encerrando programa...");
            break;
        }

        Console.WriteLine("Escolha o primeiro número: ");
        Double NumEscolhido1 = Double.Parse(Console.ReadLine());

        Console.WriteLine("Escolha o segundo número: ");
        Double NumEscolhido2 = Double.Parse(Console.ReadLine());

        double ResultadoDaOperacao;

        switch (OpcaoEscolhida)
        {
            case 1:
                Console.WriteLine("===RESULTADO===");
                ResultadoDaOperacao = Somar(NumEscolhido1, NumEscolhido2);
                Console.WriteLine(ResultadoDaOperacao);
                Console.WriteLine("===============");
                break;
            case 2:
                Console.WriteLine("===RESULTADO===");
                ResultadoDaOperacao = Subtrair(NumEscolhido1, NumEscolhido2);
                Console.WriteLine(ResultadoDaOperacao);
                Console.WriteLine("===============");
                break;
            case 3:
                Console.WriteLine("===RESULTADO===");
                ResultadoDaOperacao = Multiplicar(NumEscolhido1, NumEscolhido2);
                Console.WriteLine(ResultadoDaOperacao);
                Console.WriteLine("===============");
                break;
            case 4:
                Console.WriteLine("===RESULTADO===");
                ResultadoDaOperacao = Dividir(NumEscolhido1, NumEscolhido2);
                Console.WriteLine(ResultadoDaOperacao == -1 ? "O divisor não pode ser 0" : ResultadoDaOperacao);
                Console.WriteLine("===============");
                break;
            case 5:
                Console.WriteLine("Encerrando programa...");
                return;
        }
    }

    }

Calculadora();
