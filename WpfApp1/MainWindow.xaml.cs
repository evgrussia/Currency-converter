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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CurrencyRate cr;
        CurrencyParser cp;
        public MainWindow()
        {
            InitializeComponent();
            cp = new CurrencyParser();

            cr = new CurrencyRate(cp.GetRate());
        }

        private void TextUSD_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextRub.Text =cr.CovertFromUSDtoRUB(TextUSD.Text);
        }
    }
}
