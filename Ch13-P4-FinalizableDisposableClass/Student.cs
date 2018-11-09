using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch13_P4_FinalizableDisposableClass
{
    class Student : IDisposable
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Gpa { get; set; }

        public unsafe string crush { get; set; }
        public unsafe  bool? TcFactor { get; set; }

        public unsafe int* intPtr;

        ~Student()
        {
            Console.WriteLine(" Student Finalizeable function Invoked ");
            Console.WriteLine(" Removing all unmanaged resources... ");
            // code to remove unmanaged resources
           // intPtr = 0;
           
        }

        public void Dispose()
        {
            Console.WriteLine(" Student Finalizeable function Invoked ");
            Console.WriteLine(" Removing all unmanaged and managed resources... ");
            // code to remove unmanaged and managed resources

            GC.SuppressFinalize(this); // Stop CLR to invoke Finalize() method and any other default garbage collection
        }
    }
}
