using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace Log4netDemo
{
    class Program
    {


        static void Main(string[] args)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            log.Debug("Application started");
            try
            {
                log.Debug("Debug logging");
                log.Info("Info logging");
                log.Warn("Warn logging");
                log.Error("Error logging");
                log.Fatal("Fatal logging");


                double pi = 3.14159, zero = 0.0;
                double result = pi / zero;
            }
            catch (Exception ex)
            {

                log.Debug("Debug error logging", ex);
                log.Info("Info error logging", ex);
                log.Warn("Warn error logging", ex);
                log.Error("Error error logging", ex);
                log.Fatal("Fatal error logging", ex);
            }
        }
    }
}
