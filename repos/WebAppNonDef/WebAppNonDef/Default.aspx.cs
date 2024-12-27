using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Operators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppNonDef
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { //apparently the below constring doesn't like ';'
            string server = "localhost";//make sure that you 
            string database = "lzhou";//bypass any security 
             string username = "root";//measures that may be in place
            string password = "God@2022";//God@2022"; 
   string constring = "SERVER="+ server+ " "+"; DATABASE = "+" "+ database + " " + " ; UID = " + username + " " + " ; PASSWORD= " + password + " ;";

            MySqlConnection conn = new MySqlConnection(constring);
            conn.Open();
            string query = "select * from album844"; //
            //MySql.Data.MySqlClient.MySqlCommand cmd;  = new MySql.Data.MySqlClient.MySqlCommand(query, conn);
MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            string output = "";
            while (reader.Read()) 
            {
              
                output += reader["alID844"].ToString()+" \n";
                output += reader["alName844"].ToString()+" ";
                Console.WriteLine("");
                //Console.WriteLine(reader["eno"]);//apparently this arg doesn't like single 
                output += "\x0A";   //quotes
            }
            dbOut.Text = output; 
        }
    }
}