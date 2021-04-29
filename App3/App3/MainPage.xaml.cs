using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void buttonGuardar_Clicked(object sender, EventArgs e)
        {
            var label = new Label { Text = Conductor.Text, BackgroundColor = Color.White, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, TextColor = Color.Black, FontSize = 50, };
            var label1 = new Label { Text = Marca.Text, BackgroundColor = Color.White, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, TextColor = Color.Black, FontSize = 50, };
            var label2 = new Label { Text = Modelo.Text, BackgroundColor = Color.White, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, TextColor = Color.Black, FontSize = 50, };
            Parcial.Children.Add(label);
            Parcial.Children.Add(label1);
            Parcial.Children.Add(label2);
        }
    }
}
