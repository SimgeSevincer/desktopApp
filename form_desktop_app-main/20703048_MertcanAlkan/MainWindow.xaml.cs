using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace _20703048_MertcanAlkan
{
    public partial class MainWindow : Window
    {
        ObservableCollection<MyObject> myObjects;
        public MainWindow()
        {
            InitializeComponent();
            myObjects = new ObservableCollection<MyObject>()
            {
                new MyObject(){C1 = "34KSD05", C2 = "ford fiesta",C3="225500",C4="Dİzel"},
            };
            this.dgContent.ItemsSource = myObjects;
            marka.Items.Add("ford fiesta");
            marka.Items.Add("ford modeo");
            marka.Items.Add("ford focus");
            marka.Items.Add("ford courier");
            marka.Items.Add("fiat egea");
            marka.Items.Add("fiat punto");
            marka.Items.Add("fiat doblo");
            marka.Items.Add("fiat ducato");
            marka.Items.Add("Toyata corolla");
            marka.Items.Add("Toyata auris");
            marka.Items.Add("kia rio");
            marka.Items.Add("kia stonic");
            marka.Items.Add("kia ceed");
            marka.Items.Add("renault clio");
            marka.Items.Add("renault megane");
            marka.Items.Add("renault kadjar");
        }

        private void Kapat_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
        }
        public class MyObject
        {
            public string? C1 { get; set; }
            public string? C2 { get; set; }
            public string? C3 { get; set; }
            public string? C4 { get; set; }

        }

        private void kayıt_Click(object sender, RoutedEventArgs e)
        {
            if (dizel.IsChecked == true && benzin.IsChecked == true && elektrik.IsChecked == true)
            {
                MessageBox.Show("Yakıt Türünü Birden fazla seçemezsiniz", "TEKRAR DENEYİN", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (plaka.Text.Length > 0 && marka.Text.Length > 0 && km.Text.Length > 0)
                if (benzin.IsChecked == true)
                {
                    MyObject myObject = new MyObject() { C1 = this.plaka.Text, C2 = this.marka.Text, C3 = this.km.Text, C4 = "Benzin LPG" };
                    myObjects.Add(myObject);
                    MessageBox.Show("Araç Başarıyla Eklendi ", "Uyarı Penceresi", MessageBoxButton.OK, MessageBoxImage.Information);
                }

            if (dizel.IsChecked == true)
            {
                MyObject myObject = new MyObject() { C1 = this.plaka.Text, C2 = this.marka.Text, C3 = this.km.Text, C4 = "Dizel" };
                myObjects.Add(myObject);
                MessageBox.Show("Araç Başarıyla Eklendi!", "Uyarı Penceresi", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            if (elektrik.IsChecked == true)
            {
                MyObject myObject = new MyObject() { C1 = this.plaka.Text, C2 = this.marka.Text, C3 = this.km.Text, C4 = "elektrik" };
                myObjects.Add(myObject);
                MessageBox.Show("Araç Başarıyla Eklendi!", "Uyarı Penceresi", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void sil_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Aracı silmek istiyormusunuz? Bu işlem geri alınamaz!", "Eminmisin?", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
                MessageBox.Show("İşlem İptal Edildi!", "BAŞARILI", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                myObjects.Remove((MyObject)dgContent.SelectedItem);
                MessageBox.Show("Araç Silindi!", "BAŞARILI", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void marka_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dgContent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}