using ItemControlBindingDemo;
using Newtonsoft.Json;
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

namespace ItemControlBindingDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Init();
        }

        void Init()
        {
            string myjsondata = ResourceHelper.GetResource(ResourceHelper.FileResourceKey.JsonData);
            var data = JsonConvert.DeserializeObject<Rootobject>(myjsondata);
            Guid gouupName = Guid.NewGuid();
            var endData = data.data.ToList();
            endData.ForEach(x => x.GroupName = gouupName.ToString());
            var mysource = new System.Collections.ObjectModel.ObservableCollection<ItemData>(endData);
            mycontrol.ItemSource = mysource;
        }
    }
    public class Rootobject
    {
        public bool success { get; set; }
        public ItemData[] data { get; set; }
    }
}


