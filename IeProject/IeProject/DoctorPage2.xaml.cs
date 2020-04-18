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
    public partial class DoctorPage2 : ContentPage
    {
        public DoctorPage2()
        {
            InitializeComponent();
        }
        void GoHome(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RootPage());
        }
    }
}