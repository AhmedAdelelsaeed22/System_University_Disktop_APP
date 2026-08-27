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
    public partial class FrmShowDetailsDepartment : Form
    {

        int _DepartmentID;
        clsDepartment _DepartmentInfo;

        public FrmShowDetailsDepartment(int DepartmentID)
        {
            InitializeComponent();
            _DepartmentID = DepartmentID;
        }

        private void _DataLoad()
        {
            _DepartmentInfo = clsDepartment.FindDepartmentUsingID(_DepartmentID);


            if (_DepartmentInfo != null)
            {
                lblDepartmentID.Text = _DepartmentInfo.DepartmentID.ToString();
                txtDepartmentName.Text = _DepartmentInfo.DepartmentName;
                txtDescription.Text = _DepartmentInfo.DepartmentDescription;
            }
        }

        private void FrmShowDetailsDepartment_Load(object sender, EventArgs e)
        {
            _DataLoad();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
