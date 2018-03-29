using System;

using Xamarin.Forms;

namespace HelloWorldPopup.GridLayout
{
    public class GridLayoutEx2 : ContentPage
    {
        public GridLayoutEx2()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

