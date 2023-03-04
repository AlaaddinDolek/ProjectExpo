using Project.BLL.GenericRepository.ConcRep;
using Project.ENTITIES.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WinUI
{
    public partial class Form1 : Form
    {
        ClientProfileRepository _clientProfileRep;
        public Form1()
        {
            _clientProfileRep= new ClientProfileRepository();
            InitializeComponent();

        }


        string name;
        string psw;

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

            name = txtUserName.Text;
            psw = txtPassword.Text;

            if (name == "admin" && psw == "123")
            {
                MessageBox.Show("Welcome.");
                Form2 frm2 = new Form2();
                frm2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong username or password.");
                return;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

		private void Form1_Load_1(object sender, EventArgs e)
		{

		}
	}
}
