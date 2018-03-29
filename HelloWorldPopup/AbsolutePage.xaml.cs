using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloWorldPopup
{
    public partial class AbsolutePage : ContentPage
    {
        public AbsolutePage()
        {
            InitializeComponent();

            var layout = new AbsoluteLayout();

            var aquaBox = new BoxView { Color = Color.Aqua };
            layout.Children.Add(aquaBox, 
                                new Rectangle(0, 0, 1, 1), 
                                AbsoluteLayoutFlags.All);

            // Sets a new size of the bounds
            AbsoluteLayout.SetLayoutBounds(aquaBox, new Rectangle(0, 0, 1, 1));

            // Changes flags, if you want to move from proportional to static or visa-versa.
            AbsoluteLayout.SetLayoutFlags(aquaBox, AbsoluteLayoutFlags.HeightProportional);

            //Content = layout;
        }
    }
}
