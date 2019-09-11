using Autofac;
using DependencyInjection.Services.Logger;
using DependencyInjection.ViewModels;
using System;
using Xamarin.Forms;

namespace DependencyInjection
{
    public partial class App : Application
    {
        public static IContainer Container;

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        public static void RegisterDependencies(Action<ContainerBuilder> builder)
        {
            var containerBuilder = new ContainerBuilder();

            //ViewModels
            containerBuilder.RegisterType<MainViewModel>();

            //Services
            containerBuilder.RegisterType<LoggerService>().As<ILoggerService>().SingleInstance();

            //Invoke native dependencies from MainActivity or AppDelegate
            builder.Invoke(containerBuilder);

            Container = containerBuilder.Build();
        }
    }
}
