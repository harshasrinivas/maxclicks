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
using System.Windows.Threading;

namespace maxclicks
{

    public partial class MainWindow : Window
    {
        DispatcherTimer _timer;
        TimeSpan _time;
        int count = 0;
        public MainWindow()
        {
            InitializeComponent();
            _time = TimeSpan.FromSeconds(5);
            var foo = 5;

            _timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                tbTime.Text = _time.ToString("c");
                foo++;
                if (_time == TimeSpan.Zero)
                {
                    _timer.Stop();
                    MessageBox.Show("Your final score : " + Convert.ToString(count) + " !!");
                }
                _time = _time.Add(TimeSpan.FromSeconds(-1));
            }, Application.Current.Dispatcher);

            _timer.Start();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            count = count + 1;
            buttonone.Content = Convert.ToString(count);

        }

    }
}