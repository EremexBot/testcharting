using Avalonia.Controls;
//using Eremex.AvaloniaUI.Controls.Common;

namespace test12.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        var editor = this.FindControl<RichTextEditor>("Editor");

    }
}