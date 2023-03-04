using Project.BLL.GenericRepository.ConcRep;
using Project.ENTITIES.Models;
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

        EmployeeRepository _empRep;
        ClientProfileRepository _clientProfileRep;
        public Form1()
        {
            _clientProfileRep= new ClientProfileRepository();
            _empRep = new EmployeeRepository();
            InitializeComponent();

        }




        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.UserName = txtUserName.Text;
            emp.Password = txtPassword.Text;

            if (emp.UserName == "admin" && emp.Password =="123")
            {
                MessageBox.Show("Welcome!!");
                Form2 frm2 = new Form2();
                frm2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wrong username or password..","Try again!");
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
