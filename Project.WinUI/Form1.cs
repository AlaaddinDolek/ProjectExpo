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

        //List<BaseExtra> extralar = new List<BaseExtra>
        //{
        //    new Toilet {Name = "Tuvalet ", Price = 10}
        //};

        private void Form1_Load(object sender, EventArgs e)
        {

        }

		private void Form1_Load_1(object sender, EventArgs e)
		{

		}
	}
}
