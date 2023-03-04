using Project.BLL.DesignPattern.SingletonPattern;
using Project.BLL.GenericRepository.BaseRep;
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
	public partial class Form2 : Form
	{

		ClientRepository _clientRep;

		ClientProfileRepository _clientProfileRep;

		public Form2()
		{
			InitializeComponent();

		}

		private void Form2_Load(object sender, EventArgs e)
		{
			List<Extra> extras = new List<Extra>
			{
				new Extra{Name ="Touilet",Price =10 },
				new Extra{Name = "Cafe", Price=10},
				new Extra{Name = "Meeting Room",Price=10}
			};

			foreach (Extra item in extras)
			{
				cmbExtra.Items.Add(item);
			}

			List<Issue> ıssues = new List<Issue>
			{
				new Issue  {Description ="Technical"},
				new Issue {Description = "Management"},
				new Issue {Description = "Other"}
			};

			foreach (Issue item in ıssues)
			{
				cmbIssueType.Items.Add(item);
			}


		}

		private void btnContinue_Click(object sender, EventArgs e)
		{
			try
			{
				Client cl = new Client();

				cl.CompanyName = txtCompanyName.Text;



				ClientProfile clProfile = new ClientProfile();

				clProfile.TaxNumber = txtTaxNumber.Text;
				clProfile.PhoneNumber = txtPhoneNumber.Text;

				_clientProfileRep.Add(clProfile);
				_clientRep.Add(cl);




			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void btnAccept_Click(object sender, EventArgs e)
		{

		}

		private void btnContinue_Click_1(object sender, EventArgs e)
		{

		}
	}
}
