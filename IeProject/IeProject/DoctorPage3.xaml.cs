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
    public partial class DoctorPage3 : ContentPage
    {
        public DoctorPage3()
        {
            InitializeComponent();
        }
    void GoHome(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RootPage());
        }
    }
}