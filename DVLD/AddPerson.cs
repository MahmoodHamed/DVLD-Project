using System;
using System.Windows.Forms;
using DVLD_BusinessLayer;
namespace DVLD
{
    public partial class AddPerson : Form
    {
        public int _PersonID {  get; set; }

        public AddPerson(int _PersonID)
        {
            this._PersonID = _PersonID;
            InitializeComponent(_PersonID);



        }
        public AddPerson()
        {
            InitializeComponent();
        }

        private void personCard1_Load(object sender, EventArgs e)
        {
           
        }

        private void AddPerson_Load(object sender, EventArgs e)
        {

        }
    }
}
