using Xamarin.Forms;

namespace NavPage
{
    internal class SecondPage : ContentPage
    {
        public SecondPage()
        {
            Title = "Hierarchical Navigation";
            Label homeLabel = new Label
            {
                Text = "Second Page",
                FontSize = 40
            };
            var stackLayout = new StackLayout
            {
                Children = { homeLabel }
            };
            this.Content = stackLayout;
        }
    }
}