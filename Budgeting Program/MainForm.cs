using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budgeting_Program
{
    public partial class MainForm : Form
    {
        public List<Item> itemList = new List<Item>();

        public MainForm()
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

        public void clearText()
        {
            nameText.Clear();
            priceText.Clear();
            urlText.Clear();
            nameValid.Text = "";
            priceValid.Text = "";
            urlValid.Text = "";
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

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to quit?", "Are you sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Regex Name = new Regex(@"^[A-Za-z0-9 ]*[A-Za-z0-9][A-Za-z0-9 ]*$");
            Regex Price = new Regex(@"^(((\d{1,3})(,\d{3})*)|(\d+))(.\d+)?$");
            Regex URL = new Regex(@"(?<http>(http:[/][/]|www.)([a-z]|[A-Z]|[0-9]|[/.]|[~])*)");

            if (Name.IsMatch(nameText.Text) && Price.IsMatch(priceText.Text) && URL.IsMatch(urlText.Text))
            {
                itemList.Add(new Item(nameText.Text, priceText.Text, @urlText.Text));
                clearText();
                updateItemList();
                nameText.Focus();
            }
            else
            {
                validate(Name, nameText, nameValid);
                validate(Price, priceText, priceValid);
                validate(URL, urlText, urlValid);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            itemListBox.Items.Clear();
            updateItemList();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string chosenFile = "";
            openFile.InitialDirectory = Convert.ToString(Environment.SpecialFolder.MyDocuments);
            openFile.Title = "Select a file to open";
            openFile.FileName = "";
            if (openFile.ShowDialog() != DialogResult.Cancel)
            {
                chosenFile = openFile.FileName;
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(chosenFile, FileMode.Open, FileAccess.Read, FileShare.Read);

                itemList = (List<Item>)formatter.Deserialize(stream);
                stream.Close();
                updateItemList();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string chosenFile = "";
            saveFile.InitialDirectory = Convert.ToString(Environment.SpecialFolder.MyDocuments);
            saveFile.Title = "Select a save location";
            saveFile.FileName = "";
            if (saveFile.ShowDialog() != DialogResult.Cancel)
            {
                chosenFile = saveFile.FileName;
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(chosenFile, FileMode.Create, FileAccess.Write, FileShare.None);

                formatter.Serialize(stream, itemList);
                stream.Close();
            }
        }

        private void calculateTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var totalBox = new Total(itemList);
            totalBox.ShowDialog();
        }

        private void itemListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (itemListBox.SelectedIndex != -1)
            {
                var editBox = new Edit(itemList, itemListBox.SelectedIndex);
                editBox.ShowDialog();
                editBox.FormClosing += editBox_FormClosing;
                updateItemList();
            }
        }

        void editBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            updateItemList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var editBox = new Edit(itemList);
            editBox.ShowDialog();
            editBox.FormClosing += editBox_FormClosing;
            updateItemList();
        }

        private void resetAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            itemList.Clear();
            itemListBox.Items.Clear();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutBox = new About();
            aboutBox.ShowDialog();
        }

        private void viewAllDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var viewTotal = new ViewAll(itemList);
            viewTotal.ShowDialog();
        }

        private void noUrlBox_CheckedChanged(object sender, EventArgs e)
        {
            if (noUrlBox.Checked == true)
            {
                addButton.Click -= addButton_Click;
                addButton.Click += addButton_noUrlClick;
                urlText.ReadOnly = true;
            }
            else
            {
                addButton.Click -= addButton_noUrlClick;
                addButton.Click += addButton_Click;
                urlText.ReadOnly = false;
            }
        }

        private void addButton_noUrlClick(object sender, EventArgs e)
        {
            Regex Name = new Regex(@"^[A-Za-z0-9 ]*[A-Za-z0-9][A-Za-z0-9 ]*$");
            Regex Price = new Regex(@"^(((\d{1,3})(,\d{3})*)|(\d+))(.\d+)?$");

            if (Name.IsMatch(nameText.Text) && Price.IsMatch(priceText.Text))
            {
                itemList.Add(new Item(nameText.Text, priceText.Text, "N/A"));
                clearText();
                updateItemList();
                nameText.Focus();
            }
            else
            {
                validate(Name, nameText, nameValid);
                validate(Price, priceText, priceValid);
            }
        }


        private void noUrlBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData.Equals(Keys.Return))
            {
                noUrlBox.Checked = noUrlBox.Checked == true ? false : true;
            }
        }

    }
}
