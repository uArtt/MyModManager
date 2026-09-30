using Avalonia;
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

        return (Geometry)Application.Current!.Resources[
            open ? "sidebar_close_regular" : "sidebar_open_regular"]!;
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        => throw new NotSupportedException();
}