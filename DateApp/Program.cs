using System;
using System.Globalization;

namespace DateApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            /*
            var data2 = new DateTime(2000, 12, 26, 16, 30, 05);
            var data = DateTime.Now;

            var formatadaUS = String.Format("{0:yyyy/MM/dd}", data);
            var formatadaBR = String.Format("{0:dd/MM/yyyy}", data);
            System.Console.WriteLine(formatadaUS);
            System.Console.WriteLine(formatadaBR);

            var abreviacaoDataHoraCurta = String.Format("{0:t}", data);
            System.Console.WriteLine(abreviacaoDataHoraCurta);

            var abreviacaoDataHoraLonga = String.Format("{0:T}", data);
            System.Console.WriteLine(abreviacaoDataHoraLonga);

            var abreviacaoDataPadraoCurta = String.Format("{0:d}", data);
            System.Console.WriteLine(abreviacaoDataPadraoCurta);

            var abreviacaoDataPadraoLonga = String.Format("{0:D}", data);
            System.Console.WriteLine(abreviacaoDataPadraoLonga);
            */

            /*
            var data = DateTime.Now;

            Console.WriteLine(data.AddDays(12));
            Console.WriteLine(data.AddMonths(1));
            Console.WriteLine(data.AddYears(1));

            if (data.Date == DateTime.Now.Date)
            {
                Console.WriteLine("É igual");
            }

            Console.WriteLine(data);
            */

            /*
            var pt = new CultureInfo("pt-PT");
            var br = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");
            var atual = CultureInfo.CurrentCulture;

            var utcDate = DateTime.UtcNow;

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(utcDate);
            Console.WriteLine(utcDate.ToLocalTime());

            var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            Console.WriteLine(timezoneAustralia);

            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezoneAustralia);
            Console.WriteLine(horaAustralia);

            var timezones = TimeZoneInfo.GetSystemTimeZones();
            foreach (var timezone in timezones)
            {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
                Console.WriteLine("====================================");
            }
            */

            /* 
            var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);

            var timeSpanNanosegundos = new TimeSpan(1);
            Console.WriteLine(timeSpanNanosegundos);

            var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
            Console.WriteLine(timeSpanHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundoMilissegundo = new TimeSpan(15, 12, 55, 8, 100);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilissegundo);

            Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));
            */

            Console.WriteLine(DateTime.DaysInMonth(2020, 2));
            Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));
            Console.WriteLine(DateTime.Now.IsDaylightSavingTime());

        }

        static bool IsWeekend(DayOfWeek today)
        {
            return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
        }

    }
}