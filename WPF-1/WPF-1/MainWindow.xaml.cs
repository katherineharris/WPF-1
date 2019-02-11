using System;
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

namespace WPF_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string name, address;
            int zipCode;

            name = txtName.Text;
            address = txtAddress.Text;
            zipCode = Convert.ToInt32(txtZipCode.Text);
            bool isFormValid = true;
            if(name =="" || name== string.Empty)
            {
                MessageBox.Show("Please input your name");
                txtName.Focus();
                isFormValid = false;
            }
            if (address == "")
            {
                MessageBox.Show("Please input your address");
                //txtAddress.Focus();
                isFormValid = false;
            }
            if (zipCode == 0)
            {
                MessageBox.Show("Please input your zip code");
                //txtZipCode.Focus();
                isFormValid = false;
            }
            if(isFormValid == false)
            {
                return;
            }
            EntryForm ef = new EntryForm();
            ef.Name = name;
            ef.Address = address;
            ef.ZipCode = zipCode;

            
            lstentry.Items.Add(ef);
        }
    }
}
