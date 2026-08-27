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

namespace University.Enrollment
{
    public partial class FrmAddorEdit : Form
    {

        int _EnrollmentID;
        clsEnrollments _EnrollmentInfo;

        public FrmAddorEdit()
        {
            InitializeComponent();
            _EnrollmentID = -1;
        }


        private void _DataLoad()
        {
            ctrlAddNewEnrollment1.HandleCustomCourses();
            _EnrollmentInfo = new clsEnrollments();
        }

        private void FrmAddorEdit_Load(object sender, EventArgs e)
        {
            _DataLoad();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ctrlAddNewEnrollment1.LoadDataToObject(_EnrollmentInfo);


            if (clsEnrollments.IsCompletedEnrollment(_EnrollmentInfo.StudentID , _EnrollmentInfo.CourseID))
            {
                MessageBox.Show("This Student Is Already Enrollment In This Course", "Error"
                  , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (_EnrollmentInfo.Save())
                {
                    MessageBox.Show("Save Is Successfully", "Successfully"
                         , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ctrlAddNewEnrollment1.EnrollmentID = _EnrollmentInfo.EnrollmentID.ToString();
                }
                else
                {
                    MessageBox.Show("Save Is Not Successfully", "Error"
                        , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
