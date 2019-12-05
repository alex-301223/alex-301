using System;
using System.Collections.Generic;
using System.Collections;
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
using System.IO;
using Microsoft.Win32;

namespace _1
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

        Form1 f1 = new Form1();


        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            AboutBox1 a = new AboutBox1();
            a.Show();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount;
            try
            {
                itemCount = Convert.ToInt32(tbN.Text);
            }
            catch
            {

                itemCount = 0;
            }
            if (itemCount <= 0) MessageBox.Show("Введите положительное целое число");
            else
            {
                Random rnd1 = new Random();
                int number;
                lbMain.Items.Clear();
                f1.val = new int[itemCount];
                lbMain.Items.Add("Исходный массив");
                for (index = 0; index < itemCount; index++)
                {
                    number = 0 + rnd1.Next(200);
                    myAL.Add(number);
                    lbMain.Items.Add(number);
                    f1.val[index] = number;
                }
                myAL.Sort();
                lbMain.Items.Add("Отсортированный массив");
                foreach (int elem in myAL)
                {
                    lbMain.Items.Add(elem);
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount;
            try
            {
                itemCount = Convert.ToInt32(tbN.Text);
            }
            catch
            {

                itemCount = 0;
            }
            if (itemCount <= 0) MessageBox.Show("Введите положительное целое число");
            else
            {
                Random rnd1 = new Random();
                int number;
                lbMain.Items.Clear();
                f1.val = new int[itemCount];
                for (index = 0; index < itemCount; index++)
                {
                    number = 0 + rnd1.Next(200);
                    myAL.Add(number);
                    lbMain.Items.Add(number);
                    f1.val[index] = number;
                }

                int[] a = (int[])myAL.ToArray(typeof(int));
                int kol = 0;
                for (int i = 1; i < itemCount - 1; i++)
                {
                    if ((a[i] > a[i - 1]) && (a[i] > a[i + 1]))
                        kol++;
                }
                lbMain.Items.Add("Количество элементов, которые больше своих соседей");
                lbMain.Items.Add(kol);

            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount;
            try
            {
                itemCount = Convert.ToInt32(tbN.Text);
            }
            catch
            {

                itemCount = 0;
            }
            if (itemCount <= 0) MessageBox.Show("Введите положительное целое число");
            else
            {
                Random rnd1 = new Random();
                int number;
                lbMain.Items.Clear();
                f1.val = new int[itemCount];
                for (index = 0; index < itemCount; index++)
                {
                    number = 0 + rnd1.Next(200);
                    myAL.Add(number);
                    lbMain.Items.Add(number);
                    f1.val[index] = number;
                }

                int[] a = (int[])myAL.ToArray(typeof(int));
                int k = -1;
                for (int i = 0; i < itemCount; i++)
                {
                    if (a[i] > 25)
                    {
                        k = i;
                        break;
                    }

                }
                if (k == -1) MessageBox.Show("Такого элемента в массиве не оказалось");
                else
                {
                    lbMain.Items.Add("Номер первого элемента, значение которого больше чем 25");
                    lbMain.Items.Add(k + 1);
                }
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount;
            try
            {
                itemCount = Convert.ToInt32(tbN.Text);
            }
            catch
            {

                itemCount = 0;
            }
            if (itemCount <= 0) MessageBox.Show("Введите положительное целое число");
            else
            {
                Random rnd1 = new Random();
                int number;
                lbMain.Items.Clear();
                f1.val = new int[itemCount];
                for (index = 0; index < itemCount; index++)
                {
                    number = 0 + rnd1.Next(200);
                    myAL.Add(number);
                    lbMain.Items.Add(number);
                    f1.val[index] = number;
                }


                MessageBox.Show("Сейчас появится новое окно, в котором вам необходимо ввести число к, где к является целым числом, с которым вы хотите сравнить значение элементов массива, и найти первый, который больше чем к");
                Properties.Window1 w = new Properties.Window1();
                w.ShowDialog();
                int k = 0;
                if ((w.flag == 0) || (w.flag == -1)) MessageBox.Show("K не было введено. Операция отменена");
                else
                {
                    k = w.n;
                    lbMain.Items.Add("Введенное число к:");
                    lbMain.Items.Add(k);






                    int[] a = (int[])myAL.ToArray(typeof(int));
                    int t = -1;
                    for (int i = 0; i < itemCount; i++)
                    {
                        if (a[i] > k)
                        {
                            t = i;
                            break;
                        }

                    }
                    if (t == -1) MessageBox.Show("Элемента, значение которого больше чем введенное к, в массиве не оказалось");
                    else
                    {
                        lbMain.Items.Add("Номер первого элемента, значение которого больше чем  к");
                        lbMain.Items.Add(t + 1);
                    }


                }
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount;
            try
            {
                itemCount = Convert.ToInt32(tbN.Text);
            }
            catch
            {

                itemCount = 0;
            }
            if (itemCount <= 0) MessageBox.Show("Введите положительное целое число");
            else
            {
                Random rnd1 = new Random();
                int number;
                lbMain.Items.Clear();
                f1.val = new int[itemCount];
                for (index = 0; index < itemCount; index++)
                {
                    number = 0 + rnd1.Next(200);
                    myAL.Add(number);
                    lbMain.Items.Add(number);
                    f1.val[index] = number;
                }


                MessageBox.Show("Сейчас появится новое окно, в котором вам необходимо ввести число к, где к индексом элемента массива, с которым вы хотите сравнить значение элементов массива, и найти сумму элементов, которые больше чем к-ый элемента массива");
                Properties.Window1 w = new Properties.Window1();
                w.ShowDialog();
                int k = 0;
                if ((w.flag == 0) || (w.flag == -1)) MessageBox.Show("K не было введено. Операция отменена");

                else
                {
                    k = w.n;
                    lbMain.Items.Add("Введенное число к:");
                    lbMain.Items.Add(k);

                    if (k < 0) MessageBox.Show("Введено отрицательное число, индекс не может быть отрицательным");
                    else if (k > itemCount) MessageBox.Show("Такого элемента с индексом к не существует");

                    else
                    {


                        int[] a = (int[])myAL.ToArray(typeof(int));
                        int m = a[k];
                        int t = 0;
                        for (int i = 0; i < itemCount; i++)
                        {
                            if (a[i] > m)

                                t += a[i];

                        }
                        if (t == 0) MessageBox.Show("Элемента, значение которого больше чем элемент с индексом к, в массиве не оказалось");
                        else
                        {
                            lbMain.Items.Add("Сумма элементов, больше чем к-ый элемент");
                            lbMain.Items.Add(t);
                        }

                    }
                }
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount;
            try
            {
                itemCount = Convert.ToInt32(tbN.Text);
            }
            catch
            {

                itemCount = 0;
            }
            if (itemCount <= 0) MessageBox.Show("Введите положительное целое число");
            else if (itemCount == 1) MessageBox.Show("Один элемент в массиве не может находиться, так как задание требует минимум двух элементов");
            else
            {
                Random rnd1 = new Random();
                int number;
                lbMain.Items.Clear();
                f1.val = new int[itemCount];
                for (index = 0; index < itemCount; index++)
                {
                    number = 0 + rnd1.Next(200);
                    myAL.Add(number);
                    lbMain.Items.Add(number);
                    f1.val[index] = number;
                }

                int[] a = (int[])myAL.ToArray(typeof(int));
                int k = 0;
                for (int i = 0; i < itemCount; i++)
                {
                    if (a[i] > a[1])
                    {
                        k += a[i];

                    }

                }
                if (k == 0) MessageBox.Show("Такого элемента в массиве не оказалось");
                else
                {
                    lbMain.Items.Add("Сумма элементов, значение которых больше чем второй элемент");
                    lbMain.Items.Add(k);
                }
            }
        }




        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            SaveFileDialog myDialog = new SaveFileDialog();
            myDialog.Filter = "Текст (*.TXT)|*.TXT" + "|Все файлы (*.*)|*.* ";

            if (myDialog.ShowDialog() == true)
            {
                string filename = myDialog.FileName;
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, false))
                {
                    foreach (Object item in lbMain.Items)
                    {
                        file.WriteLine(item);
                    }
                }
            }
        }







        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            f1.Show();
        }



        private void Button_Click_11(object sender, RoutedEventArgs e)
        {

            ArrayList myAL = new ArrayList();
            int index;
            int itemCount;
            try
            {
                itemCount = Convert.ToInt32(tbN.Text);
            }
            catch
            {

                itemCount = 0;
            }
            if (itemCount <= 0) MessageBox.Show("Введите положительное целое число");
            else
            {
                Random rnd1 = new Random();
                int number;
                lbMain.Items.Clear();
                f1.val = new int[itemCount];
                for (index = 0; index < itemCount; index++)
                {
                    number = 0 + rnd1.Next(200);
                    myAL.Add(number);
                    lbMain.Items.Add(number);
                    f1.val[index] = number;
                }

                int[] a = (int[])myAL.ToArray(typeof(int));
                int kol = 0;
                for (int i = 1; i < itemCount - 1; i++)
                {
                    if ((a[i] > a[i - 1]) && (a[i] > a[i + 1]))
                        kol++;
                }
                if ((a[0] > a[itemCount - 1]) && (a[0] > a[1]))
                    kol++;
                if ((a[itemCount - 1] > a[0]) && (a[itemCount - 1] > a[itemCount - 2]))
                    kol++;

                lbMain.Items.Add("Количество элементов, которые больше своих соседей");
                lbMain.Items.Add(kol);

            }
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int i;
            int itemCount;
            try
            {
                itemCount = Convert.ToInt32(tbN.Text);
            }
            catch
            {

                itemCount = 0;
            }
            if (itemCount <= 0) MessageBox.Show("Введите положительное целое число");
            else
            {
                Random rnd1 = new Random();
                int number;
                lbMain.Items.Clear();
                f1.val = new int[itemCount];
                for (index = 0; index < itemCount; index++)
                {
                    number = 0 + rnd1.Next(200);
                    myAL.Add(number);
                    lbMain.Items.Add(number);
                    f1.val[index] = number;
                }
                int[] a = (int[])myAL.ToArray(typeof(int));
                float kol = 0;
                for (i = 0; i < itemCount; i++)
                {
                    kol = kol + (float)a[i];
                }
                kol = kol / itemCount;
                lbMain.Items.Add("Математическое ожидание для сгенерированных элементов");
                lbMain.Items.Add(kol);
                i = 0;
                int b = 0;
                while ((b != 0) && (i < itemCount))
                {
                    if (a[i] > kol) b = i;
                }
                lbMain.Items.Add("Новер первого элемента, который больше чем математическое ожидание для сгенерированных элементов");
                lbMain.Items.Add(b + 1);
            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount;
            try
            {
                itemCount = Convert.ToInt32(tbN.Text);
            }
            catch
            {

                itemCount = 0;
            }
            if (itemCount <= 0) MessageBox.Show("Введите положительное целое число");
            else
            {
                Random rnd1 = new Random();
                int number;
                lbMain.Items.Clear();
                f1.val = new int[itemCount];
                for (index = 0; index < itemCount; index++)
                {
                    number = 0 + rnd1.Next(200);
                    myAL.Add(number);
                    lbMain.Items.Add(number);
                    f1.val[index] = number;
                }

                int[] a = (int[])myAL.ToArray(typeof(int));
                int kol = 0;
                for (int i = 1; i < itemCount - 1; i++)
                {
                    if (((a[i] > a[i - 1]) && (a[i] < a[i + 1])) || ((a[i] < a[i - 1]) && (a[i] > a[i + 1])))
                        kol++;
                }
                if (((a[0] > a[itemCount - 1]) && (a[0] < a[1])) || ((a[0] < a[itemCount - 1]) && (a[0] > a[1])))
                    kol++;
                if (((a[itemCount - 1] > a[itemCount - 2]) && (a[itemCount - 1] < a[0])) || ((a[itemCount - 1] < a[itemCount - 2]) && (a[itemCount - 1] > a[0])))
                    kol++;


                lbMain.Items.Add("Количество элементов, которые составляют со своими сосядями составляют упорядоченную последовалтельность ");
                lbMain.Items.Add(kol);

            }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount;
            try
            {
                itemCount = Convert.ToInt32(tbN.Text);
            }
            catch
            {

                itemCount = 0;
            }
            if (itemCount <= 0) MessageBox.Show("Введите положительное целое число > 4");
            else
            {
                Random rnd1 = new Random();
                int number;
                lbMain.Items.Clear();

                for (index = 0; index < itemCount; index++)
                {
                    number = 0 + rnd1.Next(200);
                    myAL.Add(number);
                    lbMain.Items.Add(number);

                }

                int[] a = (int[])myAL.ToArray(typeof(int));
                int kol = 0;
                for (int i = 2; i < itemCount - 2; i++)
                {
                    if (((a[i] > a[i - 1]) && (a[i - 1] > a[i - 2]) && (a[i] < a[i + 1]) && (a[i + 1] < a[i + 2])) || ((a[i] < a[i - 1]) && (a[i - 1] < a[i - 2]) && (a[i] > a[i + 1]) && (a[i + 1] > a[i + 2])))
                        kol++;
                }
                if (((a[0] > a[itemCount - 1]) && (a[itemCount - 1] > a[itemCount - 2]) && (a[0] < a[1]) && (a[1] < a[2])) || ((a[0] < a[itemCount - 1]) && (a[itemCount - 1] < a[itemCount - 2]) && (a[0] > a[1]) && (a[1] > a[2])))
                    kol++;
                if (((a[itemCount - 1] > a[itemCount - 2]) && (a[itemCount - 2] > a[itemCount - 3]) && (a[itemCount - 1] < a[0]) && (a[0] < a[1])) || ((a[itemCount - 1] < a[itemCount - 2]) && (a[itemCount - 2] < a[itemCount - 3]) && (a[itemCount - 1] > a[0]) && (a[0] > a[1])))
                    kol++;
                if (((a[1] > a[0]) && (a[0] > a[itemCount - 1]) && (a[1] < a[2]) && (a[2] < a[3])) || ((a[1] < a[0]) && (a[0] < a[itemCount - 1]) && (a[1] > a[2]) && (a[2] > a[3])))
                    kol++;
                if (((a[itemCount - 2] > a[itemCount - 3]) && (a[itemCount - 3] > a[itemCount - 4]) && (a[itemCount - 2] < a[itemCount - 1]) && (a[itemCount - 1] < a[0])) || ((a[itemCount - 2] < a[itemCount - 3]) && (a[itemCount - 3] < a[itemCount - 4]) && (a[itemCount - 2] > a[itemCount - 1]) && (a[itemCount - 1] > a[0])))
                    kol++;


                lbMain.Items.Add("Количество элементов, которые которые состовляеют упорядоченную последовательносьть с элементами [i-2;i+2] , где i текущий элемент");
                lbMain.Items.Add(kol);

            }
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount;
            try
            {
                itemCount = Convert.ToInt32(tbN.Text);
            }
            catch
            {

                itemCount = 0;
            }
            if (itemCount <= 0) MessageBox.Show("Введите положительное целое число");
            else
            {
                Random rnd1 = new Random();
                int number;
                lbMain.Items.Clear();

                for (index = 0; index < itemCount; index++)
                {
                    number = 0 + rnd1.Next(200);
                    myAL.Add(number);
                    lbMain.Items.Add(number);

                }
                int[] a = (int[])myAL.ToArray(typeof(int));
                float kol = 0;
                for (int i = 0; i < itemCount; i++)
                {
                    kol = kol + (float)a[i];
                }
                kol = kol / itemCount;
                lbMain.Items.Add("Математическое ожидание для сгенерированных элементов");
                lbMain.Items.Add(kol);
                float n;
                for (index = 0; index < itemCount; index++)
                {
                    n = (float)a[index] - kol;

                    lbMain.Items.Add(Math.Abs(n));

                }
            }
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemCount;
            try
            {
                itemCount = Convert.ToInt32(tbN.Text);
            }
            catch
            {

                itemCount = 0;
            }
            if (itemCount <= 0) MessageBox.Show("Введите положительное целое число");
            else
            {
                Random rnd1 = new Random();
                int number;
                lbMain.Items.Clear();

                for (index = 0; index < itemCount; index++)
                {
                    number = 0 + rnd1.Next(200);
                    myAL.Add(number);
                    lbMain.Items.Add(number);

                }
                int[] a = (int[])myAL.ToArray(typeof(int));
                float kol = 0;
                for (int i = 0; i < itemCount; i++)
                {
                    kol = kol + (float)a[i];
                }
                kol = kol / itemCount;
                lbMain.Items.Add("Математическое ожидание для сгенерированных элементов");
                lbMain.Items.Add(kol);
                float n = 0;
                float k;
                for (index = 0; index < itemCount; index++)
                {
                    k = kol - (float)a[index];
                    if (n < Math.Abs(k)) n = Math.Abs(k);


                }
                lbMain.Items.Add("Макс отклонение");
                lbMain.Items.Add(n);
                for (index = 0; index < itemCount; index++)
                {
                    k = (float)a[index] - kol;
                    if (Math.Abs(k) > n / 2) lbMain.Items.Add(Math.Abs(kol));
                    else lbMain.Items.Add(a[index]);
                }
            }
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            int itemCount;
            try { itemCount = Convert.ToInt32(tbN.Text); }


            catch { itemCount = 0; }
            if (itemCount <= 0) MessageBox.Show("Введите целое положительное число");
            else
            {
                itemCount = Convert.ToInt32(tbN.Text);

                //if (itemCount <= 0) MessageBox.Show("Количество должно быть положительным"); 
                ArrayList myAL = new ArrayList();
                int index;
                //int itemCount = Convert.ToInt32(tbN.Text); 
                Random rnd1 = new Random();
                int number;


                lbMain.Items.Clear();
                f1.val = new int[itemCount];
                for (index = 0; index <= itemCount - 1; index++)
                {
                    number = 0 + rnd1.Next(200);
                    myAL.Add(number);
                    lbMain.Items.Add(number);
                    f1.val[index] = number;
                }
                float m = 0;
                ArrayList vesh = new ArrayList();
                int[] ar = (int[])myAL.ToArray(typeof(int));
                for (int i = 0; i < ar.Length; i++)
                {

                    m = m + ar[i];

                }
                m = m / itemCount;
                lbMain.Items.Add("Математическое ожидание:");
                lbMain.Items.Add(m);
                float s = 0; float max = 0;

                for (int i = 0; i < ar.Length; i++)
                {


                    max = ar[i] - m;
                    Math.Abs(max);
                    if (max > s) { s = max; }

                }
                float x;
                s = s / 2;
                lbMain.Items.Add("Максимальное отклонение:");
                lbMain.Items.Add(s);
                lbMain.Items.Add(" ");
                lbMain.Items.Add("Измененный массив:");
                float k;
                for (int i = 0; i < ar.Length; i++)
                {


                    k = ar[i] - m;
                    Math.Abs(k);
                    if (Math.Abs(k) > s) { x = m / k; myAL.Add(ar[i] - x); lbMain.Items.Add(ar[i] - x); } // мат делим на к, потом получ значвыч из элем. 
                    else { myAL.Add(ar[i]); lbMain.Items.Add(ar[i]); }



                }
            }
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            int itemCount;
            try { itemCount = Convert.ToInt32(tbN.Text); }


            catch { itemCount = 0; }
            if (itemCount <= 0) MessageBox.Show("Введите целое положительное число");
            else
            {
                itemCount = Convert.ToInt32(tbN.Text);

                //if (itemCount <= 0) MessageBox.Show("Количество должно быть положительным"); 
                ArrayList myAL = new ArrayList();
                int index;
                //int itemCount = Convert.ToInt32(tbN.Text); 
                Random rnd1 = new Random();
                int number;


                lbMain.Items.Clear();
                f1.val = new int[itemCount];
                for (index = 0; index <= itemCount - 1; index++)
                {
                    number = 0 + rnd1.Next(200);
                    myAL.Add(number);
                    lbMain.Items.Add(number);
                    f1.val[index] = number;
                }
                float m = 0;
                ArrayList vesh = new ArrayList();
                int[] ar = (int[])myAL.ToArray(typeof(int));
                for (int i = 0; i < ar.Length; i++)
                {

                    m = m + ar[i];

                }
                m = m / itemCount;
                lbMain.Items.Add("Математическое ожидание:");
                lbMain.Items.Add(m);
                float s = 0; float max = 0;

                for (int i = 0; i < ar.Length; i++)
                {


                    max = ar[i] - m;
                    Math.Abs(max);
                    if (max > s) { s = max; }

                }
                float x;
                s = s / 2;
                lbMain.Items.Add("Максимальное отклонение:");
                lbMain.Items.Add(s);
                lbMain.Items.Add(" ");
                lbMain.Items.Add("Измененный массив:");
                float k;
                for (int i = 0; i < ar.Length; i++)
                {


                    k = ar[i] - m;
                    Math.Abs(k);
                    if (Math.Abs(k) > s) { x = m / k; myAL.Add(ar[i] + x); lbMain.Items.Add(ar[i] + x); } // мат делим на к, потом получ значвыч из элем. 
                    else { myAL.Add(ar[i]); lbMain.Items.Add(ar[i]); }



                }
            }
        }

    }
}


          