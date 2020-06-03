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
        public int no_f;
        public string f1;
        public string f2;
        public string f3;
        public string f4;
        public string f5;
        public string f6;
        public string f7;
        public string f8;
        public string f9;
        public string f10;
        public string f11;
        public string f12;
        public string f13;
        public string f14;
        public string f15;
        public string f16;
        public string f17;
        public string f18;
        public string f19;
        public string f20;
        
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

        public void count_user()
        {
            string query = "CALL `count_user`()";

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
        public void id_user(string name_mach)
        {
            string query = "CALL `user_id`('" + name_mach + "')";

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
        public void name_user(int id_user)
        {
            string query = "CALL `name_user`(" + id_user + ")";

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
        IList<int> test_list = new List<int>();
        public void sync_test_user(int id_user)
        {
            string query = "CALL `sync_user_test`(" + id_user + ")";

            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {

                    test_list.Add(Convert.ToInt32(myreader["test_id"].ToString()));

                }

                //close connection
                this.CloseConnection();


            }

        }

        public void sync_test_user_name()
        {
            int j = test_list.Count;
            for (int i = 0; i < j; i++)
            {

                test_name(Convert.ToInt32(test_list[i].ToString()));
                string temp = "";
                temp = File.ReadAllText("temp");

                File.WriteAllText("temp", temp + tests_name + "%");

            }

            for (int i = 0; i < j; i++)
            {
                test_list.RemoveAt(0);
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

        public void count_test_all()
        {
            string query = "CALL `count_test_all`()";

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
                    no_f =Convert.ToInt32( myreader["no_f"].ToString());
                    f1 = myreader["f1"].ToString();
                    f2 = myreader["f2"].ToString();
                    f3 = myreader["f3"].ToString();
                    f4 = myreader["f4"].ToString();
                    f5 = myreader["f5"].ToString();
                    f6 = myreader["f6"].ToString();
                    f7 = myreader["f7"].ToString();
                    f8 = myreader["f8"].ToString();
                    f9 = myreader["f9"].ToString();
                    f10 = myreader["f10"].ToString();
                    f11 = myreader["f11"].ToString();
                    f12 = myreader["f12"].ToString();
                    f13 = myreader["f13"].ToString();
                    f14 = myreader["f14"].ToString();
                    f15 = myreader["f15"].ToString();
                    f16 = myreader["f16"].ToString();
                    f17 = myreader["f17"].ToString();
                    f18 = myreader["f18"].ToString();
                    f19 = myreader["f19"].ToString();
                    f20 = myreader["f20"].ToString();

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

        public void search_test(int id_test,int id_user)
        {
            string query = "CALL `search_test`(" + id_test + ","+id_user+")";

            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())
                
                    //check pass with user
                    //message = "";
                    message = myreader["id"].ToString();
                    //tests_qus = myreader["question"].ToString();
                    // user = myreader["pr_cod"].ToString();
                

                //close connection
                this.CloseConnection();


            }

        }

        public void insert_tests_users(int test_id,int user_id,string date,string user_answer,string f1, string f2, string f3, string f4, string f5, string f6, string f7, string f8,
            string f9, string f10, string f11, string f12, string f13, string f14, string f15, string f16, string f17, string f18, string f19, string f20)
        {
            string query = "CALL `insert_users_answ`('"+test_id+"', '"+user_id+"', '"+date+"', '"+user_answer+ "', '" + f1 + "', '" + f2 + "', '" + f3 + "', '" + f4 + "', '" + f5 
                + "', '" + f6 + "', '" + f7 + "', '" + f8 + "', '" + f9 + "', '" + f10 + "', '" + f11 + "', '" + f12 + "', '" + f13 + "', '" + f14 + "', '" + f15 + "', '" + f16 + "', '" 
                + f17 + "', '" + f18 + "', '" + f19 + "', '" + f20 + "')";

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

        public void insert_test(string test_name, int machine_id, string qus,int numf,string f1, string f2, string f3, string f4, string f5, string f6, string f7, string f8, string f9, string f10, string f11, string f12, string f13, string f14, string f15, string f16, string f17, string f18, string f19, string f20)
        {
            string query = "CALL `insert_test`('" + test_name + "', '" + machine_id + "', '" + qus + "', '" + f1 + "', '" + f2 + "', '" + f3 + "', '"
                + f4 + "', '" + f5 + "', '" + f6 + "', '" + f7 + "', '" + f8 + "', '" + f9 + "', '" + f10 + "', '" + f11 + "', '" + f12 + "', '" + f13 + "', '" + f14 + "', '" 
                + f15 + "', '" + f16 + "', '" + f17 + "', '" + f18 + "', '" + f19 + "', '" + f20 + "', '" + numf + "')";

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

        public void check_sync(int dep_id, int mach_id)
        {
            string query = "CALL `check_sync`('" + dep_id + "', '" + mach_id + "')";

            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())


                    //check pass with user
                    message = myreader["id"].ToString();
                // user = myreader["pr_cod"].ToString();


                //close connection
                this.CloseConnection();


            }

        }
        public string answer;
        public string date_answer;
        public void test_user_answr(int test_id,int user_id)
        {
            string query = "CALL `select_answer`(" + test_id + ","+user_id+")";

            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    //check pass with user
                    date_answer = myreader["date"].ToString();
                    answer = myreader["user_answer"].ToString();
                    // user = myreader["pr_cod"].ToString();
                }

                //close connection
                this.CloseConnection();


            }

        }

        public void edit_tests_users(int test_id, int user_id, string date, string user_answer)
        {
            string query = "CALL `edit_answer`('" + test_id + "', '" + user_id + "', '" + date + "', '" + user_answer + "')";

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
        IList<int> user_list = new List<int>();
        public void sync_user_test(int id_test)
        {
            string query = "CALL `sync_test_user`(" + id_test + ")";

            if (this.OpenConnection() == true)
            {
                
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                   
                    user_list.Add(Convert.ToInt32(myreader["user_id"].ToString()));

                }

                //close connection
                this.CloseConnection();


            }

        }

        public void sync_user_test_name()
        {
            int j = user_list.Count;
            for (int i = 0; i < j; i++)
            {

                //test_name_user(user_list[i]);
                string temp = "";
                temp = File.ReadAllText("temp");

                File.WriteAllText("temp", temp + user_list[i].ToString() + "%");

            }

            for (int i = 0; i < j; i++)
            {
                user_list.RemoveAt(0);
            }
        }

        IList<int> testansw_list = new List<int>();
        public void sync_test_22_user(int id_test, int id_user)
        {
            string query = "CALL `search_test`("+id_test+"," + id_user + ")";

            if (this.OpenConnection() == true)
            {

                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {

                    testansw_list.Add(Convert.ToInt32(myreader["id"].ToString()));

                }

                //close connection
                this.CloseConnection();


            }

        }

        public void sync_test_22_user_name()
        {
            int j = testansw_list.Count;
            for (int i = 0; i < j; i++)
            {

                //test_name(Convert.ToInt32(testansw_list[i].ToString()));
                string temp = "";
                temp = File.ReadAllText("temp");

                File.WriteAllText("temp", temp + testansw_list[i].ToString() + "%");

            }

            for (int i = 0; i < j; i++)
            {
                testansw_list.RemoveAt(0);
            }
        }

    }


}
