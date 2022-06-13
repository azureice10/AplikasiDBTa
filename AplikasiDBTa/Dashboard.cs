using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiDBTa
{
    public partial class Dashboard : Form
    {
        private string vUser;
        private string vRole;



        public Dashboard(string vUser, string vRule)
        {
            InitializeComponent();
            this.vUser = vUser;
            this.vRole = vRole;
        }

        private void hasilSidangToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Selamat datang " + vUser);
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formProfile= new Profile(vUser, vRole);
            formProfile.ShowDialog();
            Hide();
        }
    }
}
