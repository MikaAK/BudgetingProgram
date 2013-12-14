using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budgeting_Program
{
    public partial class ViewAll : Form
    {
        public List<Item> itemList;
        DataTable itemTable = new DataTable();

        public ViewAll()
        {
            InitializeComponent();

        }

        public ViewAll(List<Item> itemList)
        {
            InitializeComponent();
            this.itemList = itemList;
            this.itemTable = itemList.ConvertToDatatable<Item>();
            itemGridView.DataSource = itemTable;
            
        }

        private void ViewAll_Load(object sender, EventArgs e)
        {

        }

    }

    public static class Extention
    {
        public static DataTable ConvertToDatatable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            return table;
        }
    }


}
