using System;

namespace DependencyInjection.Services.Logger
{
    public interface ILoggerService
    {
        void Error(Exception e);
    }
}
