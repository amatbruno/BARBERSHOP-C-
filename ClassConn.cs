using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace P13_amatbruno_proyectoBarberTopACTUAL
{
    public class ClassConn
    {
        private string url = "http://localhost/M13/controllerDB.php";

        public string sendData(string control)
        {
            WebClient cl = new WebClient();
            NameValueCollection getData = new NameValueCollection();
            getData.Add(keyValue("d01", "usuario"));
            getData.Add(keyValue("Control", control));
            
            string res = Encoding.UTF8.GetString(cl.UploadValues(url, getData));

            return res;
        }


        private NameValueCollection keyValue(string key, string value)
        {
            NameValueCollection data = new NameValueCollection()
            {
                {key, value }
            };
                return data;
        }

    












        /*private string server = "localhost";
        private string username = "root";
        private string password = "";
        private string port = "3306";

        private MySqlConnection conn = null;
        private MySqlCommand cmd = null;

        private ClassConn(string server, string username, string password, string port, MySqlConnection conn, MySqlCommand cmd)
        {
            this.server = server;
            this.username = username;
            this.password = password;
            this.port = port;
            this.conn = conn;
            this.cmd = cmd;
        }

        public void createTable()
        {
            string query = "CREATE TABLE";
        }*/
    }
}
