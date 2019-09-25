using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ItemControlBindingDemo
{
    /// <summary>
    /// Interaction logic for RadioButtonItemControl.xaml
    /// </summary>
    public partial class RadioButtonItemControl : UserControl
    {
        public RadioButtonItemControl()
        {
            InitializeComponent();
        }



        public ObservableCollection<ItemData> ItemSource
        {
            get { return (ObservableCollection<ItemData>)GetValue(ItemSourceProperty); }
            set { SetValue(ItemSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ItemSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemSourceProperty =
            DependencyProperty.Register("ItemSource", typeof(ObservableCollection<ItemData>), typeof(RadioButtonItemControl), new PropertyMetadata(null));



    }
}
