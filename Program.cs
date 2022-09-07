
class Program
{
    static void Main()
    {
        ILogger logger = new FileLogger("mylog.txt");

        BanckAccount account1 = new BanckAccount("Leonardo", 100, logger);
        BanckAccount account2 = new BanckAccount("Santos", 300, logger);

        List<BanckAccount> accounts = new List<BanckAccount>()
        {
            account1,
            account2
        };

        DataStore<string> store = new DataStore<string>();
        store.Value = "Léo";
        Console.WriteLine(store.Value);

        // DataStore<int> store = new DataStore<int>();
        // store.Value = 42;
        // Console.WriteLine(store.Value);

        // foreach (BanckAccount account in accounts)
        // {
        //     Console.WriteLine(account.Balance);
        // } 

        // accounts.Add(account1);
        // accounts.Add(account2);      
        // accounts.Remove(account1);

        // List<int> numbers = new List<int>() { 1, 4, 8, 10 };
        // foreach (int number in numbers)
        // {
        //     Console.WriteLine(number);
        // }


        // account1.Deposit(-100);
        // account2.Deposit(150);

        // Console.WriteLine(account1.Balance);
        // Console.WriteLine(account2.Balance);


        /*
            // Tratamento de exceção
            string s = null;
            int[] numbers = { 1 };

            try
            {
                Console.WriteLine(s.Length);
                Console.WriteLine(numbers[1]);
            }
            catch (System.NullReferenceException exception)
            {
                Console.WriteLine($"ERRO de referência nula. {exception.Message}");
                Console.WriteLine($"ERRO de referência nula. {exception.StackTrace}");
            }
            catch (System.IndexOutOfRangeException exception)
            {
                Console.WriteLine("ERRO");
            }
        */

        /*
            // Tipo referênica e tipo valor
            int? i = 10;

            int? i2 = i;
            i2 = 20;

            Test t = new Test();
            t.x = 12;

            Test t2 = t;
            t2 = new Test();
            t2.x = 20;

            Console.WriteLine(t.x);
            Console.WriteLine(i);
            Console.WriteLine(t2.x);
        */

        /*
            // Conversões implícitas e explícitas
            int i = 10;
            long l = 167645454560;

            // implícitas e explícitas
            // l = i;
            string s = l.ToString();

            // explícitas
            // i = (int)l;

            // Console.WriteLine(l);
            // Console.WriteLine(i);
            Console.WriteLine(s);
        */

        /*
            bool ehNum = int.TryParse("42", out int x);

            if (ehNum)
            {
                Console.WriteLine("Sucesso");
            }
            else
            {
                Console.WriteLine("Erro");
            }

            Console.WriteLine(x);
        */

        /*
            string[] names = {"Leonardo", "Santos"};
            Console.WriteLine(string.Join(' ', names));
        */

        /*
            string name = "Leonardo";

            Console.WriteLine("string vazia ou com espaço? " + string.IsNullOrWhiteSpace(name));
            Console.WriteLine("string nula ou vazia: " + string.IsNullOrEmpty(name));
            Console.WriteLine("Indice de 'd': " + name.IndexOf('d'));
            Console.WriteLine("Contém 's'? " + name.Contains('s'));
            Console.WriteLine("Comprimento: " + name.Length);
            Console.WriteLine("Começa com 'a'? " + name.EndsWith('a'));
            Console.WriteLine("Termina com 'o'? " + name.EndsWith('o'));
            Console.WriteLine("Começa com 'L'? " + name.StartsWith('L'));
            Console.Write("Começa com 'Le'? " + name.StartsWith("Le"));
        */

        /*
            string[] names = { "Leonardo", "Santos" };

            if (string.Equals(names[0], "leonArdO", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("É igual");
            }

            foreach (var item in names)
            {
                Console.WriteLine($"{item}");
            }

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{i+1}º = {names[i]}");
            }
        */

    }

} // fim class Program

class DataStore<T>
{
    public T Value { get; set; }
}// class DataStore


class FileLogger : ILogger
{
    private readonly string filePath;

    public FileLogger(string filePath)
    {
        this.filePath = filePath;
    }
    public void Log(string message)
    {
        File.AppendAllText(filePath, $"{message}{Environment.NewLine}");
    }
} // fim class FileLogger

class ConsoleLogger : ILogger
{

} // fim class ConsoleLogger


interface ILogger
{
    void Log(string message)
    {
        Console.WriteLine($"LOGGER: {message}");
    }
} // fim interface ILogger


class BanckAccount
{
    private string name;
    private readonly ILogger logger;

    public decimal Balance
    {
        get; private set;
    }

    public BanckAccount(string name, decimal balance, ILogger logger)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Nome inválido!", nameof(name));
        }

        if (balance < 0)
        {
            throw new Exception("Saldo não pode ser negativo!");
        }

        this.name = name;
        Balance = balance;
        this.logger = logger;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            logger.Log($"Não é possível depositar {amount} na conta de {name}");
            return;
        }

        Balance += amount;
    }

}// fim class BanckAccount

/*
    class Test
    {
        public int x;
    }
*/

/*
    Console.WriteLine();
    Console.Write("Digite seu nome: ");
    string name = Console.ReadLine();

        Console.Write("Digite o ano do seu nascimento: ");
    int year = int.Parse(Console.ReadLine());

        int age = 2022 - year;

        Console.WriteLine($"Olá: {name}");
    Console.WriteLine($"Ano de nascimento: {year}");
    Console.WriteLine($"Você tem {age} anos.");

    if (age > 18 && name == "Leo") 
    {
        Console.WriteLine("Você é maior de idade!");
    }
    else 
    {
        Console.WriteLine("Você é menor de idade!");
    }
*/