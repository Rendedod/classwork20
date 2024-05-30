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

namespace WPF20._2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
                korzina.Items.Add("Молоко");   
        }

        private void Bread_Checked(object sender, RoutedEventArgs e)
        {
            korzina.Items.Add("Хлеб");
        }

        private void Chees_Checked(object sender, RoutedEventArgs e)
        {
            korzina.Items.Add("Сыр");
        }

        private void Kolbasa_Checked(object sender, RoutedEventArgs e)
        {
            korzina.Items.Add("Колбаса");
        }

        private void Bread_Unchecked(object sender, RoutedEventArgs e)
        {
            for (int i = 1; i < korzina.Items.Count; i++)
            {
                if (Convert.ToString(korzina.Items[i]) == "Хлеб")
                {
                    korzina.Items.RemoveAt(i);
                }
            }
        }

        private void milk_Unchecked(object sender, RoutedEventArgs e)
        {
            for (int i = 1; i < korzina.Items.Count; i++)
            {
                if (Convert.ToString(korzina.Items[i]) == "Молоко")
                {
                    korzina.Items.RemoveAt(i);
                }
            }
        }

        private void Chees_Unchecked(object sender, RoutedEventArgs e)
        {
            for (int i = 1; i < korzina.Items.Count; i++)
            {
                if (Convert.ToString(korzina.Items[i]) == "Сыр")
                {
                    korzina.Items.RemoveAt(i);
                }
            }
        }

        private void Kolbasa_Unchecked(object sender, RoutedEventArgs e)
        {
            for (int i = 1; i < korzina.Items.Count; i++)
            {
                if (Convert.ToString(korzina.Items[i]) == "Колбаса")
                {
                    korzina.Items.RemoveAt(i);
                }
            }
        }
    }
}
