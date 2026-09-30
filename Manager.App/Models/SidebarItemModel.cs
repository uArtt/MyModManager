using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using System;

namespace Manager.App.Models;

public class SidebarItemModel
{
    public SidebarItemModel(Type type, string iconKey)
    {
        ModelType = type;
        Label = type.Name.Replace("PageViewModel", "");

        Application.Current!.TryFindResource(iconKey, out var res);
        ItemIcon = (StreamGeometry)res!;
    }


    public string Label { get; }
    public Type ModelType { get; }
    public StreamGeometry ItemIcon {  get; }
}
