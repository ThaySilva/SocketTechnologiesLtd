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

    public partial class Edit_DeleteEmployee : MetroFramework.Forms.MetroForm
    {
        #region Instance Attributes
        private IModel model;

        List<IEmployee> employee;
        List<IUser> user;

        int empId = 0;
        #endregion

        #region Constructors
        public Edit_DeleteEmployee(IModel _Model)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;
            model = _Model;

            employee = model.EmployeeList;
            user = model.UserList;

            populateListView();
        }

        private void dataGrid_Employee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            empId = Convert.ToInt32(dataGrid_Employee.Rows[e.RowIndex].Cells["EmployeeID:"].Value);

            fillFields(empId);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            int id;
            bool result = int.TryParse(txt_search.Text, out id);
            if (result)
                populateListView(id);
            else
                MessageBox.Show("You need to enter a number on the Id field!");

            txt_search.Text = null;
        }


        private void txt_search_Click(object sender, EventArgs e)
        {
            populateListView();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(empId != 0)
            {
                if (MessageBox.Show("Are you sure you want to delete the employee " + txt_firstName.Text +  " ?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SysAdmin_Rules.DeleteEmployee(empId);
                    MessageBox.Show("The employee " + txt_firstName.Text + " was successfully deleted!");
                    this.Close();
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int deptId = getDepartment();

            if(validateFields())
            {
                try
                {
                    foreach (Employee emp in employee)
                    {
                        foreach (User u in user)
                        {
                            if (empId == emp.EmployeeID && emp.UserID == u.UserID)
                            {
                                SysAdmin_Rules.EditEmployee(empId, txt_firstName.Text, txt_lastName.Text, txt_phoneNum.Text, deptId);
                                SysAdmin_Rules.EditUser(u.UserID, txt_username.Text, txt_password.Text);
                                MessageBox.Show("The details for employee " + txt_firstName.Text + " has been successfully updated!");
                                this.Close();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        #region Descructors
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Extra Functions
        private void populateListView()
        {
            DataTable Employee = new DataTable("Employee");

            DataColumn c0 = new DataColumn("EmployeeID:");
            DataColumn c1 = new DataColumn("EmployeeName:");

            Employee.Columns.Add(c0);
            Employee.Columns.Add(c1);

            DataRow row;

            foreach (Employee e in employee)
            {
                row = Employee.NewRow();

                row["EmployeeID:"] = e.EmployeeID.ToString();
                row["EmployeeName:"] = e.FirstName;

                Employee.Rows.Add(row);
            }

            dataGrid_Employee.DataSource = Employee;

        }

        private void populateListView(int eId)
        {
            DataTable Employee = new DataTable("Employee");

            DataColumn c0 = new DataColumn("EmployeeID:");
            DataColumn c1 = new DataColumn("EmployeeName:");

            Employee.Columns.Add(c0);
            Employee.Columns.Add(c1);

            DataRow row;

            foreach (Employee e in employee)
            {
                if (e.EmployeeID == eId)
                {
                    row = Employee.NewRow();

                    row["EmployeeID:"] = e.EmployeeID.ToString();
                    row["EmployeeName:"] = e.FirstName;

                    Employee.Rows.Add(row);
                }
            }

            dataGrid_Employee.DataSource = Employee;

        }

        private Boolean validateFields()
        {
            if (txt_username.Text == "")
                MessageBox.Show("Please enter a username!");
            else if (txt_password.Text == "")
                MessageBox.Show("Please enter a password!");
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
                return true;
            }

            return false;
        }

        private void fillFields(int empID)
        {
            foreach(Employee e in employee)
            {
                foreach(User u in user)
                {
                    if (e.EmployeeID == empID && e.UserID == u.UserID)
                    {
                        txt_username.Text = u.Username;
                        txt_password.Text = u.Password;
                        txt_firstName.Text = e.FirstName;
                        txt_lastName.Text = e.LastName;
                        txt_phoneNum.Text = e.PhoneNumber;
                        cBox_dept.SelectedIndex = cBox_dept.Items.IndexOf(getDepartment(e.DepartmentID));
                    }
                }
            }
        }

        private string getDepartment(int deptId)
        {
            string department = "";

            switch (deptId)
            {
                case 1:
                    department = "Accounts";
                    break;
                case 2:
                    department = "Customer Services";
                    break;
                case 3:
                    department = "Management";
                    break;
                case 4:
                    department = "Production";
                    break;
                case 5:
                    department = "Purchasing";
                    break;
                case 6:
                    department = "Stores";
                    break;
                case 7:
                    department = "System Admin";
                    break;
                case 8:
                    department = "Engineering";
                    break;
                default:
                    department = "";
                    break;
            }

            return department;
        }

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
                    deptId = 0;
                    break;
            }

            return deptId;
        }
        #endregion
    }
}
