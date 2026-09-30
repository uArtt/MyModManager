using CommunityToolkit.Mvvm.ComponentModel;

namespace Manager.App.Models
{
    public partial class ModListItemModel : ObservableObject
    {
        [ObservableProperty]
        private bool isEnabled;

        [ObservableProperty]
        private string name = string.Empty;

        [ObservableProperty]
        private string version = string.Empty;

        [ObservableProperty]
        private int priority;
    }
}
