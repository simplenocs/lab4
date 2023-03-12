using Avalonia;
using Avalonia.Controls;
using Avalonia.Data.Converters;
using Avalonia.Media.Imaging;
using Notepad.Models;
using System;
using System.Globalization;
using static Notepad.Models.FileTyping;
namespace Notepad.Views.Converters
{
    internal class FileItemToImageconverts : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value == null) return null;
            if (value is FileTyping @f_t)
            {
                string icon = @f_t switch
                {
                    SysDrive => "sys_drive",
                    Drive => "drive",
                    BackFolder => "back_folder",
                    Folder => "folder",
                    FILE => "file",
                    _ => ""
                };
                var application = Application.Current;
                if (application == null) return null;
                var ress = application.Resources;
                var image = (Image?)ress[icon];
                if (image == null) return null;
                return (Bitmap?)image.Source;
            }
            throw new NotSupportedException();
        }
        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
