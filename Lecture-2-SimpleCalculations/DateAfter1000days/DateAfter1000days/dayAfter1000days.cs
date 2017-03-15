using System;

namespace DateAfter1000days
{
    class dayAfter1000days
    {
        static void Main(string[] args)
        {
            var birthDate = Console.ReadLine();
            string format = "dd-MM-yyyy";
            IFormatProvider provider = null;
            DateTime dayAfter1000days = DateTime.ParseExact(birthDate, format, provider).AddDays(999);
            Console.WriteLine(dayAfter1000days.ToString("dd-MM-yyyy"));
        }
    }
}

// Second resolve:
// var inputDate = Console.ReadLine();
// var date = DateTime.ParseExact(inputDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
// --> CultureInfo.InvariantCulture - казва на програмата, че не се интересува от текущите настройките на машината,
// на която се стартира програмата.
// var newDate = date.addDays(999);
// Console.Writeln(newDate.ToString("dd-MM-yyyy");

// "dd-MMM-yyyy" --> 22-Nov-1996 например
// "dd-MMMМ-yyyy" --> 20-November-2016 например