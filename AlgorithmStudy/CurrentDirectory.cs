using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmStudy
{
    class CurrentDirectory
    {
        public void GetCurrent()
        {
            Console.WriteLine(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            Console.WriteLine(System.Environment.CurrentDirectory);
            Console.WriteLine(System.IO.Directory.GetCurrentDirectory());
            Console.WriteLine(System.AppDomain.CurrentDomain.BaseDirectory);
            Console.WriteLine(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase);
            //Console.WriteLine(System.Windows.Forms.Application.StartupPath);
            //Console.WriteLine(System.Windows.Forms.Application.ExecutablePath);
        }
    }
}
