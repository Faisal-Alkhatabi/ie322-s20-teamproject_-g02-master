using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IeProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SchedulPage3 : ContentPage
    {
        public SchedulPage3()
        {
            InitializeComponent();
        }

        private DateTime? _date;
        public DateTime? Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
                OnPropertyChanged(nameof(Date));
            }
        }
        private ObservableCollection<XamForms.Controls.SpecialDate> attendances;
        public ObservableCollection<XamForms.Controls.SpecialDate> Attendances
        {
            get
            {
                return attendances;
            }
            set
            {
                attendances = value;
                OnPropertyChanged(nameof(Attendances));
            }
        }
        public Command DateChosen
        {
            get
            {
                return new Command((obj) =>
                {
                    System.Diagnostics.Debug.WriteLine(obj as DateTime?);
                });
            }
        }
    }
}