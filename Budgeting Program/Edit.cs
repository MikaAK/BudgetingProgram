using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budgeting_Program
{
    public partial class Edit : Form
    {
        public List<Item> itemList = new List<Item>();

        public Edit()
        {
            InitializeComponent();
        }

        public void updateItemList()
        {
            itemListBox.Items.Clear();
            for (int i = 0; i < itemList.Count; i++)
            {
                itemListBox.Items.Add(itemList[i].Name);
            }
        }
        public void validate(Regex reg, TextBox text, Label lab)
        {

            if (reg.IsMatch(text.Text))
            {
                lab.Text = "Complete";
                lab.ForeColor = Color.Green;
            }
            else
            {
                lab.Text = "*Required";
                lab.ForeColor = Color.Red;
            }
        }


        public void updateItemList(List<Item> itemList)
        {
            itemListBox.Items.Clear();
            for (int i = 0; i < itemList.Count; i++)
            {
                itemListBox.Items.Add(itemList[i].Name);
            }
        }

        public Edit(List<Item> i)
        {
            InitializeComponent();
            itemList = i;
            updateItemList();
        }

        public Edit(List<Item> i, int index)
        {
            InitializeComponent();
            itemList = i;
            updateItemList();
            itemListBox.SetSelected(index, true);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Regex Name = new Regex(@"^[A-Za-z0-9 ]*[A-Za-z0-9][A-Za-z0-9 ]*$");
            Regex Price = new Regex(@"^(((\d{1,3})(,\d{3})*)|(\d+))(.\d+)?$");
            Regex URL = new Regex(@"(?<http>(http:[/][/]|www.)([a-z]|[A-Z]|[0-9]|[/.]|[~])*)");

            if (itemListBox.SelectedIndex != -1)
            {
                if (Name.IsMatch(nameText.Text) && Price.IsMatch(priceText.Text) && (URL.IsMatch(urlText.Text) || urlText.Text == "N/A"))
                {
                    var index = itemList.FindIndex(x => x.Name == (string)itemListBox.SelectedItem);
                    if (index != -1)
                    {
                        itemList[index].Name = nameText.Text;
                        itemList[index].Price = Convert.ToDouble(priceText.Text);
                        itemList[index].URL = urlText.Text;
                        updateItemList();
                        itemListBox.SetSelected(index, true);
                    }
                }
                else
                {
                    validate(Name, nameText, nameErrorMessage);
                    validate(Price, priceText, priceErrorMessage);
                    validate(URL, urlText, urlErrorMessage);
                }
            }
        }

        private void Edit_Load(object sender, EventArgs e)
        {

        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            var index = itemList.FindIndex(x => x.Name == (string)itemListBox.SelectedItem);
            if (index != -1)
            {
                itemList.RemoveAt(index);
                updateItemList();
            }
        }

        private void itemListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item found = itemList.Find(x => x.Name == (string)itemListBox.SelectedItem);
            if (found != null)
            {
                nameText.Text = found.Name;
                priceText.Text = Convert.ToString(found.Price);
                urlText.Text = found.URL;
            }
        }

        private void nameSort_CheckedChanged(object sender, EventArgs e)
        {
            var nameSort = from items in itemList
                           orderby items.Name ascending
                           select items;
            itemListBox.Items.Clear();
            foreach (var item in nameSort)
            {
                itemListBox.Items.Add(item.Name);
            }

        }

        private void priceSort_CheckedChanged(object sender, EventArgs e)
        {
            var priceSort = from items in itemList
                            orderby items.Price descending
                            select items;
            itemListBox.Items.Clear();
            foreach (var item in priceSort)
            {
                itemListBox.Items.Add(item.Name);
            }
        }

        private void urlSort_CheckedChanged(object sender, EventArgs e)
        {
            var urlSort = from items in itemList
                          orderby items.URL ascending
                          select items;
            itemListBox.Items.Clear();
            foreach (var item in urlSort)
            {
                itemListBox.Items.Add(item.Name);
            }
        }
    }
}
