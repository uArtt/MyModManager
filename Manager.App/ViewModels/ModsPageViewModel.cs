using Manager.App.Models;
using System.Collections.ObjectModel;

namespace Manager.App.ViewModels;

public partial class ModsPageViewModel : ViewModelBase
{
    public ObservableCollection<ModListItemModel> ModItems { get; } = new()
    {
        new ModListItemModel()
        {
            IsEnabled = true,
        }
    };
    public void AddMod()
    {
        ModItems.Add(new ModListItemModel
        {
            IsEnabled = false
        });
    }

}