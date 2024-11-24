using System.Globalization;
using System.Net.WebSockets;

namespace DotNetRevision
{
  public class Dates
  {
    public static void DateRevision()
    {
      Console.Clear();
      //Tipo data (struct)
      DateTime date01 = new DateTime(2021, 12, 31, 8, 43, 12); //31/12/2021
      DateTime date02 = DateTime.Now; //Data e hora atual
      DateTime? dateNull = null; //Data nula
      Console.WriteLine(date01);
      Console.WriteLine(date02);
      Console.WriteLine(dateNull);

      Console.WriteLine(date01.Day); //31
      Console.WriteLine(date01.Month); //12
      Console.WriteLine(date01.Year); //2021
      Console.WriteLine(date01.Hour); //8
      Console.WriteLine(date01.Minute); //43
      Console.WriteLine(date01.Second); //12

      //Formatação de datas (yyyy-MM-dd)
      var format01 = String.Format("{0:dd/MM/yyyy hh:mm:ss}", date02);
      Console.WriteLine(format01);
      var format02 = String.Format("{0:t}", date02); //short time
      Console.WriteLine(format02);
      var format03 = String.Format("{0:T}", date02); //long time
      Console.WriteLine(format03);
      var format04 = String.Format("{0:d}", date02); //short date
      Console.WriteLine(format04);
      var format05 = String.Format("{0:D}", date02); //long date
      Console.WriteLine(format05);
      var format06 = String.Format("{0:f}", date02); //full date/time
      Console.WriteLine(format06);
      var format07 = String.Format("{0:F}", date02); //full date/time (long)
      Console.WriteLine(format07);

      //Formatação de datas (padrões)
      var format08 = String.Format("{0:r}", date02); //RFC1123
      Console.WriteLine(format08);
      var format09 = String.Format("{0:s}", date02); //sortable
      Console.WriteLine(format09);
      var format10 = String.Format("{0:u}", date02); //universal sortable
      Console.WriteLine(format10);

      //Formatação de datas (ToString)
      Console.WriteLine(date02.ToString("yyyy-MM-dd HH:mm:ss")); //2021-12-31 08:43:12
      Console.WriteLine(date02.ToString("r")); //Fri, 31 Dec 2021 08:43:12 GMT

      //Adicionando valores 
      var date03 = date02.AddDays(1); //Adiciona um dia
      Console.WriteLine(date03);
      var date04 = date02.AddMonths(1); //Adiciona um mês
      Console.WriteLine(date04);
      var date05 = date02.AddYears(1); //Adiciona um ano
      Console.WriteLine(date05);
      var date06 = date02.AddHours(1); //Adiciona uma hora
      Console.WriteLine(date06);
      var date07 = date02.AddMinutes(1); //Adiciona um minuto
      Console.WriteLine(date07);
      var date08 = date02.AddSeconds(1); //Adiciona um segundo
      Console.WriteLine(date08);

      //Comparação de datas
      if (date02.Date == DateTime.Now.Date) //Compara apenas a data
      {
        Console.WriteLine($"As datas são iguais, sendo: {date02.Date} e {DateTime.Now.Date}");
      }
      else
      {
        Console.WriteLine("As datas são diferentes");
      }

      //CultureInfo
      var pt = new CultureInfo("pt-BR"); //Brasil
      var en = new CultureInfo("en-US"); //Estados Unidos
      var de = new CultureInfo("de-DE"); //Alemanha
      var fr = new CultureInfo("fr-FR"); //França
      var culture = CultureInfo.CurrentCulture; //Cultura atual da maquina

      Console.WriteLine(date02.ToString("D", pt)); //formatação long date

      //Timezone
      var dateTime = DateTime.UtcNow; //Data e hora atual UTC
      Console.WriteLine(dateTime);
      var dateTime02 = DateTime.Now; //Data e hora atual local
      Console.WriteLine(dateTime02);

      //Conversão de fuso horário
      Console.WriteLine(dateTime.ToLocalTime()); //Converte para o fuso horário local

      var timeZoneTokyo = TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time");
      var dateTimeTokyo = TimeZoneInfo.ConvertTimeFromUtc(dateTime, timeZoneTokyo);
      Console.WriteLine(dateTimeTokyo); //Converte para o fuso horário de Tóquio

      var timeZones = TimeZoneInfo.GetSystemTimeZones(); //Lista de fusos horários
      foreach (var timeZone in timeZones) //Exibe todos os fusos horários
      {
        Console.WriteLine(timeZone.Id);
        Console.WriteLine(timeZone);
        Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dateTime, timeZone));
        Console.WriteLine("------------------------------------------------");
      }

      //TimeSpan
      var timeSpan = new TimeSpan(1, 2, 3); //1 hora, 2 minutos e 3 segundos
      Console.WriteLine(timeSpan);

      Console.WriteLine(timeSpan - TimeSpan.FromMinutes(2)); //1 hora, 0 minutos e 3 segundos
      Console.WriteLine(timeSpan.Days); //0
      Console.WriteLine(timeSpan.Add(TimeSpan.FromMinutes(2))); //1 hora, 4 minutos e 3 segundos

      //DaysInMonth
      var daysInMonth = DateTime.DaysInMonth(2021, 12); //31
      Console.WriteLine(daysInMonth);

      //IsWeekend
      Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek)); //Verifica se é final de semana
    }

    //IsWeekend
    public static bool IsWeekend(DayOfWeek today) //Verifica se é final de semana
    {
      return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
    }
  }
}