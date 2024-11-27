using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using Windows.UI;

namespace Kleuren_Veranderen
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void OnChangeColorButtonClick(object sender, RoutedEventArgs e)
        {
            // Haal de geselecteerde kleur op uit de ComboBox, de waarde is een SolidColorBrush (de Background)
            var selectedColor = ColorComboBox.SelectedValue as SolidColorBrush;

            // Zet een breakpoint op de volgende regel om het datatype van selectedColor te inspecteren
            if (selectedColor != null)
            {
                // De geselecteerde kleur is een SolidColorBrush, dus we kunnen deze direct toepassen
                ((Grid)this.Content).Background = selectedColor;
            }
            else
            {
                // Als er geen waarde is geselecteerd, stel je een fallback-kleur in (bijvoorbeeld grijs)
                ((Grid)this.Content).Background = new SolidColorBrush(Colors.Gray);
            }
        }
    }
}
