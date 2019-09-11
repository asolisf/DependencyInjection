using Autofac;
using DependencyInjection.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace DependencyInjection
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible( false )]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //Resolve ViewModel instance and his dependencies
            BindingContext = App.Container.Resolve(typeof(MainViewModel));
        }
    }
}
