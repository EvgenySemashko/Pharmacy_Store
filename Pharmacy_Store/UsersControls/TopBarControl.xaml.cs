using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Pharmacy_Store.Models;

namespace Pharmacy_Store.UsersControls
{
    /// <summary>
    /// Логика взаимодействия для TopBarControl.xaml
    /// </summary>
    public partial class TopBarControl : UserControl
    {
        private string _selectedCity = string.Empty;
        private List<Product> _products;
        private List<AdressesPharmacy> _adressesPharmacies;


        public delegate void ComboBoxSelectionChangedHandler(IEnumerable collection);
        public static event ComboBoxSelectionChangedHandler NotifySelectionChanged;

        public TopBarControl()
        {
            InitializeComponent();

            
        }

        private void comboBoxCities_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ManagerWindow_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void searchBar_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
