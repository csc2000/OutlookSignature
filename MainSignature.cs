using System.IO;
using System;
using System.Configuration;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;
using MySql.Data.MySqlClient;

namespace OutlookCorporateSignature
{
    public partial class MainSignature : Form
    {

        Configuration configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        KeyValueConfigurationCollection settings = null;
        MySqlConnection connection = null;
        string FontColor = "Black";

        public MainSignature()
        {
            InitializeComponent();
            settings = configFile.AppSettings.Settings;
            connection = new MySqlConnection(settings["connectionString"].Value);
            GetUserDataFromFile();
            richTextBox1.Text = File.ReadAllText("lasttext.txt",Encoding.Default);
        }

        private void ButtonAddNewUsers_Click(object sender, EventArgs e)
        {
            string[] directories = Directory.GetDirectories(Directory.GetParent((Environment.GetFolderPath(Environment.SpecialFolder.UserProfile))).ToString());
            foreach (string directory in directories)
            {
                string director = directory.Substring(Directory.GetParent(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)).ToString().Length + 1);
                AddNewUsers(director);
            }
            GetUserDataFromFile();
        }

        private void ButtonSave4All_Click(object sender, System.EventArgs e)    //      --- BEGIN BUTTON CLICK ---
        {
            WriteForAllUsers();
        }

        private void ButtonUserDel_Click(object sender, EventArgs e)
        {
            DeleteSelected();
            GetUserDataFromFile();
        }

        private void ButtonUserEdit_Click(object sender, EventArgs e)
        {
            new EditUser(listView1.SelectedItems[0].SubItems[4].Text).ShowDialog();
            GetUserDataFromFile();
        }

        private void Button6_Click(object sender, System.EventArgs e)
        {
            ReloadTextBoxColor(Color.Blue);
            FontColor = "Blue";
        }

        private void ButtonColorYellow_Click(object sender, System.EventArgs e)
        {
            ReloadTextBoxColor(Color.Yellow);
            FontColor = "Yellow";
        }

        private void ButtonColorDarkblue_Click(object sender, System.EventArgs e)
        {
            ReloadTextBoxColor(Color.DarkBlue);
            FontColor = "Darkblue";
        }

        private void ButtonColorRed_Click(object sender, System.EventArgs e)
        {
            ReloadTextBoxColor(Color.Red);
            FontColor = "Red";
        }

        private void ButtonColorDarkred_Click(object sender, System.EventArgs e)
        {
            ReloadTextBoxColor(Color.DarkRed);
            FontColor = "Darkred";
        }

        private void ButtonColorGreen_Click(object sender, System.EventArgs e)
        {
            ReloadTextBoxColor(Color.DarkGreen);
            FontColor = "DarkGreen";
        }

        private void ButtonColorBlack_Click(object sender, System.EventArgs e)
        {
            ReloadTextBoxColor(Color.Black);
            FontColor = "Black";
        }

        private void ButtonBold_Click(object sender, System.EventArgs e)
        {
            if (!button_bold.Font.Bold)
            {
                button_bold.Font = new Font(button_bold.Font.Name, button_bold.Font.Size, FontStyle.Bold);
                richTextBox1.Font = new Font(richTextBox1.Font.Name, richTextBox1.Font.Size, FontStyle.Bold);
            }
            else
            {
                button_bold.Font = new Font(button_bold.Font.Name, button_bold.Font.Size, FontStyle.Regular);
                richTextBox1.Font = new Font(richTextBox1.Font.Name, richTextBox1.Font.Size, button_italic.Font.Italic ? FontStyle.Italic : FontStyle.Regular);
            }
        }

        private void ButtonItalic_Click(object sender, System.EventArgs e)
        {
            if (!button_italic.Font.Italic)
            {
                button_italic.Font = new Font(button_italic.Font.Name, button_italic.Font.Size, FontStyle.Italic);
                richTextBox1.Font = new Font(richTextBox1.Font.Name, richTextBox1.Font.Size, FontStyle.Italic);
            }
            else

            {
                button_italic.Font = new Font(button_italic.Font.Name, button_italic.Font.Size, FontStyle.Regular);
                richTextBox1.Font = new Font(richTextBox1.Font.Name, richTextBox1.Font.Size, button_bold.Font.Bold ? FontStyle.Bold : FontStyle.Regular);
            }
        }

        private void ButtonSave4User_Click(object sender, System.EventArgs e)
        {
            WriteForCheckedUsers();
        }

        private void SaveemClient(string htmlcode, string username)    //      --- BEGIN FUNCTION AREA ---
        {
            SQLiteConnection sqliteconnection;
            sqliteconnection = new SQLiteConnection("Data Source=" + "C:\\Users\\" + username + "\\AppData\\Roaming\\em Client\\snippets.dat; Version = 3; New = True; Compress = True; ");
            try
            {
                sqliteconnection.Open();
                SQLiteCommand sqlitecommand = sqliteconnection.CreateCommand();
                sqlitecommand.CommandText = "UPDATE Snippets SET body = @body, allowEdit = 0, name = 'default' WHERE id = 1";
                sqlitecommand.Parameters.AddWithValue("body", htmlcode);
                sqlitecommand.ExecuteNonQuery();
                sqliteconnection.Close();
            }
            catch
            {
                sqliteconnection.Close();
            }
        }

        private void WriteForAllUsers()
        {
           foreach (ListViewItem item in listView1.Items)
            {
                CompleteTemplate(item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text, item.SubItems[4].Text);
            }
        }

        private void WriteForCheckedUsers()
        {
            foreach (ListViewItem item in listView1.CheckedItems)
            {
                CompleteTemplate(item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text, item.SubItems[4].Text);
            }
        }

        private void GetUserDataFromFile()
        {
            SQLiteConnection sqliteconnection;
            sqliteconnection = new SQLiteConnection("Data Source=" + "users.bin; Version = 3; New = True; Compress = True; ");
            try
            {
                listView1.Items.Clear();
                sqliteconnection.Open();
                SQLiteCommand sqlitecommand = sqliteconnection.CreateCommand();
                sqlitecommand.CommandText = "SELECT name, pos, mail, dw, username FROM users";
                SQLiteDataReader sqlitereader = sqlitecommand.ExecuteReader();
                while (sqlitereader.Read())
                {
                    ListViewItem item = new ListViewItem(sqlitereader["name"].ToString());
                    item.SubItems.Add(sqlitereader["pos"].ToString());
                    item.SubItems.Add(sqlitereader["mail"].ToString());
                    item.SubItems.Add(sqlitereader["dw"].ToString());
                    item.SubItems.Add(sqlitereader["username"].ToString());
                    listView1.Items.Add(item);
                }
                sqlitecommand.Dispose();
                sqliteconnection.Close();
            }
            catch
            {
                sqliteconnection.Close();
            }
        }

        private void DeleteSelected()
        {

            foreach (ListViewItem item in listView1.CheckedItems)
            {
                SQLiteConnection sqliteconnection;
                sqliteconnection = new SQLiteConnection("Data Source=" + "users.bin; Version = 3; New = True; Compress = True; ");
                try
                {
                    sqliteconnection.Open();
                    SQLiteCommand sqlitecommand = sqliteconnection.CreateCommand();
                    sqlitecommand.CommandText = "DELETE FROM users WHERE username = @user";
                    sqlitecommand.Parameters.AddWithValue("user", item.SubItems[4].Text);

                    sqlitecommand.ExecuteNonQuery();
                    sqlitecommand.Dispose();
                    sqliteconnection.Close();
                    }
                catch
                    {
                        sqliteconnection.Close();
                    }
            }
        }

        private void CompleteTemplate(string name, string pos, string mail, string dw, string username)
        {
            var StringBuilder = new System.Text.StringBuilder();
            foreach (string s in File.ReadAllLines("OutlookTemplate.htm", System.Text.Encoding.Default))
            {
                StringBuilder.AppendLine(s);
            }

            string bold = button_bold.Font.Bold ? "<b>" : "";
            string italic = button_italic.Font.Italic ? "<i>" : "";
            string ftcolorhtml = "<font color =" + FontColor + ">";
        
            StringBuilder.Replace("NAMEPLACEHOLDER", name);
            StringBuilder.Replace("MAILPLACEHOLDER", mail);

            if(richTextBox1.Enabled){
            StringBuilder.Replace("TEXTPLACEHOLDER", "<p>" + bold + italic + ftcolorhtml + richTextBox1.Text.Replace("\n", "<br />") + "</p></b></i></font>");
            } else {
            StringBuilder.Replace("TEXTPLACEHOLDER", " ");
            }               

            StringBuilder.Replace("DWPLACEHOLDER", dw);
            StringBuilder.Replace("<!--POSPLACEHOLDER-->", pos);

            if (checkBox_Outlook.Checked == true)
            {
                System.IO.File.WriteAllText("C:\\Users\\" + username + "\\AppData\\Roaming\\Microsoft\\Signatures\\Default.htm", StringBuilder.ToString(), System.Text.Encoding.Default);
            }
            if (checkBox_em.Checked == true)
            {
                SaveemClient(StringBuilder.ToString(), username);
            }
            System.IO.File.WriteAllText("D:\\Temp-Net\\lasttext.txt", richTextBox1.Text, System.Text.Encoding.Default); 
        }

        private void ReloadTextBoxColor(Color color)
        {
            richTextBox1.ForeColor = color;
        }

        private void CheckBoxAdditionalText_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkBox_additionalText.Checked)
            {
                richTextBox1.Enabled = true;
            }
            else
            {
                richTextBox1.Enabled = false;
            }
        }

        private void AddNewUsers(string user) //NEUE LEERE BENUTZER HINZUFÜGEN -> Setzt Benutzername, alle anderen Values bleiben leer und zeigen NEU an.
        {
            SQLiteConnection sqliteconnection;
            sqliteconnection = new SQLiteConnection("Data Source=" + "users.bin; Version = 3; New = True; Compress = True; ");
            try
            {
                sqliteconnection.Open();
                SQLiteCommand sqlitecommand = sqliteconnection.CreateCommand();
                sqlitecommand.CommandText = "INSERT OR IGNORE INTO users (name, pos, mail, dw, username) VALUES ('NEU', 'NEU', 'NEU', 'NEU', @username)";
                sqlitecommand.Parameters.AddWithValue("username", user);
                sqlitecommand.ExecuteNonQuery();
                sqlitecommand.Dispose();
                sqliteconnection.Close();  
            }
            catch
            {
                sqliteconnection.Close();
            }
        }

        //private void GetAllUserData()
        //{
        //    MySqlCommand command = connection.CreateCommand();
        //    command.CommandText = ("SELECT name, pos, mail, dw, username FROM OutlookProfiles");
        //    connection.Open();
        //    MySqlDataReader reader = command.ExecuteReader();
        //    listView1.Items.Clear();
        //    while (reader.Read())
        //    {
        //        ListViewItem item = new ListViewItem(reader["name"].ToString());
        //        item.SubItems.Add(reader["pos"].ToString());
        //        item.SubItems.Add(reader["mail"].ToString());
        //        item.SubItems.Add(reader["dw"].ToString());
        //        item.SubItems.Add(reader["username"].ToString());
        //        listView1.Items.Add(item);
        //    }

        //    connection.Close();
        //}

    }
}
