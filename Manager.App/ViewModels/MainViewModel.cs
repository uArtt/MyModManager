using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Manager.App.Models;
using System;
using System.Collections.ObjectModel;


namespace Manager.App.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    public ObservableCollection<SidebarItemModel> Items { get; } = new()
    {
        new SidebarItemModel(typeof(ModsPageViewModel), "arrow_next_regular"),
        new SidebarItemModel(typeof(PluginsPageViewModel), "arrow_next_regular")

    };

    [ObservableProperty]
    public bool _isPaneOpen = true;
    [ObservableProperty]
    public bool _isPaneClosed;

    [ObservableProperty]
    private ViewModelBase _currentPage = new ModsPageViewModel();

    [ObservableProperty]
    private SidebarItemModel? _selectedSidebarItem;

    [RelayCommand]
    private void TogglePane()
    {
        IsPaneOpen = !IsPaneOpen;
        IsPaneClosed = !IsPaneOpen;
    }

    partial void OnSelectedSidebarItemChanged(SidebarItemModel? value)
    {
        if (value is null) return;
        var instance = Activator.CreateInstance(value.ModelType);
        if (instance is null) return;
        CurrentPage = (ViewModelBase)instance;
    }
}
