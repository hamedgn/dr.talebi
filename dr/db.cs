using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading; 


namespace dr
{


    class db
    {
      
        private MySqlConnection connection;
        public string server;
        private string database;
        private string uid;
        private string password;
        
        public string message;
        

        public db()
        {
            Initialize();
            if (File.Exists("temp"))
            {

            }
            else
            {
                File.Create("temp");
            }
        }

       
        private void Initialize()
        {
            server = "localhost";
            database = "dr";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public List<string>[] Select()
        {
            string query = "CALL `all user`()";

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["pr_cod"] + "");
                    list[2].Add(dataReader["pass"] + "");
                    list[3].Add(dataReader["permission"] + "");
                    list[4].Add(dataReader["last_login"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }

            
        }

        public void check_user_pass(string pr_cod ,string pass)
        {
           

            string query = "CALL `check user`("+pr_cod+","+pass+")";

            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())


                //check pass with user
                message = myreader["message"].ToString();
                // user = myreader["pr_cod"].ToString();


                //close connection
                this.CloseConnection();


            }
          
            
        }

        public void count_departman()
        {
            string query = "CALL `count departeman`()";

            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())


                    //check pass with user
                    message = myreader["message"].ToString();
                // user = myreader["pr_cod"].ToString();


                //close connection
                this.CloseConnection();


            }

        }
        public void name_departman(int id_dep)
        {
            string query = "CALL `departman name`("+id_dep+")";

            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())


                    //check pass with user
                    message = myreader["message"].ToString();
                // user = myreader["pr_cod"].ToString();


                //close connection
                this.CloseConnection();


            }

        }
        public void id_departman(string name_dep)
        {
            string query = "CALL `departman id`('" + name_dep + "')";

            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())


                    //check pass with user
                    message = myreader["message"].ToString();
                // user = myreader["pr_cod"].ToString();


                //close connection
                this.CloseConnection();


            }

        }
        public void name_machine(int id_machine)
        {
            string query = "CALL `machine name`(" + id_machine + ")";

            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())


                    //check pass with user
                    message = myreader["message"].ToString();
                // user = myreader["pr_cod"].ToString();


                //close connection
                this.CloseConnection();


            }

        }
        IList<int> machine_list = new List<int>();
        public void sync_departman(int id_dep)
        {
            string query = "CALL `syncdepmach1`(" + id_dep + ")";

            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    //check pass with user
                   // message = myreader["machin_id"].ToString();
                    machine_list.Add(Convert.ToInt32(myreader["machin_id"].ToString()));
                    // user = myreader["pr_cod"].ToString();
                    /*		object.ToString returned	"2"	string

                    for (int i = 0; i <Convert.ToInt32(message); i++)
                    {
                        machine_list.Add(Convert.ToInt32(myreader[i].ToString()));
                    }
                    */
                }
                    
                //close connection
                this.CloseConnection();


            }

        }
       
        public void sync_dep_mach_name()
        {
            int j = machine_list.Count;
            for (int i = 0; i < j; i++)
            {
                
                name_machine(machine_list[i]);
                string temp = "";
                temp = File.ReadAllText("temp");

                File.WriteAllText("temp",temp  + message + "%");
                
            }
            
            for (int i = 0; i < j; i++)
            {
                machine_list.RemoveAt(0);
            }
        }
    }

   
}
