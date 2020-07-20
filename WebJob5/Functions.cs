using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;

namespace WebJob5
{
    public class Functions
    {
        // This function will get triggered/executed when a new message is written 
        // on an Azure Queue called queue.
      
        public static void Run([TimerTrigger("%myJobschedule%")]TimerInfo myTimer, TextWriter log)
        {
            log.WriteLine("VishalTimer is running late!");
           // if (myTimer.IsPastDue)
            {
                log.WriteLine("Timer is running late!");
            }
            log.WriteLine($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
