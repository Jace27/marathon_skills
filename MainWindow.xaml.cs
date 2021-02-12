using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace MarathonSkills
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Settings.MainWindow = this;
            Settings.Timer = Task.Run(() =>
            {
                while (Settings.TimerRunning)
                {
                    TimeSpan ts = Functions.TimeBeforeMarathonStart();
                    Settings.MainWindow.Dispatcher.Invoke(() =>
                    {
                        int d, h, m;

                        d = Convert.ToInt32(Math.Round(ts.TotalDays));
                        if (Math.Round(ts.TotalHours) - Math.Round(ts.TotalDays) * 24 < 0) d--;
                        h = Convert.ToInt32(Math.Round(ts.TotalHours) - d * 24);
                        if (Math.Round(ts.TotalMinutes) - Math.Round(ts.TotalHours) * 60 < 0)
                        {
                            h--;
                            m = Convert.ToInt32(Math.Round(ts.TotalMinutes) - Math.Round(ts.TotalHours - 1) * 60);
                        }
                        else
                        {
                            m = Convert.ToInt32(Math.Round(ts.TotalMinutes) - Math.Round(ts.TotalHours) * 60);
                        }

                        BeforeStart_Label.Content = d + " дней " + h + " часов " + m + " минут до старта марафона!";
                    });
                    Thread.Sleep(1000);
                }
            });
        }

        public void SetTimerLabelContent(string content)
        {
            BeforeStart_Label.Content = content;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("111");
        }
    }
}
