using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ajaplaan_Ilja_H
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ajaplaan_TimePicker : ContentPage
    {
        Label lbl;
        Image img;
        TimePicker timePicker;
        Grid gr;
        public Ajaplaan_TimePicker()
        {
            gr = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                }
            };
            timePicker = new TimePicker()
            {
                Time = new TimeSpan(0, 0, 0),
                Format = "T",
            };
            timePicker.PropertyChanged += TimePicker_PropertyChanged;

            lbl = new Label()
            {
                Text = " ",
                FontAttributes = FontAttributes.Bold,
                FontSize = 24,
                TextColor = Color.Black,
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
            };



            img = new Image();

            gr.Children.Add(timePicker, 0, 0);
            gr.Children.Add(img, 1, 0);

            StackLayout stackLayout = new StackLayout()
            {
                Children = { lbl, gr}
            };

            Content = stackLayout;
        }
        

        private void TimePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
            {
                var time = timePicker.Time.Hours;
                TimeSpan selctTime = timePicker.Time;
                if(time == 1)
                {
                    lbl.Text = "Python";
                    img.Source = ImageSource.FromFile("python.png");
                }
                else if(time == 2)
                {
                    lbl.Text = "C";
                    img.Source = ImageSource.FromFile("C.jpg");
                }
                else if (time == 3)
                {
                    lbl.Text = "C++";
                    img.Source = ImageSource.FromFile("Cpp.jpg");
                }
                else if (time == 4)
                {
                    lbl.Text = "C#";
                    img.Source = ImageSource.FromFile("Cs.jpg");
                }
                else if (time == 5)
                {
                    lbl.Text = "Golang";
                    img.Source = ImageSource.FromFile("Golang.png");
                }
                else if (time == 6)
                {
                    lbl.Text = "Java";
                    img.Source = ImageSource.FromFile("java.png");
                }
                else if (time == 7)
                {
                    lbl.Text = "JavaScript";
                    img.Source = ImageSource.FromFile("js.png");
                }
                else if (time == 8)
                {
                    lbl.Text = "PHP";
                    img.Source = ImageSource.FromFile("php.png");
                }
                else if (time == 9)
                {
                    lbl.Text = "Ruby";
                    img.Source = ImageSource.FromFile("rubypng.png");
                }
                else if (time == 10)
                {
                    lbl.Text = "Rust";
                    img.Source = ImageSource.FromFile("rust.png");
                }
                else if (time == 11)
                {
                    lbl.Text = "Swift";
                    img.Source = ImageSource.FromFile("swift.png");
                }
                else if (time == 0)
                {
                    lbl.Text = "TypeScript";
                    img.Source = ImageSource.FromFile("type.png");
                }

            }
        }
    }
}