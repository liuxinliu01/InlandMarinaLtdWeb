using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMPP248VB;


namespace TravelExpertsLoginPage
{
    public partial class AgentLoginForm : Form
    {
        public AgentLoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
            if(isValidUser(usernameTextBox.Text, passwordTextBox.Text))
            {
               
                MainForm startPage = new MainForm();

                DialogResult result = startPage.ShowDialog();

                startPage.Show();
                
            }
            else
            {
                MessageBox.Show("Invalid Password or Username","Login Error");
            }
            
        }

        private bool isValidUser(string userName, string password)
        {
            if(!String.IsNullOrEmpty(userName) && !String.IsNullOrEmpty(password))
            {
                AgentsDataContext context = new AgentsDataContext();
                var q = from p in context.Agents
                        where p.Username == userName
                        && p.Password == password
                        select p;

                if (q.Any())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
