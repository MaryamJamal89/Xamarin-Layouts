using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RelativeLayout2 : ContentPage
    {
        public RelativeLayout2()
        {
            InitializeComponent();
        }

        private void MainScreen(object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }
    }
}