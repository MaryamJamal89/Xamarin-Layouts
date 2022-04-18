using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ContentViewScreen(object sender, EventArgs e)
        {
            App.Current.MainPage = new ContentView();
        }

        private void RelativeScreen(object sender, EventArgs e)
        {
            App.Current.MainPage = new RelativeLayout();
        }

        private void Relative2Screen(object sender, EventArgs e)
        {
            App.Current.MainPage = new RelativeLayout2();
        }

        private void StackScreen(object sender, EventArgs e)
        {
            App.Current.MainPage = new StackLayout();
        }

        private void ScrollViewScreen(object sender, EventArgs e)
        {
            App.Current.MainPage = new ScrollView();
        }

        private void GridScreen(object sender, EventArgs e)
        {
            App.Current.MainPage = new GridLayout();
        }
    }
}
