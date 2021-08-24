using System.ComponentModel;

namespace Classes.Enums
{
    public enum CsvStringsEnum
    {
        [Description("id,name,age,score\n1,Jack,NULL,12\n17,Betty,28,11")]
        Example1 = 1,
        [Description("id,name,age,score\n1,Jack,22,12\n17,Betty,28,11")]
        Example2 = 2,
        [Description("id,name,age,score\n1,Jack,22,12\n17,NULL,28,11")]
        Example3 = 3
    }

    public static class CsvStringsExtensions
    {
        public static string ToDescriptionString(this CsvStringsEnum val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
            .GetType()
            .GetField(val.ToString())
            .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    } 
}