namespace dBASE.NET.Encoders
{
    using System;
    using System.Globalization;
    using System.Text;

    internal class DateEncoder : IEncoder
    {
        private const string format = "yyyyMMdd";

        private static DateEncoder instance;

        private DateEncoder() { }

        public static DateEncoder Instance => instance ?? (instance = new DateEncoder());

        /// <inheritdoc />
        public byte[] Encode(DbfField field, object data, Encoding encoding)
        {
            string text;
            if (data is DateTime dt)
            {
                text = dt.ToString(format).PadLeft(field.Length, ' ');
            }
            else
            {
                text = field.DefaultValue;
            }

            return encoding.GetBytes(text);
        }

        /// <inheritdoc />
        public object Decode(byte[] buffer, byte[] memoData, Encoding encoding)
        {
            DateTime result;
            string text = encoding.GetString(buffer).Trim();

            if (DateTime.TryParseExact(text, format, CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}