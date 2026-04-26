using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace LoginDemo
{
    internal class LogInWindowButton : Button
    {


        public CornerRadius ButtonCornerRadius
        {
            get { return (CornerRadius)GetValue(ButtonCornerRadiusProperty); }
            set { SetValue(ButtonCornerRadiusProperty, value); }
        }
        public static readonly DependencyProperty ButtonCornerRadiusProperty =
            DependencyProperty.Register(nameof(ButtonCornerRadius), typeof(CornerRadius), typeof(LogInWindowButton));



        public Brush BackgroundHover    
        {
            get { return (Brush)GetValue(BackgroundHoverProperty); }
            set { SetValue(BackgroundHoverProperty, value); }
        }
        public static readonly DependencyProperty BackgroundHoverProperty =
            DependencyProperty.Register(nameof(BackgroundHoverProperty), typeof(Brush), typeof(LogInWindowButton));



        public Brush BackgorundPressed
        {
            get { return (Brush)GetValue(BackgorundPressedProperty); }
            set { SetValue(BackgorundPressedProperty, value); }
        }
        public static readonly DependencyProperty BackgorundPressedProperty =
            DependencyProperty.Register(nameof(BackgorundPressedProperty), typeof(Brush), typeof(LogInWindowButton));
    }
}
