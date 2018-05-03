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

namespace CustomTextBox
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

        private void txttest_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text != "")
            {
                ViewModel obj = new ViewModel();

                obj.test = textbox1.Text;
                Test.ShouldHighlightText = textbox1.Text;
                Test.ShouldHighlight = obj.Matches;
                Test.Focus();

                Test1.ShouldHighlightText = textbox1.Text;
                Test1.ShouldHighlight = obj.Matches;
                Test1.Focus();
                textbox1.Focus();
            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (textbox1.Text == "")
            {
                ViewModel obj = new ViewModel();
                obj.test = textbox1.Text;
                Test.ShouldHighlightText = textbox1.Text;
                Test.ShouldHighlight = obj.Matches;
                Test.Focus();

                Test1.ShouldHighlightText = textbox1.Text;
                Test1.ShouldHighlight = obj.Matches;
                Test1.Focus();
                textbox1.Focus();
            }
        }

    }
}
