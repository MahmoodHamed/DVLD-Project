using System;
using System.Data;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using DVLD_BusinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace DVLD
{
    public partial class PeopleMangment : Form
    {

        enum enMode { Add = 1, Delete = 2 ,Update = 3 ,ShowInfo = 4 , PhoneCall = 5,SendEmail = 6 }  
        enMode Mode = enMode.Add;

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
        private void ShowPersonInfoForm()
        {

        }
        private void ShowAddPersonForm()
        {
            AddPerson addPerson1 = new AddPerson();
            addPerson1.ShowDialog();
        }
        private void ShowDeletePersonForm()
        {

        }
        private void ShowUpdatePersonForm()
        {
            AddPerson UpdatePerson = new AddPerson(_PersonID);
            UpdatePerson.Show();

        }
        private void ShowPhoneCallForm()
        {

        }
        private void ShowSendEmailForm()
        {

        }
        private void MangeOption()
        {
            switch (Mode)
            {
                case enMode.Add:
                    ShowAddPersonForm();
                    break;
                case enMode.Delete:
                    ShowDeletePersonForm();
                    break;
                case enMode.Update:
                    ShowUpdatePersonForm();
                    break;
                case enMode.PhoneCall:
                    ShowPhoneCallForm();
                    break;
                case enMode.SendEmail:
                    ShowSendEmailForm();
                    break;
                case enMode.ShowInfo:
                    ShowPersonInfoForm();
                    break;
                default:
                    MessageBox.Show("This problem dose not Exaption!");
                    break;



            }
        }
        private void DataGridViewLoad()
        {
            _People.Columns.Remove("ImagePath");
            DataView dv = _People.DefaultView;
            dataGridView1.DataSource = dv;
        }
        private void Tests_Load(object sender, EventArgs e)
        {
            DataGridViewLoad();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mode = enMode.Add;
            MangeOption();
        }


        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            _PersonID = Convert.ToInt16(RowSelected[0]);
            Mode = enMode.Update;
            MangeOption();
            

        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = dataGridView1.Rows[e.RowIndex].Index;
            RowSelected = _People.Rows[Index];
        }

        private void picAddPerson_Click(object sender, EventArgs e)
        {
            Mode = enMode.Add;
            MangeOption();  
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    