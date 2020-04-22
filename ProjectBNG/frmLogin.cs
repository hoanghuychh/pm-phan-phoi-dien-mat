using ProjectBNG.Models;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;


namespace ProjectBNG
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_login_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static string userID = "";
        public static string Username = "";
        public void CheckLogin( string username , string password)
        {
            DbContext dbContext;
            var db = new SMMgEntities();
            var select = from s in  db.USERs  select s;
            try
            {
                bool success = false;
                foreach (var data in select)
                {
                    if (username == data.Username && password == data.Password)
                    {
                        userID = data.ID.ToString();
                        Username = data.Username;
                        success = true;
                        break;
                    }
                    
                        
                }
                if (success)
                {
                    this.Hide();
                    frmMain main = new frmMain();
                    main.Show();
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("login fail");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            CheckLogin(username, password);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
#if DEBUG 
            this.txtUsername.Text = "1";
            this.txtPassword.Text = "1";
#endif
        }
    }
}
