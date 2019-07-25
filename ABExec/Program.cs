using System;

using ABUtils;
using ABService;

namespace ABExec
{
    class Program
    {
        static int Main(string[] args)
        {
            Debug.WriteLine(DebugLevel.Log, "Initializing AB-network service.");

            try 
            {
                ServiceInstance instane = new ServiceInstance();
                Debug.WriteLine(DebugLevel.Log, "Loading Services...");
            }
            catch(Exception e)
            {
                // Global exception trap
                Debug.WriteLine(DebugLevel.FatalError, "fatal error has been occured! Code (" + e.HResult + ')');
                Debug.WriteLine(DebugLevel.FatalError, " **** error message *****************");
                Debug.WriteLine(DebugLevel.FatalError, e.Message);
                Debug.WriteLine(DebugLevel.FatalError, " **** stack tracing *****************");
                Debug.WriteLine(DebugLevel.FatalError, e.StackTrace);
                
                return -1;
            }

            return 0;
        }
    }
}
