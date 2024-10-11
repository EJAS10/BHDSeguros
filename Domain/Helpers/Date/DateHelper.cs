using BHDSeguros.Domain.Structs;
using System.Globalization;

namespace BHDSeguros.Domain.Helpers.Date
{
    public class DateHelper
    {
        public static DateTime GetNow(string Format = FormattersStruct.FormatDatePrimary, string Culture = FormattersStruct.Culture)
        {
            return StrToDateTime(DateTime.Now.ToString(Format, CultureInfo.CreateSpecificCulture(Culture)), Format, Culture);
        }

        public static DateTime StrToDateTime(string CurrentDate, string Format, string Culture)
        {
            return DateTime.ParseExact(CurrentDate, Format, CultureInfo.CreateSpecificCulture(Culture));
        }

        public static int CalcularEdad(DateTime DateOfBirth)
        {
            DateTime CurrentDate = GetNow();
            int Age = CurrentDate.Year - DateOfBirth.Year;

            if (DateOfBirth.Date > CurrentDate.AddYears(-Age)) Age--;

            return Age;
        }
    }
}
