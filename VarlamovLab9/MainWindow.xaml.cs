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

namespace VarlamovLab9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Height += 25;
        }

        List<Sprint> _sprint1 = new List<Sprint>();

        private void Create(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(fio.Text, out int FIO) & int.TryParse(num.Text, out int NUM) & int.TryParse(rez.Text, out int REZ))
            {
                _sprint1.Add(new Sprint(fio.Text, NUM, REZ));
                structGrid.ItemsSource = null;
                structGrid.ItemsSource = _sprint1;
            }
            else MessageBox.Show("Ошибка");
        }

        private void Result(object sender, RoutedEventArgs e)
        {
            var average = _sprint1.Average(x => x.Result);
            MessageBox.Show(average.ToString());
        }

        private void AboutProgramm(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Заполнить таблицу участников забега на 100 метров на 8 человек с полями: ФИО, номер, результат. Вывести результат на экран. Вывести средний результат.");
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
