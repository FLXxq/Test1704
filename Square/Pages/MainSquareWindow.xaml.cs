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
using Library;

namespace Square.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainSquareWindow.xaml
    /// </summary>
    public partial class MainSquareWindow : Page
    {
        public MainSquareWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int ResultA = int.Parse(TextBoxA.Text);
            int ResultB = int.Parse(TextBoxB.Text);
            int ResultC = int.Parse(TextBoxC.Text);

            TextBoxResult.Text = SquareMethod.ResultSqrt(ResultA, ResultB, ResultC);
        }
    }
}
