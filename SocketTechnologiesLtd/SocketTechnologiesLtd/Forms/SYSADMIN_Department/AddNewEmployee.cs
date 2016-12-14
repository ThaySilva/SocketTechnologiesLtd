using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using BusinessEntities;
using DataAccessLayer;

namespace SocketTechnologiesLtd
{
    public partial class AddNewEmployee : MetroFramework.Forms.MetroForm
    {
        IdIncrement id = new IdIncrement();

        #region Instance Attributes
        private IModel model;
        #endregion

        #region Constructors
        public AddNewEmployee(IModel _Model)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;
            model = _Model;

            txt_userId.Text = id.getUserId().ToString();
            txt_employeeId.Text = id.getEmpId().ToString();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            int dept = getDepartment();
            if (validateFields())
            {
                IUser duplicateUser = model.UserList.FirstOrDefault(user => user.Username == txt_username.Text.Trim());

                if (duplicateUser == null)
                {
                    try
                    {
                        SysAdmin_Rules.AddUser(Convert.ToInt32(txt_userId.Text), txt_username.Text, txt_password.Text);
                        SysAdmin_Rules.AddEmployee(Convert.ToInt32(txt_employeeId.Text), txt_firstName.Text, txt_lastName.Text, txt_phoneNum.Text, dept, Convert.ToInt32(txt_userId.Text));
                        MessageBox.Show("The employee " + txt_firstName.Text + " was successfully added! An user account was created with username " + txt_username.Text);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("The username " + txt_username.Text + " already exists please try another username!");
            }
        }
        #endregion

        #region Destructors
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Extra Functions
        private int getDepartment()
        {
            string dept = cBox_dept.SelectedItem.ToString();
            int deptId = 0;

            switch (dept)
            {
                case "Accounts":
                    deptId = 1;
                    break;
                case "Customer Services":
                    deptId = 2;
                    break;
                case "Management":
                    deptId = 3;
                    break;
                case "Production":
                    deptId = 4;
                    break;
                case "Purchasing":
                    deptId = 5;
                    break;
                case "Stores":
                    deptId = 6;
                    break;
                case "System Admin":
                    deptId = 7;
                    break;
                case "Engineering":
                    deptId = 8;
                    break;
                default:
                    break;
            }

            return deptId;
        }

        private Boolean validateFields()
        {
            if (txt_username.Text == "")
                MessageBox.Show("Please enter a username!");
            else if (txt_password.Text == "")
                MessageBox.Show("Please enter a password!");
            else if (txt_password2.Text == "")
                MessageBox.Show("Please Re-Enter the password!");
            else if (txt_firstName.Text == "")
                MessageBox.Show("Please enter the employee's name!");
            else if (txt_lastName.Text == "")
                MessageBox.Show("Please enter the employee's last name!");
            else if (txt_phoneNum.Text == "")
                MessageBox.Show("Please enter the employee's phone number!");
            else if (cBox_dept.SelectedIndex == -1)
                MessageBox.Show("Please select a department!");
            else
            {
                if (txt_password.Text != txt_password2.Text)
                    MessageBox.Show("The passwords doesn't match, try again!");
                else
                    return true;
            }

            return false;
        }
        #endregion
    }
}
