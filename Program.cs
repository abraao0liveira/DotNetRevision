using System.Security.Claims;

namespace DotNetRevision
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

      //Object
      object meuObject;
      meuObject = 10;
      Console.WriteLine(meuObject);
      meuObject = "Abraão Oliveira";
      Console.WriteLine(meuObject);

      //Null
      int? meuNull = null;
      Console.WriteLine(meuNull);

      //Conversão Implícita
      float valor = 25.5f;
      int outro = 25;

      valor = outro; // 25.0f
      Console.WriteLine(valor);

      //Conversão Explícita
      int valor2 = 28;
      uint outro2 = (uint)valor2;
      Console.WriteLine(outro2);

      //Parse 
      int inteiro = int.Parse("10");
      Console.WriteLine(inteiro);

      //Convert 
      int inteiro2 = Convert.ToInt32("100");
      Console.WriteLine(inteiro2);

      int intConvert = 100;
      float floatConvert = 25.8f;

      // floatConvert = intConvert; //100
      // intConvert = (int)floatConvert; //25
      // intConvert = int.Parse("100"); //string 100
      // string stringConvert = floatConvert.ToString(); //25.8
      intConvert = Convert.ToInt32(floatConvert); //26
      Console.WriteLine(intConvert);

      Console.WriteLine(Convert.ToBoolean(1)); //True

    }
  }
}
