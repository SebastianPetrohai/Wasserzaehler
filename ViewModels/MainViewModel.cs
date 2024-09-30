using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wasserzaehler.ViewModels;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private int _counter = 0;

    [RelayCommand]
    void Inc()
    {
        Counter++; // Zugriff auf Eigenschaft - aktualisiert View
    }
}
