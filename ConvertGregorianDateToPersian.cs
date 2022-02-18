using System.Data.SqlTypes;
using System.Globalization;

public partial class UserDefinedFunctions
{
    [Microsoft.SqlServer.Server.SqlFunction]
    public static SqlString ConvertToPersianDate(SqlDateTime sqlDateTime)
    {
        PersianCalendar persianCalendar = new PersianCalendar();
        int year = persianCalendar.GetYear(sqlDateTime.Value);
        int month = persianCalendar.GetMonth(sqlDateTime.Value);
        int day = persianCalendar.GetDayOfMonth(sqlDateTime.Value);
        int hour = persianCalendar.GetHour(sqlDateTime.Value);
        int minute = persianCalendar.GetMinute(sqlDateTime.Value);
        int second = persianCalendar.GetSecond(sqlDateTime.Value);
        return new SqlString($"{year}/{month}/{day} {hour}:{minute}:{second}");
    }
}
