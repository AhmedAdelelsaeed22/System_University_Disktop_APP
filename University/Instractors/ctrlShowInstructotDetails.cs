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

namespace University.Instractors
{
    public partial class ctrlShowInstructotDetails : UserControl
    {
        public ctrlShowInstructotDetails()
        {
            InitializeComponent();
        }


        public string InstructorID
        {
            get { return lblIDValue.Text; }
            set { lblIDValue.Text = value; }
        }


        public string FullName
        {
            get { return lblFullName.Text; }
            set { lblFullName.Text = value; }
        }


        public string Phone
        {
            get { return lblPhone.Text; }
            set { lblPhone.Text = value; }
        }


        public string Email
        {
            get { return lblEmail.Text; }
            set { lblEmail.Text = value; }
        }

        public string Department
        {
            get { return lblDepartmentName.Text; }
            set { lblDepartmentName.Text = value; }
        }


        public void LoadDataInControl(clsInstractors InstructorInfo)
        {
            InstructorID = InstructorInfo.InstructorID.ToString();
            FullName = InstructorInfo.FullName;
            Phone = InstructorInfo.Phone;
            Email = InstructorInfo.Email;
            Department = InstructorInfo.DepartmentName;
        }
    }
}
