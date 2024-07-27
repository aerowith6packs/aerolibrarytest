using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Transparent_Form
{
    internal class StudentClass
    {
        DBconnect connection = new DBconnect();

        public bool insertStudent(string fname, string lname, DateTime bdate, string gender, string phone, string address, byte[] img)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `student`(`StdFirstName`, `StdLasttName`, `Birthdate`, `Gender`, `Phone`, `Address`, `Photo`) VALUES(@fn, @ln, @bd, @gd, @ph, @adr, @img)",connection.getconnection());

            //@fn, @ln, @bd, @gd, @ph, @adr, @img

            cmd.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            cmd.Parameters.Add("@bd", MySqlDbType.VarChar).Value = bdate;
            cmd.Parameters.Add("@dg", MySqlDbType.VarChar).Value = gender;
            cmd.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@adr", MySqlDbType.VarChar).Value = address;
            cmd.Parameters.Add("@img", MySqlDbType.VarChar).Value = img;

            connection.openConnect();

            if (cmd.ExecuteNonQuery() == 1)
            {
                connection.closeConnect();
                return true;
            }
            else
            {
                connection.closeConnect();
                return false;
            }



        }
    }
}