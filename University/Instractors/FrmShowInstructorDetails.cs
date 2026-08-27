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
    public partial class FrmShowInstructorDetails : Form
    {

        int _InstructorID = -1;
        clsInstractors _InstructorInfo;

        public FrmShowInstructorDetails(int InstructorID)
        {
            InitializeComponent();
            _InstructorID = InstructorID;
        }


        private void DataLoad()
        {
            _InstructorInfo = clsInstractors.FindInstractorInSystem(_InstructorID);

            if(_InstructorInfo != null)
            {
                ctrlShowInstructotDetails1.LoadDataInControl(_InstructorInfo);
            }
        }

        private void FrmShowDetails_Load(object sender, EventArgs e)
        {
            DataLoad();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
