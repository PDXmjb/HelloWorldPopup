using System;

using Xamarin.Forms;

namespace HelloWorldPopup
{
    public class AbsolutePage : ContentPage
    {
        public AbsolutePage()
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

