namespace DotNetRevision
{
  public class Exceptions
  {
    public static void ExceptionsRevision()
    {
      Console.Clear();

      var arr = new int[3];

      try
      {
        // for (var index = 0; index < 10; index++)
        // {
        //   Console.WriteLine(arr[index]);
        // }

        Cadastrar("");
      }
      catch (ArgumentNullException ex) // Erro de Argumento Nulo
      {
        Console.WriteLine($"Erro: {ex.Message}");
      }
      catch (MinhaException ex) // Erro de Exceção Personalizada
      {
        Console.WriteLine($"Erro: {ex.Message}");
        Console.WriteLine($"Data do Erro: {ex.DataErro}");
      }
      catch (IndexOutOfRangeException ex) // Erro de Índice, por conta do arr
      {
        Console.WriteLine($"Erro: {ex.Message}");
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Erro: {ex.InnerException}"); //Explica a causa do erro
        Console.WriteLine($"Erro: {ex.Message}"); //Mensagem de erro
      }
      finally
      {
        Console.WriteLine("Finalizando o bloco try-catch");
      }
    }

    static void Cadastrar(string texto)
    {
      if (string.IsNullOrEmpty(texto)) //vazio ou nulo
      {
        throw new Exception("Texto não pode ser nulo ou vazio"); //Lança uma exceção
        //ou
        //throw new ArgumentNullException("Texto não pode ser nulo ou vazio");
        //ou
        //throw new MinhaException(DateTime.Now);
      }
    }

    //Herança de exceções
    public class MinhaException : Exception //Criando uma exceção personalizada
    {
      public MinhaException(DateTime date)
      {
        DataErro = date;
      }
      public DateTime DataErro { get; set; }
    }
  }
}
