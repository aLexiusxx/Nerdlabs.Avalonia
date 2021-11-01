
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

#if DEBUG
using Avalonia;
using Nerdlabs.Avalonia.Extension;
using Nerdlabs.Avalonia.Extension.DtObject;
using Nerdlabs.Avalonia.Extension.Controls;
#endif


namespace Nerdlabs.Avalonia.Example
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
#pragma warning disable CS8622
            this.FindControl<Button>("btnClick").Click += MainWindow_Click;
#pragma warning restore CS8622
        }

        private async void MainWindow_Click(object sender, RoutedEventArgs e)
        {
            await MessageBox
                .Create(new MessageBoxOptions
                {
                    Button = MessageBoxButton.Yes | MessageBoxButton.No,
                    Title = "Style Overloading",
                    Message = "Did you know you can define your own MessageBox theme and overload the default ones? To modify the message box style have a look at App.axaml and make sure to set the 'MessageBox Style' to 'None' to disable any embedded styling.",
                    Location = WindowStartupLocation.CenterOwner,
                    Icon = BitmapFactory.Load("avares://Nerdlabs.Avalonia.Example/Assets/idea.png"),
                    MaxWidth = 480,
                    Style = MessageBoxStyle.None
                })
                .AsyncShowDialog(this);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
