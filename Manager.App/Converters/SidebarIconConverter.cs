using Avalonia;
using Avalonia.Controls;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Globalization;

namespace Manager.App.Converters;

public class SidebarIconConverter : IValueConverter
{
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        var open = value is true;
        var key = value is true
            ? "sidebar_close_regular"
            : "sidebar_open_regular";

        if (Application.Current?.TryFindResource(key, out var resource) == true &&
            resource is Geometry geometry)
        {
            return geometry;
        }
        return AvaloniaProperty.UnsetValue;
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotSupportedException();
    }
}