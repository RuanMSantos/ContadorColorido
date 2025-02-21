int numero = 0;
Contador();

void Contador(){
    #pragma warning disable CA1416 
    numero++;
    Thread.Sleep(500);
    Console.ForegroundColor = (ConsoleColor)numero;
    Console.Write(numero + " ");
    Console.Beep(1000, 100);
    if (numero < 10){
        Contador();
        return;
    }
    Console.WriteLine();
    Thread.Sleep(500);
    Console.ForegroundColor = (ConsoleColor)(++numero);
    Console.WriteLine("Saindo");
    for (int i = 1; i <= 3; i++){
        Console.Beep(1000, 100);
    }
    Console.ResetColor();
    #pragma warning restore CA1416
}