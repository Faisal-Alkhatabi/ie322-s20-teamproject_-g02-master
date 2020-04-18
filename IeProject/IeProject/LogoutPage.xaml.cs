using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;
using static Xamarin.Forms.Platform.Android.Resource;

namespace IeProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogoutPage : ContentPage
    {
        public LogoutPage()
        {
            InitializeComponent();
        }
        string myPassword = "1234";
        string myUsername = "Faisal";

        private void Root_Clicked(object sender, EventArgs e)
        {
        string pass = PasswordEntry.Text;
        string user = UsernameEntery.Text;
            if (pass == myPassword && user == myUsername)
            {
                Navigation.PushAsync(new RootPage());
            }
            else
            {
                Incorrect.Text = "Username or Password is incorrect";
            }                
        }
    }
}


