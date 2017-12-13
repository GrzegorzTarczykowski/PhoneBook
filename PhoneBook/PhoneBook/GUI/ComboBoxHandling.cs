using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using PhoneBook.SqlLite;

namespace PhoneBook.GUI
{
    class ComboBoxHandling
    {
        public List<string> loadFromTable(ComboBox comboBoxName)
        {
            comboBoxName.Items.Clear();
            List<string> listOfResults = new List<string>();
            ConnectorSqlLite connector = new ConnectorSqlLite();
            SQLiteCommand commander = connector.connect();
            commander.CommandText = DataBaseSelect.dataBaseSelectFirstNameLastName(DescriptionDataBase.firstFieldIdPhonBook, DescriptionDataBase.secoundFieldFirstName, DescriptionDataBase.thirdFieldLastName, DescriptionDataBase.tableName);
            SQLiteDataReader cursor = commander.ExecuteReader();
            while (cursor.Read())
            {
                listOfResults.Add(cursor.GetValue(0).ToString());
                comboBoxName.Items.Add(cursor.GetValue(2) + " " + cursor.GetValue(1));
            }
            connector.disConnect();
            return listOfResults;
        }

        public Dictionary<string, string> showTelephoneNumberSelectedIndex ()
        {
            Dictionary<string, string> dictionaryOfResaults = new Dictionary<string, string>();
            ConnectorSqlLite connector = new ConnectorSqlLite();
            SQLiteCommand commander = connector.connect();
            commander.CommandText = DataBaseSelect.dataBaseSelectTelephoneNumber(DescriptionDataBase.firstFieldIdPhonBook, DescriptionDataBase.fourthFieldTelephonNumber, DescriptionDataBase.tableName);
            SQLiteDataReader cursor = commander.ExecuteReader();
            while (cursor.Read())
            {
                dictionaryOfResaults.Add(cursor.GetValue(0).ToString(), cursor.GetValue(1).ToString());
            }
            connector.disConnect();
            return dictionaryOfResaults;
        }
    }
}
