using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(File.Exists("Logs/Log-File.txt"));
                string strValue = "Neuroscience Readies for a Showdown Over Consciousness Ideas";
                string[] arr = strValue.Split(' ');
                int lenght = 0;
                int index = 0;
                int highIndex = 0;
                foreach (var item in arr)
                {
                    int temp = item.Length;                    
                    if (temp > lenght)
                    {
                        lenght = temp;
                        highIndex = index;

                    }
                    index++;
                }
                Console.Write("Max Lenght - " + arr[index].ToString() +"--" + lenght.ToString());
                Console.WriteLine();
                var res = arr.Max(a => a.Length);
                Console.Write(res);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Enter Number to log in the selected Log Note");
                Console.WriteLine("Notepad - 1");
                Console.WriteLine("DataBase - 2");
                Console.WriteLine("Mail - 3");
                Console.Write("Enter value : ");
                int value = Convert.ToInt32(Console.ReadLine());
                throw new Excectionlog(ex.Message, value);
            }
            
        }
    }
}
