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

namespace ULer
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void up_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text.ToUpper();
        }

        private void low_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text.ToLower();
        }

        private void CamelCaseF_Click(object sender, RoutedEventArgs e)
        {
            string n = "";
            string[] r = textBox.Text.Split('_');
            foreach (string i in r)
            {
                n += i.Substring(0, 1).ToUpper() + i.Substring(1).ToLower();
            }

            textBox.Text = n;
        }

        private void CamelCase_Click(object sender, RoutedEventArgs e)
        {
            short c = 0;
            string n = "";
            string[] r = textBox.Text.Split('_');
            foreach (string i in r)
            {
                if (c == 0)
                {
                    n += i.ToString().ToLower();
                }
                else
                {
                    n += i.Substring(0, 1).ToUpper() + i.Substring(1).ToLower();
                }
                c++;
            }

            textBox.Text = n;
        }

        private void UnderScoreCase_Click(object sender, RoutedEventArgs e)
        {
            Boolean nounder = false;
            string n = "";
            string t = textBox.Text;
            for (int counter = 0; counter < t.Length; counter++)
            {
                char i = t[counter];
                // 大写字母
                nounder = i >= 65 && i <= 90 && counter > 0;
                if (nounder)
                { 

                    n += '_';
                    n += i.ToString().ToLower();
                }
                else
                {
                    n += i.ToString().ToLower();
                }
            }
            textBox.Text = n;
        }
    }
}
