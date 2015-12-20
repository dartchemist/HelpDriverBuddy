using HelpDriverBuddy.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Graphics.Imaging;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace HelpDriverBuddy.UniversalWindowsClient.Converters
{
    public class ImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value == null)
            {
                return new BitmapImage(
                    new Uri("ms-appx:/Assets/Images/DefaultCarImage.png"));
            }

            var image = value as IImage;

            var bitmapImage = new BitmapImage();

            using (var inmemoryRandomAccessStream = new InMemoryRandomAccessStream())
            {
                using (var dataWriter = new DataWriter(inmemoryRandomAccessStream.GetOutputStreamAt(0)))
                {
                    dataWriter.WriteBytes(image.ImageBytes);
                    Task.Run(async () =>
                    {
                        await dataWriter.StoreAsync();
                    });

                }

                bitmapImage.SetSource(inmemoryRandomAccessStream);
            }

           return bitmapImage;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return null; 
        }
    }
}
