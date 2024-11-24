using System.Text;

namespace DotNetRevision
{
  public class Strings
  {
    public static void StringRevision()
    {
      Console.Clear();
      //Guids
      //Hashs
      var id = Guid.NewGuid(); //Guid.NewGuid() gera um novo Guid, um hash único
      id.ToString();
      id = new Guid("b3e7d1f4-3b0b-4b7b-8b3b-3b7b0b3b7b0b");
      //Passa um Guid como string
      Console.WriteLine(id);
      Console.WriteLine(id.ToString().Substring(0, 8)); //Pega os 8 primeiros caracteres do Guid

      id = new Guid(); //Guid vazio
      Console.WriteLine(id);

      //Interpolação de Strings
      var price = 10.5;
      var text01 = "O preço é " + price; //Concatenação
      var text = string.Format("O preço é {0} é verdade? {1}", price, true); //Format
      var text02 = $"O preço é {price}"; //Interpolação
      Console.WriteLine(text01);
      Console.WriteLine(text);
      Console.WriteLine(text02);

      //Comparação de Strings
      var str01 = "Hello";
      Console.WriteLine(str01.CompareTo("Hello")); //0
      Console.WriteLine(str01.CompareTo("hello")); //1

      Console.WriteLine(str01.Contains("ell", StringComparison.OrdinalIgnoreCase)); //True e ignora case

      Console.WriteLine(str01.EndsWith("lo")); //True, termina com "lo"
      Console.WriteLine(str01.StartsWith("He")); //True, começa com "He"
      //para ingnorar case use StringComparison.OrdinalIgnoreCase

      Console.WriteLine(str01.Equals("Hello")); //True, exatamente igual
      Console.WriteLine(str01.Equals("hello", StringComparison.OrdinalIgnoreCase)); //True, exatamente igual ignorando case
      Console.WriteLine(str01.Equals("hello")); //False, exatamente igual
                                                //Equals funciona para outros tipos de objetos além de strings

      //índice de uma string
      Console.WriteLine(str01.IndexOf("l")); //2
      Console.WriteLine(str01.LastIndexOf("l")); //3

      //ToUpper e ToLower
      Console.WriteLine(str01.ToUpper()); //HELLO
      Console.WriteLine(str01.ToLower()); //hello

      //Replace e Split
      Console.WriteLine(str01.Replace("l", "w")); //Hewwo, troca "l" por "w"
      var strSplit = "Hello World";
      var split = strSplit.Split(" "); //Divide a string em um array de strings
      Console.WriteLine(split[0]); //Hello
      Console.WriteLine(split[1]); //World

      //Tamanho da string
      Console.WriteLine(str01.Length); //5

      //Remover espaços em branco
      var str02 = "  Hello  ";
      Console.WriteLine(str02.Trim()); //Hello

      //Insert e Remove
      Console.WriteLine(str01.Insert(2, "x")); //Hexllo
      Console.WriteLine(str01.Remove(2, 2)); //Heo, remove 2 caracteres a partir do índice 2

      //Substring
      var result = str01.Substring(2, 2); //ll, pega 2 caracteres a partir do índice 2
      Console.WriteLine(result);

      //StringBuilder
      var sb = new StringBuilder(); //Cria um StringBuilder vazio
      sb.Append("Hello"); //Adiciona "Hello"
      sb.Append(" World"); //Adiciona " World"
      sb.Insert(5, "C#"); //Insere "C#" no índice 5
      sb.ToString(); //Converte o StringBuilder para string
      Console.WriteLine(sb);
    }
  }
}