

// See https://aka.ms/new-console-template for more information
using SDDC_consoleApp_editFile;
using System.Collections.Generic;


if (!FileMethods.ReadIndexSnFile(@"C:\SDCC_MEMORY\"))
    Environment.Exit(0);

if (!FileMethods.ReadWeekFile(@"C:\SDCC_MEMORY\"))
    Environment.Exit(0);

if (!DateHelper.CheckForChangeWeek())
    Environment.Exit(0);

 Console.WriteLine(Memory.IndexOfSerialNumber);

 if(Memory.ParseSerialToInt())
{
    Memory.IncrementParsedSerialNumber();

    var res = DigitsList.ListOfDigits[Memory.ParsedSerialIndex];
    FileMethods.SaveIndexMemoryFile(Memory.ParsedSerialIndex.ToString(), @"C:\SDCC_MEMORY\");
    FileMethods.SaveSnFile(res, @"C:\SDCC_MEMORY\");
    FileMethods.SaveSnFile(res, @"C:\SDCC\");
    Console.WriteLine(res);
}





//Console.ReadKey();