using System.Collections.Generic;

namespace Melodica.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";
    public List<string> Songs => new List<string> 
        { "Ghost", "Stellar Stellar", "7days", "Damn Good Day", "Newton", "TEMPLATE", "TRUE GIRL SHOW", "Soware", "Michizure"};
}