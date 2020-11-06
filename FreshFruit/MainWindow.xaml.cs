using FreshFruit.Controller;
using FreshFruit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace FreshFruit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, BucketEventListener
    {
        Seller RDj;
        public MainWindow()
        {
            InitializeComponent();
            Bucket keranjangBuah = new Bucket(10);
            BucketController bucketController = new BucketController(keranjangBuah, this);

            RDj = new Seller("RDJ", bucketController);
            ListBoxBucket.ItemsSource = keranjangBuah.findAll();
        }

        private void OnButtonAddAnggurClicked(object sender, RoutedEventArgs e)
        {
            Fruit anggur = new Fruit("Anggur");
            RDj.addFruit(anggur);

            ListBoxBucket.Items.Refresh();
        }

        private void OnButtonAddApelClicked(object sender, RoutedEventArgs e)
        {
            Fruit apel = new Fruit("Apel");
            RDj.addFruit(apel);

            ListBoxBucket.Items.Refresh();

        }

        private void OnButtonAddPisangClicked(object sender, RoutedEventArgs e)
        {
            Fruit Pisang = new Fruit("Pisang");
            RDj.addFruit(Pisang);

            ListBoxBucket.Items.Refresh();
        }

        private void OnButtonAddJerukClicked(object sender, RoutedEventArgs e)
        {
            Fruit Jeruk = new Fruit("Jeruk");
            RDj.addFruit(Jeruk);

            ListBoxBucket.Items.Refresh();
        }

        public void onSucceed(string massage)
        {
            ListBoxBucket.Items.Refresh();
        }

        public void onFailed(string massage)
        {
            MessageBox.Show(massage);
        }
    }
}
