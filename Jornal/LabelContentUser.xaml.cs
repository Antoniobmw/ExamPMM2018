using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Jornal
{
    /// <summary>
    /// Interaction logic for LabelContentUser.xaml
    /// </summary>
    public partial class LabelContentUser : UserControl
    {
        public static DependencyProperty LabelTextValueProperty = DependencyProperty.Register(
            nameof(LabelTextValue),
            typeof(string),
            typeof(LabelContentUser),
            new PropertyMetadata(LabelTextValuePropertyChanged));

        public static DependencyProperty TextBoxTextValueProperty = DependencyProperty.Register(
            nameof(TextBoxTextValue),
            typeof(string),
            typeof(LabelContentUser),
            new PropertyMetadata(TextBoxValuePropertyChanged));
        
        public string LabelTextValue
        {
            get => (string)GetValue(LabelTextValueProperty);
            set => SetValue(LabelTextValueProperty, value);
        }

        public string TextBoxTextValue
        {
            get => (string)GetValue(TextBoxTextValueProperty);
            set => SetValue(TextBoxTextValueProperty, value);
        }

        public LabelContentUser()
        {
            InitializeComponent();
        }

        private static void LabelTextValuePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var labelContent = (LabelContentUser)d;
            labelContent.LabelContent.Content = e.NewValue;
        }

        private static void TextBoxValuePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {            
            var labelContent = (LabelContentUser)d;

            if(labelContent.TextBlockContent.Text != e.NewValue.ToString())
            {
                labelContent.TextBlockContent.Text = e.NewValue.ToString();
            }            
        }

        private void TextBlockContent_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBoxTextValue = TextBlockContent.Text;
        }

        public bool IsEmpty()
        {
            return string.IsNullOrWhiteSpace(TextBlockContent.Text);
        }
    }
}
