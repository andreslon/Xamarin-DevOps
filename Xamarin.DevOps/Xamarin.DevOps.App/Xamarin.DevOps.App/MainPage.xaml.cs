using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin.DevOps.App
{
    public partial class MainPage : ContentPage
    { 
        Label lbl; 
        public MainPage()
        {
            InitializeComponent();
            var b = new Button
            {
                Text = "Click me",
                AutomationId = "MyButton"       // referenced in UITests
            };
            b.Clicked += (sender, e) => {
                lbl.Text = "Was clicked";
            };

            lbl = new Label
            {
                Text = "Hello, Xamarin.Forms!",
                AutomationId = "MyLabel"            // referenced in UITests
            };

            Content = new StackLayout
            {
                Padding = new Thickness(0, 20, 0, 0),
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Children = {
                    b, lbl
                }
            };
        }
    }
}
