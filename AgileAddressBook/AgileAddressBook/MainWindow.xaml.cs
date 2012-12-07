using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace AgileAddressBook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Contact> _contacts;

        public MainWindow()
        {
            InitializeComponent();
            // some contacts to get started with
            Contact[] start = {
                                  new Contact("Splint", "Chesthair", 5558675309, "123 Fake St", "Faketon", "MO", 666666),
                                  new Contact("Thick", "McRunfast", 1112223333, "42 Douglas Ave", "Flowerville", "MO", 123123)
                              };
            _contacts = new ObservableCollection<Contact>(start);
            contactDataGrid.ItemsSource = _contacts;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            Window w = new ContactWindow(_contacts, -1, "add");
            w.Show();
        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            int i = contactDataGrid.SelectedIndex;
            Window w = new ContactWindow(_contacts, i, "edit");
            w.Show();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (contactDataGrid.SelectedValue != null)
            {
                _contacts.Remove(contactDataGrid.SelectedValue as Contact);
            }
        }
    }
}
