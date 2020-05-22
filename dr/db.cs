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
        public string permission;
        public string tests_name;
        public string tests_qus;
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
            if (File.Exists("temp2"))
            {

            }
            else
            {
                File.Create("temp2");
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
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + "; CharSet=utf8;";

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

       

        public void check_user_pass(string pr_cod ,string pass)
        {
           

            string query = "CALL `check user`("+pr_cod+","+pass+")";

            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())

                {
                    //check pass with user
                    message = myreader["message"].ToString();

                    //permission = myreader["permission"].ToString();
                    // user = myreader["pr_cod"].ToString();
                }



                //close connection
                this.CloseConnection();


            }
          
            
        }
        public void check_user_permission(string pr_cod)
        {


            string query = " CALL `userper`('"+pr_cod+"')";

            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())

                {
                    //check pass with user
                    permission = myreader["permission"].ToString();

                   // permission = myreader["permission"].ToString();
                    // user = myreader["pr_cod"].ToString();
                }



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
        public void count_machine()
        {
            string query = "CALL `count machine`()";

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

        public void id_machin(string name_mach)
        {
            string query = "CALL `machine id`('" + name_mach + "')";

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
                    
                    machine_list.Add(Convert.ToInt32(myreader["machin_id"].ToString()));
                    
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

        public void lastlogin(int pr_code,string date)
        {
            string query = "CALL `lastlogin`('"+date+"','"+pr_code+"')";

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

        public void count_test(int machine_id)
        {
            string query = "CALL `count_test`('" + machine_id + "')";

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
        IList<int> tests_list = new List<int>();
        public void test_id_to_list(int machine_id)
        {
            string query = "CALL `test_machine_id`(" + machine_id + ")";

            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {

                    tests_list.Add(Convert.ToInt32(myreader["id"].ToString()));

                }

                //close connection
                this.CloseConnection();


            }

        }

        public void tests_name_sync()
        {
            int j = tests_list.Count;
            for (int i = 0; i < j; i++)
            {

                test_name(tests_list[i]);
                string temp = "";
                temp = File.ReadAllText("temp");

                File.WriteAllText("temp", temp + tests_name + "%");
                
            }

            for (int i = 0; i < j; i++)
            {
                tests_list.RemoveAt(0);
            }
        }

        public void test_name(int id_test)
        {
            string query = "CALL `get_test`(" + id_test + ")";

            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                 //check pass with user
                    tests_name = myreader["name"].ToString();
                    tests_qus = myreader["question"].ToString();
                    // user = myreader["pr_cod"].ToString();
                }

                //close connection
                this.CloseConnection();


            }

        }

        public void id_test(string name_test)
        {
            string query = "CALL `test _id`('" + name_test + "')";

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

        public void insert_tests_users(int test_id,int user_id,string date,string user_answer)
        {
            string query = "CALL `insert_users_answ`('"+test_id+"', '"+user_id+"', '"+date+"', '"+user_answer+"')";

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

        public void insert_users(int pr_cod, int pass, int permission)
        {
            string query = "CALL `insert_user`('" + pr_cod + "', '" + pass + "', '" + permission + "')";

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

        public void insert_departman(string dep_name)
        {
            string query = "CALL `insert_departman`('" + dep_name + "')";

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

        public void insert_machine(string machine_name)
        {
            string query = "CALL `insert_machine`('" + machine_name + "')";

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

        public void insert_test(string test_name, int machine_id, string qus)
        {
            string query = "CALL `insert_test`('" + test_name + "', '" + machine_id + "', '" + qus + "')";

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

        public void insert_sync_dep_mach(int dep_id, int mach_id)
        {
            string query = "CALL `insert_sync_dep_mach`('" + dep_id + "', '" + mach_id + "')";

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
    }

   
}
