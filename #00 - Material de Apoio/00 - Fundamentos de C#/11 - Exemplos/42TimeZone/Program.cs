using System;

namespace _42TimeZone
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeZoneInfo localZone = TimeZoneInfo.Local;
            TimeZoneInfo Standard_Time = TimeZoneInfo.FindSystemTimeZoneById(localZone.Id);
            DateTime dataHoraLocal = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, Standard_Time);
            Console.WriteLine("Local Time Zone Id     : {0}", localZone.Id);
            Console.WriteLine("Display Name           : {0}", localZone.DisplayName);
            Console.WriteLine("Standard name          : {0}", localZone.StandardName);
            Console.WriteLine("Daylight saving name   : {0}", localZone.DaylightName);
            Console.WriteLine("Data/Hora local        : {0}", dataHoraLocal);
            Console.WriteLine();
            Console.WriteLine();

            foreach (TimeZoneInfo fusoHorario in TimeZoneInfo.GetSystemTimeZones())
            {
                Standard_Time = TimeZoneInfo.FindSystemTimeZoneById(fusoHorario.Id);
                dataHoraLocal = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, Standard_Time);
                Console.WriteLine(fusoHorario.Id);
                Console.WriteLine(dataHoraLocal);
                Console.WriteLine("--------------------------------");
            }

            Console.ReadKey();
        }
    }
}