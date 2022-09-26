using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JavaLearning
{
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
        }

        private void close_pictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            String password = passwordTextBox.Text.ToString();
            String username = usernameTextBox.Text.ToString();
        }

        private void login(String username, String password)
        {
            if(isValid(username) && isValid(password))
            {
                //ask database for the user!
            }
        }

        private Boolean isValid(String str)
        {
            return (str.Trim().Length > 0) ;
        }
    }
}
