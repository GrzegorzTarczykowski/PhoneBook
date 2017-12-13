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
    class ButtonAddHandling
    {
        public void saveToTable(string valueFirstName, string valueLastName, string valueTelephoneNumber)
        {
            ConnectorSqlLite connector = new ConnectorSqlLite();
            SQLiteCommand commander = connector.connect();
            commander.CommandText = DataBaseInsert.dataBaseInsert(valueFirstName, valueLastName, valueTelephoneNumber);
            commander.ExecuteNonQuery();
            MessageBox.Show("Dodano kontakt");
            connector.disConnect();
        }
    }
}
