using System;
using System.Data;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using DVLD_BusinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace DVLD
{
    public partial class PeopleMangment : Form
    {

        enum enMode { Add = 1, Remove = 2 ,Update = 3 ,ShowDetials = 4 , PhoneCall = 5,SendEmail = 6 }  
        struct MangePeople
        {
            private People _Person;

        };
        private DataTable _People = People.GetAllPeople();
        public int _PersonID = -1;
        public People _Person = new People();
        private DataRow RowSelected;

        public PeopleMangment()
        {
            InitializeComponent();
            
        }
        private void Tests_Load(object sender, EventArgs e)
        {
            _People.Columns.Remove("ImagePath");
            DataView dv = _People.DefaultView;
            dataGridView1.DataSource = dv;
            label1.Text = "#Records:" + dataGridView1.RowCount.ToString();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPerson addPerson1 = new AddPerson();
            addPerson1.ShowDialog();
        }


        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            _PersonID = Convert.ToInt16(RowSelected[0]);
            AddPerson UpdatePerson = new AddPerson(_PersonID);
            UpdatePerson.Show();

        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = dataGridView1.Rows[e.RowIndex].Index;
            RowSelected = _People.Rows[Index];
        }

        private void picAddPerson_Click(object sender, EventArgs e)
        {
            AddPerson addPerson1 = new AddPerson();
            addPerson1.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    