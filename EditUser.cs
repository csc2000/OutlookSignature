using System;
using System.Windows.Forms;
using System.Data.SQLite;
using MySql.Data.MySqlClient;

namespace OutlookCorporateSignature
{
    public partial class EditUser : Form
    {
        public EditUser(string username)
        {
            InitializeComponent();
            textBoxUsername.Text = username;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SQLiteConnection sqliteconnection;
            sqliteconnection = new SQLiteConnection("Data Source=" + "users.bin; Version = 3; New = True; Compress = True; ");
            try
            {
                sqliteconnection.Open();
                SQLiteCommand sqlitecommand = sqliteconnection.CreateCommand();
                sqlitecommand.CommandText = "UPDATE users SET name = @name, pos = @pos, mail = @mail, dw = @dw WHERE username = @username";
                sqlitecommand.Parameters.AddWithValue("username", textBoxUsername.Text);
                sqlitecommand.Parameters.AddWithValue("name", textBoxName.Text);
                sqlitecommand.Parameters.AddWithValue("pos", textBoxPostition.Text);
                sqlitecommand.Parameters.AddWithValue("mail", textBoxMailaddress.Text);
                sqlitecommand.Parameters.AddWithValue("dw", textBoxNumber.Text);
                sqlitecommand.ExecuteNonQuery();
                sqlitecommand.Dispose();
                sqliteconnection.Close();
            }
            catch
            {
                sqliteconnection.Close();
            }
            this.Close();  
        }
    }
}
