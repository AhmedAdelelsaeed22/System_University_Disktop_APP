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

namespace University.Enrollment.Attendance
{
    public partial class FrmShowAttendanceDetails : Form
    {

        int _AttendanceID;
        clsAttendance _AttendanceInfo;

        public FrmShowAttendanceDetails(int AttendanceID)
        {
            InitializeComponent();
            _AttendanceID = AttendanceID;
        }

        private void LoadDataToForm(clsAttendance AttendanceInfo)
        {
            lblIDValue.Text = AttendanceInfo.AttendanceID.ToString();
            lblEnrollmentID.Text = AttendanceInfo.EnrollmentID.ToString();
            lblAttendanceDate.Text = AttendanceInfo.AttendanceDate;
            lblStatus.Text = AttendanceInfo.Status;
        }


        private void DataLoad()
        {
            _AttendanceInfo = clsAttendance.FindAttendanceInSystem(_AttendanceID);

            if (_AttendanceInfo != null)
            {
                LoadDataToForm(_AttendanceInfo);
            }
        }

        private void FrmShowAttendanceDetails_Load(object sender, EventArgs e)
        {
            DataLoad();
        }
    }
}
