using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDDC_consoleApp_editFile
{
    public static class FileMethods
    {
        public static bool ReadIndexSnFile(string sciezka)
        {
            var path = Path.Combine(sciezka, @"IndexOfSerialToMark.txt");
          //  string sciezka = (@"C:\SDCC\serialToMark.txt");
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {


                    while (sr.Peek() >= 0)
                    {
                        Memory.IndexOfSerialNumber = sr.ReadLine();
                    }
                    sr.Close();
                }

            }
            catch (Exception ex)
            {
                //                MessageBox.Show(new Form { TopLevel = true, TopMost = true }, "Błąd odczytu limitów, załączam domyślne limity\n\n" + ex);
                return false;
            }
            return true;
        }

        public static bool ReadWeekFile(string sciezka)
        {
            var path = Path.Combine(sciezka, @"lastWeek.txt");
            //  string sciezka = (@"C:\SDCC\serialToMark.txt");
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {


                    while (sr.Peek() >= 0)
                    {
                        Memory.WeekOfLastPart = sr.ReadLine();                        
                    }
                    sr.Close();
                }

            }
            catch (Exception ex)
            {
                //                MessageBox.Show(new Form { TopLevel = true, TopMost = true }, "Błąd odczytu limitów, załączam domyślne limity\n\n" + ex);
                return false;
            }
            return true;

        }

        public static void SaveIndexMemoryFile(string serialToWrite, string sciezka)
        {
            //  string sciezka = (@"C:\SDCC");
            try
            {

                if (Directory.Exists(sciezka))       //sprawdzanie czy  istnieje
                {
                    ;
                }
                else
                    System.IO.Directory.CreateDirectory(sciezka); //jeśli nie to ją tworzy

                var path = Path.Combine(sciezka, @"IndexOfSerialToMark.txt");
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(serialToWrite);
                }
            }
            catch (Exception ex)
            {
                //                MessageBox.Show(new Form { TopLevel = true, TopMost = true }, "Błąd odczytu limitów, załączam domyślne limity\n\n" + ex);

            }

        }
        public static void SaveWeekMemoryFile(string sciezka)
        {
            //  string sciezka = (@"C:\SDCC");
            try
            {

                if (Directory.Exists(sciezka))       //sprawdzanie czy  istnieje
                {
                    ;
                }
                else
                    System.IO.Directory.CreateDirectory(sciezka); //jeśli nie to ją tworzy

                var path = Path.Combine(sciezka, @"lastWeek.txt");
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(Memory.WeekOfLastPart);
                }
            }
            catch (Exception ex)
            {
                //                MessageBox.Show(new Form { TopLevel = true, TopMost = true }, "Błąd odczytu limitów, załączam domyślne limity\n\n" + ex);

            }

        }




        public static void SaveSnFile(string sn, string sciezka)
        {
          //  string sciezka = (@"C:\SDCC");
            try
            {

                if (Directory.Exists(sciezka))       //sprawdzanie czy  istnieje
                {
                    ;
                }
                else
                    System.IO.Directory.CreateDirectory(sciezka); //jeśli nie to ją tworzy

                var path = Path.Combine(sciezka, @"serialToMark.txt");
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(sn);
                }
            }
            catch (Exception ex)
            {
                //                MessageBox.Show(new Form { TopLevel = true, TopMost = true }, "Błąd odczytu limitów, załączam domyślne limity\n\n" + ex);

            }

        }
    }
}

