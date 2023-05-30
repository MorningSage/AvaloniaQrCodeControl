using System;
using Avalonia.Controls;

namespace AvaloniaQrCodeControl;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        EccLevelComboBox.ItemsSource = Enum.GetValues<QrCode.EccLevel>();
        DataContext = new MainViewModel();
    }
}