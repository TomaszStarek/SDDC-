using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDDC_consoleApp_editFile
{
    public static class Memory
    {
        public static string IndexOfSerialNumber { get; set; }
        public static int ParsedSerialIndex { get; set; } = 0;
        public static string WeekOfLastPart { get; set; }


        public static bool ParseSerialToInt()
        {

            try
            {
                ParsedSerialIndex = Convert.ToInt32(IndexOfSerialNumber);
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Błąd parsowania numeru seryjnego!!" + ex.Message);
            }
            return false;
         }

        public static void IncrementParsedSerialNumber()
        {
            ParsedSerialIndex++;
        }
        public static string TransformParsedSerialAndReturnHexString()
        {
            var hexValue = ParsedSerialIndex.ToString("X");
            return hexValue.PadLeft(3, '0');
        }
    }
}
