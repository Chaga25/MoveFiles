using System;
using System.IO;

namespace MoveFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            MoveFiles(@"D:\SecondFolder", new DateTime(2022,01,04));
        }

        public static void MoveFiles(string saidan, DateTime changeDate)
        {
            string newFolder = @"D:\NewFolder";
            DateTime lastchange_date;

            var files = Directory.EnumerateFiles(saidan);
            foreach(var item in files)
            {
                lastchange_date = File.GetLastWriteTime(item);
                if (lastchange_date > changeDate)
                {
                    string sl=@"\";
                    string itemName = $"{newFolder}{sl}{Path.GetFileName(item)}";
                    Directory.Move(item,itemName);
                }
            }
        }
    }
}
