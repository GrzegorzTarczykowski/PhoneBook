using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneBook.GUI;

namespace PhoneBook
{
    public partial class Form1 : Form
    {
        private List<string> listOfResults = new List<string>();
        private Dictionary<string, string> dictionaryOfResaults = new Dictionary<string, string>();
        private string chosenId = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region DescribeGUI
            labelAddPhoneBook.Text = DescribeGUI.labelAddPhoneBook;
            labelFirstName.Text = DescribeGUI.labelFirstName;
            labelLastName.Text = DescribeGUI.labelLastName;
            labelTelephoneNumber.Text = DescribeGUI.labelTelephoneNumber;
            labelChooseFullName.Text = DescribeGUI.labelChooseFullName;
            buttonAddToPhoneBook.Text = DescribeGUI.buttonAddToPhoneBook;
            #endregion
            ComboBoxHandling comboBoxHandling = new ComboBoxHandling();
            listOfResults = comboBoxHandling.loadFromTable(comboBoxChooserPerson);
        }

        private void buttonAddToPhoneBook_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text != "" && textBoxLastName.Text != "" && textBoxTelephoneNumber.Text != "")
            {
                ButtonAddHandling buttonAddHandling = new ButtonAddHandling();
                buttonAddHandling.saveToTable(textBoxFirstName.Text, textBoxLastName.Text, textBoxTelephoneNumber.Text);
                textBoxFirstName.Text = "";
                textBoxLastName.Text = "";
                textBoxTelephoneNumber.Text = "";
            }
            else
            {
                MessageBox.Show("Podaj imie, nazwisko i numer telefonu");
            }
            ComboBoxHandling comboBoxHandling = new ComboBoxHandling();
            listOfResults = comboBoxHandling.loadFromTable(comboBoxChooserPerson);
        }

        private void comboBoxChooserPerson_SelectedIndexChanged(object sender, EventArgs e)
        {
            dictionaryOfResaults.Clear();
            chosenId = listOfResults[comboBoxChooserPerson.SelectedIndex];
            ComboBoxHandling comboBoxHandling = new ComboBoxHandling();
            dictionaryOfResaults = comboBoxHandling.showTelephoneNumberSelectedIndex();
            MessageBox.Show(comboBoxChooserPerson.Items[comboBoxChooserPerson.SelectedIndex] + "\nNumer telefonu: " + dictionaryOfResaults[chosenId.ToString()]);
        }
    }
}
