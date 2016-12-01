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
    public partial class SysAdmin_Form : MetroFramework.Forms.MetroForm
    {
        #region Instance Attributes
        private IModel model;
        #endregion

        #region Constructors
        public SysAdmin_Form(IModel _Model)
        {
            InitializeComponent();
            this.ControlBox = false;
            model = _Model;
        }
        #endregion

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
            AddNewEmployee addEmp = new AddNewEmployee(model);
            addEmp.MdiParent = this.MdiParent;
            addEmp.Dock = DockStyle.Fill;
            addEmp.Show();
        }

        private void btn_EditUser_Click(object sender, EventArgs e)
        {
            Edit_DeleteEmployee editDelEmp = new Edit_DeleteEmployee(model);
            editDelEmp.MdiParent = this.MdiParent;
            editDelEmp.Dock = DockStyle.Fill;
            editDelEmp.Show();

        }
    }
}
