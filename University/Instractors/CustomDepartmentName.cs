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
    public partial class CustomDepartmentName : ComboBox
    {
        public CustomDepartmentName()
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


        public void GetAllDepartments()
        {
         DataTable _dtAllDepartments = new DataTable();
        _dtAllDepartments = clsDepartment.GetAllDepartments();
            foreach (DataRow row in _dtAllDepartments.Rows)
            {
                this.Items.Add(row["DepartmentName"]);
            }
        }
    }
}
