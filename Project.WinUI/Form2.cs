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

        SaloonRepository _saloonRep;

        StandRepository _standRep;
        
        public Form2()
        {
            _clientRep= new ClientRepository();
            _clientProfileRep= new ClientProfileRepository();
            _saloonRep= new SaloonRepository();
            _standRep= new StandRepository();

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

                cmbExtra.DataSource= extras;
            

            List<Saloon> saloons = new List<Saloon>
            {
                new Saloon{SaloonName = "North"},
                new Saloon{SaloonName = "South"},
                new Saloon{SaloonName = "East"},
                new Saloon{SaloonName = "West"}
            };

            cmbSaloon.DataSource = saloons;
            

            List<Stand> stands = new List<Stand>
            {
                new Stand{StandNo="1", StandArea="50 m2", ActivityStatus = ENTITIES.Enums.Activity.High},
                new Stand{StandNo="2", StandArea="75 m2", ActivityStatus = ENTITIES.Enums.Activity.High},
                new Stand{StandNo="3", StandArea="100 m2", ActivityStatus = ENTITIES.Enums.Activity.High},
                new Stand{StandNo="4", StandArea="50 m2", ActivityStatus = ENTITIES.Enums.Activity.Medium},
                new Stand{StandNo="5", StandArea="75 m2", ActivityStatus = ENTITIES.Enums.Activity.Medium},
                new Stand{StandNo="6", StandArea="100 m2", ActivityStatus = ENTITIES.Enums.Activity.Medium},
                new Stand{StandNo="7", StandArea="50 m2", ActivityStatus = ENTITIES.Enums.Activity.Low},
                new Stand{StandNo="8", StandArea="75 m2", ActivityStatus = ENTITIES.Enums.Activity.Low},
                new Stand{StandNo="9", StandArea="100 m2", ActivityStatus = ENTITIES.Enums.Activity.Low},
            };
            
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
	}
}
