using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using DataAccessLayer;

namespace SocketTechnologiesLtd
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IDataLayer _DataLayer = DataLayer.GetInstance();
            IModel _Model = Model.GetInstance(_DataLayer);
            Application.Run(new Container(_Model));
        }
    }
}
