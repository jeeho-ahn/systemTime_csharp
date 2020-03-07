/**
 * C# Program Utilizes system time and create a folder/file named by the date
 * Might find useful when a system needs to manage massive log files by dates
 * This program will first check if a folder named by the same date exists at the designated path.
 * If it doesn't, it will create a new folder named by the system time, then create a necessacy file into it.
 * It will return when it does exist.
 * Jeeho Ahn
 * Mar. 5th, 2020
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create_folder_by_date
{
    class systemTime_csharp
    {
        static void Main(string[] args)
        {
            String test_path = "C:/";
            String date = DateTime.Now.ToString("dd-MM-yyyy"); //date format can by modified (i.e. MM-dd-yyyy)
            if (!Directory.Exists(test_path + date))
            {
                Directory.CreateDirectory(test_path + date);
                File.Create(test_path + date + "/" + "test_log_file.csv").Dispose();
            }
        }
    }
}
