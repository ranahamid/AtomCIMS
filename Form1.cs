using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;

using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

using Microsoft.Win32;
using MySql.Data.MySqlClient;

namespace Atom_CIMS
{
    public partial class Form1 : Form
    {
        private string pass=String.Empty;
       
        private string username=String.Empty;
        string hash=String.Empty;

      //  private string parentComboBox;

        private int userID;

        private string conn;
        private MySqlConnection connect;

        private string  ChildComboBoxText=String.Empty;
        private int domin_ID;
        private string CredenText=String.Empty;
        string[] domain_name = new string[100];
        string[] Childdomain_name = new string[100];

      //  private int domainCount = 0;

        System.Windows.Forms.RadioButton[] radioButtons =
       new System.Windows.Forms.RadioButton[100];

        TabPage[] newPage = new TabPage[100];
        private const string key = "gh9K*fCsZa2@hBc&hjasLKVfVBNa*%f";

        private int TotalRadioButtons = 0;

        private bool Startup = false;
        private bool StartupLoginFailed = false;
        private bool logoDisplayoff = false; 
        private bool loginDisplayoff = false;


        private void CheckAuthentication()
        {
            username = Properties.Settings.Default.UserName2;
            if (Properties.Settings.Default.UserName2 == string.Empty)
            {
                groupBox5_log.Visible = false;
                groupBox3_logo.Visible = true;
                groupBox4_browser.Visible = false;
                groupBox5_help.Visible = false;
            }
        }

        

     

        public Form1()
        {
            InitializeComponent();
            Rectangle workingArea = Screen.GetWorkingArea(this);
            double d = Size.Height*0.25;
            int m =(int)d;
            this.Location = new Point(workingArea.Right - Size.Width,
                                      workingArea.Bottom - Size.Height - m);


            notifyIcon1.Visible = false;
            groupBox4_browser.Text = "Domain/ Information categories";

            try
            {
        //        conn = "Server=192.185.191.51; Port=3306; Database=atomap_cims;Uid=atomap_cims;Password=c123ims@;";


                string txt = String.Empty;
                try
                {
                    string[] lines = System.IO.File.ReadAllLines(@"database.txt");
                    foreach (string line in lines)
                    {
                        txt = txt + line;
                    }
                    txt = txt + "@;";
                    //     MessageBox.Show(txt);
                    conn = txt;
                }
                catch (Exception)
                {
                    MessageBox.Show("Can't find the database credentials file.");
                    Application.Exit();
                }


                




                connect = new MySqlConnection(conn);
                connect.Open();
                //  MessageBox.Show("connect successfullly!!");

            }
            catch (MySqlException e)
            {
              
                MessageBox.Show("Couldn't connect to the database!!");

                throw;

            }
        //    webBrowser2_logo.DocumentText = "<p>Credentials and information management system</p>";
            CheckAuthentication();
            username = Properties.Settings.Default.UserName2;



            if (Properties.Settings.Default.UserName2 != String.Empty)
                {
                    button1_login.Text = "Log Out";
                }
                else
                {
                    button1_login.Text = "Log In";
                }
            
        }


        //Exit MenuItem
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form1_FormSystemTray();
        }

     

        //about MenuItem
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new AboutBox();
            //Show the about window
            about.ShowDialog();
        }


        private void Form1_FormSystemTray()
        {
            notifyIcon1.Visible = true;
            Hide();
        }
        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {

            //log
            string date = DateTime.Now.ToLongDateString();
            string time = DateTime.Now.ToLongTimeString();
            int userCount = Properties.Settings.Default.UserCount++;
            Properties.Settings.Default.Save();

            VariableClass.file.WriteLine("Close App: " + time + " " + date);
            VariableClass.file.WriteLine("Username: " + Properties.Settings.Default.UserName2);
            VariableClass.file.WriteLine("-------------------");
            VariableClass.file.Flush();
            //end of log
            connect.Close();
           // Application.Exit();


            if (e.CloseReason == CloseReason.UserClosing)
            {
                 e.Cancel = true;
                 notifyIcon1.Visible = true;
                 Hide();
            } 
        }

        
     

        public static string GenerateSHA512String(string pass, string salt)
        {
            SHA512 sha512 = SHA512Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(string.Concat(pass, salt));
            byte[] hash = sha512.ComputeHash(bytes);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {

                sb.Append(hash[i].ToString("x2"));
            }

            return sb.ToString();
        }

        private bool validate_login()
        {
            // db_connection() ;
            //hash
            hash = GenerateSHA512String(pass, key);
            // MessageBox.Show(hash);
            //end of hash

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "Select * from users where username=@user and password=@hash";
            cmd.Parameters.AddWithValue("@user", username);
            cmd.Parameters.AddWithValue("@hash", hash);
            connect.Close();
            cmd.Connection = connect;
            connect.Open();
            //if (connect.State!=ConnectionState.Open)
            //connect.Open();
            MySqlDataReader login = cmd.ExecuteReader();
           // connect.Close();
            
            if (login.Read())
            {
                userID = login.GetInt32("id");
                login.Close();
                 textBox2_username.Text=String.Empty;
                 textBox1_password.Text = String.Empty; 

                return true;
            }
            else
            {
                Properties.Settings.Default.UserName2 = String.Empty;
                Properties.Settings.Default.PassWord2 = String.Empty;
                Properties.Settings.Default.Save();
     
                return false;
            }

        }

        private void Domain()
        {
            if (Properties.Settings.Default.UserName2 != string.Empty)
            {
                
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText =
                    "Select distinct domain_name from domain,assign where domain.status=1 and domain.id=assign.domain_id and assign.user_id=@userID";
                cmd.Parameters.AddWithValue("@userID", userID);

                connect.Close();
                cmd.Connection = connect;
                connect.Open();

                MySqlDataReader login = cmd.ExecuteReader();
         

                int domainCount = 0;

                while (login.Read())
                {
                    domain_name[domainCount] = login.GetString("domain_name");

                    newPage[domainCount] = new TabPage(domain_name[domainCount]);
                    tabControl1.TabPages.Add(newPage[domainCount]);
                    newPage[domainCount].AutoScroll = true;
                    domainCount++;
                }
                tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;


                comboBox1_SelectedIndexChanged1();
            }
            else
            {
                loginDisplay();
            }
        }


        private void tabControl1_SelectedIndexChanged(Object sender, EventArgs e)
        {

            for (int i = 0; i < TotalRadioButtons; i++)
            {
                radioButtons[i].Checked = false;
              //  radioButtons[i].Text = "";
          //      tabControl1.SelectedTab.Controls.Remove(radioButtons[i]);
            }

            if (Properties.Settings.Default.UserName2 != string.Empty)
            {


              //  textBox1.Text = String.Empty;
                webBrowser1.DocumentText = String.Empty;

                //    MessageBox.Show("You are in the TabControl.SelectedIndexChanged event.");
                comboBox1_SelectedIndexChanged1();
            }
            else
            {
                loginDisplay();
            }
        }



        private void showDomain()
        {
            if (Properties.Settings.Default.UserName2 != string.Empty)
            {
                //    MessageBox.Show("user id : " + userID);
                Domain();
            }
            else
            {
                loginDisplay();
            }
        }

        private void HitLink()
        {
            //log
            string date3 = DateTime.Now.ToLongDateString();
            string time3 = DateTime.Now.ToLongTimeString();

            VariableClass.file.WriteLine("Start app: " + time3 + " " + date3);
            VariableClass.file.WriteLine("Username: " + username);
            VariableClass.file.WriteLine("-------------------");
            VariableClass.file.Flush();
            //end of log
            //TO BE show the menu

            
                bool r = validate_login();
                if (r)
                {
                    groupBox5_log.Visible = false;
                    groupBox4_browser.Visible = true;
                    groupBox1.Visible = false;
                    button1_login.Text = "Log Out";
                    //save 
                    Properties.Settings.Default.UserName2 = username;
                    Properties.Settings.Default.PassWord2 = pass;
                    Properties.Settings.Default.Save();
                    //set                             
                    Startup = false;
                    StartupLoginFailed = false;
                   
                    
                    //log
                    string date = DateTime.Now.ToLongDateString();
                    string time = DateTime.Now.ToLongTimeString();

                    VariableClass.file.WriteLine("Logged in: " + time + " " + date);
                    VariableClass.file.WriteLine("Username: " + Properties.Settings.Default.UserName2);
                    VariableClass.file.WriteLine("-------------------");
                    VariableClass.file.Flush();

                    //end of log

                    //show domain
                    showDomain();
                }

                else
                {
                    MessageBox.Show("Incorrect Login Credentials");
                   // loginDisplay();
                    button1_login.Text = "Log In";

                    if (Startup)
                    {
                        tabControl1.TabPages.Clear();
                        groupBox5_log.Visible = false;
                        groupBox3_logo.Visible = true;
                        groupBox4_browser.Visible = false;
                        groupBox1.Visible = false;
                        groupBox5_help.Visible = false;
                        StartupLoginFailed = true;
                        Startup = false;
                    }
                }
        }







        private void loginDisplay()
        {
            groupBox5_log.Visible = true;
            groupBox3_logo.Visible = false;
            button1_login.Text = "Log In";
          
            groupBox4_browser.Visible = false;
            groupBox1.Visible = false;
            groupBox5_help.Visible = false;

        }

        private void button1_login_Click(object sender, EventArgs e)
        {
            //change User

            if (Properties.Settings.Default.UserName2 == string.Empty)
            {

                //var login = new Log_In();
                ////Show the about window
                //login.Show();
               
                loginDisplay();

            }
            else
            {
                DialogResult result=MessageBox.Show("You are logged in. Do You really want to log out?", "Log Out",MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {

                    Properties.Settings.Default.UserName2 = string.Empty;
                    Properties.Settings.Default.PassWord2 = string.Empty;
                    Properties.Settings.Default.Save();
                    username=String.Empty;
                    pass=String.Empty;

                    //log
                    string date = DateTime.Now.ToLongDateString();
                    string time = DateTime.Now.ToLongTimeString();

                    VariableClass.file.WriteLine("Logout Successfully: " + time + " " + date);
                    VariableClass.file.WriteLine("Username: " + Properties.Settings.Default.UserName2);
                    VariableClass.file.WriteLine("-------------------");
                    VariableClass.file.Flush();

                    //end of log

                    tabControl1.TabPages.Clear();
                    CheckAuthentication();
                }
                  
            }
            

        }

        private void ChekHit()
        {
            pass = Properties.Settings.Default.PassWord2;
            username = Properties.Settings.Default.UserName2;

            if ((username != string.Empty) && (pass != string.Empty))
            {

                Startup = true;
                HitLink();

            }
        }


        private void Form1_Shown(object sender, EventArgs e)
        {
            ChekHit();
        }

    

        private void comboBox1_SelectedIndexChanged1()
        {
            if (Properties.Settings.Default.UserName2 != string.Empty)
            {
              //  textBox1.Text = String.Empty;
                webBrowser1.DocumentText = String.Empty;

                GetDomain_ID();
                //     MessageBox.Show("domain id: " + domin_ID);

                //populate

                RadioButtonList();
            }
            else
            {
                loginDisplay();
            }
         

        }

        

        private void RadioButtonList()
        {
            if (Properties.Settings.Default.UserName2 != string.Empty)
            {
                //radio button
            
                MySqlCommand cmd2 = new MySqlCommand();
                cmd2.CommandText = "Select domain_info.title from domain_info,assign where assign.status=1 and assign.domain_id=@domainID and domain_info.domain_id=@domainID and assign.user_id=@userID and assign.domain_info_id=domain_info.id";


                cmd2.Parameters.AddWithValue("@domainID", domin_ID);
                cmd2.Parameters.AddWithValue("@userID", userID);


          
                connect.Close();
                cmd2.Connection = connect;
                connect.Open();


                int i = 0;
         
                MySqlDataReader login = cmd2.ExecuteReader();
                while (login.Read())
                {
                    Childdomain_name[i] = login.GetString("title");
                    //   MessageBox.Show(Childdomain_name[i]);


                    radioButtons[i] = new RadioButton();
                   
                    radioButtons[i].Checked = false;

                    Label info=new Label();
                    info.Height= 13;
                    info.Width = 176;
                    info.Text = "Credentials/information";
                    info.Location=new System.Drawing.Point(30,4);

                    
                    radioButtons[i].Text = Childdomain_name[i];
                 

                    //if (i < 15)
                    {
                        radioButtons[i].Location = new System.Drawing.Point(30, 23 + i * 20);
                    }
                    //else if (i < 30 && i >= 15)
                    //{
                    //    radioButtons[i].Location = new System.Drawing.Point(250, 20 + i * 20);
                    //}
                    //else if (i < 45 && i >= 30)
                    //{
                    //    radioButtons[i].Location = new System.Drawing.Point(500, 20 + i * 20);
                    //}


                    this.radioButtons[i].Size = new System.Drawing.Size(185, 17);
                    //this.Controls.Add(radioButtons[i]);

                    // Add the generic event handler
                    radioButtons[i].Click += new System.EventHandler(genericClick);


                    tabControl1.SelectedTab.Controls.Add(radioButtons[i]);
                    tabControl1.SelectedTab.Controls.Add(info);

                    //this.newPage[]
                    i++;
                }
                TotalRadioButtons = i;
                //    string TabNow = tabControl1.SelectedTab.Text;



                //      MessageBox.Show(this.newPage[domainCount].Text);
            }
            else
            {
                loginDisplay();
            }
          
        }

        private void genericClick(object sender, System.EventArgs e)
        {
            RadioButton rdb;
            rdb = (RadioButton)sender;
         //   MessageBox.Show(rdb.Text);
            ChildComboBoxText = rdb.Text;
            TextBoxPopulate();
        }



 
        private void TextBoxPopulate()
        {


            if (Properties.Settings.Default.UserName2 != string.Empty)
            {
               
                MySqlCommand cmd = new MySqlCommand();
              //  cmd.CommandText = "Select detail from domain_info where status=1 and domain_id=@domainID  and  title= @ChildComboBoxText";
                cmd.CommandText = "Select detail from domain_info where  domain_id=@domainID  and  title= @ChildComboBoxText";


                cmd.Parameters.AddWithValue("@domainID", domin_ID);
                cmd.Parameters.AddWithValue("@ChildComboBoxText", ChildComboBoxText);
                //  cmd.Parameters.AddWithValue("@userID", userID);


                connect.Close();
                cmd.Connection = connect;
                connect.Open();

                MySqlDataReader login = cmd.ExecuteReader();


                while (login.Read())
                {
                    CredenText = login.GetString("detail");
                    //   MessageBox.Show("child : " +  CredenText );
                   // textBox1.Text = CredenText;
                }
               // textBox1.Text = CredenText;
               // if(CredenText!=String.Empty)
                 CrackDetails(CredenText);
            }

            else
            {
                loginDisplay();
            }

        }

        private void CrackDetails(   string cipher)
        {

           System.Text.StringBuilder result = new System.Text.StringBuilder();

           byte[] binary = Convert.FromBase64String(cipher);
           cipher = Encoding.Default.GetString(binary);//ok


           string lastChar = cipher.Substring(cipher.Length - 1);

           int end_length = Int32.Parse(lastChar);//----------------Need calc-----------------------------


           //  MessageBox.Show(end_length.ToString());

           //   MessageBox.Show(end_length.ToString());

           cipher = cipher.Substring(0, cipher.Length - 1);// ok


           //  string temp = cipher.Substring(cipher.Length-end_length, cipher.Length);


           //	$salt_length = intval(substr($cipher, $end_length*-1, $end_length));
           string temp;
           temp = cipher.Substring(cipher.Length - end_length);//okkk
           int salt_length = Int32.Parse(temp);//okk//------------------------need calc---------------------



           //  MessageBox.Show(salt_length.ToString());

           //		$cipher = substr($cipher, 0, $end_length*-1+$salt_length*-1);

           cipher = cipher.Substring(0, cipher.Length + end_length * -1 + salt_length * -1);//ok
           //  MessageBox.Show(cipher);




           //textBox1.Text = cipher;

           string chars = String.Empty;
           string keychar = String.Empty;


           string bb = "hello world";
           chars = bb.Substring(2, 1);
           //MessageBox.Show("chars: "+chars);
           //MessageBox.Show(cipher);

           for (int i = 0; i < cipher.Length; i++)
           {
               chars = cipher.Substring(i, 1);//ok

               //     MessageBox.Show("chars: "+chars.ToString());

               //$keychar = substr($key, ($i % strlen($key))-1, 1);

               int modulas = (i % key.Length) - 1;
               //  MessageBox.Show(modulas.ToString());
               if (modulas >= 0)
               {
                   keychar = key.Substring(modulas, 1);
                   //     MessageBox.Show(keychar);
               }
               else if (modulas < 0)
               {

                   keychar = (key.Substring(key.Length + modulas)).Substring(0, 1);

               }
               //ok

               // chars=((int)chars[0])- ((int)keychar[0]);


               //chars
               string tt = String.Empty;
               var bytes = Encoding.GetEncoding(1252).GetBytes(chars);
               foreach (byte b in bytes)
               {


                   tt = b.ToString();
               }

               int x = Int32.Parse(tt);

               //  textBox1.Text =  textBox1.Text+ x.ToString()+" ";
               //y
               //key
               string tt2 = String.Empty;
               var bytes2 = Encoding.GetEncoding(1252).GetBytes(keychar);
               foreach (byte b in bytes2)
               {


                   tt2 = b.ToString();
               }

               int y = Int32.Parse(tt2);

               //  textBox1.Text = textBox1.Text + y.ToString() + " ";

               int t = x - y;
               char c = Convert.ToChar(t);
               result = result.Append(c);


           }
            //    textBox1.Text = result.ToString();
            groupBox1.Visible = true;
            groupBox4_browser.Visible = false;
            webBrowser1.DocumentText = result.ToString();
        }




        private bool GetDomain_ID()
        {
            if (Properties.Settings.Default.UserName2 != string.Empty)
            {
                //MessageBox.Show("in domain ID");
             
                MySqlCommand cmd2 = new MySqlCommand();
                string TabNow = tabControl1.SelectedTab.Text;


                //      MessageBox.Show("select tab: "+TabNow);

                cmd2.CommandText = "Select * from domain where domain_name=@name ";
                cmd2.Parameters.AddWithValue("@name", TabNow);


                connect.Close(); 
                cmd2.Connection = connect;
                connect.Open(); 
                MySqlDataReader login4 = cmd2.ExecuteReader();
               

                if (login4.Read())
                {

                    domin_ID = login4.GetInt32("id");
               
                    return true;
                }
                else
                {
                    MessageBox.Show("can't get domain id");
                    return false;
                }
            }
            else
            {
                loginDisplay();
                return false;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox4_browser.Visible = true;
        }

        private void Helpbutton3_Click(object sender, EventArgs e)
        {

            if (groupBox3_logo.Visible)
            {
                groupBox3_logo.Visible = false;
                logoDisplayoff = true;
            }
             //if (StartupLoginFailed && groupBox3_logo.Visible)
             //           {
             //               groupBox3_logo.Visible = false;
             //               logoDisplayoff = true;
             //           }


            if (StartupLoginFailed && groupBox5_log.Visible )
            {
                groupBox5_log.Visible = false;
                loginDisplayoff = true;
            }

            string htmlText = @"

            <ul>
              <li>Ask web administrator to register an account if not exist.</li>
              <li>Only assigned information will be visible for registered user.</li>
              <li>All Information is read-only on desktop version.</li>
              <li>Please, Visit web application for administrative use. Click &quot;Web&quot; button for online application.</li>
              <li>To exit application, right click on tray icon and click Exit.</li>
            </ul>
            ";
            webBrowser2_help.DocumentText = htmlText;
            groupBox5_help.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string link = @"http://atomasiapacific.com/atomapcims/";
            System.Diagnostics.Process.Start(link.ToString());
        }

       
        
        private void button3_logIn_Click(object sender, EventArgs e)
        {
            username = textBox2_username.Text;
            pass = textBox1_password.Text;


            if ((username != string.Empty) && (pass != string.Empty))
            {
             

                //log
                string date = DateTime.Now.ToLongDateString();
                string time = DateTime.Now.ToLongTimeString();

                int userCount = Properties.Settings.Default.UserCount++;
                Properties.Settings.Default.Save();

                VariableClass.file.WriteLine("User Count :" + userCount);
                VariableClass.file.WriteLine("User login try" + time + " " + date);
                VariableClass.file.WriteLine("Username: " + username);
                VariableClass.file.WriteLine("-------------------");
                VariableClass.file.Flush();
                //end of log
                HitLink();
            }
            else
            {
                //log
                string date = DateTime.Now.ToLongDateString();
                string time = DateTime.Now.ToLongTimeString();
                VariableClass.file.WriteLine("User login failed: " + time + " " + date);
                if (username != string.Empty)
                {
                    VariableClass.file.WriteLine("Try with Username: " + username);
                }

                else
                {
                    VariableClass.file.WriteLine("Username: Not a username supplied.");
                }


                //end of log
                string msg = "Please enter all fields.";
                VariableClass.file.WriteLine(msg);
                VariableClass.file.WriteLine("-------------------");
                VariableClass.file.Flush();
                MessageBox.Show(msg, "Error in Login");

            }
        }

        private void textBox2_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3_logIn_Click(sender, e);
            }
        }

        private void textBox1_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3_logIn_Click(sender, e);
            }
        }

        private void button3_helpOk_Click(object sender, EventArgs e)
        {
            groupBox5_help.Visible = false;

          

            if (groupBox3_logo.Visible== false && logoDisplayoff)
            {
                groupBox3_logo.Visible = true;
                groupBox5_log.Visible = false;
                logoDisplayoff = false;
            }

            if ( groupBox5_log.Visible == false && loginDisplayoff)
            {
                groupBox5_log.Visible = true;
                groupBox3_logo.Visible = false;
                loginDisplayoff = false;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Show();
                notifyIcon1.Visible = false;

                WindowState = FormWindowState.Normal;
            }
         
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
