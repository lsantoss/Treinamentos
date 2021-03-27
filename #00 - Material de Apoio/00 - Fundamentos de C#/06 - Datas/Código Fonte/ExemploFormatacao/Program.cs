using System;

namespace ExemploFormatacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            DateTime date = DateTime.Now;

            Console.WriteLine("===== Formatações Simples =====");
            Console.WriteLine(date.ToShortDateString());
            Console.WriteLine(date.ToLongDateString());
            Console.WriteLine(date.ToShortTimeString());
            Console.WriteLine(date.ToLongTimeString());
            Console.WriteLine(date.ToLocalTime());
            Console.WriteLine(date.ToUniversalTime());

            Console.WriteLine();
            Console.WriteLine("===== Formatações ToString() =====");
            Console.WriteLine(date.ToString()); // 21/07/2007 11:02:00
            Console.WriteLine(date.ToString("dd/MM/yyyy")); // 21/07/2007 
            Console.WriteLine(date.ToString("MM/dd/yyyy")); // 07/21/2007 
            Console.WriteLine(date.ToString("dddd, dd MMMM yyyy")); //Saturday, 21 July 2007
            Console.WriteLine(date.ToString("dddd, dd MMMM yyyy HH:mm")); // Saturday, 21 July 2007 14:58
            Console.WriteLine(date.ToString("dddd, dd MMMM yyyy hh:mm tt")); // Saturday, 21 July 2007 03:00 PM
            Console.WriteLine(date.ToString("dddd, dd MMMM yyyy H:mm")); // Saturday, 21 July 2007 5:01 
            Console.WriteLine(date.ToString("dddd, dd MMMM yyyy h:mm tt")); // Saturday, 21 July 2007 3:03 PM
            Console.WriteLine(date.ToString("dddd, dd MMMM yyyy HH:mm:ss")); // Saturday, 21 July 2007 15:04:10
            Console.WriteLine(date.ToString("MM/dd/yyyy HH:mm")); // 07/21/2007 15:05
            Console.WriteLine(date.ToString("MM/dd/yyyy hh:mm tt")); // 07/21/2007 03:06 PM
            Console.WriteLine(date.ToString("MM/dd/yyyy H:mm")); // 07/21/2007 15:07
            Console.WriteLine(date.ToString("MM/dd/yyyy h:mm tt")); // 07/21/2007 3:07 PM
            Console.WriteLine(date.ToString("MM/dd/yyyy HH:mm:ss")); // 07/21/2007 15:09:29
            Console.WriteLine(date.ToString("MMMM dd")); // July 21
            Console.WriteLine(date.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK")); // 2007-07-21T15:11:19.1250000+05:30                                                                                        
            Console.WriteLine(date.ToString("ddd, dd MMM yyyy HH':'mm':'ss 'GMT'")); // Sat, 21 Jul 2007 15:12:16 GMT
            Console.WriteLine(date.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss")); // 2007-07-21T15:12:57
            Console.WriteLine(date.ToString("HH:mm")); // 15:14
            Console.WriteLine(date.ToString("hh:mm tt")); // 03:14 PM
            Console.WriteLine(date.ToString("H:mm")); // 5:15
            Console.WriteLine(date.ToString("h:mm tt")); // 3:16 PM
            Console.WriteLine(date.ToString("HH:mm:ss")); // 15:16:29
            Console.WriteLine(date.ToString("yyyy'-'MM'-'dd HH':'mm':'ss'Z'")); // 2007-07-21 15:17:20Z
            Console.WriteLine(date.ToString("dddd, dd MMMM yyyy HH:mm:ss")); // Saturday, 21 July 2007 15:17:58
            Console.WriteLine(date.ToString("yyyy MMMM")); //2007 July        

            Console.ReadKey();
        }
    }
}