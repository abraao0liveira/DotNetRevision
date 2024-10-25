namespace TesteDotNet
{
  class Program
  {
    static void Main(string[] args)
    {
      //Variáveis
      string text = "Hello World!";
      //Constantes
      const string PATH = "output.txt";
      Console.WriteLine(text);
      Console.WriteLine(PATH);

      //Bytes
      byte meuByte = 127;
      sbyte meuSByte = -128;
      Console.WriteLine(meuByte);
      Console.WriteLine(meuSByte);

      //Int 
      int meuInt = 2147483647;
      Console.WriteLine(meuInt);

      //Float
      float meuFloat = 1.5f;
      Console.WriteLine(meuFloat);

      //Boolean 
      bool meuBool = true;
      Console.WriteLine(meuBool);

      //Char
      char meuChar = 'A';
      Console.WriteLine(meuChar);

      //String 
      string minhaString = "Abraão Oliveira";
      Console.WriteLine(minhaString);

      //Var 
      var meuVar = 10;
      var meuVar2 = "Abraão Oliveira";
      Console.WriteLine(meuVar);
      Console.WriteLine(meuVar2);
    }
  }
}
