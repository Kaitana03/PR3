using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PR3
{
    
    public partial class MainWindow : Window
    {
        Lib_9 lib = new Lib_9();
        int [,] mas;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Тимофеева Виктория\r\n Группа: ИСП-31\r\n Вариант №8\r\n Задание:Дана матрица размера M × N. В каждом столбце матрицы найти максимальный \r\nэлемент.");
        }

        private void bt_esc_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void bt_input_Click(object sender, RoutedEventArgs e)
        {
            bool f1, f2;
            int n, m;
            f1 = Int32.TryParse(tb_in_n.Text, out n);
            f2 = Int32.TryParse(tb_in_m.Text, out m);
            if (f1 && f2)
            {
                
                mas = lib.Func_Input(n, m);
                dtgrid.ItemsSource = LibMas.ToDataTable(mas).DefaultView;
            }
            else MessageBox.Show("Введите корректные данные");
        }

        private void bt_calc_Click(object sender, RoutedEventArgs e)
        {
            if (mas != null)
            {
                
                string maxelement;
                lib.Func_Calc(mas, out maxelement);
                tb_rez_1.Text = maxelement;

            }
            else MessageBox.Show("Массив пуст");
        }

        private void bt_save_Click(object sender, RoutedEventArgs e)
        {

            if (mas != null)
            {
                LibMas.Func_Save(mas);
            }
            else MessageBox.Show("Массив пуст");
        }

        private void bt_open_Click(object sender, RoutedEventArgs e)
        {
            if (LibMas.Func_Open(out mas))
            {
                dtgrid.ItemsSource = LibMas.ToDataTable(mas).DefaultView;
            }
           
        }

        private void bt_clear_Click(object sender, RoutedEventArgs e)
        {
            mas = null;
            dtgrid.ItemsSource = null;
        }

        private void bt_cl_Click(object sender, RoutedEventArgs e)
        {
            tb_in_n.Clear();
            tb_in_m.Clear();
            tb_rez_1.Clear();
         
        }
    }
}