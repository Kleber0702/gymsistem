using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Gym
{
    public partial class pass_adm : UserControl
    {
        

        public bool Activo {
            get { return Activo; }
            set { Activo = value; }
        }
        bool activo;
        public pass_adm()
        {
            InitializeComponent();
        }
      
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            activo = false;

            
        }
        private void pass_adm_Load(object sender, EventArgs e)
        {
            activo = true;
        }

      
        private void check_Click(object sender, EventArgs e)
        {
            //rutina checkeo sql


        }
        



    }
}
