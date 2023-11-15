public class Program
{
    private static void Main(string[] args)
    {
        //testa o metodo, insinuando que talvez haja um erro
        try
        {
            Metodo();
        }
        //retorna caso existe um erro Dividir por 0
        catch (DivideByZeroException)
        {
            Console.WriteLine("Não é possível divisão por 0!");
        }
        //Exception retona por qualquer tipo de erro
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine(e.StackTrace);
        }
        Console.ReadLine();
    }

    static void Metodo()
    {
        TestaDivisao(0);
    }

    static void TestaDivisao(int divisor)
    {
        Dividir(10, divisor);
    }


    public static int Dividir(int numero, int divisor)
    {
        try
        {
            return numero / divisor;
        }
        catch (Exception)
        {
            Console.WriteLine("Exceção com numero=" + numero + " e divisor=" + divisor);
            //trow faz com que o metodo continue apesar do erro
            throw;
        }
    }
}