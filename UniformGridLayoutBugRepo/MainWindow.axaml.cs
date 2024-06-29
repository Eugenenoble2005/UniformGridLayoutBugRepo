using Avalonia.Controls;

namespace UniformGridLayoutBugRepo;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        DataContext = new MainWIndowViewModel();
        InitializeComponent();
    }
}