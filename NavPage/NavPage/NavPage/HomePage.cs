using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace NavPage
{
    class HomePage : ContentPage
    {
        Button homeButton;
        public HomePage()
        {
            Title = "Hierarchical Navigation";
            Label homeLabel = new Label
            {
                Text = "Home Page",
                FontSize = 40
            };

            homeButton = new Button
            {
                Text = "Go to Second Page"
            };

            Button button = new Button { Text = "Show Alert" };

            Button buttonBoolean = new Button { Text = "Show Boolean Alert" };

            button.Clicked += async (sender, e) =>
            {
                await DisplayAlert("Hey", "You really should know about this.", "OK");
            };
            
            buttonBoolean.Clicked += async (sender, e) =>
            {
                Boolean answer = await DisplayAlert("Start",
                "Are you ready to begin?", "Yes", "No");
            };

            homeButton.Clicked += async (sender, args) =>
            await Navigation.PushAsync(new SecondPage(), true);

            StackLayout stackLayout = new StackLayout
            {
                Children =
                {
                    homeLabel,
                    homeButton,
                    button,
                    buttonBoolean
                }
            };

            this.Content = stackLayout;
        }
    }
}
