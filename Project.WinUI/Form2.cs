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
    public partial class Form2 : Form
    {

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
            
        }
    }
}
