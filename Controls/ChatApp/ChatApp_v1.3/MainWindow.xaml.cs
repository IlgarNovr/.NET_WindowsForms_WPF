using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ChatApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Chat> Chats { get; set; } = new ObservableCollection<Chat>();

        bool isTextEmpty = true;

        //Colors
        SolidColorBrush UserMsgColor = new SolidColorBrush(Color.FromRgb(21, 151, 229));
        SolidColorBrush BotMsgColor = new SolidColorBrush(Color.FromRgb(66,63,62));
        SolidColorBrush TextColor = new SolidColorBrush(Color.FromRgb(250, 250, 250));

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void SendBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!isTextEmpty)
            {
                Chats.Add(new Chat(SearchTermTextBox.Text,"Right",UserMsgColor,TextColor));
                SearchTermTextBox.Text = null;
                ChatScroll.ScrollToEnd();
                BotAnswer();
                SearchTermTextBox_LostFocus(null, null);
            }
        }

        private void SendBtn_MouseEnter(object sender, MouseEventArgs e)
        {
            SendImg.Source = new BitmapImage(new Uri("/Images/sendBlue.png", UriKind.Relative));
        }

        private void SendBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            if (isTextEmpty)
                SendImg.Source = new BitmapImage(new Uri("/Images/sendGray.png", UriKind.Relative));
            else
                SendImg.Source = new BitmapImage(new Uri("/Images/sendBlack.png", UriKind.Relative));
        }

        private void BotAnswer()
        {
            string text = "Some messages not sent!";
            Chats.Add(new Chat(text, "Left", BotMsgColor, TextColor));
        }

        private void SearchTermTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                SendBtn_Click(null,null);
                SearchTermTextBox_GotFocus(null, null);
            }
        }

        private void SearchTermTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (SearchTermTextBox.Text == "Write a message...")
            {
                SearchTermTextBox.Text = null;
                SearchTermTextBox.Foreground = Brushes.Black;
                isTextEmpty = false;
            }
        }

        private void SearchTermTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchTermTextBox.Text))
            {
                SearchTermTextBox.Foreground = Brushes.DarkGray;
                SearchTermTextBox.Text = "Write a message...";
                isTextEmpty = true;
            }
        }
    }
}
