using DependencyInjection.Dependencies;
using Foundation;

namespace DependencyInjection.iOS.Dependencies
{
    public class AppInformation : IAppInformation
    {
        public string Version => 
            NSBundle.MainBundle.ObjectForInfoDictionary( "CFBundleShortVersionString" ).ToString();
    }
}