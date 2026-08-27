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
    public partial class FrmDetailsCourse : Form
    {

        int _CourseID = -1;
        clsCourses _CourseInfo;


        public FrmDetailsCourse(int CourseID)
        {
            InitializeComponent();
            _CourseID = CourseID;
        }


        private void DataLoad()
        {

            _CourseInfo = clsCourses.FindCourseUsingID(_CourseID);

            if (_CourseInfo != null)
            {
                ctrlShowDetailsCourse1.LoadDataToForm(_CourseInfo);
            }
        }

        private void FrmDetailsCourse_Load(object sender, EventArgs e)
        {
            DataLoad();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
