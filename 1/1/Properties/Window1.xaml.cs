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
using System.Windows.Shapes;

namespace _1.Properties
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : System.Windows.Window
    {
        public int flag = -1;
        public int n;
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            int fl_1 = 1;
            try
            {
                n = Convert.ToInt32(T1.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка, введите пожалуйста положительное целое число число.");
                fl_1 = 0;
            }
            
            if (fl_1 == 1)
            {
                flag = 1;
                Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            flag = 0;
            Close();
        }
    }
}
