using System;
using System.Diagnostics;
using System.Linq;

namespace dz6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Process[] processlist = Process.GetProcesses();

            foreach (Process theprocess in processlist)
            {
                Console.WriteLine("Process: {0} ID: {1}", theprocess.ProcessName, theprocess.Id);
            }
            
            two:
            Console.WriteLine("Введите ID процесса для завершения");
            string id = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(id))
                goto two;
            else
            {
                goto one;
            }
            one:

            Process programma = Process.GetProcessById(Int32.Parse(id));
            programma.Kill();
            programma.WaitForExit();

            Process[] processlist2 = Process.GetProcesses();

            foreach (Process theprocess in processlist2)
            {
                Console.WriteLine("Process: {0} ID: {1}", theprocess.ProcessName, theprocess.Id);
            }
            
            if (programma.Responding)                                                            //проверка статуса..Нужно дописать код, чтоб обновлялся процессЛист;
            {
                Console.WriteLine("Status = Работает");
            }
            else
            {
                Console.WriteLine("Status = Не отвечает");
            }

            Console.ReadKey();
            
        }
        
    }
}
