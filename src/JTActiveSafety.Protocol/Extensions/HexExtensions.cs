using System;
using System.Linq;

namespace JTActiveSafety.Protocol.Extensions
{
    /// <summary>
    /// 
    /// ref:"www.codeproject.com/tips/447938/high-performance-csharp-byte-array-to-hex-string-t"
    /// </summary>
    public static partial class HexExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="separator"></param>
        /// <returns></returns>
        public static string ToHexString(this byte[] source, string separator = " ")
        {
            var value = source.Select(s => s.ToString("X2"));
            return string.Join(separator, value);
        }

        /// <summary>
        /// 16进制字符串转16进制数组
        /// </summary>
        /// <param name="hexString"></param>
        /// <param name="separator"></param>
        /// <returns></returns>
        public static byte[] ToHexBytes(this string hexString,string separator=" ")
        {
            hexString = hexString.Replace(separator, "");
            byte[] buf = new byte[hexString.Length / 2];
            ReadOnlySpan<char> readOnlySpan = hexString.AsSpan();
            for (int i = 0; i < hexString.Length; i++)
            {
                if (i % 2 == 0)
                {
                    buf[i / 2] = Convert.ToByte(readOnlySpan.Slice(i, 2).ToString(), 16);
                }
            }
            return buf;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static string ReadNumber(this byte value, string format = "X2")
        {
            return value.ToString(format);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static string ReadNumber(this int value, string format = "X8")
        {
            return value.ToString(format);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static string ReadNumber(this uint value, string format = "X8")
        {
            return value.ToString(format);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static string ReadNumber(this long value, string format = "X16")
        {
            return value.ToString(format);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static string ReadNumber(this ulong value, string format = "X16")
        {
            return value.ToString(format);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static string ReadNumber(this short value, string format = "X4")
        {
            return value.ToString(format);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        public static string ReadNumber(this ushort value, string format = "X4")
        {
            return value.ToString(format);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ReadOnlySpan<char> ReadBinary(this ushort value)
        {
            return System.Convert.ToString(value, 2).PadLeft(16, '0').AsSpan();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ReadOnlySpan<char> ReadBinary(this short value)
        {
            return System.Convert.ToString(value, 2).PadLeft(16, '0').AsSpan();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ReadOnlySpan<char> ReadBinary(this uint value)
        {
            return System.Convert.ToString(value, 2).PadLeft(32, '0').AsSpan();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ReadOnlySpan<char> ReadBinary(this int value)
        {
            return System.Convert.ToString(value, 2).PadLeft(32, '0').AsSpan();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ReadOnlySpan<char> ReadBinary(this byte value)
        {
            return System.Convert.ToString(value, 2).PadLeft(8, '0').AsSpan();
        }

    }
}
