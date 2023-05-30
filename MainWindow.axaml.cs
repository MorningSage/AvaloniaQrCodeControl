using Avalonia.Controls;

namespace AvaloniaQrCodeControl;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainViewModel();
    }
}