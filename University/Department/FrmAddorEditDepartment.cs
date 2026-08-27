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

namespace University.Department
{
    public partial class FrmAddorEditDepartment : Form
    {

        public enum enMode {Add = 0 , Update = 1};
        private enMode _Mode;

        int _DepartmentID;
        clsDepartment _DepartmentInfo;

        public FrmAddorEditDepartment()
        {
            InitializeComponent();
            _DepartmentID = -1;
            _Mode = enMode.Add;
        }


        public FrmAddorEditDepartment(int DepartmentID)
        {
            InitializeComponent();
            _DepartmentID = DepartmentID;
            _Mode = enMode.Update;
        }


        private void _DataLoad()
        {
            if (_Mode == enMode.Add)
            {
                lblTitle.Text = "Add New Department";
                _DepartmentInfo = new clsDepartment();
                return;
            }


            lblTitle.Text = "Update Department";
            _DepartmentInfo = clsDepartment.FindDepartmentUsingID(_DepartmentID);


            if (_DepartmentInfo != null)
            {
                lblDepartmentID.Text = _DepartmentInfo.DepartmentID.ToString();
                txtDepartmentName.Text = _DepartmentInfo.DepartmentName;
                txtDescription.Text = _DepartmentInfo.DepartmentDescription;
            }
        }

        private void FrmAddorEditDepartment_Load(object sender, EventArgs e)
        {
            _DataLoad();
        }

        private void LoadDataToObject(clsDepartment DepartmentInfo)
        {
            DepartmentInfo.DepartmentName = txtDepartmentName.Text;
            DepartmentInfo.DepartmentDescription = txtDescription.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            LoadDataToObject(_DepartmentInfo);
            if (_DepartmentInfo.Save())
            {
                MessageBox.Show("Save Is Successfully" , "Successfully" 
                    ,MessageBoxButtons.OK , MessageBoxIcon.Information);
                lblDepartmentID.Text = _DepartmentInfo.DepartmentID.ToString();
            }
            else
            {
                MessageBox.Show("Save Is Not Successfully", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
