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
    public partial class AddorEditAttendance : Form
    {

        public enum enMode {Add = 0 , Edit = 1}
        private enMode _Mode;


        int _AttendanceId;
        clsAttendance _AttendanceInfo;

        public AddorEditAttendance()
        {
            InitializeComponent();
            _AttendanceId = -1;
            _Mode = enMode.Add;
        }


        public AddorEditAttendance(int AttendanceID)
        {
            InitializeComponent();
            _AttendanceId = AttendanceID;
            _Mode = enMode.Edit;
        }


        private void LoadDataToForm(clsAttendance AttendanceInfo)
        {
            lblIDValue.Text = AttendanceInfo.AttendanceID.ToString();
            txtEnrollmentID.Text = AttendanceInfo.EnrollmentID.ToString();
            txtAttendanceDate.Text = AttendanceInfo.AttendanceDate;
            txtStatus.Text = AttendanceInfo.Status;
        }



        private void LoadDataToObject(clsAttendance AttendanceInfo)
        { 
            AttendanceInfo.EnrollmentID = Convert.ToInt32(txtEnrollmentID.Text);
            AttendanceInfo.AttendanceDate = txtAttendanceDate.Text;
            AttendanceInfo.Status = txtStatus.Text;
        }


        private void DataLoad()
        {
            if (_Mode == enMode.Add)
            {
                _AttendanceInfo = new clsAttendance();
                return;
            }


            lblTitle.Text = "Update Attendance";
            _AttendanceInfo = clsAttendance.FindAttendanceInSystem(_AttendanceId);


            if (_AttendanceInfo != null)
            {
                LoadDataToForm(_AttendanceInfo);
            }
        }


        private void AddorEditAttendance_Load(object sender, EventArgs e)
        {
            DataLoad();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            LoadDataToObject(_AttendanceInfo);

            if (_AttendanceInfo.Save())
            {
                MessageBox.Show("Save Is Successfully", "Sussessfully"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblIDValue.Text = _AttendanceInfo.AttendanceID.ToString();
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
