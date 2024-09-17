using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PeopleMangment peopleMangment = new PeopleMangment();
            peopleMangment.ShowDialog();
        }

        private void peopleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PeopleMangment peopleMangment = new PeopleMangment();
            peopleMangment.ShowDialog();
        }

    }
}
