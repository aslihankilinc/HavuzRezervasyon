using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HavuzRezervasyon.Extensions
{
    public static class Extensions
    {
        public static int CharToAscii(char character)
        {
            int result = (int)character;
            return result;
        }

        public static bool IsNumeric(string value)
        {
            bool result = true;
            for (int i = 0; i < value.Length; i++)
            {
                if (CharToAscii(value[i]) > 57 || CharToAscii(value[i]) < 48)
                {
                    result = false;
                }
            }
            return result;
        }

        public static bool Search(string text, string searchText)
        {
            if (text.Contains(searchText) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsNullOrEmpty(this string text)
        {
            try
            {
                if (text == null) return true;
                return String.IsNullOrEmpty(text.Trim());
            }
            catch (Exception)
            {
                return true;
            }
        }

        public static bool IsInteger(this object number)
        {
            try
            {
                if (number == DBNull.Value) return false;
                Convert.ToInt32(number);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string GetNullOrValue(this string text)
        {
            return text.IsNullOrEmpty() ? "" : text;
        }

        public static byte ToByte(this object number)
        {
            try
            {
                if (number == DBNull.Value || number == null) return 0;
                byte x = Convert.ToByte(number);
                return x;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static int ToInt32(this object number)
        {
            try
            {
                if (number == DBNull.Value || number == null) return 0;
                int x = Convert.ToInt32(number);
                return x;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static long ToInt64(this object number)
        {
            try
            {
                if (number == DBNull.Value || number == null) return 0;
                long x = Convert.ToInt64(number);
                return x;
            }
            catch (Exception)
            {
                return 0;
            }
        }


        public static string ToFormatMoney(this object number)
        {
            var cultureInfo = CultureInfo.CurrentCulture;
            const string format = "c2";
            return number.ToDouble().ToString(format, (IFormatProvider)cultureInfo);
        }

        public static double ToDouble(this object number)
        {
            try
            {
                if (number == null) return 0.0;
                return string.IsNullOrEmpty(number.ToString().Trim()) ? 0.0 :
                Convert.ToDouble(number.ToString());
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static decimal ToDecimal(this object number)
        {
            try
            {
                return string.IsNullOrEmpty(number.ToString().Trim()) ? 0 :
                Convert.ToDecimal(number.ToString());
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static float ToSingle(this object number)
        {
            try
            {
                if (number == DBNull.Value || number == null) return 0;
                number = number.ToString().Replace('.', ',');
                float x = Convert.ToSingle(number);
                return x;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static string ToStringDateTime(this DateTime dateTime)
        {
            DateTime simdi = DateTime.Now;
            String s;
            if (dateTime.Hour == 0 && dateTime.Minute == 0 && dateTime.Second == 0)
            {
                if (simdi.Date == dateTime.Date)
                    s = "Bugün";
                else if (dateTime.Date.AddDays(1.0).Day == simdi.Date.Day)
                    s = "Dün";
                else
                    s = String.Format("{0:00}.{1:00}.{2}", dateTime.Day, dateTime.Month, dateTime.Year);
            }
            else
            {
                if (simdi.Date == dateTime.Date)
                    s = String.Format("Bugün {0:00}:{1:00}", dateTime.Hour, dateTime.Minute);
                else if (dateTime.Date.AddDays(1.0).Day == simdi.Date.Day)
                    s = String.Format("Dün {0:00}:{1:00}", dateTime.Hour, dateTime.Minute);
                else
                    s = String.Format("{0:00}.{1:00}.{2} {3:00}:{4:00}", dateTime.Day, dateTime.Month, dateTime.Year, dateTime.Hour, dateTime.Minute);
            }
            return s.ToString();
        }

        public static string ToClearText(this string s, bool endLine)
        {
            s = s.Replace("<", "&lt;");
            s = s.Replace(">", "&gt;");
            s = s.Replace("script", "scr_ipt");
            s = s.Replace("'", "`");
            s = s.Replace("\"", "`");

            if (endLine)
                s = s.Replace(Environment.NewLine, s);
            s = s.Trim();
            return s;
        }

        public static string ToClearText(this string s)
        {
            s = ToClearText(s, false);
            return s;
        }


        public static DateTime ToDateTime(this object s)
        {
            try
            {
                return s != DBNull.Value ? Convert.ToDateTime(s) : DateTime.Now;
            }
            catch (Exception)
            {
                return DateTime.Now;
            }
        }

        public static string ToShortDate(this object s)
        {
            try
            {
                string value = s.ToString();
                value = Regex.Split(value, " ")[0];
                return value;
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static TimeSpan ToTimeSpan(this object s)
        {
            try
            {
                return s != DBNull.Value ? TimeSpan.Parse(s.ToString()) : TimeSpan.Zero;
            }
            catch (Exception)
            {
                return TimeSpan.Zero;
            }
        }

        public static bool ToBoolean(this object s)
        {
            try
            {
                return (s != DBNull.Value && Convert.ToBoolean(s));
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool IsDate(this string tarih)
        {
            try
            {
                if (tarih == null) throw new Exception();
                Convert.ToDateTime(tarih);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool IsEmail(this string inputEmail)
        {
            if (string.IsNullOrEmpty(inputEmail)) return false;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                              @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                              @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

        public static string DateTimeFormatDown(this DateTime dateTime)
        {
            string s = String.Format("{0}-{1:00}-{2:00} {3:00}:{4:00}", dateTime.Day, dateTime.Month, dateTime.Year, 0, 0);
            return s.ToString();
        }

        public static string DateTimeFormatUp(this DateTime dateTime)
        {
            string s = String.Format("{0}-{1:00}-{2:00} {3:00}:{4:00}", dateTime.Day, dateTime.Month, dateTime.Year, 23, 59);
            return s.ToString();
        }

        public static string DateTimeFormatMid(this DateTime dateTime)
        {
            string s = String.Format("{0}-{1:00}-{2:00} {3:00}:{4:00}", dateTime.Day, dateTime.Month, dateTime.Year, 12, 00);
            return s.ToString();
        }

        public static string DateTimeFormatHourAndMinute(this DateTime dateTime)
        {
            string s = String.Format("{0}-{1:00}-{2:00} {3:00}:{4:00}", dateTime.Day, dateTime.Month, dateTime.Year, dateTime.Hour, dateTime.Minute);
            return s.ToString();
        }
        public static DateTime ToShortDateTimeFormat(this DateTime dateTime)
        {
            string s = String.Format("{0}-{1:00}-{2:00} {3:00}:{4:00}", dateTime.Day, dateTime.Month, dateTime.Year, 0, 0);
            return s.ToDateTime();
        }
        public static string GetIsNullOrEmpty(string value) => !string.IsNullOrEmpty(value) ? value : "";

        public static List<T> DataTableToListEntity<T>(this DataTable dataTable)
        {
            var columnNames = dataTable.Columns.Cast<DataColumn>()
                .Select(c => c.ColumnName)
                .ToList();
            var properties = typeof(T).GetProperties();
            return dataTable.AsEnumerable().Select(row =>
            {
                var objT = Activator.CreateInstance<T>();
                foreach (var pro in properties)
                {

                    if (columnNames.Contains(pro.Name))
                    {

                        Type convertTo = Nullable.GetUnderlyingType(pro.PropertyType) ?? pro.PropertyType;
                        var value = convertTo.ToString().ToLower().Contains("dbnull") ? null : row[pro.Name];
                        try
                        {
                            value = Convert.ChangeType(value, convertTo, null);
                        }
                        catch
                        {
                            continue;
                        }
                        pro.SetValue(objT, value);
                    }
                }
                return objT;
            }).ToList();
        }



    }
}
