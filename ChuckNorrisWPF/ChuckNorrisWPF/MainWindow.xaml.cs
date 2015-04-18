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
using ChuckNorris;

namespace ChuckNorrisWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ChuckNorrisQuotes _chuckNorrisQuotes = new ChuckNorrisQuotes();

        public MainWindow()
        {
            InitializeComponent();
            UpdateWithNextQuote();
        }

        private void UpdateWithNextQuote()
        {
            CurrentQuote.Text = _chuckNorrisQuotes.GetNextQuote();
        }

        private void NextQuote(object sender, RoutedEventArgs e)
        {
            UpdateWithNextQuote();
        }
    }
}
