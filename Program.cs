
class Program
{
    static void Main()
    {

        // Classes e campos(fields)
        BanckAccount account1 = new BanckAccount("Leonardo", 100);
        BanckAccount account2 = new BanckAccount("Santos", 100);

        account1.Deposit(-100);
        account2.Deposit(150);

        Console.WriteLine(account1.Balance);
        Console.WriteLine(account2.Balance);


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

class BanckAccount
{
    private string name;

    public decimal Balance 
    { 
        get; private set; 
    }

    public BanckAccount(string name, decimal balance)
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
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            return;
        }

        Balance += amount;
    }

}

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