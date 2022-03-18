using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    public class Excectionlog : Exception
    {
        private readonly string message = "Requested resource could not be found.";

        public Excectionlog(string message, int callfunc)
        {
            if (callfunc == 1)
                LogNotepad(message);
            else if (callfunc == 2)
                LogDB(message);
            else if (callfunc == 3)
                LogMail(message);
        }

        public Excectionlog()
        {            
            string m_exePath = @"D:\Ramu\Sample\Sample\Logs\Log-File.txt";
            using (StreamWriter w = File.AppendText(m_exePath))
            {
                w.Write(DateTime.Now + " -- " + message);
                w.WriteLine();
            }
        }

        public void LogNotepad(string message)
        {
            string m_exePath = @"D:\Ramu\Sample\Sample\Logs\Log-File.txt";
            using (StreamWriter w = File.AppendText(m_exePath))
            {
                w.Write(DateTime.Now + " -- " + message);
                w.WriteLine();
            }
            Console.WriteLine("Log File Updated"); 
        }

        public void LogDB(string message)
        {
            string str = DBMethod.LogDB(message);
            Console.WriteLine(str);
        }

        public void LogMail(string message)
        {
            string str = SendMail.Sentemail(message);
            Console.WriteLine(str);
        }
    }
}
