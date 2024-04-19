using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.UI.Xaml.Controls;

namespace NumberBoxTwoWayBindingLostFocusIssue;


public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private double _doubleValue;

    partial void OnDoubleValueChanged(double oldValue, double newValue)
    {
        System.Diagnostics.Debug.WriteLine($"DoubleValue changed: {oldValue} -> {newValue}");
    }


    [ObservableProperty]
    private bool _boolValue;

    partial void OnBoolValueChanged(bool oldValue, bool newValue)
    {
        System.Diagnostics.Debug.WriteLine($"BoolValue changed: {oldValue} -> {newValue}");
    }
}


public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();
        this.DataContext = this.ViewModel;
    }

    private MainViewModel ViewModel { get; } = new();
}
