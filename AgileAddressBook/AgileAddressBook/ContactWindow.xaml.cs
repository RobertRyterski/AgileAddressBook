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
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace AgileAddressBook
{
    /// <summary>
    /// Interaction logic for ContactWindow.xaml
    /// </summary>
    public partial class ContactWindow : Window
    {
        private ObservableCollection<Contact> _contacts;
        private string _mode;
        private Contact _original;

        public ContactWindow()
        {
            InitializeComponent();
        }

        public ContactWindow(ObservableCollection<Contact> contacts, int index, string mode)
        {
            InitializeComponent();
            Contact context = new Contact();
            _contacts = contacts;
            _mode = mode;

            if (_mode.Equals("add"))
            {
                Title = "Add Contact";
            }
            else if (_mode.Equals("edit"))
            {
                if (index >= 0 && index < contacts.Count)
                {
                    _original = contacts[index];
                }
                else
                {
                    return;
                }                
                Title = "Edit Contact";
                // copy properties of selected contact for local edits
                // global change will occur when OK is hit
                context.FirstName = _original.FirstName;
                context.LastName = _original.LastName;
                context.Phone = _original.Phone;
                context.Address = _original.Address;
                context.City = _original.City;
                context.State = _original.State;
                context.Zip = _original.Zip;
            }
            DataContext = context;
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            Contact context = (Contact)DataContext;
            if (context == null)
            {
                return;
            }
            if(_mode.Equals("add") && context.FirstName != null)
            {
                _contacts.Add(context);
            }
            else if (_mode.Equals("edit"))
            {
                _original.FirstName = context.FirstName;
                _original.LastName = context.LastName;
                _original.Phone = context.Phone;
                _original.Address = context.Address;
                _original.City = context.City;
                _original.State = context.State;
                _original.Zip = context.Zip;
            }
            Close();
        }
    }
}
