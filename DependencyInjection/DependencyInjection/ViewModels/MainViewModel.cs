using DependencyInjection.Dependencies;
using DependencyInjection.Services.Logger;
using System;
using System.ComponentModel;

namespace DependencyInjection.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string versionName;
        public string VersionName
        {
            get
            {
                return versionName;
            }
            private set
            {
                if(versionName != value)
                {
                    versionName = value;
                    this.notifyPropertyChanged(nameof(this.VersionName));
                }
            }
        }

        private readonly ILoggerService loggerService;

        private readonly IAppInformation appInformation;

        /// <summary>
        /// Is best practice inject dependencies in constructor,
        /// This can be Mock in UnitTest
        /// </summary>
        /// <param name="loggerService">Logger service interface</param>
        public MainViewModel(ILoggerService loggerService, IAppInformation appInformation)
        {
            this.loggerService = loggerService;
            this.appInformation = appInformation;

            this.initializeProperties();
        }

        private void initializeProperties()
        {
            this.VersionName = this.appInformation.Version;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void notifyPropertyChanged(string propertyName )
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
        }
    }
}
