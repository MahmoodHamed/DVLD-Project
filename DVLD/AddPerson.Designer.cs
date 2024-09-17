using DVLD_BusinessLayer;

namespace DVLD
{
    partial class AddPerson
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.personCard2 = new DVLD.PersonCard();
            this.SuspendLayout();
            // 
            // personCard2
            // 
            this.personCard2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.personCard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.personCard2.Location = new System.Drawing.Point(12, 122);
            this.personCard2.Name = "personCard2";
            this.personCard2.Size = new System.Drawing.Size(775, 366);
            this.personCard2.TabIndex = 0;
            // 
            // AddPerson
            // 
            this.ClientSize = new System.Drawing.Size(799, 500);
            this.Controls.Add(this.personCard2);
            this.Name = "AddPerson";
            this.ResumeLayout(false);

        }

        private void InitializeComponent(int PersonID)
        {
            this.personCard2 = new DVLD.PersonCard(PersonID);
            this.SuspendLayout();
            // 
            // personCard2
            // 
            this.personCard2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.personCard2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.personCard2.Location = new System.Drawing.Point(12, 122);
            this.personCard2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.personCard2.Name = "personCard2";
            this.personCard2.Size = new System.Drawing.Size(775, 366);
            this.personCard2.TabIndex = 0;
            // 
            // AddPerson
            // 
            this.ClientSize = new System.Drawing.Size(799, 500);
            this.Controls.Add(this.personCard2);
            this.Name = "AddPerson";
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Label lbMainLabel;
        private PersonCard personCard1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPersonID;
        private PersonCard personCard2;
    }
}