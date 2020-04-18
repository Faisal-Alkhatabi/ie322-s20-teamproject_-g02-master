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
    public partial class RootPage : ContentPage
    {
        public RootPage()
        {
            InitializeComponent();
        }


        void Advisors_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AdvisorsPage());
        }
        void Appointment_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AppointmentPage());
        }
        void About_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutPage());
        }
        void Logout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LogoutPage());
        }


    }
}