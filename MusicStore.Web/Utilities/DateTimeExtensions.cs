using System;

namespace MusicStore.Web.Utilities
{
    public static class DateTimeExtensions
    {
        public static DateTime ConvertToDateTime(this string dateTimeStr)
        {
            DateTime convertedDateTime = DateTime.MinValue;
            DateTime.TryParse(dateTimeStr, out convertedDateTime);
            return convertedDateTime;
        }
    }
}