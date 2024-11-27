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
            // Haal de geselecteerde waarde van de ComboBox op
            var selectedItem = ColorComboBox.SelectedItem as ComboBoxItem;

            // Controleer of er een item is geselecteerd
            if (selectedItem != null)
            {
                string selectedColor = selectedItem.Content.ToString();

                // Stel de achtergrondkleur in op basis van de geselecteerde kleur
                if (selectedColor == "Blauw")
                {
                    ((Grid)this.Content).Background = new SolidColorBrush(Colors.Blue);
                }
                else if (selectedColor == "Groen")
                {
                    ((Grid)this.Content).Background = new SolidColorBrush(Colors.Green);
                }
                else if (selectedColor == "Rood")
                {
                    ((Grid)this.Content).Background = new SolidColorBrush(Colors.Red);
                }
            }
            else
            {
                // Indien geen item is geselecteerd, kan je een foutmelding of default kleur tonen
                ((Grid)this.Content).Background = new SolidColorBrush(Colors.Gray); // voorbeeld fallback kleur
            }
        }
    }
}
