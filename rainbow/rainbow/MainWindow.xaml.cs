using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace rainbow
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                Random rndm = new Random();
                int R, G, B;
                R = rndm.Next(0, 255);
                G = rndm.Next(0, 255);
                B = rndm.Next(0, 255);

                btn.Background = new SolidColorBrush(Color.FromRgb((byte)R, (byte)G, (byte)B));
                MessageBox.Show($"I am {btn.Content} and my color is {R}.{G}.{B}");

            }
        }

        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Right && sender is Button btn)
            {
                view.Title = btn.Content.ToString();
                MessageBox.Show($"View title changed!");
            }
        }
    }
}