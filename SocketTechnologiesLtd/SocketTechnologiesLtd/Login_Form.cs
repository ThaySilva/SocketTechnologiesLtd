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

            Login_Rules.FillModel();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string depId = Login_Rules.ProcessLogin(txtBox_username.Text, txtBox_Password.Text);
            if(depId == null)
            {
                MessageBox.Show("Ivalid Login Details!");
            }
            else
            { 
                switch(depId)
                { 
                    case "1":
                        AccDep_Form acc = new AccDep_Form();
                        acc.FormClosing += backToLogin;
                        acc.MdiParent = this.MdiParent;
                        acc.Dock = DockStyle.Fill;
                        this.Hide();
                        acc.Show();
                        break;
                    case "2":
                        CSDep_Form cs = new CSDep_Form();
                        cs.FormClosing += backToLogin;
                        cs.MdiParent = this.MdiParent;
                        cs.Dock = DockStyle.Fill;
                        this.Hide();
                        cs.Show();
                        break;
                    case "3":
                        ManDep_Form man = new ManDep_Form();
                        man.FormClosing += backToLogin;
                        man.MdiParent = this.MdiParent;
                        man.Dock = DockStyle.Fill;
                        this.Hide();
                        man.Show();
                        break;
                    case "4":
                        ProdDep_Form prod = new ProdDep_Form();
                        prod.FormClosing += backToLogin;
                        prod.MdiParent = this.MdiParent;
                        prod.Dock = DockStyle.Fill;
                        this.Hide();
                        prod.Show();
                        break;
                    case "5":
                        PurDep_Form pur = new PurDep_Form();
                        pur.FormClosing += backToLogin;
                        pur.MdiParent = this.MdiParent;
                        pur.Dock = DockStyle.Fill;
                        this.Hide();
                        pur.Show();
                        break;
                    case "6":
                        StoDep_Form sto = new StoDep_Form();
                        sto.FormClosing += backToLogin;
                        sto.MdiParent = this.MdiParent;
                        sto.Dock = DockStyle.Fill;
                        this.Hide();
                        sto.Show();
                        break;
                    case "7":
                        SysAdmin_Form sysAdmin = new SysAdmin_Form(Model);
                        sysAdmin.FormClosing += backToLogin;
                        sysAdmin.MdiParent = this.MdiParent;
                        sysAdmin.Dock = DockStyle.Fill;
                        this.Hide();
                        sysAdmin.Show();
                        break;
                    case "8":
                        EngDep_Form eng = new EngDep_Form();
                        eng.FormClosing += backToLogin;
                        eng.MdiParent = this.MdiParent;
                        eng.Dock = DockStyle.Fill;
                        this.Hide();
                        eng.Show();
                        break;
                    default:
                        MessageBox.Show("This user is not assigned to a department!");
                        break;
                }
            }

            clearFields();
        }

        private void link_ForgotPass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WELL,\nYOU'RE FIRED!");
        }
        #endregion

        #region Extra Functions
        private void clearFields()
        {
            txtBox_username.Text = null;
            txtBox_Password.Text = null;
            txtBox_username.Select();
        }

        private void backToLogin(object sender, FormClosingEventArgs e)
        {
            this.Show();
        }
        #endregion
    }
}
