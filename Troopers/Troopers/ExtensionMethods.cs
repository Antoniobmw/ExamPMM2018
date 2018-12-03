using System.Collections.Generic;
using System.Windows.Forms;

namespace Troopers
{
    public static class ExtensionMethods
    {
        public static void RefreshDataSource<T>(this ListBox listBox, List<T> dataSource, string displayMember)
        {
            listBox.DataSource = null;
            listBox.DataSource = dataSource;
            listBox.DisplayMember = displayMember;
        }
    }
}
