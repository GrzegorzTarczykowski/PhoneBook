using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.SqlLite
{
    class DataBaseSelect
    {
        public static string dataBaseSelectFirstNameLastName(string FieldIdPhoneBook, string FieldFirstName, string FieldLastName, string FieldTableName)
        {
            string insertString = "SELECT " + FieldIdPhoneBook + ", " + FieldFirstName + ", " + FieldLastName + " FROM " + FieldTableName + ";"; ;
            return insertString;
        }
        public static string dataBaseSelectTelephoneNumber(string FieldIdPhoneBook, string FieldTelephoneNumber, string FieldTableName)
        {
            string insertString = "SELECT " + FieldIdPhoneBook + ", " + FieldTelephoneNumber + " FROM " + FieldTableName + ";"; ;
            return insertString;
        }
    }
}
