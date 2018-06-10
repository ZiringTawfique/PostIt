using System;
using Xamarin.Forms;

namespace PostIt.FrontEnd.Views
{
    public partial class MainPage: ContentPage
    {
        public MainPage()
        {
            

            var grid = new Grid
            {
                RowSpacing = 20,
                ColumnSpacing = 4,
                BackgroundColor = Color.Black

            };
            var label = new Label { Text = "Label 1", FontSize = 20 };

            grid.Children.Add(label, 5, 3);

            Grid.SetRowSpan(label, 2);
            Grid.SetColumnSpan(label, 2);

            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(100, GridUnitType.Absolute) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) });



        }



    }
}
