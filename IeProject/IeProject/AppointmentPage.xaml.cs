using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IeProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppointmentPage : ContentPage
    {
        public AppointmentPage()
        {
            InitializeComponent();
        }
        void Slct1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SchedulPage1());
        }
        void Slct2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SchedulPage2());
        }
        void Slct3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SchedulPage3());
        }
        void GoHome(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RootPage());
        }
    }
}