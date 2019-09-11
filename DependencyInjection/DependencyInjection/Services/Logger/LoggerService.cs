using System;

namespace DependencyInjection.Services.Logger
{
    public class LoggerService : ILoggerService
    {
        public void Error( Exception e )
        {
            //Do something. Analytics, Tracking, Write LogFile etc.
        }
    }
}
