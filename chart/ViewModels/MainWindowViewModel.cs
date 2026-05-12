using System.Collections.Generic;

namespace test12.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public string Greeting { get; } = "Welcome to Avalonia!";

 public IReadOnlyList<SalesPoint> Revenue { get; } =
    [
        new("Q1", 125000),
        new("Q2", 148000),
        new("Q3", 171000),
        new("Q4", 193000)
    ];

public sealed record SalesPoint(string Quarter, double Amount);
}
