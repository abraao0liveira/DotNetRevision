using System.Globalization;

namespace DotNetRevision
{
  public class Coins
  {
    public static void CoinsRevision()
    {
      Console.Clear();

      //Moedas
      decimal coin = 12.50m;
      var cultureBR = CultureInfo.CreateSpecificCulture("pt-BR");
      var cultureUS = CultureInfo.CreateSpecificCulture("en-US");
      var cultureJP = CultureInfo.CreateSpecificCulture("ja-JP");

      Console.WriteLine(coin.ToString("G", cultureBR)); //12,50
      Console.WriteLine(coin.ToString("C", cultureBR)); //R$ 12,50
      Console.WriteLine(coin.ToString("C", cultureUS)); //$12.50
      Console.WriteLine(coin.ToString("C", cultureJP)); //¥12

      Console.WriteLine(coin.ToString("N", cultureBR)); //12,50
      Console.WriteLine(coin.ToString("N", cultureUS)); //12.50
      Console.WriteLine(coin.ToString("N", cultureJP)); //12

      //Moedas com arredondamento
      Console.WriteLine(Math.Round(coin, 0)); //12, arre
      Console.WriteLine(Math.Ceiling(coin)); //13, pra cima
      Console.WriteLine(Math.Floor(coin)); //12, pra baixo
    }
  }
}