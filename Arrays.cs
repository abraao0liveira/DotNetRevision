using System.Net.Http.Headers;

namespace DotNetRevision
{
  public class Arrays
  {
    public static void ArraysRevision()
    {
      Console.Clear();

      //Arrays
      var myArray = new int[5] { 1, 2, 3, 4, 5 }; //Array de 5 posições
      // ou int[] myArray = new int[5];
      myArray[0] = 12;
      Console.WriteLine(myArray[0]);

      var arraysStruct = new Teste[2] { new Teste(), new Teste() }; //Array de 5 posições
      arraysStruct[0].Id = 12;
      //ou
      arraysStruct[1] = new Teste { Id = 13, Name = "Teste" };
      Console.WriteLine(arraysStruct[0].Id); //Propriedade

      //percorer array
      for (var index = 0; index < myArray.Length; index++)
      {
        Console.WriteLine(myArray[index]);
      } //1, 2, 3, 4, 5

      //foreach
      foreach (var item in myArray) //para cada item no array, vai passa na interação
      {
        Console.WriteLine(item);
      } //1, 2, 3, 4, 5

      foreach (var arrayStruct in arraysStruct)
      {
        Console.WriteLine(arrayStruct.Id);
        Console.WriteLine(arrayStruct.Name);
      } //12, 13 Teste

      //Alterando valores 
      var arr01 = new int[4];
      var arr02 = arr01; //arr02 aponta para o mesmo endereço de memória de arr01

      arr01[0] = 23;
      Console.WriteLine(arr02[0]); //23, o mesmo valor de arr01

      //Clonando array
      var arr03 = (int[])arr01.Clone();
      arr01[0] = 12;
      Console.WriteLine(arr03[0]); //23, o valor de arr01 antes de ser alterado

      arr03[0] = arr01[0];
      Console.WriteLine(arr03[0]); //12, o valor de arr01 depois de ser alterado
    }
  }
  struct Teste
  {
    public int Id { get; set; } //Propriedade
    public string Name { get; set; }
  }
}