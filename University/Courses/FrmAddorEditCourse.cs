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

namespace University.Courses
{
    public partial class FrmAddorEditCourse : Form
    {

        public enum enMode {Add = 0 , Update = 1}
        private enMode _Mode;

        int _CourseID = -1;
        clsCourses _CourseInfo;

        public FrmAddorEditCourse()
        {
            InitializeComponent();
            _CourseID = -1;
            _Mode = enMode.Add;
        }


        public FrmAddorEditCourse(int CourseID)
        {
            InitializeComponent();
            _CourseID = CourseID;
            _Mode = enMode.Update;
        }


        private void DataLoad()
        {
            ctrlAddorEditCourse1.handleDepartment();

            if (_Mode == enMode.Add)
            {
                lblTitle.Text = "Add New Course";
                _CourseInfo = new clsCourses();
                return;
            }

            lblTitle.Text = "Update Course";
            _CourseInfo = clsCourses.FindCourseUsingID(_CourseID);

            if (_CourseInfo != null) 
            {
                ctrlAddorEditCourse1.LoadDataToForm(_CourseInfo);
            }
        }

        private void FrmAddorEditCourse_Load(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ctrlAddorEditCourse1.LoadDataToObject(_CourseInfo);

                if (_CourseInfo.Save())
                {
                    MessageBox.Show("Save Is Successfully", "Successfully"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ctrlAddorEditCourse1.CourseID = _CourseInfo.CourseID.ToString();
                }
                else
                {
                    MessageBox.Show("Save Is Not Successfully", "Error"
                   , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
