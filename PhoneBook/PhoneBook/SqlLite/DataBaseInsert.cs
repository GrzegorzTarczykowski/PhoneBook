using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.SqlLite
{
    class DataBaseInsert
    {
        public static string dataBaseInsert(string valueFirstName, string valueLastName, string valueTelephoneNumber)
        {
            string insertString = "INSERT INTO " + DescriptionDataBase.tableName + "(" + DescriptionDataBase.secoundFieldFirstName + ", " + DescriptionDataBase.thirdFieldLastName + ", " + DescriptionDataBase.fourthFieldTelephonNumber + ") values('" + valueFirstName + "', '" + valueLastName + "', '" + valueTelephoneNumber + "');";
            return insertString;
        }
    }
}
