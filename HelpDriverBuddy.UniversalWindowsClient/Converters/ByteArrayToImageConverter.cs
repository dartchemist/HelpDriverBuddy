using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Graphics.Imaging;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media.Imaging;

namespace HelpDriverBuddy.UniversalWindowsClient.Converters
{
    public class ByteArrayToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value == null)
            {
                return new BitmapImage(
                    new Uri("ms-appx:/Assets/Images/DefaultCarImage.png"));
            }

            var imageBytes = value as byte[];

            var bitmapImage = new BitmapImage();

            using (var inmemoryRandomAccessStream = new InMemoryRandomAccessStream())
            {
                using (var dataWriter = new DataWriter(inmemoryRandomAccessStream.GetOutputStreamAt(0)))
                {
                    dataWriter.WriteBytes(imageBytes);
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
            throw new NotImplementedException();   
        }
    }
}
