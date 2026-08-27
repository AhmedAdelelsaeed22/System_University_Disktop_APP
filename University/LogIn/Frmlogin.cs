using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Microsoft.Win32;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using university_BussinesLayer;
using University.utilities;

namespace University.LogIn
{
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        
        string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\LoginInfoUniversityApp";
        string ValueName = "loginInfo";
        string ValueData = "";

        private bool _IsExistUser(string UserName , string Password)
        {
            if (clsUsers.IsExistUserInSystem(UserName , Password))
            {
                return true;
            }

            return false;
        }


        private void _SaveDataToRegistry(string UserName , string Password)
        {
                string remmeber = RBremeber.Checked ? "true" : "false";
                ValueData = string.Join("|", txtUserName.Text, txtPassword.Text , remmeber);

                try
                {
                    Registry.SetValue(KeyPath , ValueName , ValueData , RegistryValueKind.String);

                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
  
        private void _GetDataFromRegstry()
        {
            string value = "";
            try
            {
               value =  Registry.GetValue(KeyPath , ValueName , null) as string;
                if(value != null)
                {
                   string[] parts = value.Split('|');
                    if (parts.Length > 0)
                    {
                        if (parts[2] == "true")
                        {
                            txtUserName.Text = parts[0];
                            txtPassword.Text = parts[1];
                            RBremeber.Checked = true;
                            txtUserName.Focus();
                        }
                    }
                }
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Password = clsUtilities.ComputeHash(txtPassword.Text);
            if (_IsExistUser(txtUserName.Text , Password))
            {
                _SaveDataToRegistry(txtUserName.Text, txtPassword.Text);
                FrmMain MainForm = new FrmMain();
                MainForm.ShowDialog();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid UserName/Password" , "Error" 
                    ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frmlogin_Load(object sender, EventArgs e)
        {
            _GetDataFromRegstry();
        }
    }
}
