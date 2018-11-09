using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch13_P4_FinalizableDisposableClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Dispose() / Destructor Combo Platter *****");
            // Call Dispose() manually. This will not call the finalizer.
            MyResourceWrapper rw = new MyResourceWrapper();
            rw.Dispose();
            // Don't call Dispose(). This will trigger the finalizer and cause a beep.
            MyResourceWrapper rw2 = new MyResourceWrapper();
        }
    }
}
