using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.Common
{
    public static class LoggingService
    {
        public static void WriteToFile(List<ILoggable> itemstoLog)
        {
            foreach (var item in itemstoLog)
            {
                Console.WriteLine(item.Log());
            }
        
        }
    }
}
