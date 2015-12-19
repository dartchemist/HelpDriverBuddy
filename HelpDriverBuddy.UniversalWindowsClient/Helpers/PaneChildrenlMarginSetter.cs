using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace HelpDriverBuddy.UniversalWindowsClient.Helpers
{
    public class PaneChildrenlMarginSetter
    {
        public static readonly DependencyProperty MarginProperty =
            DependencyProperty.RegisterAttached("Margin", typeof(Thickness), typeof(PaneChildrenlMarginSetter),
                new PropertyMetadata(new Thickness(), SetMarginForChildren));

        public static Thickness GetMargin(DependencyObject dependencyObject)
        {
            return (Thickness)dependencyObject.GetValue(MarginProperty);
        }

        public static void SetMargin(DependencyObject dependencyObject, Thickness value)
        {
            dependencyObject.SetValue(MarginProperty, value);
        }

        private static void SetMarginForChildren(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is Panel)
            {
                var panel = (Panel)d;

                foreach (var child in panel.Children)
                {
                    if (child is FrameworkElement)
                    {
                        var frameworkElement = (FrameworkElement)child;
                        frameworkElement.Margin = GetMargin(panel);
                    }

                }
            }
            
        }
    }
}
