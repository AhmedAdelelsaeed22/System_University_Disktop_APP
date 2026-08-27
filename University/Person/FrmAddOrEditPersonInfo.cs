using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using university_BussinesLayer;
using University.Events;



namespace University.Person
{
    public partial class FrmAddOrEditPersonInfo : Form
    {

        public event EventHandler<SendPersonIDEventAgs> OnSendPersonID;
        public void RaiseOnSendPersonID(string PersonID)
        {
            RaiseOnSendPersonID(new SendPersonIDEventAgs(PersonID));
        }
        protected virtual void RaiseOnSendPersonID(SendPersonIDEventAgs e)
        {
            OnSendPersonID?.Invoke(this, e);
        }


        public enum enMode {Add = 0 , Update = 1}
        private enMode _Mode;

        int _PersonID = 0;
        clsPerson _PersonInfo;

        public FrmAddOrEditPersonInfo()
        {
            InitializeComponent();
            _PersonID = -1;
        }


        public FrmAddOrEditPersonInfo(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }


        private void _ChooseMode()
        {
            if (_PersonID == -1) 
            {
                _Mode = enMode.Add;
            }
            else
            {
                _Mode = enMode.Update;
            }
        }


        private void _DataLoad()
        {
            _ChooseMode();
            if (_Mode == enMode.Add)
            {
                lblTitle.Text = "Add Personal Information";
                _PersonInfo = new clsPerson();
                return;
            }

            lblTitle.Text = "Update Personal Information";
            _PersonInfo = clsPerson.FindPersonInfo(_PersonID);


            if (_PersonInfo != null)
            {
                ctrlAddorEditPerson1.LoadDataToForm(_PersonInfo);
            }
        }

        private void FrmAddOrEditPersonInfo_Load(object sender, EventArgs e)
        {
            _DataLoad();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ctrlAddorEditPerson1.LoadDataToObject(_PersonInfo);
            if (_PersonInfo.Save())
            {
                MessageBox.Show("Save Is Successfully" , "Successfully" 
                    ,MessageBoxButtons.OK , MessageBoxIcon.Information);
                ctrlAddorEditPerson1.PersonID = _PersonInfo.PersonID.ToString();

                if (OnSendPersonID != null)
                {
                   RaiseOnSendPersonID(ctrlAddorEditPerson1.PersonID);
                }
            }
            else
            {
                MessageBox.Show("Save Is Not Successfully", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
