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

namespace SocketTechnologiesLtd
{
    public partial class Login_Form : MetroFramework.Forms.MetroForm
    {
        #region Instance Attributes
        private IModel Model;
        #endregion

        #region Constructors
        public Login_Form(IModel _Model)
        {
            InitializeComponent();
            Model = _Model;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;
        }

        #endregion

        private void btn_Login_Click(object sender, EventArgs e)
        {
            bool validUser = Model.login(txtBox_username.Text, txtBox_username.Text);
            if(validUser)
            {
                switch(Model.userDepartment())
                {
                    case "1":
                        AccDep_Form acc = new AccDep_Form();
                        acc.Show();
                        break;
                    case "2":
                        CSDep_Form cs = new CSDep_Form();
                        cs.Show();
                        break;
                    case "3":
                        ManDep_Form man = new ManDep_Form();
                        man.Show();
                        break;
                    case "4":
                        ProdDep_Form prod = new ProdDep_Form();
                        prod.Show();
                        break;
                    case "5":
                        PurDep_Form pur = new PurDep_Form();
                        pur.Show();
                        break;
                    case "6":
                        StoDep_Form sto = new StoDep_Form();
                        sto.Show();
                        break;
                    case "7":
                        SysAdmin_Form sysAdmin = new SysAdmin_Form();
                        sysAdmin.Show();
                        break;
                    default:
                        MessageBox.Show("This user is not assigned to a department!");
                        break;
                }

                txtBox_username.Text = "";
                txtBox_Password.Text = "";
                txtBox_username.Select();
            }
            else
            {
                MessageBox.Show("Ivalid Login Details!");
                txtBox_username.Text = "";
                txtBox_Password.Text = "";
                txtBox_username.Select();
            }
        }
    }
}
