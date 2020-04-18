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
    public partial class AdvisorsPage : ContentPage
    {
        public AdvisorsPage()
        {
            InitializeComponent();
        }
        void Doctor1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DoctorPage1());
        }
        void Doctor2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DoctorPage2());
        }
        void Doctor3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DoctorPage3());
        }
        void GoHome(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RootPage());
        }
    }
}