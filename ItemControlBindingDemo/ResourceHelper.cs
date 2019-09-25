using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemControlBindingDemo
{
    public class ResourceHelper
    {
        private const string myJsonData = "myJsonData.json";

        public enum FileResourceKey
        {
            JsonData
        }

        public static string GetResource(FileResourceKey fileResourceKey)
        {
            switch (fileResourceKey)
            {
                case FileResourceKey.JsonData:
                    return GetResource(myJsonData);
                default:
                    throw new NotImplementedException();
            }
            return string.Empty;
        }

        private static string GetResource(string inputuri)
        {
            Uri uri = new Uri(inputuri, UriKind.Relative);
            System.Windows.Resources.StreamResourceInfo info = System.Windows.Application.GetResourceStream(uri);
            StreamReader reader = new StreamReader(info.Stream);
            string text = reader.ReadToEnd();
            return text;
        }
    }
}
