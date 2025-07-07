using Exercicios_POO;
class MainClass {
    private static void Main(string[] args)
    {
        string entry;
        Console.WriteLine("Selecione o número do exercício(de 1 a 4)");
        entry = Console.ReadLine();
        if (int.TryParse(entry, out int num))
        {
            switch (num)
            {
                case 1:
                    Book[] book = new Book[2];

                    book[0] = new Book("Dom Quixote", "Miguel de Cervantes", 893);
                    book[1] = new Book("Cem Anos de Solidão", " Gabriel García Márquez", 417);
                    
                    for (int i = 0; i < book.Length; i++)
                    {
                        book[i].ShowInfo();
                    }
                    break;
                case 2:
                    Rectangle[] retangulo = new Rectangle[2];

                    retangulo[0] = new Rectangle(3, 9);
                    retangulo[1] = new Rectangle(10, 25);


                    for (int i = 0; i < retangulo.Length; i++)
                    {
                        retangulo[i].CalcArea();
                        retangulo[i].CalcPerimeter();
                    }
                    break;
                case 3:
                    BankAccount account = new BankAccount("00000001", "Cecilia");
        
                    account.Deposit(5);
                    account.Withdraw(2);
                    account.Withdraw(10);
                    account.ShowBankBalance();
                    break;
                case 4:
                    TaskManager tasks = new TaskManager();
                    tasks.AddTask("lavar a louça");
                    tasks.AddTask("tirar o lixo");
                    tasks.AddTask("arrumar a cama");
                    tasks.AddTask("limpar a mesa");
                    tasks.ListTask();
                    tasks.RemoveTask("lavar a louça");
                    tasks.RemoveTask("regar as plantas");
                    tasks.ListTask();
                    break;
            }
        }
        else
        {
            Console.WriteLine("entrada inválida!");
        }

    }
}
