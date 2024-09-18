using DVLD.Properties;
using DVLD_BusinessLayer;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD
{
    public partial class PersonCard : UserControl
    {




        public int _PersonID { get; set; }
        public People Person { get; set; }
        public PersonCard(int _PersonID)
        {            
            this._PersonID = _PersonID;
            InitializeComponent();
            LoadPersonDataToControls();
        }
        public void LoadPersonDataToControls()
        {
            Person = People.FindByID(this._PersonID);
            txNationalNo.Text = Person.NationalNo;
            txFirstName.Text = Person.FirstName;
            txSecondName.Text = Person.SecondName;
            txThirdName.Text = Person.ThirdName;
            txLastName.Text = Person.LastName;
            txEmail.Text = Person.Email;
            txPhone.Text = Person.Phone;   
            txAddress.Text = Person.Address;

            if(Person.Gendor == 0)
            {
                
                rdbMale.Checked = true;
            }
            else
            {
                rdbFmale.Checked = true;
            }

          if(Person.ImagePath != "")
            {
                PersonPicture.Image = Image.FromFile(Person.ImagePath);
            }
            else
            {
                if(Person.Gendor == 0)
                {
                    PersonPicture.Image = Resources.man_in_suit_and_tie;
                }
                else
                {
                    PersonPicture.Image = Resources.woman;
                }
            }

            

        }
        public PersonCard()
        {
            InitializeComponent();
        }
        private void NationalNo_TextChanged(object sender, EventArgs e)
        {
        }

        private void txNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (People.IsPersonExist(txNationalNo.Text))
            {
                e.Cancel = true;
                txNationalNo.Focus();
                errorProvider1.SetError(txNationalNo, "This National Number is Used!");

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form form = this.FindForm();    
            form.Close();
        }

        private void txThirdName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txFirstName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txSecondName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txLastName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void DateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txPhone_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rdbMale_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdbFmale_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void txEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txDescripstion_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            
        }


    }
}
