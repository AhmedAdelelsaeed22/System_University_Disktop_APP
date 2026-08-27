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

namespace University.Students
{
    public partial class FrmShowDetailsStudents : Form
    {

        int _StudentID;
        clsStudents _StudentInfo;

        public FrmShowDetailsStudents(int StudentID)
        {
            InitializeComponent();
            _StudentID = StudentID;
        }


        private void _DataLoad()
        {
            _StudentInfo = clsStudents.FindStudent(_StudentID);

            if (_StudentInfo != null)
            {
                ctrlShowDetailsStudents1.LoadDataInControl(_StudentInfo);
            }
        }

        private void FrmShowDetailsStudents_Load(object sender, EventArgs e)
        {
            _DataLoad();
        }
    }
}
