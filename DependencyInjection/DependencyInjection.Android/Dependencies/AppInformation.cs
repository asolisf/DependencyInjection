using System;
using Android.App;
using Android.Content.PM;
using DependencyInjection.Dependencies;

namespace DependencyInjection.Droid.Dependencies
{
    public class AppInformation : IAppInformation
    {
        public string Version
        {
            get
            {
                var context = Application.Context;

                PackageManager manager = context.PackageManager;
                PackageInfo info = manager.GetPackageInfo( context.PackageName, default(int) );

                return info.VersionName;
            }
        }
    }
}