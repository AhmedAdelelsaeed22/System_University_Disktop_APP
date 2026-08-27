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
    public partial class cbCourseName : ComboBox
    {
        public cbCourseName()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }


        public void SelectFirstElement()
        {
            this.SelectedIndex = 0;
        }


        public void GetAllCourses()
        {
            DataTable _dtAllCourses = new DataTable();
            _dtAllCourses = clsCourses.GetAllCorses();
            foreach (DataRow row in _dtAllCourses.Rows)
            {
                this.Items.Add(row["CourseName"]);
            }
        }
    }
}
