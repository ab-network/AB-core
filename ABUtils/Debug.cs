using System;

namespace ABUtils
{
    public class Debug
    {
        static public void WriteLine(DebugLevel level, String str)
        {
            String strOutput = ' ' + DateTime.Now.ToString();

            switch (level)
            {
                case DebugLevel.Log:
                    strOutput += " [LOG] ";
                    break;
                case DebugLevel.Warning:
                    strOutput += " [WRN] ";
                    break;
                case DebugLevel.Error:
                    strOutput += " [ERR] ";
                    break;
                case DebugLevel.FatalError:
                    strOutput += " [FTL] ";
                    break;
            }

            strOutput += str;

            System.Console.WriteLine(strOutput);
        }
    }
}
